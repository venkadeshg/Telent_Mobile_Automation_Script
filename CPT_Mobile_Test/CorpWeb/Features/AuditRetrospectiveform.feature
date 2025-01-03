Feature: AuditRetrospectiveform



@Retrospective
Scenario: Retrospective Form
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
	#Retrospective
	When Click on the Create Audit forms
	And Click on the audit type
	And Select the Retrospective in Audit forms
	And Enter the Order Number
	And Click on the Create button
	#General information Retrospective
	Given click on the General information
	And Enter the Exchange Area
	And Enter the Job Description
	And Enter the job address
	And Enter the Contact Number
	And Enter the estimate number
	And Enter the location
	And Click on the Q Check date
	And Select the date
	And Click on the OK button
	And click on the Time Ok button
	And Click on the Operative one
	And select the Operative one Values
	And Enter the Comments
	And Enter the Jobtype
	And Enter the Reinstatementtype
	And select the supplier
	And Click on the back button on gang information
	And click on the General information
	Then Click on the back button on gang information
	#Job validation
	Given Click on the Job validation
	And Click on the work information
	And Enter the Work address
	And Click on the Back button arrow
	And Click on the A five five in job validation
	And Click on the Gang location sheet
	And Click on the Check ok button
	And Click on the back button on gang information
	Then Click on the back button on gang information
	
	 #Summary
	Given Click on the Summary
	Then Click on the back button on gang information
	 #Don't Walk by
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
	#Child form
	Given Click on the Add button in Child forms
	And click on the UG CABLING
	And click on the Form UG CABLING
	And Click on the work information
	And Enter the Work address
	And Click on the Back button arrow
	And Click on the UG Cabling
	And Clik on ugcabling not checked
	And Click on the Check ok button
	And Click on the back button on gang information
	Then Click on the Back press button arrow

	And click Audit submit button
	And click yes button in Are you sure popup screen
	And Click on the signature
	And Clcik Signature Submit button
	And Click on the OK button in audit sucess popup message
	And Click on the Submitted form module
	Then click on the sync icon in Submitted form