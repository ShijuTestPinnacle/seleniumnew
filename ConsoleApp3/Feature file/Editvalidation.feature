Feature: Editvalidation
	As a Adamin of the turnup portal
	I should be able to edit Time and Material record on the table

@mytag
Scenario: Validate edit command
	Given I have logged in to the portal
	And I have navigated to the Time and Material Page
	Then I should be able to edit data on the table
