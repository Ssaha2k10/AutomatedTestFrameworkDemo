Feature: Booking Feature


Scenario: Successful Booking Creation and checkout
	Given the user is logged into the application
	And the user is able to view the booking page
	When the user clicks on the "New" button
	And selects the "<optionName>" from the dropdown menu
	And enters "<clientName>" in the search box
	And selects the client "<clientName>" from the search results
	Then the user should see the list of services available
	When the user selects the service "<serviceCategory>" from the list
	And the user selects the "<serviceName>" from the available services
	And chooses the desired date "<ServiceDate>" for the booking and clicks "Done"
	And the user selects the stylist for the booking "<stylistName>"
	Then the user should see the selected stylist "<stylistName>" displayed for the booking
	When the user selects the desired time slot for the booking "<serviceTime>"
	When the user clicks on the "Save Booking" button
	Then the user should see the booking displayed in the calendar view "<clientName>"
	And The user should be able to confirm the appointment"<clientName>"

	

	Examples: 
	| clientName | optionName  | serviceCategory | serviceName          | ServiceDate | stylistName | serviceTime |
	| Test       | Appointment | Colouring       | Half Head Highlights | 30-Oct-2025 | Rob         | 9:30 AM     | 



	