#Scenarios are written in Gherkin
Feature: Provider logo
	Provider logo is present

#Each scenario can have specific tags so that we can run tests with only specific tags if we wish to
#Each step from the scenarios will be linked to the corresponding KEYWORDS file
@smoke @ui
Scenario: Reach providers page 
	Given that the user is on the providers page
	Then the Provider logo should be visible