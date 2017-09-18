using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Patriarx_GENERATOR
{
    public partial class Form1 : Form
    {
        private string akk;
        private string[] akkParts;
        private BackgroundWorker bwMakeMails;
        private FileInfo fileForSafe;
        private ProgressBar pbMails;
        public Form1()
        {
            InitializeComponent();
            this.bwMakeMails = new BackgroundWorker();
            this.bwMakeMails.DoWork += new DoWorkEventHandler(this.Go);
            this.bwMakeMails.ProgressChanged += new ProgressChangedEventHandler(this.ProgressChanged);
            this.bwMakeMails.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.EndWork);
            this.bwMakeMails.WorkerReportsProgress = true;
            this.pbMails.Style = ProgressBarStyle.Continuous;  
        }

        private void button1_Click(object sender, EventArgs e)
        {  

            //начало кода
            if (!this.bwMakeMails.IsBusy)
            {
                this.akk = this.Textmail.Text;
                this.akkParts = this.akk.Split(new char[] { '@' });
                if (this.akkParts.Length != 2)
                {
                    MessageBox.Show("Ой, вы наверное ошиблись? \r\nПридерживайтесь формата qwe@mail.com", "Ошибка!");
                }
                else if (this.akkParts[0].Length < 2)
                {
                    MessageBox.Show("Не маловато-ли будет?", "Ошибка!");
                }
                else if ((this.akkParts[0].Length <= 0x15) || (MessageBox.Show("Много букав, вы уверены, что хотите ждать?", "Слишком длинная почта!", MessageBoxButtons.OKCancel) != DialogResult.Cancel))
                {
                    this.pbMails.Value = 0;
                    SaveFileDialog dialog = new SaveFileDialog
                    {
                        Title = "Сохранение файла с мылами",
                        DefaultExt = "txt",
                        Filter = "Text files  (*.txt)|*.txt",
                        FileName = this.akkParts[0]
                    };
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        this.fileForSafe = new FileInfo(dialog.FileName);
                        this.bwMakeMails.RunWorkerAsync(this.akkParts[0]);
                    }
                }
            }
             
        }
        
       
        


        
        private void EndWork(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                File.WriteAllLines(this.fileForSafe.FullName, (string[])e.Result);
                MessageBox.Show("Сгенерировано " + ((string[])e.Result).Length + " почт", "Готово");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        

        

        

        private void Go(object sender, DoWorkEventArgs e)
        {
            string argument = (string)e.Argument;
            int stepen = argument.Length - 1;
            long num2 = this.Pow2(stepen) - 1L;
            string[] strArray = new string[num2];
            double num3 = num2;
            int num4 = 0;
            for (long i = 1L; i <= num2; i += 1L)
            {
                int num6 = 0;
                long num7 = i;
                strArray[(int)((IntPtr)(i - 1L))] = this.akk;
                for (int j = stepen; j > -1; j--)
                {
                    long num9 = this.Pow2(j);
                    if ((num7 / num9) == 1L)
                    {
                        strArray[(int)((IntPtr)(i - 1L))] = strArray[(int)((IntPtr)(i - 1L))].Insert((num6++ + stepen) - j, ".");
                        num7 -= num9;
                    }
                }
                int percentProgress = Convert.ToInt32((double)((((double)i) / num3) * 1000.0));
                if (num4 < percentProgress)
                {
                    this.bwMakeMails.ReportProgress(percentProgress);
                    num4 = percentProgress;
                }
            }
            e.Result = strArray;
        }

        

        private long Pow2(int stepen)
        {
            long num = 1L;
            for (byte i = 0; i < stepen; i = (byte)(i + 1))
            {
                num *= 2L;
            }
            return num;
        } 

        private void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                this.pbMails.Value = e.ProgressPercentage;
            }
            catch (Exception)
            {
            }
        } 
    }
}
