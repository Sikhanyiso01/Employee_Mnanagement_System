Employee Management System

This project highlights my expertise in Object-Oriented Programming (OOP) and proficiency with C# and the .NET Framework (specifically ADO.NET) for database interaction. Below is a detailed overview of the system and its components:

Key Components
1. DataHandler
The DataHandler is a central class responsible for all data manipulation methods, including creating, reading, updating, and deleting (CRUD) operations within the database. It acts as the bridge between the database and the application.

2. Employee Class
The Employee class represents the Employee entity within the application. It serves as the data model for employees and interacts closely with the methods in DataHandler to perform various operations on the database.

Forms in the Application
1. Login Form
Purpose: Allows HR personnel to securely log in to access the application.
Features:
Basic input validation to ensure no empty fields.
Validates login credentials to confirm accuracy before granting access.
2. Home Form
Purpose: Serves as the main dashboard or landing page of the application.
Features:
Provides HR personnel with an overview of available actions they can perform, such as adding, updating, or deleting employee records.
3. Employee Management Form
Purpose: Handles core operations related to employee records.
Features:
Register new employees.
Update existing employee information.
Access options to delete employee records (redirects to a separate form for deletion).
4. Delete Form
Purpose: Specifically designed for deleting employee records.
Features:
Requires an Employee ID to initiate and confirm deletion.
5. View Employees Form
Purpose: Provides functionalities for searching and viewing employee records.
Features:
Search for an employee by Employee ID.
View a complete list of all employees in the organization.
Note
This is a foundational application showcasing fundamental principles of database interaction and user interface design. While functional, there are numerous opportunities for further enhancement, such as:

Advanced input validation and error handling.
Improved user experience and interface design.
