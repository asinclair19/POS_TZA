CREATE DATABASE "dbinventario"
GO
/*usar base de datos creada*/
USE "dbinventario"
GO
/****** Object:  Table [dbo].[empleados]    Script Date: 12/19/2020 18:26:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[empleados](
	[idempleado] [int] IDENTITY(1,1) NOT NULL,
	[identidad] [varchar](50) NOT NULL,
	[primer_nombre] [nvarchar](100) NOT NULL,
	[primer_apellido] [nvarchar](100) NOT NULL,
	[segundo_apellido] [nvarchar](100) NULL,
	[nacimiento] [int] NOT NULL,
	[direccion] [nvarchar](max) NULL,
	[ciudad] [nvarchar](100) NULL,
	[region] [nvarchar](100) NULL,
	[codigo_postal] [nvarchar](100) NULL,
	[pais] [nvarchar](100) NULL,
	[celular] [nvarchar](30) NOT NULL,
	[fotografia] [image] NULL,
	[nota] [nvarchar](max) NULL,
	[reporta_a] [nvarchar](100) NULL,
	[salario_base] [money] NOT NULL,
	[cargo_empleado] [nvarchar](45) NOT NULL,
	[email] [varchar](255) NULL,
	[username] [nvarchar](50) NOT NULL,
	[password_user] [nvarchar](max) NOT NULL,
	[privilegios_user] [nvarchar](max) NOT NULL,
	[activo_empleado] [int] NULL,
 CONSTRAINT [PK_empleados_idempleado] PRIMARY KEY CLUSTERED 
(
	[idempleado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'dbinventario.empleados' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'empleados'
GO
/****** Object:  Table [dbo].[configuracion]    Script Date: 12/19/2020 18:26:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[configuracion](
	[idconfig] [int] IDENTITY(1,1) NOT NULL,
	[titulo_sistema] [varchar](30) NULL,
	[nombre_razon_social] [varchar](100) NULL,
	[nombre_comercial] [varchar](50) NULL,
	[nombre_sucursal] [varchar](30) NULL,
	[direccion] [text] NULL,
	[telefono] [varchar](20) NULL,
	[correo] [varchar](50) NULL,
	[slogan] [varchar](255) NULL,
	[propietario] [varchar](30) NULL,
	[usuario_root] [varchar](15) NULL,
	[pass_root] [text] NULL,
	[default_ganancia_venta] [decimal](18, 2) NULL,
	[default_seguro_deducido] [decimal](18, 2) NULL,
	[default_isr] [decimal](18, 2) NULL,
	[default_isv] [decimal](18, 2) NULL,
	[default_porc_descuento] [decimal](18, 2) NULL,
	[rtn] [nvarchar](50) NULL,
	[cai] [nvarchar](50) NULL,
	[punto_emision] [nvarchar](10) NULL,
	[establecimiento] [nvarchar](10) NULL,
	[tipo_documento] [nvarchar](10) NULL,
	[rango_inicial] [nvarchar](50) NULL,
	[rango_final] [nvarchar](50) NULL,
	[activo] [int] NULL,
 CONSTRAINT [PK_configuracion_principal] PRIMARY KEY CLUSTERED 
(
	[idconfig] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 12/19/2020 18:26:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[idcliente] [int] IDENTITY(1,1) NOT NULL,
	[tipo_documento] [nvarchar](20) NULL,
	[num_documento] [nvarchar](20) NULL,
	[nombre_cliente] [nvarchar](45) NOT NULL,
	[apellidos_cliente] [nvarchar](50) NULL,
	[sexo] [nvarchar](50) NULL,
	[fecha_nacimiento] [date] NULL,
	[direccion] [nvarchar](max) NULL,
	[ciudad] [nvarchar](100) NULL,
	[region] [nvarchar](100) NULL,
	[codigo_postal] [nvarchar](100) NULL,
	[pais] [nvarchar](100) NULL,
	[celular] [nvarchar](30) NULL,
	[email] [nvarchar](100) NULL,
	[activo_cliente] [int] NULL,
 CONSTRAINT [PK_clientes_idcliente] PRIMARY KEY CLUSTERED 
(
	[idcliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [clientes$nombre_cliente_UNIQUE] UNIQUE NONCLUSTERED 
(
	[nombre_cliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'dbinventario.clientes' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'clientes'
GO
/****** Object:  Table [dbo].[proveedores]    Script Date: 12/19/2020 18:26:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedores](
	[idproveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre_empresa] [nvarchar](255) NOT NULL,
	[nombre_contacto] [nvarchar](100) NOT NULL,
	[direccion_proveedor] [nvarchar](max) NULL,
	[ciudad] [nvarchar](100) NULL,
	[region] [nvarchar](100) NULL,
	[codigo_postal] [nvarchar](100) NULL,
	[pais] [nvarchar](100) NULL,
	[celular] [nvarchar](30) NULL,
	[telefono] [nvarchar](30) NULL,
	[activo_proveedor] [int] NULL,
 CONSTRAINT [PK_proveedores_idproveedor] PRIMARY KEY CLUSTERED 
(
	[idproveedor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [proveedores$nombre_empresa_UNIQUE] UNIQUE NONCLUSTERED 
(
	[nombre_empresa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'dbinventario.proveedores' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'proveedores'
GO
/****** Object:  Table [dbo].[productoscategoria]    Script Date: 12/19/2020 18:26:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productoscategoria](
	[idcategoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre_categoria] [nvarchar](100) NOT NULL,
	[descripcion_categoria] [nvarchar](max) NULL,
	[imagen_categoria] [nvarchar](max) NULL,
	[activa_categoria] [int] NULL,
 CONSTRAINT [PK_productoscategoria_idcategoria] PRIMARY KEY CLUSTERED 
(
	[idcategoria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'dbinventario.productoscategoria' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'productoscategoria'
GO
/****** Object:  Table [dbo].[unidades]    Script Date: 12/19/2020 18:26:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[unidades](
	[idunidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre_unidad] [nvarchar](50) NOT NULL,
	[descripcion_unidad] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_unidades] PRIMARY KEY CLUSTERED 
(
	[idunidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ventas]    Script Date: 12/19/2020 18:26:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ventas](
	[idventa] [int] IDENTITY(1,1) NOT NULL,
	[fecha_venta] [date] NOT NULL,
	[tipo_comprobante] [varchar](50) NOT NULL,
	[num_comprobante] [varchar](50) NOT NULL,
	[num_factura] [varchar](8) NULL,
	[porc_isv] [varchar](7) NULL,
	[subtotal] [money] NULL,
	[isv] [money] NOT NULL,
	[total] [money] NULL,
	[IDcliente] [int] NOT NULL,
	[IDempleado] [int] NOT NULL,
 CONSTRAINT [PK_ventas_idventa] PRIMARY KEY CLUSTERED 
(
	[idventa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'dbinventario.ventas' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ventas'
GO
/****** Object:  StoredProcedure [dbo].[spupdate_config]    Script Date: 12/19/2020 18:26:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Adonis Sinclair
-- Create date: 09/12/2020
-- Description:	actualizar configuracion general de sistema
-- =============================================
CREATE PROCEDURE [dbo].[spupdate_config]
	@idconfig int,
	@titulo varchar(30),
	@razon_social varchar(100),
	@nombre_comercial varchar(50),
	@nombre_sucursal varchar(30),
	@direccion text,
	@telefono varchar(20),
	@correo varchar(50),
	@slogan varchar(255),
	@propietario varchar(30),
	@usuario_root varchar(15),
	@pass_root text,
	@ganancia decimal(18,2),
	@seguro decimal(18,2),
	@isr decimal(18,2),
	@isv decimal(18,2),
	@descuento decimal(18,2),
	@rtn nvarchar(50),
	@cai nvarchar(50),
	@punto_emision nvarchar(10),
	@establecimiento nvarchar(10),
	@tipo_documento nvarchar(10),
	@rango_inicial nvarchar(50),
	@rango_final nvarchar(50)
AS
BEGIN
	UPDATE configuracion
	SET
		titulo_sistema = @titulo,
		nombre_razon_social = @razon_social,
		nombre_comercial = @nombre_comercial,
		nombre_sucursal = @nombre_sucursal,
		direccion = @direccion,
		telefono = @telefono,
		correo = @correo,
		slogan = @slogan,
		propietario = @propietario,
		usuario_root = @usuario_root,
		pass_root = @pass_root,
		default_ganancia_venta = @ganancia,
		default_seguro_deducido = @seguro,
		default_isr = @isr,
		default_isv = @isv,
		default_porc_descuento = @descuento,
		rtn = @rtn,
		cai = @cai,
		punto_emision = @punto_emision,
		establecimiento = @establecimiento,
		tipo_documento = @tipo_documento,
		rango_inicial = @rango_inicial,
		rango_final = @rango_final
	WHERE idconfig = @idconfig;
END
GO
/****** Object:  Table [dbo].[productos]    Script Date: 12/19/2020 18:26:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[productos](
	[idproducto] [int] IDENTITY(1,1) NOT NULL,
	[codigo_producto] [varchar](100) NOT NULL,
	[nombre_producto] [varchar](100) NOT NULL,
	[descripcion_producto] [varchar](1024) NOT NULL,
	[busqueda_producto] [nvarchar](max) NOT NULL,
	[imagen_producto] [image] NULL,
	[activo_producto] [int] NULL,
	[IDunidad] [int] NOT NULL,
	[IDcategoria] [int] NOT NULL,
 CONSTRAINT [PK_productos_idproducto] PRIMARY KEY CLUSTERED 
(
	[idproducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [productos$codigo_producto_UNIQUE] UNIQUE NONCLUSTERED 
(
	[codigo_producto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [productos$nombre_producto_UNIQUE] UNIQUE NONCLUSTERED 
(
	[nombre_producto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'dbinventario.productos' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'productos'
GO
/****** Object:  Table [dbo].[pagos_panilla]    Script Date: 12/19/2020 18:26:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pagos_panilla](
	[idpago_planilla] [int] IDENTITY(1,1) NOT NULL,
	[fecha_pago] [date] NOT NULL,
	[concepto_de] [nvarchar](100) NOT NULL,
	[tipo_pago] [nvarchar](45) NOT NULL,
	[comp_transferencia] [nvarchar](45) NULL,
	[descripcion_pago] [nvarchar](max) NULL,
	[tipo_importe] [nvarchar](45) NOT NULL,
	[total_bruto] [money] NULL,
	[seguro_social] [money] NULL,
	[total_neto] [money] NULL,
	[impuesto_renta] [money] NULL,
	[neto_a_pagar] [money] NOT NULL,
	[estado] [varchar](10) NULL,
	[IDempleado] [int] NOT NULL,
 CONSTRAINT [PK_pagos_panilla_idpago_planilla] PRIMARY KEY CLUSTERED 
(
	[idpago_planilla] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'dbinventario.pagos_panilla' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'pagos_panilla'
GO
/****** Object:  Table [dbo].[ingresos]    Script Date: 12/19/2020 18:26:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ingresos](
	[idingreso] [int] IDENTITY(1,1) NOT NULL,
	[fecha_ingreso] [date] NOT NULL,
	[tipo_comprobante] [nvarchar](100) NULL,
	[num_comprobante] [nvarchar](100) NULL,
	[subtotal_ingreso] [money] NULL,
	[isv_ingreso] [money] NULL,
	[total_ingreso] [money] NULL,
	[estado] [varchar](7) NOT NULL,
	[IDproveedor] [int] NOT NULL,
	[IDempleado] [int] NOT NULL,
 CONSTRAINT [PK_ingresos_idingreso] PRIMARY KEY CLUSTERED 
(
	[idingreso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'dbinventario.ingresos' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ingresos'
GO
/****** Object:  Table [dbo].[accesos]    Script Date: 12/19/2020 18:26:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[accesos](
	[idacceso] [int] IDENTITY(1,1) NOT NULL,
	[fecha_acceso] [date] NULL,
	[hora_acceso] [nvarchar](100) NULL,
	[IDempleado] [int] NULL,
 CONSTRAINT [PK_accesos_usuario_idacceso_usuario] PRIMARY KEY CLUSTERED 
(
	[idacceso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'dbinventario.accesos_usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'accesos'
GO
/****** Object:  StoredProcedure [dbo].[speditar_empleado]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Editar
CREATE proc [dbo].[speditar_empleado]
@idempleado int,
@identidad varchar(50),
@primer_nombre nvarchar(100),
@primer_apellido nvarchar(100),
@nacimiento int,
@celular nvarchar(30),
@salario_base money,
@cargo_empleado nvarchar(45),
@username nvarchar(50),
@password_user nvarchar(max),
@privilegios_user nvarchar(max),
@activo_empleado int --nulo
as
update empleados
set identidad = @identidad,
	primer_nombre = @primer_nombre,
	primer_apellido = @primer_apellido,
	nacimiento = @nacimiento,
	celular = @celular,
	salario_base = @salario_base,
	cargo_empleado = @cargo_empleado,
	username = @username,
	password_user = @password_user,
	privilegios_user = @privilegios_user,
	activo_empleado = @activo_empleado
where idempleado = @idempleado
GO
/****** Object:  StoredProcedure [dbo].[speditar_cliente]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Editar
create proc [dbo].[speditar_cliente]
@idcliente int,
@nombre_cliente nvarchar(45)
as
update clientes
set nombre_cliente = @nombre_cliente
where idcliente = @idcliente
GO
/****** Object:  StoredProcedure [dbo].[speditar_categoria]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[speditar_categoria]
@idcategoria int,
@nombre_categoria nvarchar(100),
@descripcion_categoria nvarchar(max),
@imagen_categoria nvarchar(max),
@activa_categoria int
as
update productoscategoria
set nombre_categoria=@nombre_categoria,
	descripcion_categoria=@descripcion_categoria,
	imagen_categoria=@imagen_categoria,
	activa_categoria=@activa_categoria
where idcategoria=@idcategoria
GO
/****** Object:  StoredProcedure [dbo].[speliminar_empleado]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Eliminar
create proc [dbo].[speliminar_empleado]
@idempleado int
as
delete from empleados
where idempleado = @idempleado
GO
/****** Object:  StoredProcedure [dbo].[speliminar_cliente]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Eliminar
create proc [dbo].[speliminar_cliente]
@idcliente int
as
delete from clientes
where idcliente = @idcliente
GO
/****** Object:  StoredProcedure [dbo].[speliminar_categoria]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[speliminar_categoria]
@idcategoria int
as
delete from productoscategoria
where idcategoria=@idcategoria
GO
/****** Object:  StoredProcedure [dbo].[speditar_unidad]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Editar
create proc [dbo].[speditar_unidad]
@idunidad int,
@nombre_unidad nvarchar(100),
@descripcion_unidad nvarchar(max)
as
update unidades
set nombre_unidad = @nombre_unidad,
	descripcion_unidad = @descripcion_unidad
where idunidad = @idunidad
GO
/****** Object:  StoredProcedure [dbo].[speditar_proveedor]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Editar proveedor
create proc [dbo].[speditar_proveedor]
@idproveedor int,
@nombre_proveedor nvarchar(255),
@contacto_proveedor nvarchar(100),
@activo_proveedor int
as
update proveedores
set nombre_empresa = @nombre_proveedor,
	nombre_contacto = @contacto_proveedor,
	activo_proveedor = @activo_proveedor
where idproveedor = @idproveedor
GO
/****** Object:  StoredProcedure [dbo].[spdesactivar_empleado]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Desactivar
create proc [dbo].[spdesactivar_empleado]
@idempleado int
as
UPDATE empleados
SET activo_empleado = 0
WHERE idempleado = @idempleado
GO
/****** Object:  StoredProcedure [dbo].[spdesactivar_categoria]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spdesactivar_categoria]
@idcategoria int
as
update productoscategoria
set activa_categoria=0
where idcategoria=@idcategoria
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_unidad]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--procedimiento buscar
create proc [dbo].[spbuscar_unidad]
@textobuscar varchar(50)
as 
select * from unidades
where nombre_unidad like '%' + @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_proveedor]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--procedimiento buscar
create proc [dbo].[spbuscar_proveedor]
@textobuscar varchar(50)
as 
select * from proveedores
where nombre_empresa like '%' + @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[spactivar_empleado]    Script Date: 12/19/2020 18:26:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Activar
create proc [dbo].[spactivar_empleado]
@idempleado int
as
UPDATE empleados
SET activo_empleado = 1
WHERE idempleado = @idempleado
GO
/****** Object:  StoredProcedure [dbo].[spactivar_categoria]    Script Date: 12/19/2020 18:26:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Activar categoria
create proc [dbo].[spactivar_categoria]
@idcategoria int
as
update productoscategoria
set activa_categoria=1
where idcategoria=@idcategoria
GO
/****** Object:  StoredProcedure [dbo].[spactivar_proveedor]    Script Date: 12/19/2020 18:26:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Activar proveedor
create proc [dbo].[spactivar_proveedor]
@idproveedor int
as
update proveedores
set activo_proveedor=1
where idproveedor = @idproveedor
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_empleado]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--procedimiento buscar
create proc [dbo].[spbuscar_empleado]
@textobuscar varchar(50)
as 
select * from empleados
where primer_apellido like '%' + @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_cliente]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--procedimiento buscar
create proc [dbo].[spbuscar_cliente]
@textobuscar varchar(50)
as 
select * from clientes
where nombre_cliente like '%' + @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_categoria]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spbuscar_categoria]
@textobuscar varchar(50)
as 
select * from productoscategoria
where nombre_categoria like @textobuscar + '%' and activa_categoria=1
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_unidad]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spmostrar_unidad]
as
select top 200 * from unidades
order by idunidad desc
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_proveedor]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Procedimiento Mostrar
create proc [dbo].[spmostrar_proveedor]
as
select top 200 * from proveedores
order by idproveedor desc
GO
/****** Object:  StoredProcedure [dbo].[spobtener_config]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spobtener_config] 
-- =============================================
-- Author:		Adonis Sinclair
-- Create date: 07-12-2020
-- Description:	mostrar configuracion principal activa
-- =============================================
AS
BEGIN
	SELECT TOP 1 * FROM configuracion 
	WHERE configuracion.activo = 1
	ORDER BY configuracion.idconfig DESC; 
END
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_empleado]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Procedimiento Mostrar
create proc [dbo].[spmostrar_empleado]
as
select top 100 * from empleados
order by idempleado desc
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_cliente]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Procedimiento Mostrar
create proc [dbo].[spmostrar_cliente]
as
select top 100 * from clientes
order by idcliente desc
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_categoria]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spmostrar_categoria]
as
select top 200 * from productoscategoria
where activa_categoria = 1
order by idcategoria desc
GO
/****** Object:  StoredProcedure [dbo].[splogin]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[splogin]
@username nvarchar(50),
@password_user nvarchar(max)
AS
SELECT idempleado,
	primer_nombre, 
	primer_apellido,
	privilegios_user
FROM empleados
WHERE username = @username AND password_user = @password_user
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_empleado]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--procedimiento insertar
CREATE proc [dbo].[spinsertar_empleado]
@idempleado int output,
@identidad varchar(50),
@primer_nombre nvarchar(100),
@primer_apellido nvarchar(100),
@nacimiento int,
@celular nvarchar(30),
@salario_base money,
@cargo_empleado nvarchar(45),
@activo_empleado int, --nulo
@username nvarchar(50),
@password_user nvarchar(max),
@privilegios_user nvarchar(max)
as
insert into empleados(
	identidad,
	primer_nombre,
	primer_apellido,
	nacimiento,
	celular,
	salario_base,
	cargo_empleado,
	username,
	password_user,
	privilegios_user,
	activo_empleado
	)
values(
	@identidad,
	@primer_nombre,
	@primer_apellido,
	@nacimiento,
	@celular,
	@salario_base,
	@cargo_empleado,
	@username,
	@password_user,
	@privilegios_user,
	@activo_empleado
	)
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_unidad]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--procedimiento insertar
create proc [dbo].[spinsertar_unidad]
@idunidad int output,
@nombre_unidad nvarchar(50),
@descripcion_unidad nvarchar(max)
as
insert into unidades(
	nombre_unidad,
	descripcion_unidad)
values(
	@nombre_unidad,
	@descripcion_unidad)
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_proveedor]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--procedimiento insertar
create proc [dbo].[spinsertar_proveedor]
@idproveedor int output,
@nombre_proveedor nvarchar(255),
@contacto_proveedor nvarchar(100),
@activo_proveedor int
as
insert into proveedores(
	nombre_empresa,
	nombre_contacto,
	activo_proveedor)
values(
	@nombre_proveedor,
	@contacto_proveedor,
	@activo_proveedor)
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_config]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Adonis Sinclair
-- Create date: 09/12/2020
-- Description:	Guardar configuracion general de sistema
-- =============================================
CREATE PROCEDURE [dbo].[spinsertar_config]
	@titulo varchar(30),
	@razon_social varchar(100),
	@nombre_comercial varchar(50),
	@nombre_sucursal varchar(30),
	@direccion text,
	@telefono varchar(20),
	@correo varchar(50),
	@slogan varchar(255),
	@propietario varchar(30),
	@usuario_root varchar(15),
	@pass_root text,
	@ganancia decimal(18,2),
	@seguro decimal(18,2),
	@isr decimal(18,2),
	@isv decimal(18,2),
	@descuento decimal(18,2),
	@rtn nvarchar(50),
	@cai nvarchar(50),
	@punto_emision nvarchar(10),
	@establecimiento nvarchar(10),
	@tipo_documento nvarchar(10),
	@rango_inicial nvarchar(50),
	@rango_final nvarchar(50)
AS
BEGIN
	INSERT INTO configuracion(
      [titulo_sistema]
      ,[nombre_razon_social]
      ,[nombre_comercial]
      ,[nombre_sucursal]
      ,[direccion]
      ,[telefono]
      ,[correo]
      ,[slogan]
      ,[propietario]
      ,[usuario_root]
      ,[pass_root]
      ,[default_ganancia_venta]
      ,[default_seguro_deducido]
      ,[default_isr]
      ,[default_isv]
      ,[default_porc_descuento]
      ,[rtn]
      ,[cai]
      ,[punto_emision]
      ,[establecimiento]
      ,[tipo_documento]
      ,[rango_inicial]
      ,[rango_final]
	) VALUES(
		@titulo,
		@razon_social,
		@nombre_comercial,
		@nombre_sucursal,
		@direccion,
		@telefono,
		@correo,
		@slogan,
		@propietario,
		@usuario_root,
		@pass_root,
		@ganancia,
		@seguro,
		@isr,
		@isv,
		@descuento,
		@rtn,
		@cai,
		@punto_emision,
		@establecimiento,
		@tipo_documento,
		@rango_inicial,
		@rango_final
	);	
END
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_cliente]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--procedimiento insertar
create proc [dbo].[spinsertar_cliente]
@idcliente int output,
@nombre_cliente nvarchar(45)
as
insert into clientes(nombre_cliente)
values(@nombre_cliente)
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_categoria]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spinsertar_categoria]
@idcategoria int output,
@nombre_categoria nvarchar(100),
@descripcion_categoria nvarchar(max),
@imagen_categoria nvarchar(max),
@activa_categoria int
as
insert into productoscategoria(
	nombre_categoria,
	descripcion_categoria,
	imagen_categoria,
	activa_categoria)
values(
	@nombre_categoria,
	@descripcion_categoria,
	@imagen_categoria,
	@activa_categoria)
GO
/****** Object:  StoredProcedure [dbo].[spdesactivar_proveedor]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Desactivar proveedor
create proc [dbo].[spdesactivar_proveedor]
@idproveedor int
as
update proveedores
set activo_proveedor=0
where idproveedor = @idproveedor
GO
/****** Object:  StoredProcedure [dbo].[speliminar_unidad]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Eliminar
create proc [dbo].[speliminar_unidad]
@idunidad int
as
delete from unidades
where idunidad = @idunidad
GO
/****** Object:  StoredProcedure [dbo].[speliminar_proveedor]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Eliminar proveedor
create proc [dbo].[speliminar_proveedor]
@idproveedor int
as
delete from proveedores
where idproveedor = @idproveedor
GO
/****** Object:  StoredProcedure [dbo].[speliminar_producto]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Eliminar
create proc [dbo].[speliminar_producto]
@idproducto int
as
DELETE FROM productos
WHERE idproducto = @idproducto
GO
/****** Object:  StoredProcedure [dbo].[spdesactivar_producto]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--DESACTIVAR
create proc [dbo].[spdesactivar_producto]
@idproducto int
as
UPDATE productos
SET
	activo_producto = 0
WHERE idproducto = @idproducto
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_producto]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--procedimiento insertar
CREATE proc [dbo].[spinsertar_producto]
@idproducto int output,
@codigo_producto varchar(100),
@nombre_producto varchar(100),
@descripcion_producto varchar(1024),
@busqueda_producto nvarchar(max),
@imagen_producto image,
@activo_producto int,
@idunidad int,
@idcategoria int
as
insert into productos
(
	codigo_producto,
	nombre_producto,
	descripcion_producto,
	busqueda_producto,
	imagen_producto,
	activo_producto,
	IDunidad,
	IDcategoria
)
values
(
	@codigo_producto,
	@nombre_producto,
	@descripcion_producto,
	@busqueda_producto,
	@imagen_producto,
	@activo_producto,
	@idunidad,
	@idcategoria
)
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_pago_planilla]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--procedimiento insertar
CREATE proc [dbo].[spinsertar_pago_planilla]
@idpago_planilla int output,
@fecha_pago date,
@concepto_de nvarchar(100),
@tipo_pago nvarchar(45),
@comp_transferencia nvarchar(45),
@descripcion_pago nvarchar(max),
@tipo_importe nvarchar(45),
@total_bruto money,
@seguro_social money,
@total_neto money,
@impuesto_renta money,
@neto_a_pagar money,
@estado varchar(10),
@idempleado int
AS
INSERT INTO pagos_panilla(
	fecha_pago,
	concepto_de,
	tipo_pago,
	comp_transferencia,
	descripcion_pago,
	tipo_importe,
	total_bruto,
	seguro_social,
	total_neto,
	impuesto_renta,
	neto_a_pagar,
	estado,
	IDempleado
	)
values(
	@fecha_pago,
	@concepto_de,
	@tipo_pago,
	@comp_transferencia,
	@descripcion_pago,
	@tipo_importe,
	@total_bruto,
	@seguro_social,
	@total_neto,
	@impuesto_renta,
	@neto_a_pagar,
	@estado,
	@idempleado
	)
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_ingreso]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--procedimiento insertar
CREATE proc [dbo].[spinsertar_ingreso]
@idingreso int=null output,
@fecha_ingreso date,
@tipo_comprobante nvarchar(100),
@num_comprobante nvarchar(100),
@isv_ingreso money,
@total_ingreso money,
@estado varchar(7),
@idproveedor int,
@idempleado int
as
insert into ingresos(
	fecha_ingreso,
	tipo_comprobante,
	num_comprobante,
	isv_ingreso,
	total_ingreso,
	estado,
	IDproveedor,
	IDempleado)
values(
	@fecha_ingreso,
	@tipo_comprobante,
	@num_comprobante,
	@isv_ingreso,
	@total_ingreso,
	@estado,
	@idproveedor,
	@idempleado
	)
SET @idingreso = @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[speliminar_venta]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Procedimiento eliminar
CREATE PROC [dbo].[speliminar_venta]
@idventa int
AS
DELETE FROM ventas
WHERE idventa = @idventa
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_venta_fecha]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--procedimiento buscar
CREATE proc [dbo].[spbuscar_venta_fecha]
@textobuscar varchar(50),
@textobuscar2 varchar(50)
as 
SELECT
	v.idventa,
	(e.primer_apellido + ' ' + e.primer_nombre) as empleado,
	c.nombre_cliente,
	v.fecha_venta,
	v.tipo_comprobante,
	v.num_comprobante,
	v.num_factura,
	v.porc_isv,
	v.subtotal,
	v.isv,
	v.total
FROM ventas v
INNER JOIN clientes c ON v.IDcliente = c.idcliente
INNER JOIN empleados e ON v.IDempleado = e.idempleado
WHERE v.fecha_venta >= @textobuscar AND v.fecha_venta <= @textobuscar2
ORDER BY v.idventa DESC
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_venta]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--procedimiento insertar
CREATE proc [dbo].[spinsertar_venta]
@idventa int=null output,
@fecha_venta date,
@tipo_comprobante varchar(50),
@num_comprobante varchar(50),
@num_factura varchar(8),
@porc_isv varchar(7),
@subtotal money,
@isv money,
@total money,
@idcliente int,
@idempleado int
as
insert into ventas(
	fecha_venta,
	tipo_comprobante,
	num_comprobante,
	num_factura,
	porc_isv,
	subtotal,
	isv,
	total,
	IDcliente,
	IDempleado
	)
values(
	@fecha_venta,
	@tipo_comprobante,
	@num_comprobante,
	@num_factura,
	@porc_isv,
	@subtotal,
	@isv,
	@total,
	@idcliente,
	@idempleado
	)
SET @idventa = @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[spobtener_ultimo_num_factura]    Script Date: 12/19/2020 18:26:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spobtener_ultimo_num_factura]
AS
BEGIN
	-- =============================================
	-- Author:		Adonis Sinclair
	-- Create date: 13/12/2020 --dd/mm/aaaa
	-- Description:	Obtener numero de factura de idventa maximo.
	-- =============================================
	SELECT max(Cast(num_factura as int)) as numero FROM ventas WHERE idventa = (SELECT MAX(idventa)FROM ventas);
END
GO
/****** Object:  StoredProcedure [dbo].[spobtener_ultimaventa]    Script Date: 12/19/2020 18:26:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spobtener_ultimaventa]
-- =============================================
-- Author:		Adonis Sinclair
-- Create date: 07/12/2020
-- Description:	Obtener ultima venta de sistema
-- =============================================
AS
BEGIN
	SELECT MAX(v.idventa) FROM ventas v;
END
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_venta]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Procedimiento Mostrar
CREATE proc [dbo].[spmostrar_venta]
as
SELECT TOP 100
	v.idventa,
	(e.primer_apellido + ' ' + e.primer_nombre) as empleado,
	c.nombre_cliente,
	v.fecha_venta,
	v.tipo_comprobante,
	v.num_comprobante,
	v.num_factura,
	v.porc_isv,
	v.subtotal,
	v.isv,
	v.total
FROM ventas v
INNER JOIN clientes c ON v.IDcliente = c.idcliente
INNER JOIN empleados e ON v.IDempleado = e.idempleado
ORDER BY v.idventa DESC
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_producto]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Procedimiento Mostrar
CREATE proc [dbo].[spmostrar_producto]
as
select top 100
	dbo.productos.idproducto,
	dbo.productos.codigo_producto,
	dbo.productos.nombre_producto,
	dbo.productos.descripcion_producto,
	dbo.productos.busqueda_producto,
	dbo.productos.imagen_producto,
	dbo.productos.activo_producto,
	dbo.productos.IDcategoria,
	dbo.productoscategoria.nombre_categoria AS Categoria,
	dbo.productos.IDunidad,
	dbo.unidades.nombre_unidad AS Unidad
	FROM dbo.productos 
	INNER JOIN dbo.productoscategoria ON dbo.productos.IDcategoria = dbo.productoscategoria.idcategoria
	INNER JOIN dbo.unidades ON dbo.productos.IDunidad = dbo.unidades.idunidad
order by dbo.productos.idproducto desc
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_pago_planilla]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spmostrar_pago_planilla]
as
SELECT TOP 200
	p.*,
	e.identidad,
	(e.primer_nombre + ' ' + e.primer_apellido) as empleado,
	e.salario_base,
	e.cargo_empleado,
	e.activo_empleado
FROM pagos_panilla p 
INNER JOIN empleados e ON p.IDempleado = e.idempleado
ORDER BY p.idpago_planilla DESC
GO
/****** Object:  StoredProcedure [dbo].[spanular_pago_planilla]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spanular_pago_planilla]
@idpago_planilla int,
@estado varchar(10)
as
update pagos_panilla
set estado = @estado
where idpago_planilla = @idpago_planilla
GO
/****** Object:  StoredProcedure [dbo].[spanular_ingreso]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Procedimiento anular
CREATE PROC [dbo].[spanular_ingreso]
@idingreso int
AS
UPDATE ingresos
SET estado = 'ANULADO'
WHERE idingreso = @idingreso
GO
/****** Object:  StoredProcedure [dbo].[spactivar_producto]    Script Date: 12/19/2020 18:26:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--ACTIVAR
create proc [dbo].[spactivar_producto]
@idproducto int
as
UPDATE productos
SET
	activo_producto = 1
WHERE idproducto = @idproducto
GO
/****** Object:  Table [dbo].[detallesingreso]    Script Date: 12/19/2020 18:26:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detallesingreso](
	[iddetalleIngreso] [int] IDENTITY(1,1) NOT NULL,
	[precio_compra] [money] NOT NULL,
	[precio_venta] [money] NOT NULL,
	[stock_inicial] [int] NOT NULL,
	[stock_final] [int] NOT NULL,
	[fecha_produccion] [date] NULL,
	[fecha_vencimiento] [date] NULL,
	[IDingreso] [int] NOT NULL,
	[IDproducto] [int] NOT NULL,
 CONSTRAINT [PK_detallesingreso_iddetalleIngreso] PRIMARY KEY CLUSTERED 
(
	[iddetalleIngreso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'dbinventario.detallesingreso' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'detallesingreso'
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_producto]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--procedimiento buscar
CREATE proc [dbo].[spbuscar_producto]
@textobuscar varchar(50)
as 
SELECT
	dbo.productos.idproducto,
	dbo.productos.codigo_producto,
	dbo.productos.nombre_producto,
	dbo.productos.descripcion_producto,
	dbo.productos.busqueda_producto,
	dbo.productos.imagen_producto,
	dbo.productos.activo_producto,
	dbo.productos.IDcategoria,
	dbo.productoscategoria.nombre_categoria AS Categoria,
	dbo.productos.IDunidad,
	dbo.unidades.nombre_unidad AS Unidad
	FROM dbo.productos 
	INNER JOIN dbo.productoscategoria ON dbo.productos.IDcategoria = dbo.productoscategoria.idcategoria
	INNER JOIN dbo.unidades ON dbo.productos.IDunidad = dbo.unidades.idunidad
WHERE dbo.productos.busqueda_producto like '%' + @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_pago_planilla]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--procedimiento buscar
CREATE proc [dbo].[spbuscar_pago_planilla]
@textobuscar varchar(20),
@textobuscar2 varchar(20)
as 
SELECT TOP 200
	p.*,
	e.identidad,
	(e.primer_nombre + ' ' + e.primer_apellido) as empleado,
	e.salario_base,
	e.cargo_empleado,
	e.activo_empleado
FROM pagos_panilla p 
INNER JOIN empleados e ON p.IDempleado = e.idempleado
WHERE p.fecha_pago >= @textobuscar and p.fecha_pago <= @textobuscar2
GO
/****** Object:  StoredProcedure [dbo].[speditar_producto]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Editar
create proc [dbo].[speditar_producto]
@idproducto int,
@codigo_producto varchar(100),
@nombre_producto varchar(100),
@descripcion_producto varchar(1024),
@busqueda_producto nvarchar(max),
@imagen_producto image,
@activo_producto int,
@idunidad int,
@idcategoria int
as
UPDATE productos
SET 
	codigo_producto = @codigo_producto,
	nombre_producto = @nombre_producto,
	descripcion_producto = @descripcion_producto,
	busqueda_producto = @busqueda_producto,
	imagen_producto = @imagen_producto,
	activo_producto = @activo_producto,
	IDunidad = @idunidad,
	IDcategoria = @idcategoria
	
WHERE idproducto = @idproducto
GO
/****** Object:  Table [dbo].[detallesventa]    Script Date: 12/19/2020 18:26:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detallesventa](
	[iddetalleventa] [int] IDENTITY(1,1) NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio_venta] [money] NOT NULL,
	[descuento] [money] NULL,
	[IDventa] [int] NOT NULL,
	[IDdetalleingreso] [int] NOT NULL,
 CONSTRAINT [PK_ordenes_idorden] PRIMARY KEY CLUSTERED 
(
	[iddetalleventa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'dbinventario.ordenes' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'detallesventa'
GO
/****** Object:  StoredProcedure [dbo].[spdisminuir_stock]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Restar stock despues de realizar Venta
CREATE proc [dbo].[spdisminuir_stock]
@iddetalleingreso int,
@cantidad int
AS
update detallesingreso set stock_final = stock_final - @cantidad
where iddetalleIngreso = @iddetalleingreso
GO
/****** Object:  StoredProcedure [dbo].[spbuscarproducto_venta_codigo]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--procedimiento buscar por codigo
create proc [dbo].[spbuscarproducto_venta_codigo]
@textobuscar varchar(50)
as 
SELECT
	di.iddetalleIngreso,
	p.codigo_producto,
	p.nombre_producto,
	c.nombre_categoria as categoria,
	u.nombre_unidad as unidad,
	di.stock_final,
	di.precio_compra,
	di.precio_venta,
	di.fecha_vencimiento
FROM productos p
INNER JOIN productoscategoria c ON p.IDcategoria = c.nombre_categoria
INNER JOIN unidades u ON p.IDunidad = u.idunidad
INNER JOIN detallesingreso di ON p.idproducto = di.IDproducto
INNER JOIN ingresos i ON di.IDingreso = i.idingreso
WHERE p.codigo_producto = @textobuscar
AND di.stock_final > 0
AND i.estado <> 'ANULADO'
GO
/****** Object:  StoredProcedure [dbo].[spbuscarproducto_venta]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--procedimiento buscar por nombre
CREATE proc [dbo].[spbuscarproducto_venta]
@textobuscar varchar(50)
as 
SELECT
	di.iddetalleIngreso,
	p.codigo_producto,
	p.nombre_producto,
	c.nombre_categoria as categoria,
	u.nombre_unidad as unidad,
	di.stock_final,
	di.precio_compra,
	di.precio_venta,
	di.fecha_vencimiento
FROM productos p
INNER JOIN productoscategoria c ON p.IDcategoria = c.idcategoria
INNER JOIN unidades u ON p.IDunidad = u.idunidad
INNER JOIN detallesingreso di ON p.idproducto = di.IDproducto
INNER JOIN ingresos i ON di.IDingreso = i.idingreso
WHERE p.busqueda_producto LIKE '%' + @textobuscar + '%'
AND di.stock_final > 0
AND i.estado <> 'ANULADO'
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_ingreso_fecha]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--procedimiento buscar
CREATE proc [dbo].[spbuscar_ingreso_fecha]
@textobuscar varchar(20),
@textobuscar2 varchar(20)
as 
SELECT
	i.idingreso,
	(e.primer_nombre + ' ' + e.primer_apellido) as empleado,
	p.nombre_empresa as proveedor,
	i.fecha_ingreso,
	i.tipo_comprobante,
	i.num_comprobante,
	i.isv_ingreso,
	i.total_ingreso,
	i.estado,
	SUM(d.precio_compra*d.stock_inicial) as total
FROM detallesingreso d 
INNER JOIN ingresos i ON d.IDingreso = i.idingreso
INNER JOIN proveedores p ON i.IDproveedor = p.idproveedor
INNER JOIN empleados e ON i.IDempleado = e.idempleado
GROUP BY 
	i.idingreso,
	(e.primer_nombre + ' ' + e.primer_apellido),
	p.nombre_empresa,
	i.fecha_ingreso,
	i.tipo_comprobante,
	i.num_comprobante,
	i.isv_ingreso,
	i.total_ingreso,
	i.estado
HAVING i.fecha_ingreso >= @textobuscar AND i.fecha_ingreso <= @textobuscar2
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_ingreso]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Procedimiento Mostrar
CREATE proc [dbo].[spmostrar_ingreso]
as
SELECT TOP 100
	i.idingreso,
	(e.primer_nombre + ' ' + e.primer_apellido) as empleado,
	p.nombre_empresa as proveedor,
	i.fecha_ingreso,
	i.tipo_comprobante,
	i.num_comprobante,
	i.isv_ingreso,
	i.total_ingreso,
	i.estado,
	SUM(d.precio_compra*d.stock_inicial) as total
FROM detallesingreso d 
INNER JOIN ingresos i ON d.IDingreso = i.idingreso
INNER JOIN proveedores p ON i.IDproveedor = p.idproveedor
INNER JOIN empleados e ON i.IDempleado = e.idempleado
GROUP BY 
	i.idingreso,
	(e.primer_nombre + ' ' + e.primer_apellido),
	p.nombre_empresa,
	i.fecha_ingreso,
	i.tipo_comprobante,
	i.num_comprobante,
	i.isv_ingreso,
	i.total_ingreso,
	i.estado
ORDER BY i.idingreso DESC
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_detalle_ingreso]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Mostrar detalle de ingreso
create proc [dbo].[spmostrar_detalle_ingreso]
@textobuscar int
as
select 
	d.IDproducto,
	p.nombre_producto as Producto,
	d.precio_compra,
	d.precio_venta,
	d.stock_inicial,
	d.fecha_produccion,
	d.fecha_vencimiento,
	(d.precio_compra * d.stock_inicial) as Subtotal
FROM detallesingreso d 
INNER JOIN productos p ON d.IDproducto = p.idproducto
WHERE d.IDingreso = @textobuscar
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_detalle_ingreso]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--procedimiento insertar detalle ingreso
CREATE proc [dbo].[spinsertar_detalle_ingreso]
@iddetalleIngreso int output,
@precio_compra money,
@precio_venta money,
@stock_inicial int,
@stock_final int,
@fecha_produccion date,
@fecha_vencimiento date,
@idingreso int,
@idproducto int
as
INSERT into detallesingreso(
	precio_compra,
	precio_venta,
	stock_inicial,
	stock_final,
	fecha_produccion,
	fecha_vencimiento,
	IDingreso,
	IDproducto
)
values(
	@precio_compra,
	@precio_venta,
	@stock_inicial,
	@stock_final,
	@fecha_produccion,
	@fecha_vencimiento,
	@idingreso,
	@idproducto
)
GO
/****** Object:  StoredProcedure [dbo].[spstock_productos]    Script Date: 12/19/2020 18:26:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spstock_productos]
AS
SELECT     
	dbo.productos.codigo_producto, 
	dbo.productos.nombre_producto, 
	dbo.productoscategoria.nombre_categoria AS categoria, 
	SUM(dbo.detallesingreso.stock_inicial) AS cantidad_ingresos, 
	SUM(dbo.detallesingreso.stock_final) AS cantidad_stock,
	(SUM(dbo.detallesingreso.stock_inicial) - SUM(dbo.detallesingreso.stock_final)) AS cantidad_venta
FROM dbo.detallesingreso 
	INNER JOIN dbo.ingresos ON dbo.detallesingreso.IDingreso = dbo.ingresos.idingreso 
	INNER JOIN dbo.productos ON dbo.detallesingreso.IDproducto = dbo.productos.idproducto 
	INNER JOIN dbo.productoscategoria ON dbo.productos.IDcategoria = dbo.productoscategoria.idcategoria
WHERE dbo.ingresos.estado <> 'ANULADO'
GROUP BY dbo.productos.codigo_producto, 
	dbo.productos.nombre_producto, 
	dbo.productoscategoria.nombre_categoria
GO
/****** Object:  Trigger [trrestablecer_stock]    Script Date: 12/19/2020 18:26:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*CREACION DE TRIGGER ELIMINACION POST VENTA
*/
CREATE TRIGGER [dbo].[trrestablecer_stock]
ON [dbo].[detallesventa]
FOR DELETE
AS
/*inicio de instruccion*/
	UPDATE di
	SET di.stock_final = di.stock_final + dv.cantidad
	FROM detallesingreso AS di
	INNER JOIN deleted AS dv ON di.iddetalleIngreso = dv.IDdetalleingreso
/*final instruccion*/
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_detalle_venta]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Mostrar detalle de venta
CREATE proc [dbo].[spmostrar_detalle_venta]
@textobuscar int
as
select 
	dv.IDdetalleingreso,
	p.nombre_producto as nombre_producto,
	dv.cantidad,
	dv.precio_venta,
	dv.descuento,
	((dv.precio_venta * dv.cantidad) - dv.descuento) as subtotal
FROM detallesventa dv 
INNER JOIN detallesingreso di ON dv.IDdetalleingreso = di.iddetalleIngreso
INNER JOIN productos p ON di.IDproducto = p.idproducto
WHERE dv.IDventa = @textobuscar
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_detalle_venta]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--procedimiento insertar detalle venta
create proc [dbo].[spinsertar_detalle_venta]
@iddetalleventa int output,
@cantidad int,
@precio_venta money,
@descuento money,
@idventa int,
@iddetalleingreso int
as
INSERT into detallesventa(
	cantidad,
	precio_venta,
	descuento,
	IDventa,
	IDdetalleingreso
)
values(
	@cantidad,
	@precio_venta,
	@descuento,
	@idventa,
	@iddetalleingreso
)
GO
/****** Object:  StoredProcedure [dbo].[spinforme_factura]    Script Date: 12/19/2020 18:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spinforme_factura]
@idventa INT
AS
SELECT 
	v.idventa,
	(e.primer_apellido + ' ' + e.primer_nombre) as empleado,
	c.nombre_cliente as cliente,
	c.direccion,
	c.celular,
	v.fecha_venta,
	v.tipo_comprobante,
	v.num_comprobante,
	v.num_factura,
	v.porc_isv,
	p.nombre_producto,
	dv.precio_venta,
	dv.cantidad,
	dv.descuento,
	((dv.precio_venta * dv.cantidad) - dv.descuento) as total_parcial,
	v.subtotal,
	v.isv,
	v.total,
	cf.titulo_sistema,
	cf.nombre_razon_social,
	cf.nombre_comercial,
	cf.nombre_sucursal,
	cf.direccion,
	cf.telefono,
	cf.correo,
	cf.slogan,
	cf.propietario,
	cf.rtn,
	cf.cai,
	cf.punto_emision,
	cf.establecimiento,
	cf.tipo_documento,
	cf.rango_inicial,
	cf.rango_final
FROM detallesventa dv
INNER JOIN detallesingreso di ON di.iddetalleIngreso = dv.IDdetalleingreso
INNER JOIN productos p ON di.IDproducto = p.idproducto
INNER JOIN ventas v ON dv.IDventa = v.idventa
INNER JOIN clientes c ON v.IDcliente = c.idcliente
INNER JOIN empleados e ON v.IDempleado = e.idempleado
CROSS JOIN configuracion cf
WHERE v.idventa = @idventa
GO
/****** Object:  Default [DF__accesos__fecha_a__5165187F]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[accesos] ADD  DEFAULT (NULL) FOR [fecha_acceso]
GO
/****** Object:  Default [DF__accesos__hora_ac__52593CB8]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[accesos] ADD  DEFAULT (NULL) FOR [hora_acceso]
GO
/****** Object:  Default [DF__clientes__identi__014935CB]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[clientes] ADD  CONSTRAINT [DF__clientes__identi__014935CB]  DEFAULT (NULL) FOR [num_documento]
GO
/****** Object:  Default [DF__clientes__ciudad__023D5A04]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[clientes] ADD  CONSTRAINT [DF__clientes__ciudad__023D5A04]  DEFAULT (NULL) FOR [ciudad]
GO
/****** Object:  Default [DF__clientes__region__03317E3D]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[clientes] ADD  CONSTRAINT [DF__clientes__region__03317E3D]  DEFAULT (NULL) FOR [region]
GO
/****** Object:  Default [DF__clientes__codigo__0425A276]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[clientes] ADD  CONSTRAINT [DF__clientes__codigo__0425A276]  DEFAULT (NULL) FOR [codigo_postal]
GO
/****** Object:  Default [DF__clientes__pais__0519C6AF]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[clientes] ADD  CONSTRAINT [DF__clientes__pais__0519C6AF]  DEFAULT (NULL) FOR [pais]
GO
/****** Object:  Default [DF__clientes__celula__060DEAE8]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[clientes] ADD  CONSTRAINT [DF__clientes__celula__060DEAE8]  DEFAULT (NULL) FOR [celular]
GO
/****** Object:  Default [DF__clientes__email__07020F21]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[clientes] ADD  CONSTRAINT [DF__clientes__email__07020F21]  DEFAULT (NULL) FOR [email]
GO
/****** Object:  Default [DF__clientes__activo__07F6335A]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[clientes] ADD  CONSTRAINT [DF__clientes__activo__07F6335A]  DEFAULT ((1)) FOR [activo_cliente]
GO
/****** Object:  Default [DF_configuracion_principal_activo]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[configuracion] ADD  CONSTRAINT [DF_configuracion_principal_activo]  DEFAULT ((1)) FOR [activo]
GO
/****** Object:  Default [DF__detallesi__stock__0CBAE877]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[detallesingreso] ADD  CONSTRAINT [DF__detallesi__stock__0CBAE877]  DEFAULT (NULL) FOR [stock_inicial]
GO
/****** Object:  Default [DF__detallesi__stock__0DAF0CB0]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[detallesingreso] ADD  CONSTRAINT [DF__detallesi__stock__0DAF0CB0]  DEFAULT (NULL) FOR [stock_final]
GO
/****** Object:  Default [DF__detallesi__fecha__0EA330E9]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[detallesingreso] ADD  CONSTRAINT [DF__detallesi__fecha__0EA330E9]  DEFAULT (NULL) FOR [fecha_produccion]
GO
/****** Object:  Default [DF__detallesi__fecha__0F975522]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[detallesingreso] ADD  CONSTRAINT [DF__detallesi__fecha__0F975522]  DEFAULT (NULL) FOR [fecha_vencimiento]
GO
/****** Object:  Default [DF__empleados__segun__117F9D94]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[empleados] ADD  CONSTRAINT [DF__empleados__segun__117F9D94]  DEFAULT (NULL) FOR [segundo_apellido]
GO
/****** Object:  Default [DF__empleados__ciuda__1273C1CD]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[empleados] ADD  CONSTRAINT [DF__empleados__ciuda__1273C1CD]  DEFAULT (NULL) FOR [ciudad]
GO
/****** Object:  Default [DF__empleados__regio__1367E606]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[empleados] ADD  CONSTRAINT [DF__empleados__regio__1367E606]  DEFAULT (NULL) FOR [region]
GO
/****** Object:  Default [DF__empleados__codig__145C0A3F]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[empleados] ADD  CONSTRAINT [DF__empleados__codig__145C0A3F]  DEFAULT (NULL) FOR [codigo_postal]
GO
/****** Object:  Default [DF__empleados__pais__15502E78]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[empleados] ADD  CONSTRAINT [DF__empleados__pais__15502E78]  DEFAULT (NULL) FOR [pais]
GO
/****** Object:  Default [DF__empleados__repor__164452B1]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[empleados] ADD  CONSTRAINT [DF__empleados__repor__164452B1]  DEFAULT (NULL) FOR [reporta_a]
GO
/****** Object:  Default [DF__empleados__activ__173876EA]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[empleados] ADD  CONSTRAINT [DF__empleados__activ__173876EA]  DEFAULT ((1)) FOR [activo_empleado]
GO
/****** Object:  Default [DF__ingresos__fecha___1920BF5C]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[ingresos] ADD  CONSTRAINT [DF__ingresos__fecha___1920BF5C]  DEFAULT (NULL) FOR [fecha_ingreso]
GO
/****** Object:  Default [DF__ingresos__subtot__1A14E395]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[ingresos] ADD  CONSTRAINT [DF__ingresos__subtot__1A14E395]  DEFAULT (NULL) FOR [subtotal_ingreso]
GO
/****** Object:  Default [DF__ingresos__isv_in__1B0907CE]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[ingresos] ADD  CONSTRAINT [DF__ingresos__isv_in__1B0907CE]  DEFAULT (NULL) FOR [isv_ingreso]
GO
/****** Object:  Default [DF__ingresos__total___1BFD2C07]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[ingresos] ADD  CONSTRAINT [DF__ingresos__total___1BFD2C07]  DEFAULT (NULL) FOR [total_ingreso]
GO
/****** Object:  Default [DF__pagos_pan__comp___239E4DCF]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[pagos_panilla] ADD  CONSTRAINT [DF__pagos_pan__comp___239E4DCF]  DEFAULT (NULL) FOR [comp_transferencia]
GO
/****** Object:  Default [DF__pagos_pan__total__24927208]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[pagos_panilla] ADD  CONSTRAINT [DF__pagos_pan__total__24927208]  DEFAULT (NULL) FOR [total_bruto]
GO
/****** Object:  Default [DF__pagos_pan__segur__25869641]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[pagos_panilla] ADD  CONSTRAINT [DF__pagos_pan__segur__25869641]  DEFAULT (NULL) FOR [seguro_social]
GO
/****** Object:  Default [DF__pagos_pan__total__267ABA7A]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[pagos_panilla] ADD  CONSTRAINT [DF__pagos_pan__total__267ABA7A]  DEFAULT (NULL) FOR [total_neto]
GO
/****** Object:  Default [DF__pagos_pan__impue__276EDEB3]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[pagos_panilla] ADD  CONSTRAINT [DF__pagos_pan__impue__276EDEB3]  DEFAULT (NULL) FOR [impuesto_renta]
GO
/****** Object:  Default [DF__productos__activ__2C3393D0]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[productos] ADD  CONSTRAINT [DF__productos__activ__2C3393D0]  DEFAULT ((1)) FOR [activo_producto]
GO
/****** Object:  Default [DF__productos__activ__6EF57B66]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[productoscategoria] ADD  DEFAULT ((1)) FOR [activa_categoria]
GO
/****** Object:  Default [DF__proveedor__ciuda__6FE99F9F]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[proveedores] ADD  DEFAULT (NULL) FOR [ciudad]
GO
/****** Object:  Default [DF__proveedor__regio__70DDC3D8]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[proveedores] ADD  DEFAULT (NULL) FOR [region]
GO
/****** Object:  Default [DF__proveedor__codig__71D1E811]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[proveedores] ADD  DEFAULT (NULL) FOR [codigo_postal]
GO
/****** Object:  Default [DF__proveedore__pais__72C60C4A]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[proveedores] ADD  DEFAULT (NULL) FOR [pais]
GO
/****** Object:  Default [DF__proveedor__celul__73BA3083]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[proveedores] ADD  DEFAULT (NULL) FOR [celular]
GO
/****** Object:  Default [DF__proveedor__telef__74AE54BC]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[proveedores] ADD  DEFAULT (NULL) FOR [telefono]
GO
/****** Object:  Default [DF__proveedor__activ__75A278F5]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[proveedores] ADD  DEFAULT ((1)) FOR [activo_proveedor]
GO
/****** Object:  Default [DF__ventas__celular___398D8EEE]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[ventas] ADD  CONSTRAINT [DF__ventas__celular___398D8EEE]  DEFAULT (NULL) FOR [tipo_comprobante]
GO
/****** Object:  Default [DF_ventas_num_factura]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[ventas] ADD  CONSTRAINT [DF_ventas_num_factura]  DEFAULT ('00000000') FOR [num_factura]
GO
/****** Object:  ForeignKey [FK_accesos_empleados]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[accesos]  WITH CHECK ADD  CONSTRAINT [FK_accesos_empleados] FOREIGN KEY([IDempleado])
REFERENCES [dbo].[empleados] ([idempleado])
GO
ALTER TABLE [dbo].[accesos] CHECK CONSTRAINT [FK_accesos_empleados]
GO
/****** Object:  ForeignKey [detallesingreso$fk_detallesIngreso_ingresos1]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[detallesingreso]  WITH CHECK ADD  CONSTRAINT [detallesingreso$fk_detallesIngreso_ingresos1] FOREIGN KEY([IDingreso])
REFERENCES [dbo].[ingresos] ([idingreso])
GO
ALTER TABLE [dbo].[detallesingreso] CHECK CONSTRAINT [detallesingreso$fk_detallesIngreso_ingresos1]
GO
/****** Object:  ForeignKey [detallesingreso$fk_detallesIngreso_productos1]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[detallesingreso]  WITH CHECK ADD  CONSTRAINT [detallesingreso$fk_detallesIngreso_productos1] FOREIGN KEY([IDproducto])
REFERENCES [dbo].[productos] ([idproducto])
GO
ALTER TABLE [dbo].[detallesingreso] CHECK CONSTRAINT [detallesingreso$fk_detallesIngreso_productos1]
GO
/****** Object:  ForeignKey [FK_detallesventa_detallesingreso]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[detallesventa]  WITH CHECK ADD  CONSTRAINT [FK_detallesventa_detallesingreso] FOREIGN KEY([IDdetalleingreso])
REFERENCES [dbo].[detallesingreso] ([iddetalleIngreso])
GO
ALTER TABLE [dbo].[detallesventa] CHECK CONSTRAINT [FK_detallesventa_detallesingreso]
GO
/****** Object:  ForeignKey [FK_detallesventa_ventas]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[detallesventa]  WITH CHECK ADD  CONSTRAINT [FK_detallesventa_ventas] FOREIGN KEY([IDventa])
REFERENCES [dbo].[ventas] ([idventa])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[detallesventa] CHECK CONSTRAINT [FK_detallesventa_ventas]
GO
/****** Object:  ForeignKey [ingresos$fk_ingresos_empleados1]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[ingresos]  WITH CHECK ADD  CONSTRAINT [ingresos$fk_ingresos_empleados1] FOREIGN KEY([IDempleado])
REFERENCES [dbo].[empleados] ([idempleado])
GO
ALTER TABLE [dbo].[ingresos] CHECK CONSTRAINT [ingresos$fk_ingresos_empleados1]
GO
/****** Object:  ForeignKey [ingresos$fk_ingresos_proveedores1]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[ingresos]  WITH CHECK ADD  CONSTRAINT [ingresos$fk_ingresos_proveedores1] FOREIGN KEY([IDproveedor])
REFERENCES [dbo].[proveedores] ([idproveedor])
GO
ALTER TABLE [dbo].[ingresos] CHECK CONSTRAINT [ingresos$fk_ingresos_proveedores1]
GO
/****** Object:  ForeignKey [pagos_panilla$fk_pagos_panilla_empleados1]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[pagos_panilla]  WITH CHECK ADD  CONSTRAINT [pagos_panilla$fk_pagos_panilla_empleados1] FOREIGN KEY([IDempleado])
REFERENCES [dbo].[empleados] ([idempleado])
GO
ALTER TABLE [dbo].[pagos_panilla] CHECK CONSTRAINT [pagos_panilla$fk_pagos_panilla_empleados1]
GO
/****** Object:  ForeignKey [FK_productos_unidades]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[productos]  WITH CHECK ADD  CONSTRAINT [FK_productos_unidades] FOREIGN KEY([IDunidad])
REFERENCES [dbo].[unidades] ([idunidad])
GO
ALTER TABLE [dbo].[productos] CHECK CONSTRAINT [FK_productos_unidades]
GO
/****** Object:  ForeignKey [productos$fk_productos_productosCategoria]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[productos]  WITH CHECK ADD  CONSTRAINT [productos$fk_productos_productosCategoria] FOREIGN KEY([IDcategoria])
REFERENCES [dbo].[productoscategoria] ([idcategoria])
GO
ALTER TABLE [dbo].[productos] CHECK CONSTRAINT [productos$fk_productos_productosCategoria]
GO
/****** Object:  ForeignKey [FK_ventas_clientes]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[ventas]  WITH CHECK ADD  CONSTRAINT [FK_ventas_clientes] FOREIGN KEY([IDcliente])
REFERENCES [dbo].[clientes] ([idcliente])
GO
ALTER TABLE [dbo].[ventas] CHECK CONSTRAINT [FK_ventas_clientes]
GO
/****** Object:  ForeignKey [FK_ventas_empleados]    Script Date: 12/19/2020 18:26:40 ******/
ALTER TABLE [dbo].[ventas]  WITH CHECK ADD  CONSTRAINT [FK_ventas_empleados] FOREIGN KEY([IDempleado])
REFERENCES [dbo].[empleados] ([idempleado])
GO
ALTER TABLE [dbo].[ventas] CHECK CONSTRAINT [FK_ventas_empleados]
GO

/*INSERCION DE DATOS***********************************************************************************/
/*CONFIG GENERAL GENERICA*/
INSERT INTO [dbo].[configuracion]
           ([titulo_sistema]
           ,[nombre_razon_social]
           ,[nombre_comercial]
           ,[nombre_sucursal]
           ,[direccion]
           ,[telefono]
           ,[correo]
           ,[slogan]
           ,[propietario]
           ,[usuario_root]
           ,[pass_root]
           ,[default_ganancia_venta]
           ,[default_seguro_deducido]
           ,[default_isr]
           ,[default_isv]
           ,[default_porc_descuento]
           ,[rtn]
           ,[cai]
           ,[punto_emision]
           ,[establecimiento]
           ,[tipo_documento]
           ,[rango_inicial]
           ,[rango_final]
           ,[activo])
VALUES
       ('SISTEMA POS',
       'EMPRESA X',
       'EMPRESA X COMERCIAL',
       'NOMBRE SUCURSAL X',
       'DIRECCION SUCURSAL X',
       '504-00000000',
       'CORREO@CORREO.COM',
       'SISTEMA POS SLOGAN',
       'PROPIETARIO X',
       'root',
       '1234',
       0.00,
       0.00,
       0.12,
       0.15,
       0.00,
       'RTN0000000000000000',
       'CAI000000000000000',
       '001',
       '001',
       '01',
       '00000000',
       '00000000',
       1)
GO
       
/*UNIDAD GENERICA*/
INSERT INTO [dbo].[unidades]
           ([nombre_unidad]
           ,[descripcion_unidad])
     VALUES
           ('UNIDAD',
           'UNIDAD GENERICA')
GO

/*CATEGORIA GENERICA*/
INSERT INTO [dbo].[productoscategoria]
           ([nombre_categoria]
           ,[descripcion_categoria]
           ,[activa_categoria])
     VALUES
           ('GENERICA'
           ,'CATEGORIA GENERICA'
           ,1)
GO

/*PROVEEDOR GENERICO*/
INSERT INTO [dbo].[proveedores]
           ([nombre_empresa]
           ,[nombre_contacto]
           ,[activo_proveedor])
     VALUES
           ('PROVEEDOR GENERICO'
           ,'CONTACTO GENERICO'
           ,1)
GO

/*CLIENTE GENERICO*/
INSERT INTO [dbo].[clientes]
           ([nombre_cliente]
           ,[activo_cliente])
     VALUES
           ('GENERICO'
           ,1)
GO
