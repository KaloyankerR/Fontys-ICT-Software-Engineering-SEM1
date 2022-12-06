-- 10
--select *
--from Dept d
--where d.Deptno not in (
--	select e.Deptno
--	from Emp e
--	--where e.Deptno = NULL
--)

-- 11
select e.Ename as [EmployeeNumber]
from Emp e
where e.Mgr in (
	select em.Empno
	from Emp em
)

select *
from Emp


