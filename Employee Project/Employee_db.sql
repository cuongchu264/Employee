CREATE DATABASE EMPLOYEE
GO

USE EMPLOYEE
GO

CREATE TABLE Employees
(
	Id int identity(1,1) PRIMARY KEY,
	Name nvarchar(50),
	Age int,
	Sex nvarchar(50),
	DateOfBirth date,
	Hometown nvarchar(50)
)

insert into Employees(Name, Age, Sex, DateOfBirth, Hometown)
values('Chu Manh Cuong', 21, 'Male', '04-26-2001', 'Da Nang city')