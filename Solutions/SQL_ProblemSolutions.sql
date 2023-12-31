﻿--# Write a solution to report all the duplicate emails. Note that it's guaranteed that the email field is not NULL.
SELECT Email
FROM Person
GROUP BY email
HAVING COUNT(email) > 1;

--#175 Combine two table
SELECT p.firstName, p.lastName, a.city, a.state
FROM Person p
LEFT JOIN Address a ON p.personId = a.personId;

--#181 Employees-earning-more-than-their-managers
Select e1.Name AS Employee 
From Employee e1
join Employee e2 on e1.managerId = e2.id 
Where e1.salary > e2.salary

--way 2
SELECT e1.name AS Employee
FROM Employee e1
WHERE e1.salary > (
    SELECT MAX(e2.salary)
    FROM Employee e2
    WHERE e2.id = e1.managerId
);


/* 183: customers-who-never-order */
SELECT Name as Customers 
from Customers 
where Id not in(select customerId from Orders) 

/* 1280 Stedent and Examination*/
SELECT s.student_id, s.student_name, sub.subject_name, COUNT(e.student_id) AS attended_exams
FROM Students s
CROSS JOIN Subjects sub
LEFT JOIN Examinations e ON s.student_id = e.student_id AND sub.subject_name = e.subject_name
GROUP BY s.student_id, s.student_name, sub.subject_name
ORDER BY s.student_id, sub.subject_name;

/* Write your T-SQL query statement below */

SELECT p.product_name, SUM(o.unit) AS unit
FROM Products p
INNER JOIN Orders o ON p.product_id = o.product_id
WHERE  o.order_date between '2020-02-01'and '2020-02-29'
GROUP BY p.product_id, p.product_name
HAVING SUM(o.unit) >= 100;

