INSERT INTO Groups VALUES('FSDM_2911_ru');

INSERT INTO Groups VALUES('FSDM_2915_az');

SELECT * FROM Groups;

SELECT * FROM Student;

INSERT INTO Student VALUES('Aftandil','Mammadov',4);

DELETE FROM Groups
WHERE Id = 2;

/*
	NOT NULL
	DEFAULT
	CHECK
	UNIQUE
	PRIMARY KEY
	FOREIGHN KEY
*/

SELECT * FROM Student;

INSERT INTO Student VALUES('Dima','Nuriyev',2);

SELECT Student.Name + ' ' + Surname AS FullName, Groups.Name
FROM Student, Groups
WHERE Student.GroupId = Groups.Id;

SELECT Student.Name + ' ' + Surname AS FullName, Groups.Name
FROM Student, Groups;

SELECT S.Name + ' ' + Surname AS FullName, G.Name
FROM Student AS S, Groups AS G
WHERE S.GroupId = G.Id;

INSERT INTO StudentsInformative 
VALUES('Jessica','Brown','1997-07-17',1100,'jb@ne.ru',3);

SELECT * FROM StudentsInformative;

/*
	 COUNT()
	 AVG()
	 SUM()
	 MIN()
	 MAX()
*/

SELECT COUNT(*) AS [Number of records]
FROM StudentsInformative;

SELECT COUNT(Grants) AS [Number of students who has grants]
FROM StudentsInformative;


SELECT COUNT(DISTINCT Grants) AS [Number unique grants]
FROM StudentsInformative;

SELECT AVG(Grants) AS [Avarage grants]
FROM StudentsInformative;

SELECT AVG(DATEDIFF(dd,BirthDate,GETDATE())/365.25) AS [Avarage age]
FROM StudentsInformative;

SELECT SUM(Grants) AS [Sum grants]
FROM StudentsInformative;


SELECT MIN(BirthDate) AS [Minimum Birthdate]
FROM StudentsInformative;


SELECT MAX(LastName) AS [Minimum Birthdate]
FROM StudentsInformative;

SELECT COUNT(*) AS [Number of students name starts with J]
FROM StudentsInformative
WHERE FirstName LIKE 'J%';