Feature: OrangeHRM
checkingLogin

@Login
Scenario: checkingLogin
Given navigate to login page
And enter Admin as username and admin123 as password
When i click login
Then after successfull login the page should be dashboard

@invalidLogin
Scenario: Check Invalid Login
Given navigate to login page
And enter Admin as username and admin@123 as password
When i click login
Then the login page will show message invalid credentials

@navigateToBuzzPage
Scenario: Check Navigate to Buzz Page
Given navigate to login page
And enter Admin as username and admin123 as password
When i click login
Then after successfull login
When i click on Buzz
Then the page should be Buzz

@navigateToLeavePage
Scenario: Check Navigate to Leave Page
Given navigate to login page
And enter Admin as username and admin123 as password
When i click login
Then after successfull login
When i click on Leave
Then the page should be Leave

@navigateToAdminPage
Scenario: Check Navigate to Admin Page
Given navigate to login page
And enter Admin as username and admin123 as password
When i click login
Then after successfull login
When i click on Admin
Then the page should be Admin






