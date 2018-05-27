using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace GameEngine.Features.Steps
{
    [Binding]
    public class CheckingWinningsSteps
    {
        [Then(@"Checking the end of the game must return = ""(.*)""")]
        public void ThenCheckingTheEndOfTheGameMustReturn(string p0)
        {
            bool result;
            if (p0.Equals("false"))
            {
                result = false;
            }
            else
            {
                result = true;
            }
            Assert.AreEqual(AddingPlayersSteps.gameEngine.IsWin(), result);
        }
    }
}
