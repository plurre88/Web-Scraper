using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Web_Scrape
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            var element = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input"));
            element.SendKeys(".net");
            element.Submit();

            var links = driver.FindElements(By.TagName("a"));

            foreach(var link in links)
            {
                if (link.Text != string.Empty)
                {
                    Console.WriteLine(link.Text);
                }
            }
        }
    }
}
