Feature: AddProfileDetails
	In order to people seeking for some skills can look into my details
	As a Seller
	I want to add my Profile Details

@mytag
	Scenario: 1 Add my profile details
	Given Seller has signed in to the Mars Portal
	Then Seller should be able to add profile details

	Scenario: 2 Edit my profile details
	Given Seller has signed in to the Mars Portal
	Then Seller should be able to Edit profile details

	Scenario: 3 Delete my profile details
	Given Seller has signed in to the Mars Portal
	Then Seller should be able to Delete profile details
