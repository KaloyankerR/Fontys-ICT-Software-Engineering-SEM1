exec MyAssignments
exec CheckAssignments
exec SneakPeek 6, 0

-- Give the list of order numbers for which a workstation has been used more than once. 
-- List the order id, workstation id and the number of times the workstation was used. 
-- Limit the list to order numbers up to 200020 (not included)

-- CREATE OR ALTER VIEW v_s4740262_asgmt_6_00 AS <your query>;  

select so.OrderID, 
from ServiceOrders so
join Workstation w on w.ShopID = s