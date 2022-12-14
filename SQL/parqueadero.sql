
CREATE DATABASE [parqueadero]
USE [parqueadero]

CREATE TABLE [clientes](
	[cedula] [nvarchar](50) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[telefono] [nvarchar](50) NULL,
	[celular] [nvarchar](50) NULL,
	[direccion] [nvarchar](100) NULL,
	[correo] [nvarchar](50) NULL,
	[dia_pago] [nvarchar](10) NULL,
	[ref_pago] [nvarchar](50) NULL,
	[comentario] [nvarchar](50) NULL
) ON [PRIMARY]
GO

CREATE TABLE [ingreso](
	[fecha] [datetime2](0) NOT NULL,
	[hora] [nvarchar](10) NOT NULL,
	[placa] [nvarchar](50) NOT NULL,
	[vehiculo] [nvarchar](50) NULL,
	[usuario] [nvarchar](50) NULL,
 CONSTRAINT [ingreso$placa] UNIQUE CLUSTERED 
(
	[placa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [ingreso_lavado](
	[placa] [nvarchar](50) NOT NULL,
	[encargado] [nvarchar](50) NOT NULL,
	[identificacion] [nvarchar](50) NOT NULL,
	[vehiculo] [nvarchar](50) NOT NULL,
	[fecha] [datetime2](0) NOT NULL,
	[total] [float] NOT NULL,
	[tipo_lavado] [nvarchar](40) NOT NULL,
 CONSTRAINT [ingreso_lavado$placa] UNIQUE CLUSTERED 
(
	[placa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [lavador](
	[fecha] [datetime2](0) NOT NULL,
	[hora] [nvarchar](50) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[identificacion] [float] NOT NULL,
	[valor] [int] NOT NULL,
 CONSTRAINT [lavador$identificacion] UNIQUE CLUSTERED 
(
	[identificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


GO
CREATE TABLE [mensualidades](
	[Id_ventas] [int] NOT NULL,
	[fecha] [datetime2](0) NOT NULL,
	[hora] [nvarchar](20) NOT NULL,
	[placa] [nvarchar](10) NULL,
	[egresos] [int] NULL,
	[tipo] [nvarchar](50) NULL,
	[mes] [nvarchar](50) NULL,
	[servicio] [nvarchar](50) NULL,
	[cliente] [nvarchar](50) NULL,
	[usuario] [nvarchar](50) NULL,
	[valor] [int] NOT NULL
) ON [PRIMARY]
GO

CREATE TABLE [pagos](
	[id_pagos] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime2](0) NOT NULL,
	[hora] [nvarchar](45) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[identificacion] [float] NOT NULL,
	[valor] [float] NOT NULL,
 CONSTRAINT [PK_pagos_id_pagos] PRIMARY KEY CLUSTERED 
(
	[id_pagos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [prestamo](
	[nombre] [nvarchar](45) NOT NULL,
	[cedula] [float] NOT NULL,
	[valor] [float] NOT NULL,
	[fecha] [date] NOT NULL,
	[hora] [nvarchar](45) NOT NULL,
 CONSTRAINT [prestamo$cedula] UNIQUE CLUSTERED 
(
	[cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [temporal_ingreso](
	[fecha] [datetime2](0) NOT NULL,
	[hora] [nvarchar](10) NOT NULL,
	[placa] [nvarchar](50) NULL,
	[vehiculo] [nvarchar](50) NULL,
	[usuario] [nvarchar](50) NULL,
 CONSTRAINT [temporal_ingreso$placa] UNIQUE NONCLUSTERED 
(
	[placa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE TABLE [total_ventas](
	[fechadesde] [datetime2](0) NOT NULL,
	[fechahasta] [datetime2](0) NOT NULL,
	[total] [int] NULL
) ON [PRIMARY]

GO
CREATE TABLE [usuarios](
	[Id_user] [int] NOT NULL,
	[nombre_user] [nvarchar](50) NULL,
	[contraseña_user] [nvarchar](50) NULL,
	[cargo_user] [nvarchar](50) NULL
) ON [PRIMARY]

GO
CREATE TABLE [vehiculo_pendientes](
	[fecha] [datetime2](0) NOT NULL,
	[hora] [nvarchar](20) NOT NULL,
	[lavador] [nvarchar](50) NOT NULL,
	[placa] [nvarchar](50) NOT NULL,
	[vehiculo] [nvarchar](50) NOT NULL,
	[estado] [nvarchar](20) NOT NULL,
	[valor] [float] NOT NULL,
	[id] [int] IDENTITY(3,1) NOT NULL,
 CONSTRAINT [PK_vehiculo_pendientes_id] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [ventas](
	[Id_ventas] [int] NULL,
	[fecha] [datetime2](0) NOT NULL,
	[hora] [nvarchar](20) NOT NULL,
	[placa] [nvarchar](50) NULL,
	[egresos] [int] NULL,
	[tipo] [nvarchar](50) NULL,
	[mes] [nvarchar](50) NULL,
	[servicio] [nvarchar](50) NULL,
	[cliente] [nvarchar](50) NULL,
	[usuario] [nvarchar](50) NULL,
	[valor] [float] NULL
) ON [PRIMARY]

GO
