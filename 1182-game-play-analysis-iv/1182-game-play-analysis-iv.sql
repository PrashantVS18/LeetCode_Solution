/* Write your T-SQL query statement below */
WITH FirstLogin AS (
    SELECT player_id, MIN(event_date) AS first_login
    FROM Activity
    GROUP BY player_id
),
NextDayLogin AS (
    SELECT f.player_id
    FROM FirstLogin f
    JOIN Activity a
        ON a.player_id = f.player_id
       AND a.event_date = DATEADD(DAY, 1, f.first_login)
)
SELECT 
    ROUND(1.0 * COUNT(DISTINCT n.player_id) / COUNT(DISTINCT f.player_id), 2) AS fraction
FROM FirstLogin f
LEFT JOIN NextDayLogin n
    ON f.player_id = n.player_id;
