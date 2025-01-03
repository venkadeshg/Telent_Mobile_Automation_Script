Feature: AuditForm

A short summary of the feature

@Regression
Scenario: Auditforms_BEE_mobile
	Given Launched 'TelentEmulator' app
	When Allow all permission in BEE mobile app
	And Enter the User name
	And Enter the Password
	And Click on the submit button in sign in page
	And Click on I Agree button
	And Click on the Cancel button in Storage clean popup
    And Enable the Active taggle button
	And Click on the Check Now button on Gate check
	And Complete Gate Check
    When Click on the Create Audit forms 
	And Select Audit Type
	And Enter the Order Number
    And Click on the Create button
    And click on the Gang information
    And Enter the Gang ID
    And Enter vechcle Registeration Number
    And Select the Region
	And Enter the Location
    And Enter BT ID Card Number
	And Enter the NRSWA card Number
	Then Click on the back button on gang information

	And Click Agent gate check
	And click vechile and trailer checklist
	And Click yes radio buttton preuse inspector
	And Click on the back button on vechile and trailer checklist screen
	And Click on the back button on Agent Gate Check

	And Click on the Summary
	And Enter the Gate check summary
	And Enter the Name
	And click on the No burron in Work Stop
	And Click on the back button on Summary

	Given Click on the Dont walk by
	And Enter the Name Of person
	And Enter the Mobile Number
	And Select the Parent company
	And Select the Dont walk by region
	#And Enter the Location
	And Enter the what to you want to tell us?
	And Enter the Describe the action you have taken
	And Click on the No button in does this require further action
	And Click on the Minor radio button in severity
	And Click on the Quality Radio button in Category
	And Selet the Type
	Then click on the backbutton in Dont walk by screen

	And click Audit submit button
	And click yes button in Are you sure popup screen
	And Click on the signature
	And Clcik Signature Submit button
	And Click on the OK button in audit sucess popup message
	And Click on the Submitted form module
	Then click on the sync icon in Submitted form