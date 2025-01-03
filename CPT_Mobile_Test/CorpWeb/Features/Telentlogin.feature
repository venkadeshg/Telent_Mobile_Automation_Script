Feature: Telent_MOBILE_APP

@Regression
Scenario: Telent_MOBILE_LOGIN
	Given Launched 'TelentEmulator' app
	When Allow all permission in BEE mobile app
	And Verify the Signin 
	And Enter the User name
	And Enter the Password
	And Click on the submit button in sign in page
	And Click on I Agree button
	And Click on the Cancel button in Storage clean popup	
    And Enable the Active taggle button
	And Verify the Dashbord username
	And Click on the Check Now button on Gate check
	Then Complete Gate Check
