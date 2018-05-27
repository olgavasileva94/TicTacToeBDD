Feature: Adding players
	To add a player
	As a game engine
	I want to create a player and add to the game engine

@add 1 player
Scenario: Add 1 player
	Given I have a game engine
	And No players in game engine
	When I add 1 player to game engine
	Then Game engine should contains 1 player

@add 2 player
Scenario: Add 2 player
	Given I have a game engine
	And No players in game engine
	When I add 2 player to game engine
	Then Game engine should contains 2 player

@add 3 player
Scenario: Add 3 player
	Given I have a game engine
	And No players in game engine
	When I add 3 player to game engine
	Then Game engine should contains 2 player

@add player with parameters (name = "player1" token = "token1" id = 1)
Scenario: Add player with parameters (name = "player1" token = "token1" id = 1)
	Given I have a game engine
	And No players in game engine
	When I add a player with parameters (name = "player1" token = "token1" id = 1) to the game engine
	Then The game engine must contain a player with parameters (name = "player1" token = "token1" id = 1)

@add player with parameters (name = "player2" token = "token2" id = 2)
Scenario: Add player with parameters (name = "player2" token = "token2" id = 2)
	Given I have a game engine
	And No players in game engine
	When I add a player with parameters (name = "player2" token = "token2" id = 2) to the game engine
	Then The game engine must contain a player with parameters (name = "player2" token = "token2" id = 2)