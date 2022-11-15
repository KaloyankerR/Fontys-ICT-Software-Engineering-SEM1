-- Creating a database
CREATE DATABASE FontysExercising
GO

/* Gives me error whenever I try to run it from the Database folder
CREATE TABLE FontysExercising.Students (
	StudentId INT PRIMARY KEY IDENTITY (1, 1),
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	StudentEmail VARCHAR(50),
); 
*/ 

-- Creating a table 
CREATE TABLE Students (
	StudentId INT PRIMARY KEY IDENTITY (1, 1),
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	StudentEmail VARCHAR(50),
); 

-- Inserting values to the table
INSERT INTO Students (FirstName, LastName, StudentEmail)
VALUES
('Kaloyan', 'Kulov', 'kulovkaloyan@gmail.com'),
('Danko', 'Kralski', 'danko@gmail.com'),
('Tomas', 'Shelby', 'tomas@email.com'),
('Timothee', 'From the other class', ''),
('Todor', 'DDz', '');

-- Updating the table
UPDATE Students
SET Notes='Amazing', Phone='BG'
WHERE StudentEmail IS NOT NULL;

-- Add a column to an existing table
ALTER TABLE Students
ADD Phone BIT;

SELECT * FROM Students;
