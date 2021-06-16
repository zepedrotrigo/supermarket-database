GO
CREATE PROCEDURE dbo.login 
@username INT,  
@pass VARCHAR(128),
@retval BIT=0 OUTPUT
AS
	BEGIN
		SET NOCOUNT ON;
		SET @retval=0
		IF EXISTS (SELECT TOP 1 [user] FROM supermarket.login WHERE [user] = @username)
			BEGIN
				IF EXISTS (SELECT TOP 1 [password] FROM supermarket.login WHERE [password] = @pass)
					BEGIN
						SET @retval=1
					END
			END
	END
GO

CREATE PROCEDURE dbo.getnumrows
@table VARCHAR(30),
@retval INT OUTPUT
AS
	BEGIN
		SET NOCOUNT ON;
		declare @sql varchar(max)
		set @sql='SELECT * FROM '+@table
		execute(@sql)
		SET @retval = @@ROWCOUNT
	END
GO

GO
CREATE PROCEDURE dbo.getEmployees
AS
	BEGIN
		SET NOCOUNT ON;
		SELECT person.[name], person.NIF, employee.employeeID, person.phone, person.email,
			employee.jobTitle, employee.salary, employee.employeeSince
			FROM supermarket.person JOIN supermarket.employee on person.NIF = employee.NIF;
	END
GO

GO

CREATE PROCEDURE dbo.getEmployeeColumns
AS
	BEGIN
		SET NOCOUNT ON;
		SELECT DISTINCT COLUMN_NAME
			FROM INFORMATION_SCHEMA.COLUMNS
			WHERE TABLE_NAME like 'employee' OR TABLE_NAME like 'person'
	END
GO

CREATE PROC dbo.filterEmployees
(
    @name VARCHAR(50) = NULL,
    @nif INT = NULL,
    @employeeID INT = NULL,
    @phone VARCHAR(15) = NULL,
    @email VARCHAR(30) = NULL,
    @jobTitle VARCHAR(20) = NULL,
    @salary FLOAT(2) = NULL,
    @employeeSince DATE = NULL
)
AS
BEGIN
    SELECT  * 
    FROM supermarket.person JOIN supermarket.employee on person.NIF = employee.NIF
    WHERE   (@name IS NULL OR [name] = @name)
            AND (@nif IS NULL OR person.NIF = @nif)
            AND (@employeeID IS NULL OR employeeID = @employeeID)
            AND (@phone IS NULL OR phone = @phone)
            AND (@email IS NULL OR email = @email)
            AND (@jobTitle IS NULL OR jobTitle = @jobTitle)
            AND (@salary IS NULL OR salary = @salary)
            AND (@employeeSince IS NULL OR employeeSince = @employeeSince)
END