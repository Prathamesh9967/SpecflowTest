Feature: Login
	To check the login feature


@tag1
Scenario: Login user as admin
	Given I navigate to application
	And I click the Login link
	And I enter username and password
		| username   |	password	|
		|	admin	 |  password	|
	And I click login button
	Then I should see user logged in
