USE [WPC]
GO



drop table if exists ASSIGNMENT
go
drop table if exists PROJECT
go
drop table if exists EMPLOYEE
go
drop table if exists DEPARTMENT
go
create table DEPARTMENT (
    DepartmentName nvarchar(35) primary key not null,
    BudgetCode nvarchar(30) not null,
    OfficeNumber nvarchar(15) not null,
    Phone nvarchar(35) not null
)
go




create table EMPLOYEE (
    EmployeeNumber int primary key not null,
    FirstName nvarchar(25) not null,
    LastName nvarchar(25) not null,
    Department nvarchar(35) not null foreign key references DEPARTMENT (DepartmentName),
    Phone nvarchar(12) null,
    Email nvarchar(100) not null,    
)
go



create table PROJECT (
    ProjectID int primary key not null,
    Name nvarchar(50) not null,
    Department nvarchar(35) not null foreign key references DEPARTMENT (DepartmentName),
    MaxHours int not null,
    StartDate date null,
    EndDate date null
)
go



create table ASSIGNMENT (
  ProjectID int not null foreign key references PROJECT (ProjectId),
  EmployeeNumber int not null foreign key references EMPLOYEE (EmployeeNumber),
  HoursWorked int null
)
go



create unique index UQ_Assignment on ASSIGNMENT (ProjectId, EmployeeNumber)
go



INSERT [dbo].[DEPARTMENT] ([DepartmentName], [BudgetCode], [OfficeNumber], [Phone]) VALUES (N'Accounting', N'Caruthers', N'BLDG01-100', N'360-285-8300')
GO
INSERT [dbo].[DEPARTMENT] ([DepartmentName], [BudgetCode], [OfficeNumber], [Phone]) VALUES (N'Administration', N'BC-100-10', N'BLDG01-300', N'360-285-8100')
GO
INSERT [dbo].[DEPARTMENT] ([DepartmentName], [BudgetCode], [OfficeNumber], [Phone]) VALUES (N'Finance', N'BC-400-10', N'BLDG01-140', N'360-285-8400')
GO
INSERT [dbo].[DEPARTMENT] ([DepartmentName], [BudgetCode], [OfficeNumber], [Phone]) VALUES (N'Human Resources', N'BC-500-10', N'BLDG01-180', N'360-285-8500')
GO
INSERT [dbo].[DEPARTMENT] ([DepartmentName], [BudgetCode], [OfficeNumber], [Phone]) VALUES (N'InfoSystems', N'BC-800-10', N'BLDG02-270', N'360-287-8800')
GO
INSERT [dbo].[DEPARTMENT] ([DepartmentName], [BudgetCode], [OfficeNumber], [Phone]) VALUES (N'Legal', N'BC-200-10', N'BLDG01-200', N'360-285-8200')
GO
INSERT [dbo].[DEPARTMENT] ([DepartmentName], [BudgetCode], [OfficeNumber], [Phone]) VALUES (N'Marketing', N'BC-700-10', N'BLDG02-200', N'360-287-8700')
GO
INSERT [dbo].[DEPARTMENT] ([DepartmentName], [BudgetCode], [OfficeNumber], [Phone]) VALUES (N'Production', N'BC-600-10', N'BLDG02-100', N'360-287-8600')
GO
INSERT [dbo].[EMPLOYEE] ([EmployeeNumber], [FirstName], [LastName], [Department], [Phone], [Email]) VALUES (1, N'Mary', N'Jacobs', N'Administration', N'360-285-8110', N'Mjacobs@WPC.com')
GO
INSERT [dbo].[EMPLOYEE] ([EmployeeNumber], [FirstName], [LastName], [Department], [Phone], [Email]) VALUES (2, N'Rosalie', N'Jackson', N'Administration', N'360-285-8120', N'Rjackson@WPC.com')
GO
INSERT [dbo].[EMPLOYEE] ([EmployeeNumber], [FirstName], [LastName], [Department], [Phone], [Email]) VALUES (3, N'Richard', N'Bandalone', N'Legal', N'360-285-8210', N'Rbandalone@WPC.com')
GO
INSERT [dbo].[EMPLOYEE] ([EmployeeNumber], [FirstName], [LastName], [Department], [Phone], [Email]) VALUES (4, N'Tom', N'Caruthers', N'Accounting', N'360-285-8310', N'Tcaruthers@WPC.com')
GO
INSERT [dbo].[EMPLOYEE] ([EmployeeNumber], [FirstName], [LastName], [Department], [Phone], [Email]) VALUES (5, N'Heather', N'Jones', N'Accounting', N'360-285-8320', N'Hjones@WPC.com')
GO
INSERT [dbo].[EMPLOYEE] ([EmployeeNumber], [FirstName], [LastName], [Department], [Phone], [Email]) VALUES (6, N'Mary', N'Abernathy', N'Finance', N'360-285-8410', N'Mabernathy@WPC.com')
GO
INSERT [dbo].[EMPLOYEE] ([EmployeeNumber], [FirstName], [LastName], [Department], [Phone], [Email]) VALUES (7, N'George', N'Smith', N'Human Resources', N'360-285-8510', N'Gsmith@WPC.com')
GO
INSERT [dbo].[EMPLOYEE] ([EmployeeNumber], [FirstName], [LastName], [Department], [Phone], [Email]) VALUES (8, N'Tom', N'Jackson', N'Production', N'360-287-8610', N'Tjackson@WPC.com')
GO
INSERT [dbo].[EMPLOYEE] ([EmployeeNumber], [FirstName], [LastName], [Department], [Phone], [Email]) VALUES (9, N'George', N'Jones', N'Production', N'360-287-8620', N'Gjones@WPC.com')
GO
INSERT [dbo].[EMPLOYEE] ([EmployeeNumber], [FirstName], [LastName], [Department], [Phone], [Email]) VALUES (10, N'Ken', N'Numoto', N'Marketing', N'360-287-8710', N'Knumoto@WPC.com')
GO
INSERT [dbo].[EMPLOYEE] ([EmployeeNumber], [FirstName], [LastName], [Department], [Phone], [Email]) VALUES (11, N'James', N'Nestor', N'InfoSystems', NULL, N'Jnestor@WPC.com')
GO
INSERT [dbo].[EMPLOYEE] ([EmployeeNumber], [FirstName], [LastName], [Department], [Phone], [Email]) VALUES (12, N'Rick', N'Brown', N'InfoSystems', N'360-287-8820', N'Rbrown@WPC.com')
GO
INSERT [dbo].[PROJECT] ([ProjectID], [Name], [Department], [MaxHours], [StartDate], [EndDate]) VALUES (1000, N'2008 Q3 Product Plan', N'Marketing', 135, CAST(N'2008-05-10' AS Date), CAST(N'2008-06-15' AS Date))
GO
INSERT [dbo].[PROJECT] ([ProjectID], [Name], [Department], [MaxHours], [StartDate], [EndDate]) VALUES (1100, N'2008 Q3 Porfolio Analysis', N'Finance', 120, CAST(N'2008-07-05' AS Date), CAST(N'2008-07-25' AS Date))
GO
INSERT [dbo].[PROJECT] ([ProjectID], [Name], [Department], [MaxHours], [StartDate], [EndDate]) VALUES (1200, N'2008 Q3 Task Preparation', N'Accounting', 145, CAST(N'2008-08-10' AS Date), CAST(N'2008-10-25' AS Date))
GO
INSERT [dbo].[PROJECT] ([ProjectID], [Name], [Department], [MaxHours], [StartDate], [EndDate]) VALUES (1300, N'2008 Q4 Product Plan', N'Marketing', 150, CAST(N'2008-08-10' AS Date), CAST(N'2008-09-15' AS Date))
GO
INSERT [dbo].[PROJECT] ([ProjectID], [Name], [Department], [MaxHours], [StartDate], [EndDate]) VALUES (1400, N'2008 Q4 Portfolio Analysis', N'Finance', 140, CAST(N'2008-10-05' AS Date), NULL)
GO
INSERT [dbo].[ASSIGNMENT] ([ProjectID], [EmployeeNumber], [HoursWorked]) VALUES (1000, 1, CAST(30.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[ASSIGNMENT] ([ProjectID], [EmployeeNumber], [HoursWorked]) VALUES (1000, 8, CAST(75.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[ASSIGNMENT] ([ProjectID], [EmployeeNumber], [HoursWorked]) VALUES (1000, 10, CAST(55.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[ASSIGNMENT] ([ProjectID], [EmployeeNumber], [HoursWorked]) VALUES (1100, 1, CAST(25.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[ASSIGNMENT] ([ProjectID], [EmployeeNumber], [HoursWorked]) VALUES (1100, 4, CAST(40.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[ASSIGNMENT] ([ProjectID], [EmployeeNumber], [HoursWorked]) VALUES (1100, 6, CAST(45.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[ASSIGNMENT] ([ProjectID], [EmployeeNumber], [HoursWorked]) VALUES (1200, 2, CAST(20.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[ASSIGNMENT] ([ProjectID], [EmployeeNumber], [HoursWorked]) VALUES (1200, 4, CAST(45.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[ASSIGNMENT] ([ProjectID], [EmployeeNumber], [HoursWorked]) VALUES (1200, 5, CAST(40.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[ASSIGNMENT] ([ProjectID], [EmployeeNumber], [HoursWorked]) VALUES (1300, 1, CAST(35.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[ASSIGNMENT] ([ProjectID], [EmployeeNumber], [HoursWorked]) VALUES (1300, 8, CAST(80.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[ASSIGNMENT] ([ProjectID], [EmployeeNumber], [HoursWorked]) VALUES (1300, 10, CAST(50.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[ASSIGNMENT] ([ProjectID], [EmployeeNumber], [HoursWorked]) VALUES (1400, 4, CAST(15.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[ASSIGNMENT] ([ProjectID], [EmployeeNumber], [HoursWorked]) VALUES (1400, 5, CAST(10.00 AS Decimal(5, 2)))
GO
INSERT [dbo].[ASSIGNMENT] ([ProjectID], [EmployeeNumber], [HoursWorked]) VALUES (1400, 6, CAST(27.50 AS Decimal(5, 2)))
GO