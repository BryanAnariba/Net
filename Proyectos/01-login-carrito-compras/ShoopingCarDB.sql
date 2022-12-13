-- BASE DE DATOS
CREATE DATABASE ShoppingCarDB
GO
USE ShoppingCarDB
GO

-- TABLAS
-- Category: Categorias
CREATE TABLE Category
(
	categoryId INT PRIMARY KEY IDENTITY,
	categoryDescription VARCHAR(150),
	categoryStatus BIT DEFAULT 1,
	createdAt DATETIME DEFAULT GETDATE(),
	updatedAt DATETIME DEFAULT NULL
)
GO

-- Brand: Marca
CREATE TABLE Brand 
(
	brandId INT PRIMARY KEY IDENTITY,
	brandDescription VARCHAR(150),
	brandStatus BIT DEFAULT 1,
	createdAt DATETIME DEFAULT GETDATE(),
	updatedAt DATETIME DEFAULT NULL
)
GO

-- Product: Producto
CREATE TABLE Product 
(
	productId INT PRIMARY KEY IDENTITY,
	brandId INT REFERENCES Brand( brandId ),
	categoryId INT REFERENCES Category( categoryId ),
	productName VARCHAR(255),
	productDescription VARCHAR(255),
	productPrice DECIMAL( 18,2 ) DEFAULT 0,
	productStock INT,
	productImage VARCHAR( 255 ),
	productImageName VARCHAR( 255 ),
	productStatus BIT DEFAULT 1,
	createdAt DATETIME DEFAULT GETDATE(),
	updatedAt DATETIME DEFAULT NULL,
)
GO

-- Cliente: Cliente
CREATE TABLE Client
(
	clientId INT PRIMARY KEY IDENTITY,
	clientFirstName VARCHAR( 80 ),
	clientLastName VARCHAR( 80 ),
	clientEmail VARCHAR( 100 ),
	clientPassword VARCHAR( 255 ),
	clientRestablePassword BIT DEFAULT 0,
	createdAt DATETIME DEFAULT GETDATE(),
	updatedAt DATETIME DEFAULT NULL
)
GO

-- ShoppingCar: Carrito Compra
CREATE TABLE ShoppingCar
(
	shoppingCar INT PRIMARY KEY IDENTITY,
	clientId INT REFERENCES Client( clientId ),
	productId INT REFERENCES Product( productId ) ,
	quantity INT
)
GO

-- Sales: Ventas
CREATE TABLE Sales
(
	salesId INT PRIMARY KEY IDENTITY,
	clientId INT REFERENCES Client( clientId ),
	districtId VARCHAR( 10 ),
	transactionId VARCHAR( 50 ),
	productTotal INT,
	totalPrice DECIMAL( 18,2 ),
	contact VARCHAR( 100 ),
	phone VARCHAR( 30 ),
	address VARCHAR( 255 ),
	createdAt DATETIME DEFAULT GETDATE()
)
GO

-- DetailSales: Detalle de Venta
CREATE TABLE DetailSales
(
	detailSalesId INT PRIMARY KEY IDENTITY,
	salesId INT REFERENCES Sales( salesId ),
	productId INT REFERENCES Product( productId ),
	quantity INT,
	total DECIMAL( 18,2 )
)
GO

-- Users: Usuarios
CREATE TABLE Users
(
	userId INT PRIMARY KEY IDENTITY,
	userFirstName VARCHAR( 80 ),
	cuserLastName VARCHAR( 80 ),
	userEmail VARCHAR( 100 ),
	userPassword VARCHAR( 255 ),
	userRestablePassword BIT DEFAULT 0,
	userStatus BIT DEFAULT 1,
	createdAt DATETIME DEFAULT GETDATE(),
	updatedAt DATETIME DEFAULT NULL
)
GO

-- DEPARTMENT: DEPARTAMENTO DE UBICACION
CREATE TABLE Department
(
	departmenId VARCHAR( 2 ) NOT NULL,
	departmentDescription VARCHAR( 50 ) NOT NULL,
)
GO

-- Province: Provicia del departamento
CREATE TABLE Province
(
	provinceId VARCHAR( 4 ) NOT NULL,
	provinceDescription VARCHAR( 50 ) NOT NULL,
	departmenId VARCHAR( 2 ) NOT NULL,
)
GO

-- DISTRICT: distrito al cual pertenece el departamento
CREATE TABLE District 
(
	districtId VARCHAR( 10 ) NOT NULL,
	districtDescription VARCHAR( 50 ) NOT NULL,
	provinceId VARCHAR( 4 ) NOT NULL,
	departmenId VARCHAR( 2 ) NOT NULL,
)
GO