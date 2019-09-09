Feature: TMfeature
	As an Admin for the turnup portal I should
	be able to mange Time and material record
@tm @automate
Scenario: create Time and Material record successfuly
	Given I have logged in to the turnup portal sucessfully
	And I have navigated to the Time and Material page
	Then I should be able to create and validate Time and Material record sucessfully

@tm @automate
Scenario: Edit Time and Material record sucessfully
	Given I have logged in to the turnup portal sucessfully
	And I have navigated to the Time and Material page
	Then I should be able to edit data and validate edit command

@tm @automate
Scenario: Edit Time and Material record sucessfully
	Given I have logged in to the turnup portal sucessfully
	And I have navigated to the Time and Material page
	Then I should be able to delete data and validate edit command