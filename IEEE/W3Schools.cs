using IEEE.ComponentHelper;
using IEEE.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEEE.DataDriven
{
   public class W3Schools
    {
        //string xlpath = @"C:\Users\ee210668\Desktop\Data.xlsx";

        #region Webelements
      
        [FindsBy(How = How.XPath, Using = "//*[@id='mySidenav']/div/a[1]")]
        private IWebElement LearnHTML;

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[4]/a")]
        private IWebElement TryItYourself;

        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/button")]
        private IWebElement Run;

      
        #endregion

        public W3Schools()
        {


            PageFactory.InitElements(ObjectRepository.Driver, this);


        }
        #region Actions
        public void NavigatetoW3SchoolsHomePage()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            ObjectRepository.Driver.Manage().Window.Maximize();
        }
        public void ClickLearnHTML()
        {
            LearnHTML.Click();
            //ObjectRepository.Driver.FindElement(Signin).Click();
        }

        public void ClickTryItYourSelf()
        {
            //Username.SendKeys(ExcelHelper.GetCellData(xlpath, "Details", 1, 0).ToString());
            //password.SendKeys(ExcelHelper.GetCellData(xlpath, "Details", 1, 1).ToString());
            //ObjectRepository.Driver.FindElement(Username).SendKeys("divyagottipati97@gmail.com");
            //ObjectRepository.Driver.FindElement(password).SendKeys("Divya@123");
            TryItYourself.Click();
        }
        public void ClickRun()
        {
            var currentWindow = ObjectRepository.Driver.CurrentWindowHandle;
            foreach (String winHandle in ObjectRepository.Driver.WindowHandles)
            {
                if (winHandle != currentWindow)
                {
                    ObjectRepository.Driver.SwitchTo().Window(winHandle);
                }
            }
            Run.Click();
           
            //ObjectRepository.Driver.FindElement(SignInButton).Click();
        }

        #endregion
        #region NAvigation
        public void result()
        {
            Assert.IsNotNull(ObjectRepository.Driver.FindElement(By.XPath("//*[@id='iframeResult']")));
        }

#endregion



    }
}
