SELECT * FROM StudentsInformative;

SELECT * FROM Groups;

SELECT G.Name, Grants, COUNT(S.Id) AS [Number of students]
FROM Groups AS G, StudentsInformative AS S
WHERE G.Id = S.GroupId
GROUP BY G.Name, Grants
ORDER BY G.Name;

SELECT LastName, Grants 
FROM StudentsInformative
GROUP BY LastName, Grants
HAVING AVG(Grants) <= 1200
ORDER BY LastName;

SELECT G.Name, COUNT(*) AS [Number of students]
FROM Groups AS G, StudentsInformative AS S
WHERE G.Id = S.GroupId
GROUP BY G.Name
HAVING COUNT(S.Id) > 2;

SELECT FirstName, LastName
FROM StudentsInformative
GROUP BY LastName, FirstName
HAVING LastName IN ('Moore', 'Thomas', 'Doe');

SELECT MIN(LastName) AS [Minimum Last Name]
FROM StudentsInformative
HAVING AVG(Grants) > 1400;

SELECT LastName, FirstName, G.Name, Grants
FROM StudentsInformative AS S, Groups AS G
WHERE G.Id = S.GroupId
GROUP BY LastName, FirstName, G.Name, Grants
HAVING Grants = MAX(Grants);


SELECT LastName, FirstName, G.Name, Grants
FROM StudentsInformative AS S, Groups AS G
WHERE G.Id = S.GroupId 
AND Grants = (SELECT MAX(Grants) 
FROM StudentsInformative);

SELECT LastName, FirstName, Grants
FROM StudentsInformative
WHERE GroupId = (SELECT Id FROM Groups WHERE Name LIKE '%11%' )

SELECT * FROM StudentsTable;

SELECT * FROM Groups;

SELECT * FROM StudentsInformative;


SELECT LastName, FirstName
FROM StudentsInformative
GROUP BY LastName, FirstName
HAVING AVG(MONTH(BirthDate)) > (SELECT AVG(MONTH(BirthDate)) FROM StudentsTable);

SELECT Name
FROM Groups
WHERE Id IN (	SELECT GroupId
				FROM StudentsInformative
				WHERE Grants = (SELECT MAX(Grants) 
								FROM StudentsInformative));


INSERT INTO TeachersTable VALUES('Israfil','Abiyev');

SELECT * FROM TeachersTable;

SELECT * FROM TeachersGroups;

INSERT INTO TeachersGroups VALUES((SELECT Id 
									FROM TeachersTable
									WHERE Surname = 'Abiyev'
											),1);

SELECT T.Name + ' ' + T.Surname AS [Tacher Fullname], G.Name
FROM TeachersGroups AS TG, TeachersTable AS T, Groups AS G
WHERE TG.TeacherId = T.Id AND TG.GroupId = G.Id;
