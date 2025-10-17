
Feature: Login Feature

@Priority1
Scenario Outline: Successful Login with Valid Credentials with Enter Key
	Given the user is on the login page
	When the user enters valid credentials "<username>" and "<password>"
	Then the user should be redirected to the product page

	Examples: 
	| username      | password     |
	|				|			   |

Scenario Outline: Successful Login with Valid Credentials using login button
	Given the user is on the login page
	When the user enters valid credentials "<username>" and "<password>"
	Then the user should be redirected to the product page

	Examples: 
	| username      | password     |
	|               |              |


  Scenario Outline: Unsuccessful Login with Invalid Credentials
	Given the user is on the login page
	When the user enters invalid credentials "<username>" and "<password>"
	Then an error message should be displayed
	
	Examples: 
	| username      | password     |
	|    Test       |     Pass     |

 