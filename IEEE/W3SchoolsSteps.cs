using IEEE.DataDriven;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace IEEE
{
    [Binding]
    public class W3SchoolsSteps
    {

        W3Schools ws = new W3Schools();
        [Given(@"I am at W(.*)Schools HomePage")]
        public void GivenIAmAtWSchoolsHomePage(int p0)
        {
            ws.NavigatetoW3SchoolsHomePage();
        }
        
        [Given(@"I Click Learn HTML")]
        public void GivenIClickLearnHTML()
        {
            ws.ClickLearnHTML();
        }
        
        [Given(@"I Click On Try It YourSelf")]
        public void GivenIClickOnTryItYourSelf()
        {
            ws.ClickTryItYourSelf();
        }
        
        [When(@"I press Run")]
        public void WhenIPressRun()
        {
            ws.ClickRun();
        }
        
        [Then(@"Verify The Result")]
        public void ThenVerifyTheResult()
        {
            ws.result();
        }
    }
}
