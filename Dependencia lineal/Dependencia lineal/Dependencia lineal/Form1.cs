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
                textBoxV11,textBoxV12,textBoxV13,textBoxV21,textBoxV22,textBoxV23,textBoxV31,textBoxV32,textBoxV33
            };
        }

        private void buttonDependiente_Click(object sender, EventArgs e)
        {
            ComprobateLinealDependence();           
        }
        static double Determinante(double[,] matriz)
        {
            double renglon1Positivo = matriz[0, 0] * matriz[1, 1] * matriz[2, 2];
            double renglon2Positivo = matriz[0, 1] * matriz[1, 2] * matriz[2, 0];
            double renglon3Positivo = matriz[0, 2] * matriz[1, 0] * matriz[2, 1];
            double renglon1Negativo = matriz[2, 0] * matriz[1, 1] * matriz[0, 2];
            double renglon2Negativo = matriz[2, 1] * matriz[1, 2] * matriz[0, 0];
            double renglon3Negativo = matriz[2, 2] * matriz[1, 0] * matriz[0, 1];

            return (renglon1Positivo + renglon2Positivo + renglon3Positivo - renglon1Negativo - renglon2Negativo - renglon3Negativo);
        }

        private double[,] GetMatrix(List<TextBox> list)
        {            
                int index = 0;
                double[,] temp = new double[3, 3];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        temp[i, j] = Convert.ToDouble(list[index].Text);
                        index++;
                    }
                }
                return temp;                        
        }

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
            else if(e.KeyChar.Equals('.'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

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
            ComprobateLinealDependence();
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

        public void ComprobateLinealDependence()
        {
            try
            {
                if (textBoxList.All(x => x.Text != ""))
                {
                    if (Determinante(GetMatrix(textBoxList)) == 0)
                    {
                        MessageBox.Show("El conjunto es linealmente dependiente");
                    }
                    else
                    {
                        MessageBox.Show("El conjunto es linealmente independiente");

                    }
                }
                else
                {
                    MessageBox.Show("Rellene todos los campos por favor");
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Favor de introducir caracteres válidos", "Error");
            }
        }
    }
}
