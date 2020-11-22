using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AbelandcoleProject.Utilities
{
    [Binding]
    public class Hooks1
    {
        public static IWebDriver driver;
       

        [BeforeScenario]
        public void BeforeScenario()
            
        {
//             ChromeOptions option = new ChromeOptions();
//             option.AddArguments("start-maximize");
//             option.AddArguments("--disable-gup");
//             option.AddArguments("--headless");
            
//             new DriverManager().SetUpDriver(new ChromeConfig());
//             Console.WriteLine("Setup");
//             Driver = new ChromeDriver(option);
            
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
