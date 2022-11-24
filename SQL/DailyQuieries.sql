-- exec MyAssignments
-- exec CheckAssignments
-- exec SneakPeek 112, 00

-- First assignment
--CREATE OR ALTER VIEW v_s4740262_asgmt_110_00 
--AS 
--select last_name, job_id, hire_date
--from employees e
--where (e.last_name = 'Matos' OR e.last_name = 'Taylor')
--and e.job_id like '%CLERK'
--ORDER BY e.hire_date asc
--OFFSET 0 ROWS;

-- Second assignment
--CREATE OR ALTER VIEW v_s4740262_asgmt_111_00 
--AS  
--select e.first_name, e.last_name, e.hire_date
--from employees e
--where e.first_name like 'M%' and e.hire_date >= '01-01-2017';

-- Third task
--CREATE OR ALTER VIEW v_s4740262_asgmt_112_00 
--AS   
--select e.last_name as "Employee", e.salary as "Monthly salary"
--from employees e
--where (e.salary between 5000 and 12000)
--and (e.department_id = 20 or e.department_id = 50)
--and (e.last_name in ('Weiss', 'Fripp', 'Kaufling', 'Vollman'))

-- Fourth one
--CREATE OR ALTER VIEW v_s4740262_asgmt_113_00 AS 
--select d.department_name, e.last_name + ' ' + e.first_name as "Full name", l.state_province
--from employees e
--join departments d on (e.manager_id= d.manager_id)
--and (e.department_id = d.department_id)
--join locations l on d.location_id = l.location_id
--where (d.manager_id is not null)
--and (l.state_province is not null)
--order by l.state_province
--offset 0 rows;

-- Fifth one
--CREATE OR ALTER VIEW v_s4740262_asgmt_114_00 AS <your query>;  
--select * from jobs

--select j.job_title, j.max_salary
--from employees e
--join jobs j on e.job_id = j.job_id
--join departments d on e.department_id = d.department_id
--where (e.department_id = '80')
--and (d.department_name like '%Sales%')
--and (j.job_title like '%Sales Manager%')

--CREATE OR ALTER VIEW v_s4740262_asgmt_114_00 AS  
--select top 1 j.job_title, j.max_salary
--from jobs j
--join employees e on j.job_id = e.job_id
--where j.job_title like '%Sales Manager%'

-- Sixth one
--CREATE OR ALTER VIEW v_s4740262_asgmt_115_00 AS  
--select e.first_name + ' ' + e.last_name as 'Full name', j.job_title, d.department_id, d.department_name
--from employees e
--join departments d on e.department_id = d.department_id
--join locations l on d.location_id = l.location_id
--join jobs j on e.job_id = j.job_id
--where (e.department_id = 60) and (e.department_id = 100)
--and (l.location_id = 1800)
--order by d.department_name
--offset 0 rows;

-- Seventh one
-- exec MyAssignments
-- exec SneakPeek 117, 00
-- exec CheckAssignments

-- Eighth one
-- CREATE OR ALTER VIEW v_s4740262_asgmt_117_00 AS  
-- select l.city, count(*) as [number of locations]
-- from locations l
-- group by l.city

-- Ninth one
--CREATE OR ALTER VIEW v_s4740262_asgmt_116_00 AS 
--select distinct e.first_name, e.last_name, v.vac_start_date, 
--DATEDIFF(DAY, v.vac_start_date, v.vac_end_date) as [length]
--from employees e
--join vacations v
--	on e.employee_id = v.employee_id
--where v.vacation_type_id = 3

