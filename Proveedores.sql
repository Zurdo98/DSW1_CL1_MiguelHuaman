CREATE DATABASE ProveedorBD
GO

USE ProveedorBD
GO
CREATE TABLE Proveedores (
    ProveedorID INT PRIMARY KEY identity(1,1),
    Nombre VARCHAR(50),
	Email VARCHAR(30),
    Direccion VARCHAR(30),
    Telefono CHAR(9)
)
GO
SELECT * FROM Proveedores
GO
