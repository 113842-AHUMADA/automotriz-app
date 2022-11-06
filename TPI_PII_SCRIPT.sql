USE [master]
GO
/****** Object:  Database [AUTOMOTRIZPROG]    Script Date: 6/11/2022 19:15:37 ******/
CREATE DATABASE [AUTOMOTRIZPROG]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AUTOMOTRIZPROG', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\AUTOMOTRIZPROG.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AUTOMOTRIZPROG_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\AUTOMOTRIZPROG_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AUTOMOTRIZPROG].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET ARITHABORT OFF 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET  ENABLE_BROKER 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET  MULTI_USER 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET QUERY_STORE = OFF
GO
USE [AUTOMOTRIZPROG]
GO
/****** Object:  Table [dbo].[CREDENCIALES]    Script Date: 6/11/2022 19:15:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CREDENCIALES](
	[id_credencial] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](100) NOT NULL,
	[contrasenia] [varchar](100) NOT NULL,
	[privilegio] [varchar](20) NOT NULL,
	[id_empleado] [int] NULL,
 CONSTRAINT [pk_credenciales] PRIMARY KEY CLUSTERED 
(
	[id_credencial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DETALLES]    Script Date: 6/11/2022 19:15:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLES](
	[id_detalle] [int] IDENTITY(1,1) NOT NULL,
	[id_documento] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[precio_unitario] [numeric](10, 2) NOT NULL,
	[cantidad] [smallint] NOT NULL,
 CONSTRAINT [pk_detalles] PRIMARY KEY CLUSTERED 
(
	[id_detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOCUMENTOS]    Script Date: 6/11/2022 19:15:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOCUMENTOS](
	[id_documento] [int] IDENTITY(1,1) NOT NULL,
	[tipo_documento] [varchar](100) NOT NULL,
	[vendedor] [varchar](100) NOT NULL,
	[cliente] [varchar](100) NOT NULL,
	[fecha_documento] [datetime] NOT NULL,
	[fecha_entrega] [datetime] NOT NULL,
	[fecha_baja] [datetime] NULL,
 CONSTRAINT [pk_pedidos] PRIMARY KEY CLUSTERED 
(
	[id_documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PERSONAL]    Script Date: 6/11/2022 19:15:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERSONAL](
	[id_empleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](25) NULL,
	[apellido] [varchar](25) NULL,
	[email] [varchar](60) NULL,
	[dni] [bigint] NULL,
	[celular] [bigint] NULL,
	[fecha_nacimiento] [date] NULL,
 CONSTRAINT [pk_personal] PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCTOS]    Script Date: 6/11/2022 19:15:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTOS](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[marca] [varchar](100) NOT NULL,
	[modelo] [int] NOT NULL,
	[descripcion] [varchar](100) NOT NULL,
	[color] [varchar](100) NOT NULL,
	[anio] [int] NOT NULL,
	[stock] [int] NOT NULL,
	[stock_critico] [int] NOT NULL,
	[precio_vta] [numeric](10, 2) NOT NULL,
 CONSTRAINT [pk_productos] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CREDENCIALES]  WITH CHECK ADD  CONSTRAINT [fk_credenciales_personal] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[PERSONAL] ([id_empleado])
GO
ALTER TABLE [dbo].[CREDENCIALES] CHECK CONSTRAINT [fk_credenciales_personal]
GO
ALTER TABLE [dbo].[DETALLES]  WITH CHECK ADD  CONSTRAINT [fk_detalles_documentos] FOREIGN KEY([id_documento])
REFERENCES [dbo].[DOCUMENTOS] ([id_documento])
GO
ALTER TABLE [dbo].[DETALLES] CHECK CONSTRAINT [fk_detalles_documentos]
GO
ALTER TABLE [dbo].[DETALLES]  WITH CHECK ADD  CONSTRAINT [fk_detalles_productos] FOREIGN KEY([id_producto])
REFERENCES [dbo].[PRODUCTOS] ([id_producto])
GO
ALTER TABLE [dbo].[DETALLES] CHECK CONSTRAINT [fk_detalles_productos]
GO
/****** Object:  StoredProcedure [dbo].[SP_ACTUALIZAR_DOCUMENTOS]    Script Date: 6/11/2022 19:15:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ACTUALIZAR_DOCUMENTOS]
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
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_DOCUMENTOS]    Script Date: 6/11/2022 19:15:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_CONSULTAR_DOCUMENTOS]
	@fecha_desde datetime,
	@fecha_hasta datetime,
	@cliente varchar(255)
as
begin
	select * 
	from documentos
	where fecha_baja is null and
	(fecha_documento between @fecha_desde and @fecha_hasta)
	and cliente LIKE '%' +@cliente+ '%'
end;
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_DOCUMENTOS_CON_DETALLES]    Script Date: 6/11/2022 19:15:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_CONSULTAR_DOCUMENTOS_CON_DETALLES]
	@id_documento int
as
begin
	select d.*,p.marca,p.modelo,p.descripcion,p.color,p.anio,p.precio_vta,doc.vendedor,doc.cliente,doc.fecha_documento,doc.fecha_entrega
	from detalles d
	join productos p on p.id_producto = d.id_producto
	join documentos doc on d.id_documento = doc.id_documento
end;
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_PRODUCTOS]    Script Date: 6/11/2022 19:15:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_CONSULTAR_PRODUCTOS]
as
begin
	select * from productos order by marca
end;
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINAR_DOCUMENTOS]    Script Date: 6/11/2022 19:15:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ELIMINAR_DOCUMENTOS]
	@id_documento int
as
begin
	update documentos set fecha_baja = getdate() 
	where @id_documento = id_documento
end;
GO
/****** Object:  StoredProcedure [dbo].[SP_INGRESAR]    Script Date: 6/11/2022 19:15:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INGRESAR]
	@usuario varchar(100),
	@contrasenia varchar(100),
	@privilegio varchar(20) output,
	@nombreApellido varchar(60) output,
	@Id_Credencial int output
AS
BEGIN
	set @privilegio = (SELECT privilegio FROM credenciales where usuario = @usuario AND contrasenia = @contrasenia)

	set @nombreApellido =(SELECT CONCAT_WS(' ',nombre,apellido) As resultado  FROM personal p LEFT JOIN CREDENCIALES c on p.id_empleado = c.id_empleado
	WHERE c.usuario = @usuario AND c.contrasenia = @contrasenia) 

	set @Id_Credencial = (SELECT id_credencial FROM CREDENCIALES WHERE usuario = @usuario AND contrasenia = @contrasenia)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_DETALLES]    Script Date: 6/11/2022 19:15:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_INSERTAR_DETALLES]
	@id_documento int,
	@id_producto int,
	@precio_unitario numeric(10,2),
	@cantidad smallint
as
begin
	insert into DETALLES(id_documento,id_producto,precio_unitario,cantidad)
    values (@id_documento,@id_producto,@precio_unitario,@cantidad)
  
end;
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_DOCUMENTOS]    Script Date: 6/11/2022 19:15:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_INSERTAR_DOCUMENTOS]
	@id_documento int output,
	@id	int,
	@tipo_documento	varchar(100),
	@vendedor varchar(100),
	@cliente varchar(100),
	@fecha_documento datetime,
	@fecha_entrega datetime
as
begin
	insert into documentos (tipo_documento,vendedor,cliente,fecha_documento,fecha_entrega,fecha_baja)
	values (@tipo_documento,@vendedor,@cliente,@fecha_documento,@fecha_entrega,null);
	set @id_documento = scope_identity()
end;
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_PRODUCTO]    Script Date: 6/11/2022 19:15:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_INSERTAR_PRODUCTO]
@id	int,
@marca	varchar(100),
@modelo	varchar(100),
@descripcion	varchar(100),
@color	varchar(100),
@anio	int,
@stock	int,
@stock_critico	int, 
@precio_vta		numeric(10,2)
as
begin
insert into productos (marca, modelo, descripcion, color, anio, stock, stock_critico, precio_vta)
VALUES (@marca,@modelo,@descripcion,@color,@anio,@stock,@stock_critico,@precio_vta)
end;
GO
/****** Object:  StoredProcedure [dbo].[SP_NOMBRE_EMPLEADO]    Script Date: 6/11/2022 19:15:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_NOMBRE_EMPLEADO]
	@Id_Credencial int,
	@ApellidoNombre varchar (60) output
AS
BEGIN
	

	set @ApellidoNombre =(SELECT CONCAT_WS(' ',nombre,apellido) As resultado  FROM personal p LEFT JOIN CREDENCIALES c on p.id_empleado = c.id_empleado
	WHERE c.id_credencial = 2)

	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORTE_PRODUCTOS_AGRUPADO]    Script Date: 6/11/2022 19:15:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_REPORTE_PRODUCTOS_AGRUPADO]
as
begin
	select id_producto'Id_Producto',marca'Marca',modelo'Modelo',descripcion'Descripcion',color'Color',anio'Anio',
	stock'Stock',stock_critico'Stock_Critico',precio_vta'Precio_Vta'
	from productos
end;
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORTE_PRODUCTOS_LISTADO]    Script Date: 6/11/2022 19:15:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_REPORTE_PRODUCTOS_LISTADO]
as
begin
	select id_producto'Id_Producto',marca'Marca',modelo'Modelo',descripcion'Descripcion',color'Color',anio'Anio',
	stock'Stock',stock_critico'Stock_Critico',precio_vta'Precio_Vta'
	from productos
end;
GO
USE [master]
GO
ALTER DATABASE [AUTOMOTRIZPROG] SET  READ_WRITE 
GO
