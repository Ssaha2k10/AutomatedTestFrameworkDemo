Feature: Logout Feature

@Priority2
  Scenario: Successful Logout
	Given the user is logged in with valid credentials <"username"> and <"password">
	When the user views the burger menu
	And the user clicks on the logout button
	Then the user should be redirected to the login page

	Examples: 
	| username | password |
	|          |          |