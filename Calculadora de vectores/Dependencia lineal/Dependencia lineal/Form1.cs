using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Dependencia_lineal
{
    public partial class Form1 : Form
    {
        List<TextBox> textBoxList;
        public Form1()
        {
            InitializeComponent();
            textBoxList = new List<TextBox>()
            {
                txtboxI1,txtboxI2,txtboxResult,txtboxJ1,txtboxJ2,txtboxK1,txtboxK2
            };
        }


        public void ReadText(string path)
        {
            Thread.Sleep(10);
            int index = 0;
            FileStream fl = null;
            StreamReader streamReader = null;
            try
            {
                fl = new FileStream(path, FileMode.Open, FileAccess.Read);
                streamReader = new StreamReader(fl);
                while (streamReader.Peek() != -1)
                {
                    string row = streamReader.ReadLine();
                    string[] columns = row.Split(',');
                    textBoxList[index].Text = columns[0].ToString().Remove(0, 9);
                    index++;
                    textBoxList[index].Text = columns[1].ToString();
                    index++;
                    textBoxList[index].Text = columns[2].ToString().Remove(columns[2].Length - 1);
                    index++;
                }
            }
            catch (FileLoadException a)
            {
                MessageBox.Show(a.Message);
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (streamReader != null)
                    streamReader.Close();
                if (fl != null)
                    fl.Close();
            }
        }

        //Handlers
        private void textBoxV11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxV11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.Equals('-'))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.Equals('.'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            foreach (TextBox textbox in textBoxList)
                textbox.Text = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            //MessageBox.Show(e.FullPath+" cambió");
            ReadText(e.FullPath);
            //ComprobateLinealDependence();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            double[] vector1 = new double[3];
            double[] vector2 = new double[3];
            double[] vectorSum = new double[3];

            GetVector(txtboxI1, txtboxJ1, txtboxK1).CopyTo(vector1, 0);
            GetVector(txtboxI2, txtboxJ2, txtboxK2).CopyTo(vector2, 0);
            VectorSum(vector1, vector2).CopyTo(vectorSum, 0);
            SetVector(vectorSum);
        }

        private void btnSubs_Click(object sender, EventArgs e)
        {
            double[] vector1 = new double[3];
            double[] vector2 = new double[3];
            double[] vectorSum = new double[3];

            GetVector(txtboxI1, txtboxJ1, txtboxK1).CopyTo(vector1, 0);
            GetVector(txtboxI2, txtboxJ2, txtboxK2).CopyTo(vector2, 0);
            VectorSubs(vector1, vector2).CopyTo(vectorSum, 0);
            SetVector(vectorSum);
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            double[] vector1 = new double[3];
            double[] vector2 = new double[3];
            double[] vectorCross = new double[3];

            GetVector(txtboxI1, txtboxJ1, txtboxK1).CopyTo(vector1, 0);
            GetVector(txtboxI2, txtboxJ2, txtboxK2).CopyTo(vector2, 0);
            CrossProduct(vector1, vector2).CopyTo(vectorCross,0);
            SetVector(vectorCross);

        }

        //Methods

        static double[] GetVector(TextBox i, TextBox j, TextBox k)
        {
            double[] vector = new double[3];
            if (i.Text != "")
            {
                vector[0] = double.Parse(i.Text);
            }
            else
            {
                vector[0] = 0;
            }
            if (j.Text != "")
            {
                vector[1] = double.Parse(j.Text);
            }
            else
            {
                vector[1] = 0;
            }
            if (k.Text != "")
            {
                vector[2] = double.Parse(k.Text);
            }
            else
            {
                vector[2] = 0;
            }
            return vector;
        }
        static double[] VectorSum(double[] vectorA, double[] vectorB)
        {
            double[] vectorSum = new double[3];
            vectorSum[0] = vectorA[0] + vectorB[0];
            vectorSum[1] = vectorA[1] + vectorB[1];
            vectorSum[2] = vectorA[2] + vectorB[2];
            return vectorSum;
        }
        static double[] VectorSubs(double[] vectorA, double[] vectorB)
        {
            double[] vectorSubs = new double[3];
            for (int i = 0; i < 3; i++)
            {
                vectorSubs[i] = vectorA[i] - vectorB[i];
            }
            return vectorSubs;
        }
        static double GetSize(double[] vector)
        {
            return Math.Sqrt(Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2) + Math.Pow(vector[0], 2));
        }
        void PointProduct(double[] vector1, double[] vector2)
        {
            double result = 0;
            double[] product = new double[3];
            for (int i = 0; i < 3; i++)
            {
                product[i] = vector1[i] * vector2[i];
            }
            result = product[0] + product[1] + product[2];
            txtboxResult.Text = result.ToString();
        }
        static double[] CrossProduct(double[] vector1, double[] vector2)
        {
            double[] vectorCross = new double[3];
            vectorCross[0] = ((vector1[1] * vector2[2]) - (vector1[2] * vector2[1]));
            vectorCross[1] = -((vector1[0] * vector2[2]) - (vector1[2] * vector2[0]));
            vectorCross[2] = ((vector1[0] * vector2[1]) - (vector1[1] * vector2[0]));
            return vectorCross;
        }
        void SetVector(double[] vector)
        {
            txtboxResult.Text = VectorFormat("i", vector[0]) + VectorFormat("j", vector[1]) + VectorFormat("k", vector[2]);
        }
        public string VectorFormat(string axis, double number)
        {
            if (number >= 0)
            {
                return String.Format("+ {0}{1} ", number, axis);
            }
            else if (number < 0)
            {
                return String.Format("- {0}{1} ", Math.Abs(number), axis);
            }
            else
            return "";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            double[] vector1 = new double[3];
            double[] vector2 = new double[3];
            double[] vectorCross = new double[3];

            GetVector(txtboxI1, txtboxJ1, txtboxK1).CopyTo(vector1, 0);
            GetVector(txtboxI2, txtboxJ2, txtboxK2).CopyTo(vector2, 0);
            PointProduct(vector1, vector2);
        }
    }
}
