/* Write your T-SQL query statement below */
WITH RankedSalaries AS (
    SELECT 
        ID,
        Name,
        DepartmentID,
        Salary,
        RANK() OVER (PARTITION BY DepartmentID ORDER BY Salary DESC) AS SalaryRank
    FROM Employee
)
SELECT 
(select name from department where id = r.departmentid) as Department,
Name as Employee,
salary as Salary
FROM RankedSalaries r
WHERE SalaryRank = 1 order by salary desc;