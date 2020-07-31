using AbelandcoleProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;
using System.Threading;

namespace AbelandcoleProject.PageObject
{
    
    class AbelandColeProjectPagecs
    {
        IWebDriver driver;
        public AbelandColeProjectPagecs()
        {
            driver = Hooks1.driver;
            // ImplicitWait;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            

        }




        IWebElement searchTerm => driver.FindElement(By.XPath("//input[@type= 'search']"));
        IWebElement searchButton => driver.FindElement(By.XPath("//input[@class='search menu-item icon-search']"));
        IWebElement addButton => driver.FindElement(By.XPath("(//div[@class='add cta-button'])[1]"));
        IWebElement acceptCookie => driver.FindElement(By.XPath("//*[@id='ccc-notify-accept']"));
        IWebElement searchTerm1 => driver.FindElement(By.XPath("//input[@id='search-term']"));
        IWebElement searchAgain => driver.FindElement(By.XPath("//input[@placeholder='Search']"));
        IWebElement addButton1 => driver.FindElement(By.XPath("//div[@class='add-to-basket-controls']"));
        IWebElement plusAdd => driver.FindElement(By.XPath("(//div[@class='add-sign plus'])[2]"));
        IWebElement searchTerm2 => driver.FindElement(By.XPath("//input[@type= 'search']"));
        IWebElement searchButton2 => driver.FindElement(By.XPath("//input[@class='search menu-item icon-search']"));
        IWebElement addButton3 => driver.FindElement(By.XPath("//*[@id='main - inner]/div[2]/div[2]/form/div/div[3]"));
        IWebElement plusAdd1 => driver.FindElement(By.XPath("(//div[@class='add-sign plus'])[2]"));
        IWebElement plusAddToBaskets => driver.FindElement(By.XPath("(//div[@class='add-sign plus'])[2]"));
        IWebElement plusSignTwice => driver.FindElement(By.XPath("(//div[@class='add-sign plus'])[2]"));
        IWebElement plusSignAgain => driver.FindElement(By.XPath("(//div[@class='add-sign plus'])[2]"));
        IWebElement minusSign => driver.FindElement(By.XPath("(//div[@class='add-sign minus'])[2]"));
        IWebElement allSixProductInBasket => driver.FindElement(By.XPath("//*[@id='BasketTotal']"));
        IWebElement brownie => driver.FindElement(By.XPath("//div[@class='product-name']"));
        IWebElement hummusChips => driver.FindElement(By.XPath("//div[@class='product-name']"));
        IWebElement simplySaltedPopcorn => driver.FindElement(By.XPath("//div[@class='product-name']"));
        IWebElement basket => driver.FindElement(By.XPath("//*[@id='BasketCount']"));
        IWebElement totalPrice => driver.FindElement(By.XPath("//div[@class='total-price-value total']"));











        public void EnterSearchTerm(string Brownie)
        {
            searchTerm.SendKeys(Brownie);
        }

        public void EnterSearchTerm1(string HummusChipsOrganic)
        {

            Thread.Sleep(5000);
        
            searchTerm1.SendKeys(HummusChipsOrganic);
            
        }

        public void EnterSearchTerm2(string SimplySaltedPopcorn)
        {
            Thread.Sleep(5000);
            searchTerm2.SendKeys(SimplySaltedPopcorn);
        }

        public void SearchAgain()
        {
            Thread.Sleep(5000);
            searchAgain.Click();
        }

        public void SearchButton2()
        {
            Thread.Sleep(5000);
            searchButton2.Click();
        }

        public void AddButton1()
        {
            Thread.Sleep(5000);
            addButton1.Click();   
        }

        public void ClickOnBasket()
        {
            basket.Click();
        }

        public void AddButton3()
        {
            Thread.Sleep(5000);
            addButton3.Click();
        }

        public void ClickOnPlusAdd()
        {
            Thread.Sleep(5000);
            plusAdd.Click();
            
        }

        public void ClickOnPlusAddToBaskets()
        {
            plusAddToBaskets.Click();
        }

        public void ClickOnPlusSignTwice()
        {
            plusSignTwice.Click();
        }

        public void ClickOnPlusSignAgain()
        {
            plusSignAgain.Click();
        }

        public void ClickOnMinusSign()
        {
            minusSign.Click();
        }
            


        public void ClickOnAddButton()
        {
            Thread.Sleep(5000);
            addButton.Click();
        }

        public void ClickOnSearchButton()
        {
            Thread.Sleep(5000);
            searchButton.Click();
            
        }

        public void ClickAcceptCookie()
        {
            Thread.Sleep(5000);
            acceptCookie.Click();
        }

        public bool IsAllSixProductDisplayed()
        {
            Thread.Sleep(5000);
            return allSixProductInBasket.Displayed;
        }

        public bool IsBrownieDisplayed()
        {
            Thread.Sleep(5000);
            return brownie.Displayed;
        }

        public bool IsHummusChipsDisplayed()
        {
            Thread.Sleep(5000);
            return hummusChips.Displayed;
        }

        public bool IsSimplySaltedPopcornDisplayed()
        {
            Thread.Sleep(5000);
            return simplySaltedPopcorn.Displayed;
        }

        public bool IsTotalPriceDisplayed()
        {
            Thread.Sleep(5000);
            return totalPrice.Displayed;
        }



        public void NavigateToWebsite(string Url)
        {
            driver.Navigate().GoToUrl(Url);
        }




    }













}
