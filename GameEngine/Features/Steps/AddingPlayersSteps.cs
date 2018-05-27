using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace GameEngine.Features.Steps
{
    [Binding]
    public class AddingPlayersSteps
    {
        GameEngine gameEngine;

        [Given(@"I have a game engine")]
        public void GivenIHaveAGameEngine()
        {
            this.gameEngine = new GameEngine();
        }
        
        [Given(@"No players in game engine")]
        public void GivenNoPlayersInGameEngine()
        {
            Assert.AreEqual(this.gameEngine.GetNumberOfPlayers(), 0);
        }
        
        [When(@"I add (.*) player to game engine")]
        public void WhenIAddPlayerToGameEngine(int p0)
        {
            for (int i = 0; i < p0; i ++)
            {
                if (i == 2)
                {
                    Assert.AreEqual(this.gameEngine.AddPlayer(), false);
                } else
                {
                    Assert.AreEqual(this.gameEngine.AddPlayer(), true);
                }
            }
        }
        
        [Then(@"Game engine should contains (.*) player")]
        public void ThenGameEngineShouldContainsPlayer(int p0)
        {
            Assert.AreEqual(this.gameEngine.GetNumberOfPlayers(), p0);
        }
    }
}
