CREATE FUNCTION getNthHighestSalary(@N INT) 
RETURNS INT
AS
BEGIN
    DECLARE @result INT;

    ;WITH SalaryRank AS (
        SELECT Salary,
               DENSE_RANK() OVER (ORDER BY Salary DESC) AS rnk
        FROM Employee
    )
    SELECT @result = Salary
    FROM SalaryRank
    WHERE rnk = @N;

    RETURN @result;
END