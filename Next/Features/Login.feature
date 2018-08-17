Feature: Login
	Login to www.next.co.uk

@mytag
Scenario: LoginToNext
	Given user is on the homepage
	And selects MyAccount to login
	When user enters username and password
	Then user signs in
