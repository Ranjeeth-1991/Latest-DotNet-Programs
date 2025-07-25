Feature: LoginSauseDemo

Testing the Login of Sause Demo Application

#Background: 
#		Given I Click on Login Option in the Home Page

Rule: To Verify the Login with single credentials 

Background: 
		Given I navigate to Sause Demo application website

	@FeatureTests
	Scenario: Valid Login of Sause Demo Application
	
		When User enter the valid Username and Password
		And User click on Login Button
		Then User must Login successfully
		Then User close the window
	
	@FeatureTests
	Scenario: In Valid Login of Sause Demo Application
	
		When User enter the Invalid Username and Password
		And User click on Login Button
		Then User must Stay in Sause Demo Login successfully
		Then User close the window
#
#Rule: To Verify the Login with Multiple Credentials
#
#Scenario Outline: Multiple Login of Sause Demo Application
#	Given I Click on Login Option in the Home Page
#	When User enter the <Username> and <Password>
#	And User click on Login Button
#	Then User must Login successfully
#
#	Examples: 
#	| Username      |					| Password     |
#	| standard_user |					| secret_sauce |
#	| locked_out_user |					| secret_sauce |
#	| problem_user |					| secret_sauce |
#	| performance_glitch_user |			| secret_sauce |

