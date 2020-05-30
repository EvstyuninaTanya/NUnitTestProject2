Feature: Product search
         As a user
         I want to open the application
         So I can search product

         Scenario: Search for Product

         Given I open "http://localhost:5000/" url
         And I click on button "All Products"
         And I select product "Rosemary"
         Then Product name should be "Rosemary"
