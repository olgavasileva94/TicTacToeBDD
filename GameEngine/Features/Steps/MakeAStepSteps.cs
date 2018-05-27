using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace GameEngine.Features.Steps
{
    [Binding]
    public class MakeAStepSteps
    {
        [When(@"I make a step in cell x = (.*) y = (.*)")]
        public void WhenIMakeAStepInCellXY(int p0, int p1)
        {
            bool result;
            if (AddingPlayersSteps.gameEngine.GetCellValue(p0, p1) == "")
            {
                result = true;
            }
            else
            {
                result = false;
            }
            Assert.AreEqual(AddingPlayersSteps.gameEngine.MakeAStep(p0, p1), result);
        }
        
        [Then(@"The value of the cell in x = (.*) y = (.*) must equal the value of the player token with id = (.*)")]
        public void ThenTheValueOfTheCellInXYMustEqualTheValueOfThePlayerTokenWithId(int p0, int p1, int p2)
        {
            Assert.AreEqual(AddingPlayersSteps.gameEngine.GetCellValue(p0, p1), AddingPlayersSteps.gameEngine.GetPlayer(p2).GetToken());
        }
    }
}
