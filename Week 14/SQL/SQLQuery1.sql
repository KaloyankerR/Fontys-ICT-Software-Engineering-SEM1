-- 1
--select e.EmployeeNumber, e.FirstName, e.LastName
--from EMPLOYEE e
--where e.EmployeeNumber in (
--	select a.EmployeeNumber
--	from ASSIGNMENT a
--)

-- 2
--select *
--from PROJECT p
--where p.Department in (
--	select d.DepartmentName
--	from DEPARTMENT d
--	where d.BudgetCode like 'BC-700-10'
--)

-- 3
--select e.EmployeeNumber, e.FirstName, e.LastName
--from EMPLOYEE e
---- join ASSIGNMENT a on a.EmployeeNumber = e.EmployeeNumber
--where e.Department in (
--	select d.DepartmentName
--	from DEPARTMENT d
--	where d.OfficeNumber like 'BLDG01-300'
--)

-- 4
--select e.EmployeeNumber, e.FirstName, e.LastName
--from EMPLOYEE e
--where e.EmployeeNumber not in (
--	select a.EmployeeNumber
--	from ASSIGNMENT a
--)

-- 5
--select distinct e.EmployeeNumber, e.FirstName, e.LastName
--from EMPLOYEE e
--join ASSIGNMENT a on a.EmployeeNumber = e.EmployeeNumber
--where a.ProjectID in (
--	select p.ProjectID
--	from PROJECT p
--	group by p.ProjectID
--	having a.HoursWorked > avg(p.MaxHours)
--	and 
--)

--select e.EmployeeNumber, e.FirstName, e.LastName
--from EMPLOYEE e
--join ASSIGNMENT a on e.EmployeeNumber = a.EmployeeNumber
--where a.ProjectID in (
--	select p.ProjectID
--	from PROJECT p
--	group by p.ProjectID
--	having avg(p.MaxHours) < a.HoursWorked
--)

--select distinct e.EmployeeNumber, e.FirstName, e.LastName 
--from PROJECT p
--join ASSIGNMENT a on p.ProjectID = a.ProjectID
--join EMPLOYEE e on a.EmployeeNumber = e.EmployeeNumber
--where a.EmployeeNumber in (
--	select e.EmployeeNumber
--	from EMPLOYEE e
--	join PROJECT p on p.ProjectID = a.ProjectID
--	group by e.EmployeeNumber
--	-- having avg(p.MaxHours) < a.HoursWorked
--)
--group by e.EmployeeNumber, e.FirstName, e.LastName, a.HoursWorked
--having avg(p.MaxHours) < a.HoursWorked

--select *
--from ASSIGNMENT a
--where a.ProjectID in (
--	select p.ProjectID
--	from PROJECT p
--	where avg(p.MaxHours) 
--) and
--a.EmployeeNumber in (
--	select e.EmployeeNumber
--	from EMPLOYEE e
--	group by e.EmployeeNumber
--)

--select *
--from EMPLOYEE

--select *
--from PROJECT
-- Question

-- 6
--select w.WarehouseID, w.Manager, w.WarehouseCity
--from WAREHOUSE w
--where w.WarehouseID in (
--	select i.WarehouseID
--	from INVENTORY i
--	where i.QuantityOnHand < i.QuantityOnOrder 
-- and i.SKU_Description like '%Half-dome Tent%'
--)

-- 7
--select sd.SKU, sd.SKU_Description
--from ORDER_ITEM oi
--join SKU_DATA sd on oi.SKU = sd.SKU
--where oi.OrderNumber in (
--	select ro.OrderNumber
--	from RETAIL_ORDER ro
--	where ro.StoreNumber like '10'
--)

-- 8
--select i.SKU, i.WarehouseID, i.SKU_Description, i.QuantityOnHand, i.QuantityOnOrder
--from INVENTORY i
--group by i.SKU, i.WarehouseID, i.SKU_Description, i.QuantityOnHand, i.QuantityOnOrder
--having avg(i.QuantityOnHand) < i.QuantityOnHand

select *
from INVENTORY i
where i.SKU in (
	select iNew.SKU
	from INVENTORY iNew
	group by iNew.SKU
	having avg(iNew.QuantityOnHand) < i.QuantityOnHand
)
order by i.SKU