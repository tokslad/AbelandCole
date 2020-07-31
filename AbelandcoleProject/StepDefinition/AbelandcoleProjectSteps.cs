using AbelandcoleProject.PageObject;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AbelandcoleProject.StepDefinition
{
    [Binding]
    public class AbelandcoleProjectSteps
    {
        AbelandColeProjectPagecs abelandColeProjectPagecs;
        public AbelandcoleProjectSteps()
        {
            abelandColeProjectPagecs = new AbelandColeProjectPagecs();
        }

        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            abelandColeProjectPagecs.NavigateToWebsite(url);
            
        }

        [When(@"I enter search in to the search ""(.*)""")]
        public void WhenIEnterSearchInToTheSearch(string Brownie)
        {
            abelandColeProjectPagecs.EnterSearchTerm(Brownie);
        }

        [When(@"I click on search")]
        public void WhenIClickOnSearch()
        {
            abelandColeProjectPagecs.ClickOnSearchButton();
        }

        [Given(@"I click on Accept cookies")]
        public void GivenIClickOnAcceptCookies()
        {
            abelandColeProjectPagecs.ClickAcceptCookie();
        }


        [When(@"I click on the Add button")]
        public void WhenIClickOnTheAddButton()
        {
            abelandColeProjectPagecs.ClickOnAddButton();
        }


        [When(@"I enter search item in the search ""(.*)""")]
        public void WhenIEnterSearchItemInTheSearch(string HummusChipsOrganic)
        {
            abelandColeProjectPagecs.EnterSearchTerm1(HummusChipsOrganic);
        }
        
        [When(@"I click on search again")]
        public void WhenIClickOnSearchAgain()
        {
            Thread.Sleep(5000);
            abelandColeProjectPagecs.SearchAgain();
        }

        [When(@"I click on the Add again")]
        public void WhenIClickOnTheAddAgain()
        {
            abelandColeProjectPagecs.AddButton1();
        }

        [When(@"I click on the plus to add two more to the basket")]
        public void WhenIClickOnThePlusToAddTwoMoreToTheBasket()
        {
            Thread.Sleep(5000);
            abelandColeProjectPagecs.ClickOnPlusAdd();
        }

        [When(@"I click on the plus to Add two more to the baskets")]
        public void WhenIClickOnThePlusToAddTwoMoreToTheBaskets()
        {
            abelandColeProjectPagecs.ClickOnPlusAddToBaskets();
        }


        [When(@"I enter search items in the search ""(.*)""")]
        public void WhenIEnterSearchItemsInTheSearch(string SimplySaltedPopcorn)
        {
            Thread.Sleep(5000);
            abelandColeProjectPagecs.EnterSearchTerm2(SimplySaltedPopcorn);
        }
        
        [When(@"I click on search button")]
        public void WhenIClickOnSearchButton()
        {
            Thread.Sleep(5000);
            abelandColeProjectPagecs.SearchButton2();
        }

        [When(@"I click on the Add item")]
        public void WhenIClickOnTheAddItem()
        {
            Thread.Sleep(5000);
            abelandColeProjectPagecs.AddButton3();
        }

        [When(@"I click on plus sign twice")]
        public void WhenIClickOnPlusSignTwice()
        {
            abelandColeProjectPagecs.ClickOnPlusSignTwice();
            
        }

        [When(@"I click on plus sign again")]
        public void WhenIClickOnPlusSignAgain()
        {
            abelandColeProjectPagecs.ClickOnPlusSignAgain();
        }




        [When(@"I click on the - sign")]
        public void WhenIClickOnThe_Sign()
        {
            abelandColeProjectPagecs.ClickOnMinusSign();
        }

        [When(@"I click on the basket")]
        public void WhenIClickOnTheBasket()
        {
            abelandColeProjectPagecs.ClickOnBasket();
        }


        [Then(@"I should have all six products in my basket")]
        public void ThenIShouldHaveAllSixProductsInMyBasket()
        {
            Assert.That(abelandColeProjectPagecs.IsAllSixProductDisplayed);
        }


        [Then(@"I should have Brownie displayed")]
        public void ThenIShouldHaveBrownieDisplayed()
        {
            Thread.Sleep(5000);
            Assert.That(abelandColeProjectPagecs.IsBrownieDisplayed);
        }

        [Then(@"I have Hummus Chips displayed")]
        public void ThenIHaveHummusChipsDisplayed()
        {
            Thread.Sleep(5000);
            Assert.That(abelandColeProjectPagecs.IsHummusChipsDisplayed);
        }

        [Then(@"I have Simply salted Popcorn displayed")]
        public void ThenIHaveSimplySaltedPopcornDisplayed()
        {
            Thread.Sleep(5000);
            Assert.That(abelandColeProjectPagecs.IsSimplySaltedPopcornDisplayed);
            
        }

        [Then(@"I have total price is displayed")]
        public void ThenIHaveTotalPriceIsDisplayed()
        {
            Assert.That(abelandColeProjectPagecs.IsTotalPriceDisplayed);
        }










    }
}
