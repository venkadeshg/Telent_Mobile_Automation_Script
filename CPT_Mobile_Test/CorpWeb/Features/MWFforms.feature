Feature: MWFforms

Validate the MWF Forms

@Regression
Scenario: MWF forms
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
	Given Click on the List of Task
	When click on the Order Number
	And Click on the site visits
	And Click on the Add visits
	And Click on the POWRA
	And Click on the Incomplete
	And Click on the View button
	And Click on the Weather conditions
	And Select the Weather Conditions
	And select the Workstream
	And Click on the Yes button in job pack
	And Click on the Yes button in Access to the Job

	#Site survey
	And Click on the Yes button in Adequate site survey
	And Click on the Yes button in during site survey
	And Click on the No button in work distrub the asbsetos
	#Site Documentation
    Given Click on the yes button in Asbestos register site
	And Click on the Yes button in Asbestos Management plan
	And Click on the No button in Building fire risk Assessment
	#Cable Route
	And Click on the Yes button in cable routes identified
	And Click on the Yes button in cable Entries and route identified
	And Click on the Yes button in Safe access to cable
	And Click on the No button in Any existing cable
	And Click on the No button in will existing fire stopping
	#Documentation
	And Click on the Yes button in Task RA & Ms 
	#Works Guarding & Access
	And Click on the Yes button in Work areas guarded
	And Click on the Yes button in Clear of obstruction
	And Click on the Yes button in public access routes
	And Click on the Yes button in Safe access underground cable ducting
	#Street works
	And Click on the Yes button in Risk for general public
	#Competency
	And Click on the Yes button in Operatives on site
	And Click on the Yes button in Required level DBS security
	#plants
	And Click on the Yes button in Daily pre use checks
	And Click on the No button in Existing cable or plant impacts
	And Click on the Yes button in Adequate safety zone in places
	And Click on the Yes button in plant being used excavating
	#Building services
	And Click on the No button in Plant present
	And Click on the No button in heating pipe present
	And Click on the No button in network cable present
	And Click on the No button in Gas pipe present
	And Click on the No button in service required
	#Equipment and PPE
	And Click on the yes button in relevant PPE
	And Click on the No button in specialist PPE required
	And Click on the N/A button in Insulated tools
	And Click on the N/A button in Water suppression equipment
	And Click on the N/A button in head GDU calibration
	#working in lofts or ceiling voids welfare
	And Click on the N/A button in egress to the loft
	And Click on the N/A button in Is the loft full
	And Click on the N/A button in Sufficient lighting
	And Click on the N/A button in evidence of vermin
	And Click on the N/A button in wasp nests
	And Click on the N/A button in build up of dust work area
	And Click on the N/A button in safety man place
	#Enviroment
	And Click on the N/A button in product species bats
	And Click on the N/A button in Spill kits instrument
	And Click on the N/A button in Enviromental issues
	#other risk in comments
	And Click on the No button in Covereda dditional risk
	And Click on the Complete button
    Then Click on the back button icon

	#Site setup
	Given Click on the Site setup
	When Click on the Signs Lights and guarding
	And Click on the twenty in Speed limit
	And Click on the No button in site setup third party
	And Click on the No button in Closure diversion signs in place
	And Click on the No button in rolling road works
	And Click on the one Radio button in confirm number of approaches
	And Click on the SLG approach
	And Click on the Yes Radio button in Advace warning 
	And Click on the Camera fields
	And Click on the Capture button in inside camera 
	And Click on the close camera icon
	And Click on the NO Radio button in Closed the footpath
    And Click on the back button icon
	And Click on the Camera fields
	And Click on the Capture button in inside camera 
	And Click on the close camera icon
	And Click on the No Radio button in vachile parked on site
	And Click on the Camera fields in parkingbays and cycle ways
	And Click on the Capture button in inside camera 
	And Click on the close camera icon
	Then Click on the back button icon

	#Before starting work
	Given Click on the Before starting woek
	When Click on the Camera fields
	And Click on the Capture button in inside camera 
	And Click on the close camera icon
	And Click on the No button in installation
	Then Click on the back button icon

	#Permission to proceed
	Given Click on the Permission to proceed
	Then Click on the back button icon

	#Signature
	Given Click on the signature in Site setup
	When Click on the Sign image
	And Click on the signature
	And Click on the Done button on signature
	And Click on the back button icon
	Then Click on the back button icon

	#During work
	Given Click on the During work
	When Click on the No Radio button in Todays work completed job
	And Click on the No Radio button in Additional work been completed
	And Click on the Camera button
	And Click on the Capture the photo
	And Enter the Comments
	Then Click on the back button icon

	#TDFS
	Given Click on the TDFS
	When Click on the Supporting photos
	And Click on the Capture the photo
	And Click on the close camera icon
	And Enter the Comments
	Then Click on the back button icon

	#Finish on site
	Given Click on the Finish on site
