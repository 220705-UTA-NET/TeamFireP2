Standup - 8/10/2022
Hau- Worked on SQLRepository async methods with SQL querys. Blockers: no blockers yet.
Alejandro- Worked on Controller logic. Changed book controller, returns 404 for no content. Modified GetCustomerAsync. Slight refactoring to tests to reflect new methods. Working on integrating Hau's SQLRepository, as well as quantitizing test coverage. 
Abanoub - Working on testing with Alejandro. Backend testing complete for now. 
Jonathan - Working on adding book objects, deploy API to azure for testing, give out url. Add secrets to azure. Work on CI/CD pipeline. Add angular app skeleton to the repo. 

Standup - 8/9/2022

- Abanoub - Working with Alejandro on x-unit tests, refactoring tests after removal of BookResponse object.
- Alejandro - Working with abanoub on testing, implementing routes for Getbook and Getcutomer.
- Hau - Working on creating the SqlRepository methods for LibraryRepository GetCustomer and Getbook.
- Jonathan - add book objects, deploy API to azure for testing, give out url. Add secrets to azure. Work on CI/CD pipeline. Add angular app skeleton to the repo. 



Standup - 8/8/2022

SQL database (tables, data, stored procedures)
- tables - add tables - Hau
- data - add data - Jonathan (console app)
- stored procedure - Hau?

asp.net API  (Controllers, Models, SQLRepository)
- Controllers - Alejandro
- SQL Repository methods - Hau
	+ Find one book by ISBN
	+ Get a list of books using author and title 
	+ Get books by genre
	+ Get account info for user

-Models - Jonathan
	+ Add genre to books

-Tests - Alejandro/Abanoub

Angular front-end - Jonathan/Alejandro
 -TBD
