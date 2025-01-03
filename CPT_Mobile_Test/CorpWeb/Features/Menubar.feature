Feature: Menubar

Validate the Menu bar Screen

@Regression
Scenario: Telent_menu_list
	Given Launched 'TelentEmulator' app
	When Allow all permission in BEE mobile app
	#And Verify the Signin 
	And Enter the User name
	And Enter the Password
	And Click on the submit button in sign in page
	And Click on I Agree button
	And Click on the Cancel button in Storage clean popup	
    And Enable the Active taggle button
	And Verify the Dashbord username
	And Click on the Check Now button on Gate check
	Then Complete Gate Check

	#Help
	Given Click on the Menu icon
	When Click on the Help button
	And Verify the Report a problem
	And Enter the Comments in Report a problem
	And Click on the Send report
	And Verify the Problem Report popup
	And Click on the Ok button in Problem Report popup

	#List of Task
	Given Click on the List of Task in menu bar
	And Verfy the Active Task
	Then Click on the back press icon in List of Task Screen

	#Two hour Response
	Given Click on the Two hour Response
	When Verify the Order number label
	And Enter the Order No
	And Click on the Add visits in Menu bar screen
	Then Click on the back button in Two hour response Screen

	#Create new job manually
	Given Click on the Create new Job manually
	When Verify site Visit in Create new job Screen
	And Enter the Order No
	And Click Reason for job creating manually
	And Click on the Urgent visit
	And Click on the Add visits in Menu bar screen
	Then Click on the back button in Two hour response Screen

	#Create New Audit
	Given Click on the Create new Audit
	When Verify the Create New Audit Form Screen
	Then Click on the back press icon in List of Task Screen

	#sync status
	Given Click on the sync status 
	When Verify the Sync Status
	And Click on the back icon in sync

	#Message
	Given Click on the message
	When Verify the message screen
	And Verify the Info Container
	And Click on the Info Container
	And Verify the Message details
	And Enter the Comments in message
	And Click on the Plus icon
	And Verift the Member one text
	And Click on the Edit button
	And Verify Acknowledge
	And Enter the CSSID in Acknowledge Screen
	And Enter the Comments in message
	And Click on the signature in Acknowledge
	And Click on the signature
	And Click on the Done button on signature
	And Click on the Acknowledgment button
	And Click on the signature in Acknowledge
	And Click on the signature
	And Click on the Done button on signature
	And Click on the Acknowledge button in message
	Then Click on the back button in message screen


	#HSEQ Hub
	Given Click on the HSEQ HUb 
	When Verify HSEQ Screen
	And Enter text field in HSEQ 
	And Click on the item
	And Verify the PDF view
	And Click on the back press icon in List of Task Screen
	Then Click on the back icon in HSEQ screen