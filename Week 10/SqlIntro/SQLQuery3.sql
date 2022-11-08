-- Exercise 4
SELECT ProjectID, Name, StartDate, EndDate FROM PROJECT WHERE EndDate IS NULL;

-- Exercise 5
SELECT * FROM PROJECT WHERE Name Like '%Q3%';

-- Exercise 6
SELECT FirstName FROM EMPLOYEE ORDER BY FirstName DESC;

-- Exercise 7
SELECT DepartmentName FROM DEPARTMENT WHERE OfficeNumber LIKE '%BLDG01%';

-- Exercise 8
SELECT * FROM DEPARTMENT WHERE BudgetCode = 'BC-400-10';

-- Exercise 9
SELECT EmployeeNumber, FirstName, LastName, Department 
FROM EMPLOYEE 
WHERE Department IN ('Accounting', 'Administration', 'Production ', 'Legal')
ORDER BY Department ASC, LastName ASC;

