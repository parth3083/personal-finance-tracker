# personal-finance-tracker
<br>
Watch Demo at
<br>
https://youtu.be/kfFmRE-9lfs?si=jIs3gRN1kfmBuvVl
<br>
<br>
The provided C# code covers several topics related to personal financial tracking. Here's a summary of the major topics covered:

Object-Oriented Programming (OOP):

The code uses OOP principles with the definition of classes like transaction, Income, expense, budgetlimit, and Financial_profile.
Inheritance is demonstrated through the relationship between the transaction class and its derived classes (Income and expense).
Abstraction:

The transaction class is declared as an abstract class, and it contains an abstract method display_transtion(), which is implemented in its derived classes.
Collections:

The code utilizes lists (List<transaction> and List<budgetlimit>) to store financial transactions and budget limits in the Financial_profile class.
User Input and Output:

The code takes user input using Console.ReadLine() to gather information about income, expenses, and budget limits.
It also uses Console.WriteLine() to display information and prompts to the user.
Exception Handling:

The code uses decimal.Parse() for converting user input to decimal, which can potentially throw exceptions if the input is not a valid decimal. However, error handling or validation for such scenarios is not explicitly implemented in the provided code.
Encapsulation:

Properties with getters and setters are used for encapsulation in the transaction class to control access to the amount and description fields.
Logic Flow:

The Main method in the Program class orchestrates the flow of the financial tracking application. It creates instances of classes, gathers user input, and displays the financial profile.
Polymorphism:

Polymorphism is demonstrated through the display_transtion() method, which is overridden in both the Income and expense classes.
Namespace:

The code uses a namespace Personal_Financial_Tracker to organize the classes.
Code Structure:

The code is organized into several classes, each responsible for specific aspects of financial tracking, enhancing code readability and maintainability.
Overall, the code provides a simple console-based application for tracking income, expenses, and budget limits, demonstrating key concepts of OOP and financial management.