Feature: Countdown Timer
	As a user i want to verify countdown functionality of the E.ggTimer.

@smoke @functional
Scenario: Verify user is able to access E.ggTimer url and load the page
	Given The user has navigated to the E.ggTimer url
	When Is on the E.ggTimer page
	Then The user is able to view E.ggTimer homepage contents loaded

@smoke @functional
Scenario: Verify that user is able to enter 25 seconds and start the counter
	Given The user has navigated to the E.ggTimer url
	When The user enters <time> and starts the counter
	Then The countdown is strated
	Examples:
	| time       |
	| 25 Seconds |

@smoke @functional	
Scenario: Verify that countdown starts from period spefied and is decremented by one-second per second
	Given The user has navigated to the E.ggTimer url
	And enters <time> and starts the counter
	When The countdown is strated
	Then The counter to start counting down from the period specified <period1> <period2> <period3>
	And The time is decreased by one-second per second
	Examples:
	| time       | period1    | period2     | period3     |
	| 25 Seconds | /5 minutes | /10 minutes | /15 minutes |
