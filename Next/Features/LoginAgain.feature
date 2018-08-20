Feature: LoginAgain
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
	Then clicks Help button


Scenario: LoginToNext4
	Given user is on the homepage
	And selects MyAccount to login
	When user enters username and password
	Then user signs in
	Then clicks Help button