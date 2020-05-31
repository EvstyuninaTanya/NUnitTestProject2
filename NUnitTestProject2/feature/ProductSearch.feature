Feature: Product search
         As a user
         I want to open the application
         So I can add product

         Scenario: Search for Product

         Given I open "http://localhost:5000/" url
         When I set login "user"
         And I set password "user"
         And I click on button "All Products"
         And I click on create new
         And I set name of product "Rosemary"
         And I set category "Beverages"
         And I set supplier "Bigfoot Breweries"
         And I set unitPrice "17"
         And I set quantityPerUnit "2 boxes"
         And I set unitsInStock "23"
         And I set unitsOnOrder "40"
         And I set reorderLevel "10"
         Then Pages Header should be "All Products"
        
