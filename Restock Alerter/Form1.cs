using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
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
            if(URLbox.Text == "Alarm")
            {
                ALERT();
            }
            foreach (char c in TimeLengthBox.Text)
            {
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("Please enter only numbers in the TimeLength Box");
                    return;
                }
                    
            }

            if(TimeUnitBox.Text == "seconds")
            {
                Frequency = int.Parse(TimeLengthBox.Text);
            }
            else if(TimeUnitBox.Text == "minutes")
            {
                Frequency = int.Parse(TimeLengthBox.Text) * 60;
            }
            else if (TimeUnitBox.Text == "hours")
            {
                Frequency = int.Parse(TimeLengthBox.Text) * 3600;
            }
            else
            {
                MessageBox.Show("TimeUnit Box not working. Please try again");
                return;
            }

            timeEnd = dateTimePicker.Value;

            Run();
            
        }

        public String getSite()
        {
            MessageBox.Show(URL.Substring(URL.IndexOf('.'), URL.IndexOf('.', URL.IndexOf('.') + 1) - URL.IndexOf('.')));
            return URL.Substring(URL.IndexOf('.'), URL.IndexOf('.', URL.IndexOf('.')+1) - URL.IndexOf('.'));
        }

        public void Run()
        {
            StartButton.Visible = true;
            bool seconds = Frequency < 60 ? true : false;
            String site = getSite();
            IWebDriver driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            driver.Navigate().GoToUrl(URL);
            
            while(DateTime.Now < timeEnd)
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
                else if(site == "gamestop" && driver.FindElements(By.XPath("//button [@class = 'add-to-cart btn btn-primary']")).Count != 0)
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
                if(site == "bestbuy")
                {
                    wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//div [@class = 'priceView-hero-price priceView-customer-price']")));
                }
                else if (site == "walmart")
                {
                    wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//span[@class = 'display-inline-block-xs prod-PaddingRight--xs valign-top']")));
                }
                else if (site == "target")
                {
                    wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//div [@data-test = 'product-price']")));
                }
                else if (site == "gamestop")
                {
                    wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//span [@class = 'selling-price-redesign']")));
                }
                driver.Navigate().Refresh();
            }
        }

        public void ALERT()
        {
            //SoundPlayer player = new SoundPlayer(@"C:\Users\email\Desktop\Alarm.wav");
            MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory + "Resources\\Alarm.wav");
            SoundPlayer player = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "Resources\\Alarm.wav");
            player.Play();
            MessageBox.Show("AVAILABLE");
        }

        #region Accidents
        private void URL_Label_Click(object sender, EventArgs e)
        {

        }

        private void URLbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimeUnitBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
