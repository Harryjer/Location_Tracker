using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Location_Tracker
{
    class EntryPoint
    {
        static void Main()
        {
            IWebDriver driver = new ChromeDriver();
            string Url = "https://www.google.com/webhp?hl=en&sa=X&ved=0ahUKEwiO1sjrrs3uAhXkzzgGHSpxD2EQPAgI";

            IWebElement image = driver.FindElement(By.CssSelector("#hplogo"));
            driver.Manage().Window.Maximize();

            Console.WriteLine(image.Location.X);
            Console.WriteLine(image.Size.Height);
            Console.WriteLine(image.Size.Width);
            Console.WriteLine(image.Location.Y);
        }
    }
}
