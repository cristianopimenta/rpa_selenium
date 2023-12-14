using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caSelenium
{
    public class Automator
    {
        public IWebDriver driver;

        public Automator()
        {
            driver = new ChromeDriver();

                }

        public string TesteWeb()
        {
            driver.Navigate().GoToUrl("https://www.google.com.br");
            driver.FindElement(By.Name("q")).SendKeys("hello");
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[2]/div[2]/div[6]/center/input[1]")).Click();
           var text = driver.FindElement(By.XPath("//*[@id=\"gsr\"]")).Text;
            
           return text;
        }

    }
}
