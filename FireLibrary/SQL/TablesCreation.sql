CREATE SCHEMA FireLibrary;
GO



 --DROP TABLE FireLibrary.Authors
CREATE TABLE FireLibrary.Authors
(
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(64) UNIQUE NOT NULL
)
SELECT * FROM FireLibrary.Authors



DROP TABLE FireLibrary.Books
CREATE TABLE FireLibrary.Books
(
    ISBN NVARCHAR(17) PRIMARY KEY,
    AuthorId INT FOREIGN KEY REFERENCES FireLibrary.Authors(Id),
    Title NVARCHAR (255) NOT NULL,
    Pages INT NOT NULL,
    Publisher NVARCHAR (255) NOT NULL,  
    Language NVARCHAR (16) NOT NULL,
    Genre NVARCHAR (16) NOT NULL,
    Excerpt NVARCHAR(MAX) NOT NULL,
    Synopsis NVARCHAR(MAX) NOT NULL, 
    MSRP REAL NULL,
    TotalCopies INT NOT NULL,
    AvailableCopies INT NOT NULL,
)
SELECT * FRom FireLibrary.Books


--DROP TABLE FireLibrary.Users
CREATE TABLE FireLibrary.Users
(
    Id INT PRIMARY KEY IDENTITY,
    Username NVARCHAR (32) UNIQUE NOT NULL,
    Password NVARCHAR(32) NOT NULL,
)
SELECT * FRom FireLibrary.Users;




--DROP TABLE FireLibrary.Customer
CREATE TABLE FireLibrary.Customer
(
    Id INT PRIMARY KEY IDENTITY,
    Username NVARCHAR (32) UNIQUE NOT NULL,
    CanBorrow TINYINT NOT NULL DEFAULT 0,
    Fines REAL NOT NULL DEFAULT 0.0,
    BookCount INT NOT NULL DEFAULT 0
)
SELECT * FRom FireLibrary.Customer




 --DROP TABLE FireLibrary.Orders
CREATE TABLE FireLibrary.Orders
(
    Id INT PRIMARY KEY IDENTITY,
    CustomerID INT FOREIGN KEY REFERENCES FireLibrary.Customer(Id), -- PersonID int FOREIGN KEY REFERENCES Persons(PersonID)
    DateLent DATE NOT NULL,
    DateDue DATE NOT NULL,
)
SELECT * FRom FireLibrary.Orders


SELECT * FROM FireLibrary.Authors


SELECT ISBN, Title, Pages, Publisher, Language, Genre, Excerpt, Synopsis, TotalCopies, AvailableCopies, a.Name as AuthorName FROM FireLibrary.Books AS b
JOIN FireLibrary.Authors AS a
ON a.Id = b.AuthorId
WHERE Title = 'The Martian'
AND a.Name = 'Andy Weir'




SELECT Id, Username, CanBorrow, Fines, BookCount 
FROM FireLibrary.Customer
WHERE Id = 1

