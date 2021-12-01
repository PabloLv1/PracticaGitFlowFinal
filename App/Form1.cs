using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = " ";
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int num3 = int.Parse(textBox3.Text);
            int num4 = int.Parse(textBox4.Text);

            int[] vector ={num1,
                           num2,
                           num3,
                           num4};

            ordenamiento(vector);
        }

        void ordenamiento(int[] vectorEnviado)
        {
            int aux = 0;

            for (int i = 0; i < vectorEnviado.Length - 1; i++)
            {

                for (int j = 0; j < vectorEnviado.Length - 1; j++)
                {

                    if (vectorEnviado[j] > vectorEnviado[j + 1])
                    {
                        aux = vectorEnviado[j];
                        vectorEnviado[j] = vectorEnviado[j + 1];
                        vectorEnviado[j + 1] = aux;

                    }

                }

            }
            TxtResultado.Text += "Vector Ordenado" + Environment.NewLine;
            
            foreach (int elemento in vectorEnviado)
            {
                TxtResultado.Text += elemento + Environment.NewLine;
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
