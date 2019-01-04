Feature: PHPTravelAdmin
	In order to add PHP Customers account
	As a admin
	I want to be logged into that application

@mytag
Scenario: Login into PHP Travel admin
	Given I have already opened the Admin application
	And I have entered valid credentials
	When I press login
	Then I should see the admin dashboard screen
