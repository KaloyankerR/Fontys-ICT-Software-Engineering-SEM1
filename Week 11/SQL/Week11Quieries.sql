-- First task
SELECT p.ProjectID, a.EmployeeNumber, e.LastName, e.FirstName, e.Phone
FROM PROJECT p
JOIN ASSIGNMENT a ON p.ProjectID = a.ProjectID
JOIN EMPLOYEE e ON a.EmployeeNumber=e.EmployeeNumber
ORDER BY EmployeeNumber, ProjectID DESC

-- Second task
SELECT p.ProjectID, p.Name AS "ProjectName", e.Department AS "ProjectDepartment", 
a.EmployeeNumber, e.LastName, e.FirstName, e.Phone
FROM PROJECT p
JOIN ASSIGNMENT a ON p.ProjectID = a.ProjectID
JOIN DEPARTMENT d ON p.Department = d.DepartmentName
JOIN EMPLOYEE e ON p.Department = e.Department
ORDER BY p.ProjectID ASC

-- Third task
SELECT p.ProjectId, p.Name, e.Department, d.Phone, e.LastName, e.FirstName, e.EmployeeNumber AS "Employee Phone"
FROM PROJECT p
JOIN EMPLOYEE e ON p.Department = e.Department
JOIN DEPARTMENT d ON e.Department = d.DepartmentName
WHERE p.Department = 'Marketing'
ORDER BY p.ProjectID 
-- Default it sorts by asc - ORDER BY p.ProjectID ASC

SELECT p.ProjectID, p.Name, e.Department,
d.Phone AS "Department phone", e.LastName, e.FirstName, e.Phone AS "Employee phone"
FROM PROJECT p
JOIN DEPARTMENT d ON p.Department = d.DepartmentName
JOIN ASSIGNMENT a ON p.ProjectID = a.ProjectID
JOIN EMPLOYEE e ON a.EmployeeNumber = e.EmployeeNumber
WHERE p.Department = 'Marketing';


-- Fourth task
SELECT p.ProjectID, p.Name AS "ProjectName", p.Department as "ProjectDepartment", 
e.EmployeeNumber, e.LastName, e.FirstName, e.Phone AS "EmployeePhone" 
FROM EMPLOYEE e
JOIN ASSIGNMENT a ON e.EmployeeNumber = a.EmployeeNumber
JOIN PROJECT p ON a.ProjectID = p.ProjectID
ORDER BY p.ProjectID ASC

-- Fifth task
SELECT DISTINCT e.EmployeeNumber, e.FirstName, e.LastName
FROM EMPLOYEE e
JOIN ASSIGNMENT a ON e.EmployeeNumber = a.EmployeeNumber
ORDER BY e.EmployeeNumber

-- Sixth task
SELECT p.ProjectID, p.Name, p.StartDate, d.DepartmentName, d.BudgetCode
FROM PROJECT p
JOIN DEPARTMENT d ON p.Department = d.DepartmentName

-- Seventh task
SELECT p.ProjectID, p.Name, p.StartDate
FROM PROJECT p
JOIN DEPARTMENT d ON p.Department = d.DepartmentName
WHERE d.BudgetCode LIKE '%BC-400-10%';

-- Eighth task
SELECT e.EmployeeNumber, e.FirstName, e.LastName, p.ProjectID, p.Name, a.HoursWorked
FROM EMPLOYEE e
JOIN ASSIGNMENT a ON e.EmployeeNumber = a.EmployeeNumber 
JOIN PROJECT p ON a.ProjectID = p.ProjectID 
WHERE e.Department = 'Administration';

-- Ninth task
SELECT e.EmployeeNumber, e.FirstName, 
e.LastName, e.Email, d.DepartmentName, d.OfficeNumber
FROM DEPARTMENT d
JOIN EMPLOYEE e ON e.Department = d.DepartmentName
ORDER BY d.DepartmentName

-- Tenth task
SELECT DISTINCT e.EmployeeNumber, e.FirstName, e.LastName, e.Department
FROM EMPLOYEE e
JOIN ASSIGNMENT a ON e.EmployeeNumber = a.EmployeeNumber
WHERE a.HoursWorked > 50

-- Eleventh task
SELECT e.EmployeeNumber, e.FirstName, e.LastName, d.DepartmentName, e.Phone, e.Email
FROM EMPLOYEE e
JOIN DEPARTMENT d ON e.Department= d.DepartmentName
WHERE e.Department != 'Accounting';

-- Twelfth task
SELECT DISTINCT e.EmployeeNumber, e.FirstName, 
e.LastName, d.DepartmentName, e.Phone, e.Email
FROM EMPLOYEE e
JOIN DEPARTMENT d ON e.Department = d.DepartmentName
JOIN ASSIGNMENT a ON e.EmployeeNumber = a.EmployeeNumber
WHERE e.Department != 'Accounting' AND a.HoursWorked < 45;

-- Daily queries - Px8!S1