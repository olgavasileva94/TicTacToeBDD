using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace GameEngine.Features.Steps
{
    [Binding]
    public class SetCellValueOnGamePlaceSteps
    {
        [When(@"I set the cell value x = (.*) y = (.*) to value ""(.*)""")]
        public void WhenISetTheCellValueXYToValue(int p0, int p1, string p2)
        {
            Assert.AreEqual(AddingPlayersSteps.gameEngine.SetCellValue(p0, p1, p2), true);
        }
        
        [Then(@"The value of the cell in x = (.*) y = (.*) must be ""(.*)""")]
        public void ThenTheValueOfTheCellInXYMustBe(int p0, int p1, string p2)
        {
            Assert.AreEqual(AddingPlayersSteps.gameEngine.GetCellValue(p0, p1), p2);
        }

        [Then(@"If you set values to a busy cell x = (.*) y = (.*) value ""(.*)"" i get false")]
        public void ThenIfYouSetValuesToABusyCellXYValueIGetFalse(int p0, int p1, string p2)
        {
            Assert.AreEqual(AddingPlayersSteps.gameEngine.SetCellValue(p0, p1, p2), false);
        }
    }
}
