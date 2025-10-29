Feature: Booking Feature


Scenario: Successful Booking Creation and checkout
	Given the user is on the Slick Calendar page
	And the user is logged into the application
	And the user is able to view the booking page
	When the user clicks on the "New" button
	And selects the "<optionName>" from the dropdown menu
	And enters "<clientName>" in the search box
	And selects the client "<clientName>" from the search results
	Then the user should see the list of services available for "<clientName>"
	When the user selects the service "<serviceCategory>" from the list
	And the user selects the "<serviceName>" from the available services
	Then the user should see the calendar and the option to select a stylist for booking
	When the user selects the calendar 
	And chooses the desired date "<ServiceDate>" for the booking and clicks "Done"
	Then the calendar should collapse and show the selected date "<ServiceDate>"
	When the user clicks to select the stylist for the booking
	And the user clicks on the "More" button
	And selects the available stylist from the list
	Then the user should see the selected stylist displayed for the booking
	When the user clicks to select the time for the booking
	And selects the desired time slot for the booking
	Then the user should see the selected time displayed for the booking
	When the user clicks on the "Save Booking" button
	Then the user should see the booking displayed in the calendar view
	And the sidebar should close automatically
	When the user clicks on the created booking in the calendar
	Then the user should see the booking details displayed
	When the user clicks on the "Confirm" button
	Then the booking status should change to "Confirmed"
	When the user clicks on the "Checkout & Rebook" button
	Then the modal for checkout or rebook should appear
	When the user clicks on the "GO TO CHECKOUT" button
	Then the user should see the checkout page with booking details
	When the user clicks on the "Complete" button
	Then the user should see the modal to confirm payment
	When the user clicks on the "Confirm" button
	Then the user should see the payment confirmation message
	And should view the modal to enter the email address "<emailAddress>" for receipt
	When the user enters the email address "<emailAddress>"
	And the user clicks on the "Send Receipt" button
	Then the user should see a message confirming that the receipt has been sent to "<emailAddress>"
	When the user clicks on the "Close" button
	Then the user should be redirected to the calendar view
	When the user clicks on the booking
	Then the sidebar should open displaying the booking details as checked out

	Examples: 
	| clientName | optionName        | serviceCategory | serviceName			| ServiceDate     | stylistName    | emailAddress           |
	| Test      | Appointment        | Colouring       | Half Head Highlights   | 30 Oct 2025     |    Rob         | test@test.com          |



	