--create database ADO_by_example
USE ADO_by_example

CREATE  TABLE Employees(
	EmpNO INT PRIMARY KEY,
	Ename VARCHAR(50),
	Salary money,
	Hiredate DATETIME
)


CREATE TABLE CompanyRevenue(
	CompanyName VARCHAR(50),
	revenue MONEY
)
--drop table CompanyRevenue

SELECT  * FROM Employees;
SELECT * FROM CompanyRevenue;
