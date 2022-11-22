-- Sixth task
--select oi.OrderNumber, sum(oi.ExtendedPrice) as [TotalOrder]
--from ORDER_ITEM oi
--group by oi.OrderNumber

-- Seventh task
--select oi.OrderNumber, avg(oi.Price) as [TotalOrder]
--from ORDER_ITEM oi
--group by oi.OrderNumber

-- Eight task
--select sum(oi.ExtendedPrice) as [Revenue]
--from SKU_DATA sd
--join ORDER_ITEM oi
--	on oi.SKU = sd.SKU
--where sd.Department = 'Water Sports'

-- Ninth task
--select ro.OrderMonth, avg(ro.OrderYear) as [OrderYear], sum(oi.ExtendedPrice) as [totalSales]
--from RETAIL_ORDER ro
--join ORDER_ITEM oi 
--	on oi.OrderNumber = ro.OrderNumber
--group by ro.OrderMonth

-- Tenth task
--select sd.Department, sum(oi.ExtendedPrice)
--from SKU_DATA sd
--join ORDER_ITEM oi
--	on sd.SKU = oi.SKU
--group by sd.Department

select sd.SKU, sd.SKU_Description, sum(oi.ExtendedPrice) as [totalSales], sum(oi.Quantity) as [quantitySaled]
from SKU_DATA sd
join ORDER_ITEM oi
	on sd.SKU = oi.SKU
where sd.SKU_Description like 'Dive Mask%'
group by sd.SKU, sd.SKU_Description

