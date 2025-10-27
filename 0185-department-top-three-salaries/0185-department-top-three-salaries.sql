/* Write your T-SQL query statement below */
With SalaryRank as (
    select departmentid,
    salary,name,
    dense_rank() over ( partition by departmentid order by salary desc) as sal
     from Employee
)
select 
(select name from department where id = departmentid) as Department,
name as Employee,
salary as Salary
 from SalaryRank where sal <= 3 order by departmentid desc