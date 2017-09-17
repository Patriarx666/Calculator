using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Threading.Timer timer = new System.Threading.Timer(
                new System.Threading.TimerCallback((o) =>
                {
                    label1.Invoke(new Action(() => label1.Text = DateTime.Now.ToString()));
                }), null, 0, 1000);
        }
    }
}
