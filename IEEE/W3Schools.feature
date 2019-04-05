Feature: W3Schools
	

@mytag
Scenario: W3Schools
Given I am at W3Schools HomePage
	And I Click Learn HTML
	And I Click On Try It YourSelf
	When I press Run
	Then Verify The Result 
