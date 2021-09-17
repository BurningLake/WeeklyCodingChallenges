-- a.) Write an SQL query to fetch worker names with salaries >= 50000 and <= 100000
select e.FIRST_NAME, e.LAST_NAME
from Employee e 
WHERE e.SALARY BETWEEN 50000 AND 100000

-- b.) Write an SQL query to fetch the no. of workers for each department in the descending order.
select e.DEPARTMENT, COUNT(e.DEPARTMENT)
from Employee e 
group by e.DEPARTMENT 
order by COUNT(e.DEPARTMENT) DESC, e.DEPARTMENT


-- c.) Write an SQL query to fetch intersecting records of two tables.
-- Using inner join
select e.FIRST_NAME, e.LAST_NAME, t.WORKER_TITLE
from Employee e
inner join Title t
on e.WORKER_ID = t.WORKER_REF_ID 


-- d.) Write an SQL query to determine the 5th highest salary without using TOP or limit method.
-- Using subqueries
select sub.SALARY
from (select (ROW_NUMBER() over(order by e.SALARY DESC)) as rownum, e.SALARY
from Employee e) sub
where rownum = 5