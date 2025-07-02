Feature: Feature1

A short summary of the feature


Scenario: Automating the Ajio online shopping App
	Given Iam on Ajio Home Page and verified the Home Page "MEN"
	When I mouse hover on the Mens Section
	And I click on the Coates and Jackets Section
	And I Select the Product 
	Then I Verified the Price of the product "799"
	When I Click on SIze Button
	And I Click on Add To Bag Button
	And I click on Bag
	Then I Verify the Shipping Page "PROCEED TO SHIPPING"
