-- 1
--select p.Department, sum(p.MaxHours) as [total max project hours]
--from PROJECT p
--group by Department

-- 2
--select Department, COUNT(EmployeeNumber) as "count empl"
--from EMPLOYEE e
--group by Department
--having COUNT(EmployeeNumber) = 1

-- 3
--select EmployeeNumber, count(ProjectID) as [NumberOfProjectMoreThan20Hours]
--from ASSIGNMENT
--where HoursWorked > 20
--group by EmployeeNumber
--having count(ProjectID) >= 2

--select e.EmployeeNumber, count(a.ProjectID) as [NumberOfProjectsMoreThan20Hours]
--from EMPLOYEE e
--join ASSIGNMENT a on a.EmployeeNumber = e.EmployeeNumber
--join PROJECT p on p.ProjectID = a.ProjectID
--where p.MaxHours > 20
--group by e.EmployeeNumber
-- Question

-- 4
--select a.EmployeeNumber, count(p.ProjectID) as [totatl number of projects]
--from ASSIGNMENT a
--join PROJECT p on a.ProjectID = p.ProjectID
--group by a.EmployeeNumber
--having count(p.ProjectID) > 2

-- 5
select e.FirstName, e.LastName, count(p.ProjectID) as [totatl number of projects]
from ASSIGNMENT a
join PROJECT p on a.ProjectID = p.ProjectID
join EMPLOYEE e on a.EmployeeNumber = e.EmployeeNumber
group by e.FirstName, e.LastName
having count(p.ProjectID) > 2


select * from ASSIGNMENT
-- 6
--select concat('$', SUM(ExtendedPrice)) as [Total price], sum(Quantity) as [Total quantity]
--from ORDER_ITEM
--group by OrderNumber
--having sum(Quantity) > 2

-- 7
--select ro.OrderNumber, sum(oi.ExtendedPrice)
--from RETAIL_ORDER ro
--join ORDER_ITEM oi on ro.OrderNumber = oi.OrderNumber
--group by ro.OrderNumber
-- Questions

-- 8
--select SKU
--from INVENTORY
--group by SKU
--having avg(QuantityOnHand) > max(QuantityOnOrder)

-- 9
--select WarehouseID
--from INVENTORY
--group by WarehouseID
--having sum(QuantityOnHand) > sum(QuantityOnOrder)

-- 10
--select WarehouseID
--from INVENTORY
--where SKU_Description like '%Tent%'
--group by WarehouseID
--having sum(QuantityOnHand) > sum(QuantityOnOrder)

-- 11
--select SKU, SKU_Description, sum(QuantityOnHand) as [QOH]
--from INVENTORY	
--group by SKU, SKU_Description
--order by SKU

-- 12
--select w.WarehouseID, w.Manager, sum(i.QuantityOnHand) as [QOH]
--from INVENTORY i
--join WAREHOUSE w on i.WarehouseID = w.WarehouseID
--where i.SKU_Description like '%Tent%'
--group by w.WarehouseID, w.Manager
--having sum(i.QuantityOnHand) > 100
	