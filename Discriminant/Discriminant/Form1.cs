using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discriminant
{
    public partial class Form1 : Form
    {
        double a, b, c, D, x1, x2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Peremenie();
            Korni();
        }

        public void Peremenie()
        {
            a = Convert.ToDouble(textBox1.Text.ToString());
            b = Convert.ToDouble(textBox2.Text.ToString());
            c = Convert.ToDouble(textBox3.Text.ToString());

            D = Math.Pow(b, 2) - 4 * a * c;


        }

        public void Korni()
        {
            if (D < 0)
            {
                MessageBox.Show("Дискриминант равен: " +D.ToString(), "Уравнение корней не имеет");
               
            }

            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);

                StringBuilder strbd = new StringBuilder();

                strbd.Append("Дискриминант равен: " +D.ToString() +Environment.NewLine);
                strbd.Append("X1=  " + x1.ToString() + Environment.NewLine);
                strbd.Append("X2=  " + x2.ToString() + Environment.NewLine);

                richTextBox1.Text = strbd.ToString();

            }
            
            if (D == 0)
            {
                x1 = -b / (2 * a);
                StringBuilder Strbd = new StringBuilder();
                Strbd.Append("Дискриминант равен: " + D.ToString() + Environment.NewLine);
                Strbd.Append("X1= " +x1.ToString());

                richTextBox1.Text = Strbd.ToString();
            }
        }
    }
}
