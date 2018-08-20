Feature: Login
	Login to www.next.co.uk


Scenario: LoginToNext
	Given user is on the homepage
	And selects MyAccount to login
	When user enters username and password
	Then user signs in


Scenario: LoginToNext2
	Given user is on the homepage
	And selects MyAccount to login
	When user enters username and password
	Then user signs in
   	Then then exits


Scenario: LoginToNext3
	Given user is on the homepage
	And selects MyAccount to login
	When user enters username and password
	Then user clicks Help button


Scenario: LoginToNext4
	Given user is on the homepage
	And selects MyAccount to login
	When user enters username and password
	Then user signs in
	Then user clicks nextunlimited
	And confirm nu image exists
	And user clicks on call back
	And enters phone number