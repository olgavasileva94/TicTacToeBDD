Feature: Checking winnings
	To check that the game is over
	As a game engine
	I have to check certain cells

@vertical win
Scenario: Vertical win
	Given I have a game engine
	When I create game place size 3
	And I add a player with parameters (name = "player1" token = "X" id = 1) to the game engine
	And I add a player with parameters (name = "player2" token = "Y" id = 2) to the game engine
	And I make a step in cell x = 0 y = 0
	And I make a step in cell x = 1 y = 1
	And I make a step in cell x = 0 y = 1
	And I make a step in cell x = 1 y = 2
	And I make a step in cell x = 0 y = 2
	Then Checking the end of the game must return = "true"

@horizontal win
Scenario: Horizontal win
	Given I have a game engine
	When I create game place size 3
	And I add a player with parameters (name = "player1" token = "X" id = 1) to the game engine
	And I add a player with parameters (name = "player2" token = "Y" id = 2) to the game engine
	And I make a step in cell x = 0 y = 0
	And I make a step in cell x = 0 y = 1
	And I make a step in cell x = 1 y = 0
	And I make a step in cell x = 1 y = 1
	And I make a step in cell x = 2 y = 0
	Then Checking the end of the game must return = "true"

@diagonal win
Scenario: Diagonal win
	Given I have a game engine
	When I create game place size 3
	And I add a player with parameters (name = "player1" token = "X" id = 1) to the game engine
	And I add a player with parameters (name = "player2" token = "Y" id = 2) to the game engine
	And I make a step in cell x = 0 y = 0
	And I make a step in cell x = 0 y = 1
	And I make a step in cell x = 1 y = 1
	And I make a step in cell x = 1 y = 1
	And I make a step in cell x = 2 y = 2
	Then Checking the end of the game must return = "true"

@no vertical win
Scenario: No vertical win
	Given I have a game engine
	When I create game place size 3
	And I add a player with parameters (name = "player1" token = "X" id = 1) to the game engine
	And I add a player with parameters (name = "player2" token = "Y" id = 2) to the game engine
	And I make a step in cell x = 0 y = 0
	And I make a step in cell x = 1 y = 0
	And I make a step in cell x = 2 y = 0
	Then Checking the end of the game must return = "false"

@no horizontal win
Scenario: No horizontal win
	Given I have a game engine
	When I create game place size 3
	And I add a player with parameters (name = "player1" token = "X" id = 1) to the game engine
	And I add a player with parameters (name = "player2" token = "Y" id = 2) to the game engine
	And I make a step in cell x = 0 y = 0
	And I make a step in cell x = 0 y = 1
	And I make a step in cell x = 0 y = 2
	Then Checking the end of the game must return = "false"

@no diagonal win
Scenario: No diagonal win
	Given I have a game engine
	When I create game place size 3
	And I add a player with parameters (name = "player1" token = "X" id = 1) to the game engine
	And I add a player with parameters (name = "player2" token = "Y" id = 2) to the game engine
	And I make a step in cell x = 0 y = 0
	And I make a step in cell x = 1 y = 1
	And I make a step in cell x = 2 y = 2
	Then Checking the end of the game must return = "false"
