using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Wildmoney
{
    public partial class Form1 : Form
    {
        IWebDriver Browser;
        public Form1()
        {
            InitializeComponent();
        }

        void Authorization()
        {
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl("https://wildmoney.org/login");
            
            WebDriverWait lp = new WebDriverWait(Browser, TimeSpan.FromSeconds(30)); //Задаем время ожидания 
            IWebElement vv = lp.Until(ExpectedConditions.ElementIsVisible(By.Id("ctrl_pageLogin_login"))); //Задаем селектор , который должен появится на странице
           
            IWebElement login = Browser.FindElement(By.Id("ctrl_pageLogin_login")); //Поиск строки ввода логина
            login.SendKeys("" + textBox1.Text); //Читаем логин из текстбокса и вводим 

            IWebElement password = Browser.FindElement(By.Id("ctrl_pageLogin_password")); //Поиск строки ввода пароля
            password.SendKeys("" + textBox2.Text + OpenQA.Selenium.Keys.Enter); //Читаем пароль из текстбокса и вводим , надимаем кнопку ентер для входа

            System.Threading.Thread.Sleep(10000);
        }
     public  void MainMethod ()
            {
            System.Threading.Timer timer = new System.Threading.Timer(
              new System.Threading.TimerCallback((o) =>
              {
                  textBox4.Invoke(new Action(() => textBox4.Text = DateTime.Now.ToString()));
              }), null, 0, 1000);


            int n = 1;
            while (n< 6)
            {
                System.Threading.Thread.Sleep(30000);
                string edit = "/edit";
        Browser.Navigate().GoToUrl("https://wildmoney.org/profile-posts/" +textBox3.Text  + edit);
        //Work


        IWebElement post = Browser.FindElement(By.Name("message"));
        post.Click();
                post.Clear();

               
                post.SendKeys("" + textBox4.Text);

                
              

                IWebElement go = Browser.FindElement(By.CssSelector(".primary"));
        go.Click();

              
            }
}


        private void button1_Click(object sender, EventArgs e)
        {
            Authorization();

            Thread t = new Thread(MainMethod);
            t.Start();

            // textBox4.Text = dateTimePicker1.Value.ToString();

            // dateTimePicker1.Value = DateTime.Now.ToLocalTime();

          

           

        }

       

        
         


        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
   
          
            
        }

        
    }

