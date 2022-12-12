-- 7
--CREATE OR ALTER VIEW v_s4740262_asgmt_10_00 AS 
--select c.CustName, cr.Brand, cr.Model, count(*) as [NrService]
--from Customer c
--join Car cr on cr.CarCustNr = c.CustNr
--join ServiceOrders so on so.CarID = cr.CarID
--group by c.CustName, cr.Brand, cr.Model
--having count(*) >

-- 10
--CREATE OR ALTER VIEW v_s4740262_asgmt_7_00
--AS
--select cr.BuildYear, cr.Brand, count(cr.Brand)  as [TOTALperYearAndBrand]
--from Car cr
--group by cr.BuildYear, cr.Brand
--having count(cr.Brand) > 1

-- 11
--CREATE OR ALTER VIEW v_s4740262_asgmt_11_00 AS
--select sl.City, m.MechLevel, count(*) as [Cnt]
--from Mechanic m
--join ShopLocation sl on m.ShopID = sl.ShopID
--group by sl.City, m.MechLevel

exec MyAssignments
exec CheckAssignments
exec SneakPeek 10, 00


Give the list of order numbers for which a workstation has been used more than once. 
List the order id, workstation id and the number of times the workstation was used. 
Limit the list to order numbers up to 200020 (not included)

CREATE OR ALTER VIEW v_s4740262_asgmt_6_00 AS <your query>;  

exec SneakPeek 6, 0

select *
from serviceOrder


select *
from ServiceOrders so
join SubOrder sbo on so.OrderID=sbo.OrderID
join Workstation w on w.ShopID=sbo.WorkstationID

select *
from ser
