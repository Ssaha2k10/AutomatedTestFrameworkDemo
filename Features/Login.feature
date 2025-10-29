
Feature: Login Feature

@Priority1
Scenario Outline: Successful Login with Valid Credentials with Enter Key
	Given the user is on the login page
	When the user enters valid credentials "<username>" and "<password>"
	And the user enters the pin code 
	Then the user should be redirected to the product page

	Examples: 
	| username | password |
	|          |          |     

Scenario Outline: Successful Login with Valid Credentials using login button
	Given the user is on the login page
	When the user enters valid credentials "<username>" and "<password>"
	And the user enters the pin code 
	Then the user should be redirected to the product page

	Examples: 
	| username      | password     |
	|               |              |


  Scenario Outline: Unsuccessful Login with Invalid Credentials
	Given the user is on the login page
	When the user enters valid credentials "<username>" and "<password>"
	And the user enters incorrect pin code "<pin>"	
	Then an error message should be displayed
	
	Examples: 
	| username | password | pin |
	|          |          | 0123 |


 