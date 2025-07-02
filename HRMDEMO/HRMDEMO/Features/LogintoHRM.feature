Feature: LogintoHRM

A short summary of the feature

@TAG1
Scenario: Verify The Login Functionality Of HRM With Valid and Invalid Credentilas
	Given Iam on Hrm LoginPage
	When I enter Username and Password
	| UserName | Password   |
	| Admin    | admin123   |
	| Invalid  | Invalid123 |
	Then I Validate the Dashboard and Errormsg
