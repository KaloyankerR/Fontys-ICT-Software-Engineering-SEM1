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
--select e.EmployeeNumber, e.FirstName, e.LastName
--from EMPLOYEE e
--where e.EmployeeNumber in (
--	select a.EmployeeNumber
--	from ASSIGNMENT a
--	where a.HoursWorked > (
--		select avg(HoursWorked)
--		from ASSIGNMENT
--	)
--)

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

--select *
--from INVENTORY i
--where i.SKU in (
--	select iNew.SKU
--	from INVENTORY iNew
--	group by iNew.SKU
--	having avg(iNew.QuantityOnHand) < i.QuantityOnHand
--)
--order by i.


-- 10
--select *
--from Dept d
--where d.Deptno not in (
--select e.Deptno
--from Emp e
--)


-- 11
select distinct e.Ename, e.Job, e.Sal
from Emp e
where e.Empno in (
	select Mgr
	from Emp	
)

select *
from Emp

-- 12
--select e.Ename as [Name], e.Job, e.Sal as [salary]
--from Emp e
--inner join Emp e2
--on e.Empno = e2.Mgr
--group by e.Ename, e.Job, e.Sal 
--having count(e.Empno) >= 1

