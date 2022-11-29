--exec MyAssignments

-- CREATE OR ALTER VIEW v_s4740262_asgmt_118_00 AS <your query>;  
--HR wants to know per every year in which roles the most reckless employees do work 
--and figure out how it depends on the salary. 
--Show  per Year and job id the number of vacations and 
--average salary of those who started their vacation of Friday, 13th.
exec SneakPeek 118, 00

select *
from employees

select * from calendar

CREATE OR ALTER VIEW v_s4740262_asgmt_118_00 AS
select c.CalendarYear, e.job_id, count(v.employee_id) as [NrOfVacations], avg(e.salary) as [Average_Salary]
from calendar c
join vacations v on v.vac_start_date = c.CalendarDate
join employees e on e.employee_id = v.employee_id
where c.CalendarDay = 13 and c.DayOfWeekName = 'Friday'
group by c.CalendarYear, e.job_id

--List per vacation type the number of employees who had such a vacation. 
--List the vacation type and the number of employees

--exec SneakPeek 119, 00

--CREATE OR ALTER VIEW v_s4740262_asgmt_119_00 
--AS   
--select vt.vacation_type, count(employee_id) as [number of employees]
--from vacation_type vt
--join vacations v on v.vacation_type_id = vt.vacation_type_id
--group by vt.vacation_type
--;
--exec CheckAssignments


