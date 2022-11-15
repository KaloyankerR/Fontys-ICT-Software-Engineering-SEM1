exec MyAssignments
exec CheckAssignments
exec SneakPeek 112, 00

-- First assignment
CREATE OR ALTER VIEW v_s4740262_asgmt_110_00 
AS 
select last_name, job_id, hire_date
from employees e
where (e.last_name = 'Matos' OR e.last_name = 'Taylor')
and e.job_id like '%CLERK'
ORDER BY e.hire_date asc
OFFSET 0 ROWS;

-- Second assignment
CREATE OR ALTER VIEW v_s4740262_asgmt_111_00 
AS  
select e.first_name, e.last_name, e.hire_date
from employees e
where e.first_name like 'M%' and e.hire_date >= '01-01-2017';

-- Third task
CREATE OR ALTER VIEW v_s4740262_asgmt_112_00 
AS   
select e.last_name as "Employee", e.salary as "Monthly salary"
from employees e
where (e.salary between 5000 and 12000)
and (e.department_id = 20 or e.department_id = 50)
and (e.last_name in ('Weiss', 'Fripp', 'Kaufling', 'Vollman'))
-- where (e.salary >= 5000 and e.salary <= 12000)


