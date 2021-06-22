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
		SELECT * FROM view_employees
	END
GO

GO
CREATE PROCEDURE dbo.getEmployeeColumns
AS
	BEGIN
		SET NOCOUNT ON;
		SELECT DISTINCT COLUMN_NAME
			FROM INFORMATION_SCHEMA.COLUMNS
			WHERE TABLE_NAME like 'view_employees'
	END
GO

GO
CREATE PROC dbo.filterEmployees
(
    @nif INT = NULL,
    @name VARCHAR(50) = NULL,
	@address VARCHAR(100) = NULL,
	@phone VARCHAR(15) = NULL,
	@email VARCHAR(30) = NULL,
    @employeeID INT = NULL,
	@employeeSince DATE = NULL,
	@salary FLOAT(2) = NULL,
    @jobTitle VARCHAR(20) = NULL
)
AS
BEGIN
	SET NOCOUNT ON;
    SELECT DISTINCT * 
    FROM view_employees
    WHERE   (@nif IS NULL OR person.NIF = @nif)
            AND (@name IS NULL OR [name] LIKE @name+'%')
			AND (@address IS NULL OR [address] LIKE @address+'%')
			AND (@phone IS NULL OR phone LIKE @phone+'%')
            AND (@email IS NULL OR email LIKE @email+'%')
            AND (@employeeID IS NULL OR employeeID = @employeeID)
			AND (@employeeSince IS NULL OR employeeSince >= @employeeSince)
			AND (@salary IS NULL OR salary >= @salary)
            AND (@jobTitle IS NULL OR jobTitle LIKE @jobTitle+'%')
END
GO

GO
CREATE PROC dbo.addEmployee
(
    @nif INT = NULL,
    @name VARCHAR(50) = NULL,
	@address VARCHAR(100) = NULL,
	@phone VARCHAR(15) = NULL,
	@email VARCHAR(30) = NULL,
    @employeeID INT = NULL,
	@employeeSince DATE = NULL,
	@salary FLOAT(2) = NULL,
    @jobTitle VARCHAR(20) = NULL
)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO supermarket.person(NIF, [name], [address], phone, email)
	VALUES(@nif, @name, @address, @phone, @email);
	
	INSERT INTO supermarket.employee(employeeID, employeeSince, salary, jobtitle, NIF)
	VALUES(@employeeID, @employeeSince, @salary, @jobTitle, @nif);
END
GO

GO
CREATE PROC dbo.deleteEmployee
(
    @nif INT
)
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM supermarket.employee WHERE nif=@nif
	DELETE FROM supermarket.person WHERE nif=@nif
END
GO

GO
CREATE PROCEDURE dbo.getClients
AS
	BEGIN
		SET NOCOUNT ON;
		SELECT * FROM view_clients
	END
GO

GO
CREATE PROC dbo.filterClients
(
    @clientID INT = NULL,
    @name VARCHAR(50) = NULL,
	@nif INT = NULL,
	@address VARCHAR(100) = NULL,
	@phone VARCHAR(15) = NULL,
	@email VARCHAR(30) = NULL,
	@website VARCHAR(30) = NULL,
	@clientSince DATE = NULL
)
AS
BEGIN
	SET NOCOUNT ON;
    SELECT DISTINCT * 
    FROM view_clients
    WHERE   (@nif IS NULL OR NIF = @nif)
            AND (@name IS NULL OR [name] LIKE @name+'%')
			AND (@address IS NULL OR [address] LIKE @address+'%')
			AND (@phone IS NULL OR phone LIKE @phone+'%')
            AND (@email IS NULL OR email LIKE @email+'%')
            AND (@clientID IS NULL OR clientID = @clientID)
			AND (@clientSince IS NULL OR clientSince >= @clientSince)
			AND (@website IS NULL OR website LIKE @website+'%')
END
GO

GO
CREATE PROC dbo.addClient
(
    @nif INT = NULL,
    @name VARCHAR(50) = NULL,
	@address VARCHAR(100) = NULL,
	@phone VARCHAR(15) = NULL,
	@email VARCHAR(30) = NULL,
    @clientID INT = NULL,
	@clientSince DATE = NULL,
	@website VARCHAR(30) = NULL
)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO supermarket.person(NIF, [name], [address], phone, email)
	VALUES(@nif, @name, @address, @phone, @email);
	
	INSERT INTO supermarket.client(clientID, clientSince, website, NIF)
	VALUES(@clientID, @clientSince, @website, @nif);
END
GO

GO
CREATE PROC dbo.deleteClient
(
    @nif INT
)
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM supermarket.client WHERE nif=@nif
	DELETE FROM supermarket.person WHERE nif=@nif
END
GO

GO
CREATE PROCEDURE dbo.getProduct
@barcode INT

AS
	BEGIN
		SET NOCOUNT ON;
		SELECT barcode, [name], brand, retailUnitPrice FROM supermarket.product WHERE barcode = @barcode
	END
GO

GO
CREATE PROCEDURE dbo.addToShoppingList
@orderNumber INT,
@barcode INT,
@amount INT

AS
	BEGIN
		SET NOCOUNT ON;
		INSERT INTO supermarket.shoppingList(orderNumber, productBarCode, amount) VALUES(@orderNumber, @barcode, @amount)
	END
GO


