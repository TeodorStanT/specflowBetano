#Scenarios are written in Gherkin
Feature: Login
	Login to BETANO

#Each scenario can have specific tags so that we can run tests with only specific tags if we wish to
#Each step from the scenarios will be linked to the corresponding KEYWORDS file
@smoke @ui
Scenario: Perform Login of BETANO Appliaction site
	Given that the user clicks the login link
	When the user logs in with credentials
		| Username | Password |
		| tstanstgro | parolateodor1  |
	Then the Balance should be visible