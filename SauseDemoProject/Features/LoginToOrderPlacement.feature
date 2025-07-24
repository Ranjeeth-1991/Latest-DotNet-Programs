Feature: LoginToOrderPlacement

A short summary of the feature

@tag1 @tag2
Scenario: Login to Sauce Demo Application
	Given User Login to Sauce Demo Login Page.
	When User Enter the User Name in Login Page.
	When User Enter the Password in Login Page.
	When User Click on the Login Button.
	Then User Should Login to Sauce Demo Application.
	When User is in Inventory Page.
	When User Click on Add to Cart for Sauce Labs Bolt T-Shirt.
	When User Click on Cart Option.
	And  User Click on Checkout Button.
	When User enter First Name Last Name and Zip Code.
	And  User Click on Continue Button.
	When User Click on Finish Button.
	Then the Order is placed successfully.

	

	

