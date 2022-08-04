# FireLibrary
### Team Fire Project 2

### Executive Summary
FireLibrary is a web application that will simulate a full library portal. Customers will be able to create a personal password protected account. It will allow users to rent books, track their rentals, and view any associated fines and overdue charges. It will also point users to a free ebook version of the book if available.This system will be populated with data from the Internet Archive's Open Library project, and it will simulate the restrictions of a normal library with regards to number of available physical copies. FireLibrary is designed to scale easily and be adaptable so that any county or regional library system could implement it to track their own user rentals. 

### Objectives
#### Team objectives / Timeline
- Have all team members clone the repository locally, as well as create a Dev and personal branches for members by EOD 8/4.
- Create nessecary files for and host the AuthenticationDB, Library server, and asp.net Web API's on Azure by EOD 8/5.
- Create GitHub Project for managing the project by EOD 8/5.
- Populate the LibraryDB with books from the Open Library data dump with loading program by EOD 8/8.
- Set up CI/CD Pipeline skeleton using GitHub actions for AuthDB, LibraryDB, and Web API by EOD 8/9.
- Add Sonarcloud static analysis to the project and include it in the CI/CD Pipeline by EOD 8/9.
- Add Angular SPA skeleton (with DevOps pipeline) by EOD 8/9.
- Working Server by EOD 8/10.
- Angular SPA done by EOD 8/12.
- Create and publish Docker images on DockerHub by EOD 8/12.
- **MVP achieved by EOD 8/12.**
  - User account creation/login.
  - Book lookup by Title/ISBN/Genre/etc.
  - Looking up Authors, listing all their books.
  - Tracking user orders, with time tracking for lent items.
  - Stopping users with overdue items from borrowing further items.
  - Linking to ebooks when available. 
- **Stretch Goals**
  - User authentication handled with OAuth or OAuth2, eliminating the simple auth DB
 #### User Stories
 1. As a user I want to create an account.
 2. As a user I want to search for a specific book.
 3. As a user, I want to search for books by genre.
 4. As a user, I want to see the status of my order/loan.
 5. As a user, I want to view an overview of my account.
 6. User is blocked from checking out book due to late fees. 

### Technical Specifications
- Authentication DB built with SQL Server, hosted on Azure.
- Library DB built with SQL Server, hosted on Azure.
- Server built with ASP.NET, hosted on Azure. 
- Client is a single page web application, build with Angular and hosted on Azure. 
- Images hosted on DockerHub. 
- Static analysis using Sonar Cloud.
- GitHub Projects for project managment/SCRUM tracking.
- GitHub Actions to Azure for CI/CD pipeline. 

[Entity Relationship Diagram][ERD]

[ERD]: https://raw.githubusercontent.com/jdelacruz96/ProjectFire/main/LibraryERD.png


