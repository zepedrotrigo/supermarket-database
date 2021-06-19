CREATE VIEW view_employees AS
SELECT employeeID, [name], person.NIF, [address], phone, email,
jobTitle, salary, employeeSince
FROM supermarket.person JOIN supermarket.employee on person.NIF = employee.NIF;

CREATE VIEW view_clients AS
SELECT clientID, [name], person.NIF, [address], phone, email,
website, clientSince
FROM supermarket.person JOIN supermarket.client on person.NIF = client.NIF;