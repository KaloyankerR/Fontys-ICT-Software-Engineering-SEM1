-- 1
select *
from DEPARTMENT d
where (d.BudgetCode = 'BC-500-10')
or (d.OfficeNumber = 'BLDG02-100' or d.OfficeNumber = 'BLDg02-200')
-- ----------------------------------------------

-- 2
select e.Department, count(e.EmployeeNumber) as [EmployeesWorkingThere]
from EMPLOYEE e
group by e.Department
-- ---------------------------------------------

-- 3
select e.FirstName, e.LastName
from DEPARTMENT d
join EMPLOYEE e on e.Department = d.DepartmentName
where d.OfficeNumber like 'BLDG01%'
-- ----------------------------------------------

-- 4
select p.ProjectID, p.MaxHours, sum(a.HoursWorked) as [WorkedHoursInTotal]
from ASSIGNMENT a
join PROJECT p on p.ProjectID = a.ProjectID
group by p.ProjectID, p.MaxHours
having sum(a.HoursWorked) > p.MaxHours


--select *
--from PROJECT p
----join ASSIGNMENT a on a.ProjectID = p.ProjectID
---- group by p.Name
--where p.MaxHours > (
--	select sum(a.HoursWorked)
--	from ASSIGNMENT a
--)

--select *
--from PROJECT p
--where p.ProjectID in (
--	select a.ProjectID, sum(a.HoursWorked)
--	from ASSIGNMENT a
--	group by a.ProjectID
--	having p.MaxHours < sum(a.HoursWorked)
--)

select *
from PROJECT p
join ASSIGNMENT a on p.ProjectID = a.ProjectID

--having sum(a.HoursWorked) > (
--	select MaxHours
--	from PROJECT
--)


