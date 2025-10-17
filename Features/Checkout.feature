Feature: Checkout Feature

@Priority4
  Scenario: Successful Checkout Process
	Given the user is logged in with valid credentials <"username"> and <"password">
	And the user adds a product to the cart
	When the user user navigates to the cart
	And the user proceeds to checkout
	And the user enters valid shipping information <"firstname">, <"lastname"> and <"postalcode">
	And the user completes the purchase
	Then the user should see a confirmation message
	Examples: 
	| username | password | firstname | lastname | postalcode |
	|          |          | John      | Doe      | Bn1 3OO    |


	