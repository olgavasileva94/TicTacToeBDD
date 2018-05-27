using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace GameEngine.Features.Steps
{
    [Binding]
    public class CreateGamePlaceSteps
    {
        [When(@"I create game place size (.*)")]
        public void WhenICreateGamePlaceSize(int p0)
        {
            AddingPlayersSteps.gameEngine.CreateGamePlace(p0);
        }

        [Then(@"The game place should be the size (.*)")]
        public void ThenTheGamePlaceShouldBeTheSize(int p0)
        {
            Assert.AreEqual(AddingPlayersSteps.gameEngine.GetSizeGamePlace(), p0);
        }

        [When(@"I create game place")]
        public void WhenICreateGamePlaceSize()
        {
            AddingPlayersSteps.gameEngine.CreateGamePlace();
        }

        [Then(@"All cells of the game place must be ""(.*)""")]
        public void ThenAllCellsOfTheGamePlaceMustBe(string p0)
        {
            int size = AddingPlayersSteps.gameEngine.GetSizeGamePlace();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Assert.AreEqual(AddingPlayersSteps.gameEngine.GetCellValue(i, j), p0);
                }
            }
        }
    }
}
