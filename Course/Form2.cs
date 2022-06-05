using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Course
{
    public partial class Form2 : Form
    {
        static string function = "";
        static double leftBorder = 0;
        static double rightBorder = 0;

        private org.mariuszgromada.math.mxparser.Function InitFunc(string form)
        {
            form = "f(x)=" + form;
            return new org.mariuszgromada.math.mxparser.Function(form);
        }

        private double ResultFunction(double x, org.mariuszgromada.math.mxparser.Function function)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            org.mariuszgromada.math.mxparser.Expression expression = new org.mariuszgromada.math.mxparser.Expression($"f({x})", function);
            return expression.calculate();
        }

        public Form2(string func, double left, double right)
        {
            InitializeComponent();

            leftBorder = left;
            rightBorder = right;
            function = func;

            CreateScatterPlot(zedGraph);
        }

        public void CreateScatterPlot(ZedGraphControl zgc)
        {

            GraphPane myPane = zgc.GraphPane;
            myPane.CurveList.Clear();

            myPane.Title.Text = "Вариант 11";
            myPane.XAxis.Title.Text = "Ось X";
            myPane.YAxis.Title.Text = "Ось Y";

            var func = InitFunc(function);

            double step = 0.5;
            int steps = (int)((rightBorder - leftBorder) / step);
            double[] xValues = new double[steps];
            double[] yValues = new double[steps];

            PointPairList list = new PointPairList();

            for (int i = 0; i < steps; i++)
            {
                xValues[i] = leftBorder + step * i;
                yValues[i] = ResultFunction(xValues[i], func);

                list.Add(xValues[i], yValues[i]);
            }

            if (list == null)
                return;

            LineItem myCurve = myPane.AddCurve("Scatter", list, Color.Blue, SymbolType.Diamond);

            myPane.XAxis.Cross = 0.0;
            myPane.YAxis.Cross = 0.0;
            myCurve.Line.IsVisible = false;
            myPane.Legend.IsVisible = true;

            myPane.Legend.Position = LegendPos.Float;

            myPane.Legend.Location.CoordinateFrame = CoordType.ChartFraction;

            myPane.Legend.Location.AlignH = AlignH.Right;
            myPane.Legend.Location.AlignV = AlignV.Bottom;

            myPane.Legend.Location.TopLeft = new PointF(1.0f - 0.02f, 1.0f - 0.02f);

            myCurve.Symbol.Fill.Type = FillType.Solid;

            zgc.AxisChange();
            zgc.Refresh();
            zedGraph.Invalidate();
        }

        private void radioBtbOffLegend_CheckedChanged(object sender, EventArgs e)
        {
            GraphPane pane = zedGraph.GraphPane;

            pane.Legend.IsVisible = false;
            zedGraph.AxisChange();
            zedGraph.Refresh();
            zedGraph.Invalidate();
        }

        private void radioBntShowLegend_CheckedChanged(object sender, EventArgs e)
        {
            GraphPane pane = zedGraph.GraphPane;

            pane.Legend.IsVisible = true;
            zedGraph.AxisChange();
            zedGraph.Refresh();
            zedGraph.Invalidate();
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            GraphPane pane = zedGraph.GraphPane;
            if(pane.Legend.FontSpec.IsBold)
                pane.Legend.FontSpec.IsBold = false;
            else
                pane.Legend.FontSpec.IsBold = true;

            zedGraph.AxisChange();
            zedGraph.Refresh();
            zedGraph.Invalidate();
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            GraphPane pane = zedGraph.GraphPane;
            if (pane.Legend.FontSpec.IsItalic)
                pane.Legend.FontSpec.IsItalic = false;
            else
                pane.Legend.FontSpec.IsItalic = true;

            zedGraph.AxisChange();
            zedGraph.Refresh();
            zedGraph.Invalidate();
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            GraphPane pane = zedGraph.GraphPane;
            if (pane.Legend.FontSpec.IsUnderline)
                pane.Legend.FontSpec.IsUnderline = false;
            else
                pane.Legend.FontSpec.IsUnderline = true;

            zedGraph.AxisChange();
            zedGraph.Refresh();
            zedGraph.Invalidate();
        }
    }
}
