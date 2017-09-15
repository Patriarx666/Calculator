using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        Calculator C;
        public Form1()
        {
            InitializeComponent();
            C = new Calculator();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            CorrectNumber();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            CorrectNumber();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            CorrectNumber();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            CorrectNumber();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            CorrectNumber();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            CorrectNumber();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            CorrectNumber();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            CorrectNumber();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            CorrectNumber();
        }

     

        private void button3_Click(object sender, EventArgs e)
        {

            if (!BtnPlus.Enabled)
                textBox1.Text = C.Plus(Convert.ToDouble(textBox1.Text)).ToString();
            if (!BtnDelit.Enabled)
                textBox1.Text = C.Delit(Convert.ToDouble(textBox1.Text)).ToString();

            if (!BtnUmnojit.Enabled)
                textBox1.Text = C.Umnojit(Convert.ToDouble(textBox1.Text)).ToString();

            if (!BtnMinus.Enabled)
                textBox1.Text = C.Minus(Convert.ToDouble(textBox1.Text)).ToString();
            C.Clear_X();
            FreeButtons();


        }

        //удаляем лишний ноль впереди числа, если таковой имеется
        private void CorrectNumber()
        {
            //если есть знак "бесконечность" - не даёт писать цифры после него
            if (textBox1.Text.IndexOf("∞") != -1)
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);

            //ситуация: слева ноль, а после него НЕ запятая, тогда ноль можно удалить
            if (textBox1.Text[0] == '0' && (textBox1.Text.IndexOf(",") != 1))
                textBox1.Text = textBox1.Text.Remove(0, 1);

            //аналогично предыдущему, только для отрицательного числа
            if (textBox1.Text[0] == '-')
                if (textBox1.Text[1] == '0' && (textBox1.Text.IndexOf(",") != 2))
                    textBox1.Text = textBox1.Text.Remove(1, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.IndexOf(",") == -1) && (textBox1.Text.IndexOf("∞") == -1))
                textBox1.Text += ",";
        }

        

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            C.Save_X(Convert.ToDouble(textBox1.Text));
            BtnPlus.Enabled = false;
            textBox1.Text = "0";
        }
        

    private void FreeButtons()
        {
            BtnUmnojit.Enabled = true;
            BtnDelit.Enabled = true;
            BtnPlus.Enabled = true;
            BtnMinus.Enabled = true;
           
        }

        private void BtnUmnojit_Click(object sender, EventArgs e)
        {
            C.Save_X(Convert.ToDouble(textBox1.Text));
            BtnPlus.Enabled = false;
            textBox1.Text = "0";
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            C.Save_X(Convert.ToDouble(textBox1.Text));
            BtnPlus.Enabled = false;
            textBox1.Text = "0";
        }

        private void BtnDelit_Click(object sender, EventArgs e)
        {
            C.Save_X(Convert.ToDouble(textBox1.Text));
            BtnDelit.Enabled = false;
            textBox1.Text = "0";
        }
    }
}
