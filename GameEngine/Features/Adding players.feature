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