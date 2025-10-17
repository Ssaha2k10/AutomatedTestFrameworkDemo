Feature: Add Product Feature

@Priority3
  Scenario: View Products Page
	Given the user is logged in with valid credentials <"username"> and <"password">
	Then the user should be able to view the products page
	
	Examples: 
	| username | password |
	|          |          |

Scenario: Add item to cart and navigate to cart
	Given the user is logged in with valid credentials <"username"> and <"password">
	And The user is on the products page
	When the user adds a product to the cart
	Then the user should be able to view the product in cart
		Examples: 
	| username | password |
	|          |          |
