SELECT * FROM StudentsTable;

SELECT [LastName], FirstName, BirthDate, Grants, Email
FROM University.dbo.StudentsTable;

SELECT FirstName +' '+LastName AS FullName, BirthDate, Grants, Email
FROM University.dbo.StudentsTable;

SELECT FirstName +' '+LastName AS FullName, BirthDate, Grants,
Grants*1.2 AS [Plus 20 Percent], Email
FROM University.dbo.StudentsTable;

SELECT FirstName +' '+LastName +' '+ CAST(Grants AS nvarchar(10)) AS [FullName and Grant], BirthDate, Email
FROM University.dbo.StudentsTable;

SELECT FirstName +' '+LastName +' '+ CONVERT(nvarchar(10), Grants) AS [FullName and Grant], BirthDate, Email
FROM University.dbo.StudentsTable;

SELECT TOP 2 FirstName +' '+LastName AS FullName, BirthDate, Grants, Email
FROM University.dbo.StudentsTable;

SELECT TOP 25 PERCENT FirstName +' '+LastName AS FullName, BirthDate, Grants, Email
FROM University.dbo.StudentsTable;

SELECT DISTINCT FirstName
FROM StudentsTable;

SELECT [LastName], FirstName, BirthDate, Grants, Email
FROM University.dbo.StudentsTable
WHERE Grants > 500;

/*
	SQL - C#
	=   - ==
	<>  - !=
	>,<,>=,<=  - >,<,>=,<= (no difference)
	!>,!< - !(<), !(>)
	AND, OR, NOT - &&, ||, !
*/

SELECT [LastName], FirstName, BirthDate, Grants, Email
FROM University.dbo.StudentsTable
WHERE LEN(FirstName) !> 5;

SELECT [LastName], FirstName, BirthDate, Grants, Email
FROM University.dbo.StudentsTable
WHERE MONTH(BirthDate) >= 3
AND MONTH(BirthDate) <= 5;

SELECT [LastName], FirstName, BirthDate, Grants, Email
FROM University.dbo.StudentsTable
WHERE YEAR(BirthDate) %2 = 0
OR DAY(BirthDate) %2 <> 0;

SELECT [LastName], FirstName, BirthDate, Grants, Email
FROM University.dbo.StudentsTable
WHERE Grants IS NULL;

SELECT [LastName], FirstName, BirthDate, Grants, Email
FROM University.dbo.StudentsTable
WHERE Grants IS NOT NULL;

SELECT [LastName], FirstName, BirthDate, Grants, Email
FROM University.dbo.StudentsTable
WHERE NOT FirstName = 'Adil';

SELECT [LastName], FirstName, BirthDate, Grants, Email
FROM University.dbo.StudentsTable
WHERE Grants IS NOT NULL
ORDER BY Grants DESC, BirthDate ASC;

SELECT [LastName], FirstName, BirthDate, Grants, Email
FROM University.dbo.StudentsTable
WHERE FirstName = 'Adil'OR FirstName = 'Nurlan' OR FirstName = 'Garib';

SELECT [LastName], FirstName, BirthDate, Grants, Email
FROM University.dbo.StudentsTable
WHERE FirstName IN('Adil', 'Nurlan', 'Garib');

SELECT [LastName], FirstName, BirthDate, Grants, Email
FROM University.dbo.StudentsTable
WHERE BirthDate >= '1995-01-01'
AND BirthDate <= '2000-12-31';

SELECT [LastName], FirstName, BirthDate, Grants, Email
FROM University.dbo.StudentsTable
WHERE BirthDate BETWEEN '1995-01-01' AND '2000-12-31';


SELECT [LastName], FirstName, BirthDate, Grants, Email
FROM University.dbo.StudentsTable
WHERE BirthDate NOT BETWEEN '1995-01-01' AND '2000-12-31';


SELECT [LastName], FirstName, BirthDate, Grants, Email
FROM University.dbo.StudentsTable
WHERE LastName NOT BETWEEN 'F' AND 'J';

/*
	% - 0 и более символов
	_ - одиночный символ
	[] - диапозон или последовательность символов
	[^] -  диапозон или последовательность символов НЕ должны присутствовать
*/

SELECT LastName, FirstName, BirthDate, Grants, Email
FROM University.dbo.StudentsTable
WHERE LastName LIKE '_a%';

SELECT LastName, FirstName, BirthDate, Grants, Email
FROM University.dbo.StudentsTable
WHERE FirstName LIKE '%l';

INSERT INTO StudentsTable (LastName, FirstName, BirthDate, Grants, Email)
VALUES ('Mahmudov','Ismayil','1989-10-1',132,'isma@mail.ru');

SELECT * FROM StudentsTable;

INSERT INTO StudentsTable
VALUES ('Mahmudov','Ismayil','1989-10-1',NULL,'isama@mail.ru');

INSERT INTO TempStudents([Name], Surname)
SELECT LastName, FirstName
FROM StudentsTable
WHERE MONTH(BirthDate) > 6;

SELECT * FROM TempStudents;

SELECT LastName, FirstName
INTO NewStudents
FROM StudentsTable
WHERE Grants IS NOT NULL;

SELECT * FROM NewStudents;

UPDATE StudentsTable
SET Grants += 500
WHERE Grants <= 1000;

SELECT * FROM StudentsTable;

DELETE FROM StudentsTable
WHERE Grants IS NULL;