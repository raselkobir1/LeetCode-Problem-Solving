--# Write a solution to report all the duplicate emails. Note that it's guaranteed that the email field is not NULL.
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

