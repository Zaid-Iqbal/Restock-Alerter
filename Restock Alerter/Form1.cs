using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restock_Alerter
{
    public partial class Form1 : Form
    {
        public static String URL;
        public static int Frequency;
        public static DateTime timeEnd;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            URL = URLbox.Text;
            foreach (char c in TimeLengthBox.Text)
            {
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("Please enter only numbers in the TimeLength Box");
                    return;
                }
                    
            }

            if(TimeUnitBox.Text == "s")
            {
                Frequency = int.Parse(TimeLengthBox.Text);
            }
            else if(TimeUnitBox.Text == "min")
            {
                Frequency = int.Parse(TimeLengthBox.Text) * 60;
            }
            else if (TimeUnitBox.Text == "hr")
            {
                Frequency = int.Parse(TimeLengthBox.Text) * 3600;
            }
            else
            {
                MessageBox.Show("TimeUnit Box not working. Please try again");
                return;
            }

            timeEnd = dateTimePicker.Value;

            
        }

        #region Accidents
        private void URL_Label_Click(object sender, EventArgs e)
        {

        }

        private void URLbox_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        public String getSite()
        {
            return URL.Substring(URL.IndexOf('.'), URL.IndexOf('.') - URL.IndexOf('.', URL.IndexOf('.')+1));
        }

        public void Run()
        {
            bool seconds = Frequency < 60 ? true : false;
            String site = getSite();
            IWebDriver driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            driver.Navigate().GoToUrl(URL);
            
            while(DateTime.Now != timeEnd)
            {
                DateTime start = DateTime.Now;

                if(site == "bestbuy" && driver.FindElements(By.XPath("//button [@class = 'btn btn-primary btn-lg btn-block btn-leading-ficon add-to-cart-button']")).Count != 0)
                {
                    ALERT();
                }
                else if (site == "walmart" && driver.FindElements(By.XPath("//span[@class = 'spin-button-children']")).Count != 0)
                {
                    ALERT();
                }
                else if (site == "target" && driver.FindElements(By.XPath("//button [@class = 'Button__ButtonWithStyles-y45r97-0 styles__StyledButton-sc-1f2lsll-0 eLsRDh iyUhph']")).Count != 0)
                {
                    ALERT();
                }
                else if(site == "gamstop" && driver.FindElements(By.XPath("//button [@class = 'add-to-cart btn btn-primary ']")).Count != 0)
                {
                    ALERT();
                }

                /*
                if(seconds)
                {
                    while ((DateTime.Now - start) < TimeSpan.FromSeconds(Frequency))
                    {
                        if((DateTime.Now - start) >  TimeSpan.FromSeconds(5))
                        {
                            Thread.Sleep(5000);
                        }
                    }
                }
                */

                Thread.Sleep(Frequency*1000);
                driver.Navigate().Refresh();
            }
        }

        public void ALERT()
        {
            MessageBox.Show("AVAILABLE");
        }
    }
}
