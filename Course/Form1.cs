using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    public partial class Form1 : Form
    {
        string formula = "";
        double rightBorder = 0;
        double leftBorder = 0;
        double accuracy = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOptimize_Click(object sender, EventArgs e)
        {
            if (false == double.TryParse(txtBoxLeftBorder.Text, out leftBorder))
            {
                MessageBox.Show("Левая граница не число");
                return;
            }

            if (false == double.TryParse(txtBoxRightBorder.Text, out rightBorder))
            {
                MessageBox.Show("Правая граница не число");
                return;
            }

            if (false == double.TryParse(txtBoxAccuracy.Text, out accuracy))
            {
                MessageBox.Show("Точность не число");
                return;
            }

            if (txtBoxPath.Text == "" || false == File.Exists(txtBoxPath.Text))
            {
                MessageBox.Show("Ввдеите путь к файлу с результатами");
                return;
            }

            formula = txtBoxFormula.Text;

            List<List<double>> result = new List<List<double>>();
            int length = 0;

            if (radioBtnMin.Checked)
            {
                result = Optimization.Minimize(formula, leftBorder, rightBorder, accuracy);
                length = result[0].Count;
                txtBoxResult.Text = result[0][length - 1].ToString();
            }
            else
            {
                result = Optimization.Maximize(formula, leftBorder, rightBorder, accuracy);
                length = result[0].Count;
                txtBoxResult.Text = result[0][length - 1].ToString();
            }
            
            WorkWithFiles.OutputData(txtBoxPath.Text, txtBoxFormula.Text, result);
        }

        private void btnGraph_Click_1(object sender, EventArgs e)
        {
            if (false == double.TryParse(txtBoxLeftBorder.Text, out leftBorder))
            {
                MessageBox.Show("Левая граница не число");
                return;
            }

            if (false == double.TryParse(txtBoxRightBorder.Text, out rightBorder))
            {
                MessageBox.Show("Правая граница не число");
                return;
            }

            Form2 form2 = new Form2(txtBoxFormula.Text, leftBorder, rightBorder);
            form2.Show();
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtBoxPath.Text = openFileDialog1.FileName;
        }

        private void btnInputData_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            if (false == File.Exists(openFileDialog1.FileName))
            {
                MessageBox.Show("Файла с исходными данными не существует");
                return;
            }

            var inputData = WorkWithFiles.InputData(openFileDialog1.FileName);
            txtBoxFormula.Text = inputData[0];
            txtBoxLeftBorder.Text = inputData[1];
            txtBoxRightBorder.Text = inputData[2];
            txtBoxAccuracy.Text = inputData[3];
        }
    }
}
