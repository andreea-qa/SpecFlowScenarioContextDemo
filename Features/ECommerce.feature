﻿Feature: ECommerce

As a user, I want to navigate between the product categories
So I can find the desired product in the list

Background:
	Given I navigate to the LambdaTest ecommerce playground page

Scenario Outline: Navigate to categories
	Given I expand the Shop by Category menu
	When I select the <category> category
	Then the correct page is loaded
Examples:
	| category   |
	| Components |
	| Cameras    |
	| Software   |