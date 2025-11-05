/* Write your T-SQL query statement below */
WITH OrderCounts AS (
  SELECT customer_number, COUNT(*) AS total_orders
  FROM Orders
  GROUP BY customer_number
)
SELECT customer_number
FROM OrderCounts
WHERE total_orders = (
  SELECT MAX(total_orders) FROM OrderCounts
);
