--First task
--select count(*) as [NumberOfMarketingDepProjects]
--from project p
--join DEPARTMENT d 
--	on d.DepartmentName = p.Department
--where d.DepartmentName = 'Marketing'

--Second task
--select sum(p.MaxHours) as [TotalMaxHoursForMarketingDepProjects]
--from project p
--join DEPARTMENT d 
--	on d.DepartmentName = p.Department
--where d.DepartmentName = 'Marketing'

--Third task
--select avg(p.MaxHours) as [AverageMaxHoursOfMarketingDepProject]
--from project p
--join DEPARTMENT d 
--	on d.DepartmentName = p.Department
--where d.DepartmentName = 'Marketing'
-- Attention

--Fourth task
--select d.DepartmentName, COUNT(*)
--from DEPARTMENT d
--join PROJECT p 
--	on p.Department = d.DepartmentName
--group by d.DepartmentName

--Fifth one
--select p.ProjectID, min(a.HoursWorked) as [MinimumHoursWorked], max(a.HoursWorked) as [MaximumHoursWoked]
--from PROJECT p
--join ASSIGNMENT a
--	on a.ProjectID = p.ProjectID
--group by p.ProjectID
