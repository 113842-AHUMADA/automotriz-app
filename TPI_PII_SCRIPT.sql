USE MASTER;
GO
CREATE DATABASE AUTOMOTRIZPROG
GO
USE AUTOMOTRIZPROG;
GO

--CREACION TABLAS
CREATE TABLE CREDENCIALES(
id_credencial	int IDENTITY(1,1),
usuario			varchar(100) NOT NULL,
contrasenia		varchar(100) NOT NULL,	
privilegio      varchar(20)  NOT NULL,
	CONSTRAINT pk_credenciales PRIMARY KEY (id_credencial)
);

CREATE TABLE PRODUCTOS(
id_producto			int IDENTITY(1,1),
marca				varchar(100) NOT NULL,
modelo				int NOT NULL,
descripcion			varchar(100) NOT NULL,
color				varchar(100) NOT NULL,
anio				int NOT NULL,
stock				int NOT NULL,
stock_critico		int NOT NULL,
precio_vta			numeric (10,2) NOT NULL,
	CONSTRAINT pk_productos PRIMARY KEY (id_producto)
);

CREATE TABLE DOCUMENTOS(
id_documento		int IDENTITY(1,1),
tipo_documento		varchar(100) NOT NULL,	--HARDCODEADO
vendedor			varchar(100) NOT NULL,
cliente				varchar(100) NOT NULL,	--HARDCODEADO
fecha_documento		datetime NOT NULL,
fecha_entrega		datetime NOT NULL,
fecha_baja			datetime NULL,
	CONSTRAINT pk_pedidos PRIMARY KEY (id_documento),
);

CREATE TABLE DETALLES(
id_detalle				int IDENTITY(1,1),
id_documento			int NOT NULL,
id_producto				int NOT NULL,
precio_unitario			numeric(10,2) NOT NULL, 
cantidad				smallint NOT NULL,
	CONSTRAINT pk_detalles PRIMARY KEY (id_detalle),
	CONSTRAINT fk_detalles_documentos FOREIGN KEY (id_documento)
		REFERENCES DOCUMENTOS (id_documento),
	CONSTRAINT fk_detalles_productos FOREIGN KEY (id_producto)
		REFERENCES PRODUCTOS (id_producto)
);

	----------------------------------------------------------------
--           				STORED PROCEDURES						  --
	----------------------------------------------------------------

create procedure SP_CONSULTAR_PRODUCTOS
as
begin
	select * from productos order by marca
end;

-----------------------------------------
-----------------------------------------

create procedure SP_INSERTAR_DETALLES
	@id_documento int,
	@id_producto int,
	@precio_unitario numeric(10,2),
	@cantidad smallint
as
begin
	insert into DETALLES(id_documento,id_producto,precio_unitario,cantidad)
    values (@id_documento,@id_producto,@precio_unitario,@cantidad)
  
end;

-----------------------------------------
-----------------------------------------

create procedure SP_INSERTAR_DOCUMENTOS
	@id_documento int output,
	@tipo_documento	varchar(100),
	@vendedor varchar(100),
	@cliente varchar(100),
	@fecha_entrega datetime
as
begin
	insert into documentos (tipo_documento,vendedor,cliente,fecha_documento,fecha_entrega,fecha_baja)
	values (@tipo_documento,@vendedor,@cliente,getdate(),@fecha_entrega,null);
	set @id_documento = scope_identity()
end;

-----------------------------------------
-----------------------------------------

create procedure SP_ELIMINAR_DOCUMENTOS
	@id_documento int
as
begin
	update documentos set fecha_baja = getdate() 
	where @id_documento = id_documento
end;

-----------------------------------------
-----------------------------------------

create procedure SP_ACTUALIZAR_DOCUMENTOS
	@id_documento int,
	@vendedor int, 
	@cliente varchar(200),
	@fecha_entrega datetime
as
begin
	update DOCUMENTOS 
	set vendedor = @vendedor, cliente = @cliente, fecha_documento = getdate(), fecha_entrega = @fecha_entrega, fecha_baja = null
	where id_documento = @id_documento;
	
	delete detalles
	where id_documento = @id_documento
end;

-----------------------------------------
-----------------------------------------

create procedure SP_CONSULTAR_DOCUMENTOS
	@fecha_desde datetime,
	@fecha_hasta datetime,
	@cliente varchar(255)
as
begin
	select * 
	from documentos
	where (@fecha_desde is null OR fecha_documento >= @fecha_desde)
	and (@fecha_hasta is null OR fecha_documento <= @fecha_hasta)
	and (@cliente is null OR cliente LIKE '%' + @cliente + '%')
	and fecha_baja is null;
end;

-----------------------------------------
-----------------------------------------

create procedure SP_CONSULTAR_DOCUMENTOS_CON_DETALLES
	@id_documento int
as
begin
	select d.*,p.marca,p.modelo,p.descripcion,p.color,p.anio,p.precio_vta,doc.vendedor,doc.cliente,doc.fecha_documento,doc.fecha_entrega
	from detalles d
	join productos p on p.id_producto = d.id_producto
	join documentos doc on d.id_documento = doc.id_documento
end;

-----------------------------------------
-----------------------------------------



CREATE PROCEDURE SP_INGRESAR
	@usuario varchar(100),
	@contrasenia varchar(100),
	@privilegio varchar(20) output
AS
BEGIN
	set @privilegio = (SELECT privilegio FROM credenciales where usuario = @usuario AND contrasenia = @contrasenia)
END

	----------------------------------------------------------------
--           				INSERT REGISTROS						  --
	----------------------------------------------------------------


--CREDENCIALES
INSERT INTO CREDENCIALES (usuario,contrasenia,privilegio) VALUES ('admin','admin','administrador');
INSERT INTO CREDENCIALES (usuario,contrasenia,privilegio) VALUES ('vendedor','vendedor','empleado');

--PRODUCTOS
INSERT INTO PRODUCTOS(marca,modelo,descripcion,color,anio,stock,stock_critico,precio_vta) VALUES ('FIAT','600','3 PUERTAS','DORADO','2022',10,1,9000);

--CLIENTES
INSERT INTO CLIENTES (nom_cliente,ape_cliente,dni,email,telefono) VALUES ('Jorge','Rodriguez',39654789,'jrodriguez@gmail.com',3515578695);

