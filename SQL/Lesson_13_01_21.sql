SELECT * FROM Achievements;

INSERT INTO Achievements VALUES(9,10);

SELECT * FROM StudentsInformative;

SELECT FirstName, LastName, BirthDate, Email
FROM StudentsInformative
WHERE EXISTS   (SELECT * FROM Achievements
				WHERE Achievements.StudentId = StudentsInformative.Id);

SELECT FirstName, LastName, BirthDate, Email
FROM StudentsInformative
WHERE NOT EXISTS   (SELECT * FROM Achievements
				WHERE Achievements.StudentId = StudentsInformative.Id);

-- ANY / SOME

SELECT FirstName, LastName, BirthDate, Email
FROM StudentsInformative
WHERE Id = ANY (SELECT StudentId FROM Achievements
				WHERE Score = 8);

SELECT FirstName, LastName, BirthDate, Email
FROM StudentsInformative
WHERE Id = SOME (SELECT StudentId FROM Achievements
				WHERE Score = 8);
				
SELECT FirstName, LastName, BirthDate, Email
FROM StudentsInformative
WHERE Id IN (SELECT StudentId FROM Achievements
			 WHERE Score = 8);

SELECT COUNT(*) AS [Count]
FROM StudentsInformative
WHERE BirthDate < ANY (SELECT BirthDate
						FROM StudentsTable);

SELECT AVG(Score)
FROM Achievements
GROUP BY StudentId;

SELECT FirstName, LastName, Score
FROM StudentsInformative AS S, Achievements AS A
WHERE StudentId = S.Id AND
Score <> ALL (	SELECT AVG(Score)
				FROM Achievements
				GROUP BY StudentId);

SELECT * FROM StudentsInformative;
SELECT * FROM StudentsTable;

SELECT FirstName + ' ' + LastName
		AS FullName, BirthDate
FROM StudentsInformative
	WHERE MONTH(BirthDate) > 3
		AND MONTH(BirthDate) < 10
UNION
SELECT FirstName + ' ' + LastName
		AS FullName, BirthDate
FROM StudentsTable
	WHERE MONTH(BirthDate) > 3
		AND MONTH(BirthDate) < 10
ORDER BY BirthDate;

SELECT 'Spring' AS Season, COUNT(*)
				AS [Number of students]
FROM StudentsInformative
WHERE MONTH(BirthDate) BETWEEN 3 AND 5
UNION ALL
SELECT 'Summer', COUNT(*)
FROM StudentsInformative
WHERE MONTH(BirthDate) BETWEEN 6 AND 8
UNION ALL
SELECT 'Autumn', COUNT(*)
FROM StudentsInformative
WHERE MONTH(BirthDate) BETWEEN 9 AND 11
UNION ALL
SELECT 'Winter', COUNT(*)
FROM StudentsInformative
WHERE MONTH(BirthDate) IN (1,2,12);

SELECT * 
FROM StudentsInformative INNER JOIN Groups
ON Groups.Id = StudentsInformative.GroupId;
				


	

