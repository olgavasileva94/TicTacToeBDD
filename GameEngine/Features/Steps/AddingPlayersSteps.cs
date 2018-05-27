using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace GameEngine.Features.Steps
{
    [Binding]
    public class AddingPlayersSteps
    {
        public static GameEngine gameEngine;

        [Given(@"I have a game engine")]
        public void GivenIHaveAGameEngine()
        {
            gameEngine = new GameEngine();
        }
        
        [Given(@"No players in game engine")]
        public void GivenNoPlayersInGameEngine()
        {
            gameEngine.ClearPlayers();
            Assert.AreEqual(gameEngine.GetNumberOfPlayers(), 0);
        }
        
        [When(@"I add (.*) player to game engine")]
        public void WhenIAddPlayerToGameEngine(int p0)
        {
            for (int i = 0; i < p0; i ++)
            {
                if (i == 2)
                {
                    Assert.AreEqual(gameEngine.AddPlayer(), false);
                } else
                {
                    Assert.AreEqual(gameEngine.AddPlayer(), true);
                }
            }
        }
        
        [Then(@"Game engine should contains (.*) player")]
        public void ThenGameEngineShouldContainsPlayer(int p0)
        {
            Assert.AreEqual(gameEngine.GetNumberOfPlayers(), p0);
        }

        [When(@"I add a player with parameters \(name = ""(.*)"" token = ""(.*)"" id = (.*)\) to the game engine")]
        public void WhenIAddAPlayerWithParametersNameTokenIdToTheGameEngine(string p0, string p1, int p2)
        {
            Assert.AreEqual(gameEngine.AddPlayer(p0, p1, p2), true);
        }

        [Then(@"The game engine must contain a player with parameters \(name = ""(.*)"" token = ""(.*)"" id = (.*)\)")]
        public void ThenTheGameEngineMustContainAPlayerWithParametersNameTokenId(string p0, string p1, int p2)
        {
            Assert.AreEqual(gameEngine.PlayerExist(p2), true);
            Player player = gameEngine.GetPlayer(p2);
            Assert.AreEqual(player.GetName(), p0);
            Assert.AreEqual(player.GetToken(), p1);
            Assert.AreEqual(player.GetId(), p2);
        }
    }
}
