using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal static class Optimization
    {
        private static Function InitFunc(string form)
        {
            form = "f(x)=" + form;
            return new Function(form);
        }

        private static double ResultFunction(double x, Function function)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Expression expression = new Expression($"f({x})", function);
            return expression.calculate();
        }

        public static List<List<double>> Minimize(string formula, double left, double right, double eps)
        {
            double z = (3 - Math.Sqrt(5)) / 2;
            var func = InitFunc(formula);

            List<double> xValues = new List<double>();
            List<double> yValues = new List<double>();

            double x1 = left + (right - left) * z;
            xValues.Add(x1);
            double x2 = right - (right - left) * z;
            xValues.Add(x2);

            double y1 = ResultFunction(x1, func);
            double y2 = ResultFunction(x2, func);
            while (Math.Abs(right - left) / 2 > eps)
            {
                if (y1 != ResultFunction(x1, func))
                {
                    y1 = ResultFunction(x1, func);
                    yValues.Add(y1);
                }
                    
                if (y2 != ResultFunction(x2, func))
                {
                    y2 = ResultFunction(x2, func);
                    yValues.Add(y2);
                }
                
                if (y1 >= y2)
                {
                    left = x1;
                    x1 = x2;
                    x2 = right - (right - left) * z;
                    xValues.Add(x2);
                }
                else
                {
                    right = x2;
                    x2 = x1;
                    x1 = left + (right - left) * z;
                    xValues.Add(x1);
                }
            }

            xValues.Add((right + left) / 2);
            return new List<List<double>>() { xValues, yValues};
        }

        public static List<List<double>> Maximize(string formula, double left, double right, double eps)
        {
            double z = (3 - Math.Sqrt(5)) / 2;
            var func = InitFunc(formula);

            List<double> xValues = new List<double>();
            List<double> yValues = new List<double>();

            double x1 = left + (right - left) * z;
            xValues.Add(x1);
            double x2 = right - (right - left) * z;
            xValues.Add(x2);

            double y1 = ResultFunction(x1, func);
            double y2 = ResultFunction(x2, func);
            while (Math.Abs(right - left) > eps)
            {

                if (y1 != ResultFunction(x1, func))
                {
                    y1 = ResultFunction(x1, func);
                    yValues.Add(y1);
                }

                if (y2 != ResultFunction(x2, func))
                {
                    y2 = ResultFunction(x2, func);
                    yValues.Add(y2);
                }
                if (y1 <= y2)
                {
                    left = x1;
                    x1 = x2;
                    x2 = right - (right - left) * z;
                }
                else
                {
                    right = x2;
                    x2 = x1;
                    x1 = left + (right - left) * z;
                }
            }

            xValues.Add((right + left) / 2);
            return new List<List<double>>() { xValues, yValues };
        }
    }
}
