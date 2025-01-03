Feature: SupportingformDontwalkby

Validate the Supprtingform under Dont walk by form

@Regression
Scenario: Supportingform_dontwalkby
	Given Launched 'TelentEmulator' app
	When Allow all permission in BEE mobile app
	And Enter the User name
	And Enter the Password
	And Click on the submit button in sign in page
	And Click on I Agree button
	And Click on the Cancel button in Storage clean popup
    And Enable the Active taggle button
	And Click on the Check Now button on Gate check
	Then Complete Gate Check

	#Supporting forms
	Given Click on the Create new supporting forms

	When Click on the Form Type Dropdown
