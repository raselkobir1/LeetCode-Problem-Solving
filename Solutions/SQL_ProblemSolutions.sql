﻿--# Write a solution to report all the duplicate emails. Note that it's guaranteed that the email field is not NULL.
SELECT Email
FROM Person
GROUP BY email
HAVING COUNT(email) > 1;