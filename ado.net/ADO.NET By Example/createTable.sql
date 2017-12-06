--create database ADO_by_example
USE ADO_by_example

CREATE  TABLE Employees(
	EmpNO INT PRIMARY KEY,
	Ename VARCHAR(50),
	Salary money,
	Hiredate DATETIME
)

SELECT  * FROM Employees;

