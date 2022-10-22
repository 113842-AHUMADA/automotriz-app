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


	----------------------------------------------------------------
--           				STORED PROCEDURES						  --
	----------------------------------------------------------------

create procedure SP_CONSULTAR_PRODUCTOS
as
begin
	select * from productos order by marca;
end;

-----------------------------------------
-----------------------------------------

create procedure SP_INSERTAR_DETALLES
	@id_pedido int,
	@id_producto int,
	@precio_unitario numeric(10,2),
	@cantidad smallint
as
begin
	insert into DETALLES(id_pedido,id_producto,precio_unitario,cantidad)
    values (@id_pedido,@id_producto,@precio_unitario,@cantidad);
  
end;

-----------------------------------------
-----------------------------------------

create procedure SP_INSERTAR_PEDIDOS
	@id_pedido int output,
	@empleado varchar(100),
	@cliente varchar(100),
	@fecha_entrega datetime
as
begin
	insert into pedidos (empleado,cliente,fecha_pedido,fecha_entrega)
	values (@empleado,@cliente,getdate(),@fecha_entrega);
	set @id_pedido = scope_identity()
end;

-----------------------------------------
-----------------------------------------










