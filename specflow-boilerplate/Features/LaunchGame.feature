#Scenarios are written in Gherkin
Feature: Launch game
	Game launched

#Each scenario can have specific tags so that we can run tests with only specific tags if we wish to
#Each step from the scenarios will be linked to the corresponding KEYWORDS file
@smoke @ui
Scenario: Launch a game 
	Given that the user is on the Casino page
	When the user clicks on the Casino link
	AND the user filters after a specific provider
	AND clicks on the PLAY button of one of the games 
	Then the game is launched