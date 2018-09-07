Feature: Login

  Background: :
    Given the user is on the homepage
     When the user selects login on the homepage
  
  @Smoke
  Scenario: Successful Login
    Given the user is on the login page
     When the user enters the login details <email>, <password>
     Then the user can see the dashboard
