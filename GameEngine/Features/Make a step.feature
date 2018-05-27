Feature: Make a step
	To make a step
	As a game engine
	I want to set cell value on game place

@make a step in cell x = 0 y = 1
Scenario: Make a step in cell x = 0 y = 1
	Given I have a game engine
	When I create game place size 3
	And I add a player with parameters (name = "player1" token = "X" id = 1) to the game engine
	And I make a step in cell x = 0 y = 1
	Then The value of the cell in x = 0 y = 1 must equal the value of the player token with id = 1

@make a step in cell x = 2 y = 2
Scenario: Make a step in cell x = 2 y = 2
	Given I have a game engine
	When I create game place size 3
	And I add a player with parameters (name = "player1" token = "X" id = 1) to the game engine
	And I make a step in cell x = 2 y = 2
	Then The value of the cell in x = 2 y = 2 must equal the value of the player token with id = 1

@make a step in cell x = 0 y = 0 and make a step in cell x = 1 y = 1
Scenario: Make a step in cell x = 0 y = 0 and make a step in cell x = 1 y = 1
	Given I have a game engine
	When I create game place size 3
	And I add a player with parameters (name = "player1" token = "X" id = 1) to the game engine
	And I add a player with parameters (name = "player2" token = "Y" id = 2) to the game engine
	And I make a step in cell x = 0 y = 0
	And I make a step in cell x = 1 y = 1
	Then The value of the cell in x = 0 y = 0 must equal the value of the player token with id = 1
	And The value of the cell in x = 1 y = 1 must equal the value of the player token with id = 2

@make a step in cell x = 0 y = 0 and make a step in cell x = 1 y = 1 and make a step in cell x = 2 y = 2
Scenario: Make a step in cell x = 0 y = 0 and make a step in cell x = 1 y = 1 and make a step in cell x = 2 y = 2
	Given I have a game engine
	When I create game place size 3
	And I add a player with parameters (name = "player1" token = "X" id = 1) to the game engine
	And I add a player with parameters (name = "player2" token = "Y" id = 2) to the game engine
	And I make a step in cell x = 0 y = 0
	And I make a step in cell x = 1 y = 1
	And I make a step in cell x = 2 y = 2
	Then The value of the cell in x = 0 y = 0 must equal the value of the player token with id = 1
	And The value of the cell in x = 1 y = 1 must equal the value of the player token with id = 2
	And The value of the cell in x = 2 y = 2 must equal the value of the player token with id = 1

@make a two step in cell x = 0 y = 0
Scenario: Make a two step in cell x = 0 y = 0
	Given I have a game engine
	When I create game place size 3
	And I add a player with parameters (name = "player1" token = "X" id = 1) to the game engine
	And I add a player with parameters (name = "player2" token = "Y" id = 2) to the game engine
	And I make a step in cell x = 0 y = 0
	And I make a step in cell x = 0 y = 0
	Then The value of the cell in x = 0 y = 0 must equal the value of the player token with id = 1
