/* Write your T-SQL query statement below */
select b.name as Employee from Employee a  join Employee b on a.id = b.managerId where a.salary < b.salary;