Feature: Login
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](BankProjectLogin/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Successful User Login
	Given a user with valid user name "abc" and valid password "abc@123"
	When the Login method is called
	Then  the result should  Login Successful


	Scenario: UnSuccessful User Login
	Given a user with invalid user name "invalid_user" and valid password "invalid"
	When the Login method is called
	Then  the result should  Login Failed

	