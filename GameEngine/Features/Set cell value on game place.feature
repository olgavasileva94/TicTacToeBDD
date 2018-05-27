Feature: Set cell value on game place
	To set cell value on game place
	As a game engine
	I want to create a game place and set cell value on game place

@set cell x = 1 y = 2 value "x"
Scenario: Set cell x = 1 y = 2 value "x"
	Given I have a game engine
	When I create game place size 3
	And I set the cell value x = 1 y = 2 to value "x"
	Then The game place should be the size 3
	And The value of the cell in x = 1 y = 2 must be "x"

@set cell x = 2 y = 0 value "y"
Scenario: Set cell x = 2 y = 0 value "y"
	Given I have a game engine
	When I create game place size 3
	And I set the cell value x = 2 y = 0 to value "y"
	Then The game place should be the size 3
	And The value of the cell in x = 2 y = 0 must be "y"
