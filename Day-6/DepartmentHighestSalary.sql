# Write your MySQL query statement below
SELECT dep.name AS Department, emp.name AS Employee, emp.salary AS Salary
FROM Employee emp JOIN Department dep ON emp.departmentId = dep.id
WHERE (emp.departmentID, emp.salary) IN
(SELECT e.departmentId, max(e.salary)
FROM Employee e
GROUP BY e.departmentId)