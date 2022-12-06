-- exec MyAssignments
-- exec CheckAssignments

--   
-- Give the number of customers per city
-- exec SneakPeek 4, 00

-- 1
CREATE OR ALTER VIEW v_s4740262_asgmt_4_00 AS
select c.CustAddressCity, count(*) as [CustomersPerCity]
from Customer c
group by c.CustAddressCity

-- 2
--CREATE OR ALTER VIEW v_s4740262_asgmt_5_00 AS
--select t.TaskID, count(sp.PartID) as [NumberOfPartsUsed]
--from Tasks t
--join ServicePart sp on t.TaskID = sp.TaskID
--group by t.TaskID
--having count(sp.PartID) > 3




