Feature: Create game place
	To create game place
	As a game engine
	I want to create a game place

@create game place 3 x 3
Scenario: Create game place 3 x 3
	Given I have a game engine
	When I create game place size 3
	Then The game place should be the size 3

@create game place 4 x 4
Scenario: Create game place 4 x 4
	Given I have a game engine
	When I create game place size 4
	Then The game place should be the size 4

@create an empty game place
Scenario: Create an empty game place
	Given I have a game engine
	When I create game place size 3
	Then The game place should be the size 3
	And All cells of the game place must be ""
