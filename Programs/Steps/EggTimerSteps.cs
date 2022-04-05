using Programs.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Programs.Steps
{
    class EggTimerSteps
    {

        EggTimerPage _etsteps = new EggTimerPage();


        [Given(@"The user has navigated to the E\.ggTimer url")]
        public void GivenTheUserHasNavigatedToTheE_GgTimerUrl()
        {
            _etsteps.eggtimerUrlLaunch();
        }

        [When(@"Is on the E\.ggTimer page")]
        public void WhenIsOnTheE_GgTimerPage()
        {
            _etsteps.eggtimerPageTitle();
        }

        [Then(@"The user is able to view E\.ggTimer homepage contents loaded")]
        public void ThenTheUserIsAbleToViewE_GgTimerHomepageContentsLoaded()
        {
            _etsteps.eggtimerPageTitle();
        }

        [When(@"The user enters (.*) and starts the counter")]
        public void WhenTheUserEntersAndStartsTheCounter(string time)
        {
            _etsteps.verifyTimerTextBox(time);
        }

        [Then(@"The countdown is strated")]
        public void ThenTheCountdownIsStrated()
        {
            _etsteps.verifyCountdownStarted();
        }

        [Given(@"enters (.*) and starts the counter")]
        public void GivenEntersAndStartsTheCounter(string time)
        {
            _etsteps.verifyTimerTextBox(time);
        }

        [When(@"The countdown is strated")]
        public void WhenTheCountdownIsStrated()
        {
            _etsteps.verifyCountdownStarted();
        }

        [Then(@"The counter to start counting down from the period specified (.*) (.*) (.*)")]
        public void ThenTheCounterToStartCountingDownFromThePeriodSpecified(string period1, string period2, string period3)
        {
            _etsteps.verifyCountdownPeriod(period1, period2, period3);
        }

        [Then(@"The time is decreased by one-second per second")]
        public void ThenTheTimeIsDecreasedByOne_SecondPerSecond()
        {
            _etsteps.verifyTimerDecrement();
        }

    }
}
