CREATE DATABASE EmployeesDB
GO
USE EmployeesDB 
GO
CREATE TABLE Department
(
	departmentId INT PRIMARY KEY IDENTITY( 1,1 ),
	departmentName VARCHAR(50),
)

CREATE TABLE Employee
(
	employeeId INT PRIMARY KEY IDENTITY( 1,1 ),
	employeeName VARCHAR(80),
	departmentId INT REFERENCES Department( departmentId ),
	salary DECIMAL( 18,2 ),
	contractDate DATETIME
)

INSERT INTO Department ( departmentName ) VALUES 
( 'Administracion' ),
( 'Marketing' ),
( 'Ventas' ),
( 'Comercio' );

INSERT INTO Employee( employeeName, departmentId, salary, contractDate  )
VALUES ( 'Bryan Ariel Sanchez Anariba', 1, 1500.99, GETDATE());


-- SP
CREATE OR ALTER PROCEDURE SP_GETDEPARTMENTS
AS
BEGIN
	SELECT departmentId, departmentName FROM Department;
END;

CREATE OR ALTER PROCEDURE SP_GETEMPLOYEES
AS
BEGIN
	SELECT 
		Employee.employeeId, 
		Employee.employeeName,
		Employee.departmentId,
		Department.departmentName,
		Employee.salary, 
		CONVERT( VARCHAR, Employee.contractDate, 9 ) AS createdAt
		FROM Employee INNER JOIN Department 
		ON ( Employee.departmentId = Department.departmentId );
END;

CREATE OR ALTER PROCEDURE SP_SAVEEMPLOYEE
(
	@employeeName VARCHAR(80),
	@departmentId INT,
	@salary DECIMAL( 18,2 )
)
AS
BEGIN
	INSERT INTO 
	Employee( employeeName, departmentId, salary, contractDate  )
	VALUES 
	( @employeeName, @departmentId, @salary, GETDATE());
END;

CREATE OR ALTER PROCEDURE SP_EDITEMPLOYEE
(
	@employeeId INT,
	@employeeName VARCHAR(80),
	@departmentId INT,
	@salary DECIMAL( 18,2 )
)
AS
BEGIN
	UPDATE Employee 
		SET
			employeeName = @employeeName, 
			departmentId = @departmentId,
			salary = @salary,
			contractDate = GETDATE()
		WHERE 
			employeeId = @employeeId;
END;

CREATE OR ALTER PROCEDURE SP_DELETEEMPLOYEE
(
	@employeeId INT
)
AS
BEGIN
	DELETE FROM Employee WHERE employeeId = @employeeId;
END;

