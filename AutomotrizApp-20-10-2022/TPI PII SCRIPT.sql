CREATE DATABASE AUTOMOTRIZPROG
GO
USE AUTOMOTRIZPROG;
GO

--CREACION TABLAS


CREATE TABLE PRODUCTOS(
id_producto			int IDENTITY(1,1),
marca				varchar(100) NOT NULL,
descripcion			varchar(100) NOT NULL,
anio				int NOT NULL,
stock				bit NOT NULL, 
-- Podemos hacerlo bool al stock y manejarlo desde programacion 
-- En caso que necesitemos saber cuantas unidades hay, lo cambiamos
precio_vta			numeric (10,2) NOT NULL,
	CONSTRAINT pk_productos PRIMARY KEY (id_producto)
);

CREATE TABLE PEDIDOS(
id_pedido			int IDENTITY(1,1),
empleado			varchar(100) NOT NULL,
cliente				varchar(100) NOT NULL,
fecha_pedido		datetime NOT NULL,
fecha_entrega		datetime NOT NULL,
	CONSTRAINT pk_pedidos PRIMARY KEY (id_pedido)
);

CREATE TABLE DETALLES(
id_detalle				int IDENTITY(1,1),
id_pedido				int NOT NULL,
id_producto				int NOT NULL,
precio_unitario			numeric(10,2) NOT NULL, 
cantidad				smallint NOT NULL,
	CONSTRAINT pk_detalles PRIMARY KEY (id_detalle),
	CONSTRAINT fk_detalles_pedidos FOREIGN KEY (id_pedido)
		REFERENCES PEDIDOS (id_pedido),
	CONSTRAINT fk_detalles_productos FOREIGN KEY (id_producto)
		REFERENCES PRODUCTOS (id_producto)
);





