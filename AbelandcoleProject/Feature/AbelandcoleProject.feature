Feature: AbelandcoleProject
	In order to buy some Organic foodstuffs
	


@mytag
Scenario: Abelandcole Products
	Given I navigate to "https://www.abelandcole.co.uk/"
	And I click on Accept cookies
	When I enter search in to the search "Brownie Tray Organic Daylesford(570g)"
	And I click on search
	And I click on the Add button
	And I enter search item in the search "Hummus Chips Organic"
	And I click on search
	And I click on the Add button
	And I click on the plus to add two more to the basket
	And I click on the plus to Add two more to the baskets
	And I enter search items in the search "Simply salted popcorn organic"
	And I click on search
	And I click on the Add button
	And I click on plus sign twice
	And I click on plus sign again
	And I click on the - sign
	And I click on the basket 
	#Then I should have all six products in my basket
	Then I should have Brownie displayed
	Then I have Hummus Chips displayed
	Then I have Simply salted Popcorn displayed
	Then I have total price is displayed
	
