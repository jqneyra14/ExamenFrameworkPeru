USE [BDOrdTrabajo]
GO
/****** Object:  Table [dbo].[TBL_DETALLEORDENTRABAJO]    Script Date: 6/05/2018 23:04:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_DETALLEORDENTRABAJO](
	[Id_OTDetalle] [int] IDENTITY(1,1) NOT NULL,
	[Id_OT] [int] NOT NULL,
	[Id_Equipo] [int] NOT NULL,
	[CantEquipo_OT] [int] NOT NULL,
 CONSTRAINT [PK_TBL_DETALLEORDENTRABAJO] PRIMARY KEY CLUSTERED 
(
	[Id_OTDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TBL_EQUIPO]    Script Date: 6/05/2018 23:04:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_EQUIPO](
	[Id_Equipo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion_Equipo] [varchar](100) NOT NULL,
	[Id_Marca] [int] NOT NULL,
	[Modelo_Equipo] [varchar](50) NOT NULL,
	[Serie_Equipo] [varchar](50) NOT NULL,
	[CantComprometida_Equipo] [int] NULL CONSTRAINT [DF_TBL_EQUIPO_CantComprometida_Equipo]  DEFAULT ((0)),
	[CantBase_Equipo] [int] NULL,
	[FechaRegistro_Equipo] [datetime] NOT NULL,
	[FechaModificacion_Equipo] [datetime] NULL,
	[Activo_Equipo] [bit] NULL CONSTRAINT [DF_TBL_EQUIPO_Activo_Equipo]  DEFAULT ((1)),
 CONSTRAINT [PK_TBL_EQUIPO] PRIMARY KEY CLUSTERED 
(
	[Id_Equipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_MARCA]    Script Date: 6/05/2018 23:04:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_MARCA](
	[ID_Marca] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion_Marca] [varchar](100) NOT NULL,
 CONSTRAINT [PK_TBL_MARCA] PRIMARY KEY CLUSTERED 
(
	[ID_Marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_ORDENTRABAJO]    Script Date: 6/05/2018 23:04:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_ORDENTRABAJO](
	[Id_OT] [int] IDENTITY(1,1) NOT NULL,
	[Numero_OT] [varchar](10) NULL,
	[Fecha_OT] [date] NOT NULL,
	[Estado_OT] [varchar](20) NOT NULL,
	[Descripcion_OT] [varchar](200) NOT NULL,
	[FechaRegiro_OT] [datetime] NOT NULL,
	[FechaModificacion_OT] [datetime] NULL,
 CONSTRAINT [PK_TBL_ORDENTRABAJO] PRIMARY KEY CLUSTERED 
(
	[Id_OT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_DETALLEORDENTRABAJO] ON 

GO
INSERT [dbo].[TBL_DETALLEORDENTRABAJO] ([Id_OTDetalle], [Id_OT], [Id_Equipo], [CantEquipo_OT]) VALUES (1, 1, 1, 1)
GO
INSERT [dbo].[TBL_DETALLEORDENTRABAJO] ([Id_OTDetalle], [Id_OT], [Id_Equipo], [CantEquipo_OT]) VALUES (2, 1, 3, 5)
GO
INSERT [dbo].[TBL_DETALLEORDENTRABAJO] ([Id_OTDetalle], [Id_OT], [Id_Equipo], [CantEquipo_OT]) VALUES (3, 2, 1, 3)
GO
INSERT [dbo].[TBL_DETALLEORDENTRABAJO] ([Id_OTDetalle], [Id_OT], [Id_Equipo], [CantEquipo_OT]) VALUES (4, 2, 2, 3)
GO
INSERT [dbo].[TBL_DETALLEORDENTRABAJO] ([Id_OTDetalle], [Id_OT], [Id_Equipo], [CantEquipo_OT]) VALUES (5, 3, 1, 2)
GO
INSERT [dbo].[TBL_DETALLEORDENTRABAJO] ([Id_OTDetalle], [Id_OT], [Id_Equipo], [CantEquipo_OT]) VALUES (6, 3, 3, 3)
GO
INSERT [dbo].[TBL_DETALLEORDENTRABAJO] ([Id_OTDetalle], [Id_OT], [Id_Equipo], [CantEquipo_OT]) VALUES (7, 4, 3, 1)
GO
INSERT [dbo].[TBL_DETALLEORDENTRABAJO] ([Id_OTDetalle], [Id_OT], [Id_Equipo], [CantEquipo_OT]) VALUES (8, 4, 1, 2)
GO
SET IDENTITY_INSERT [dbo].[TBL_DETALLEORDENTRABAJO] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_EQUIPO] ON 

GO
INSERT [dbo].[TBL_EQUIPO] ([Id_Equipo], [Descripcion_Equipo], [Id_Marca], [Modelo_Equipo], [Serie_Equipo], [CantComprometida_Equipo], [CantBase_Equipo], [FechaRegistro_Equipo], [FechaModificacion_Equipo], [Activo_Equipo]) VALUES (1, N'PERFORADORA', 2, N'DM M2', N'AVO 10A1271', 2, 25, CAST(N'2018-05-06 00:00:00.000' AS DateTime), CAST(N'2018-05-06 19:03:12.297' AS DateTime), 1)
GO
INSERT [dbo].[TBL_EQUIPO] ([Id_Equipo], [Descripcion_Equipo], [Id_Marca], [Modelo_Equipo], [Serie_Equipo], [CantComprometida_Equipo], [CantBase_Equipo], [FechaRegistro_Equipo], [FechaModificacion_Equipo], [Activo_Equipo]) VALUES (2, N'CARGADOR FRONTAL', 2, N'KJQH45', N'3TZ00254', 0, 25, CAST(N'2018-05-06 19:16:38.877' AS DateTime), NULL, 1)
GO
INSERT [dbo].[TBL_EQUIPO] ([Id_Equipo], [Descripcion_Equipo], [Id_Marca], [Modelo_Equipo], [Serie_Equipo], [CantComprometida_Equipo], [CantBase_Equipo], [FechaRegistro_Equipo], [FechaModificacion_Equipo], [Activo_Equipo]) VALUES (3, N'TRACTOR/CADENAS', 3, N'D10R', N'3KR01236', 1, 25, CAST(N'2018-05-06 19:18:08.650' AS DateTime), NULL, 1)
GO
SET IDENTITY_INSERT [dbo].[TBL_EQUIPO] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_MARCA] ON 

GO
INSERT [dbo].[TBL_MARCA] ([ID_Marca], [Descripcion_Marca]) VALUES (1, N'Atlas Copco')
GO
INSERT [dbo].[TBL_MARCA] ([ID_Marca], [Descripcion_Marca]) VALUES (2, N'CAT')
GO
INSERT [dbo].[TBL_MARCA] ([ID_Marca], [Descripcion_Marca]) VALUES (3, N'KOMATSU')
GO
INSERT [dbo].[TBL_MARCA] ([ID_Marca], [Descripcion_Marca]) VALUES (4, N'I/Rand')
GO
INSERT [dbo].[TBL_MARCA] ([ID_Marca], [Descripcion_Marca]) VALUES (5, N'Letourneau')
GO
INSERT [dbo].[TBL_MARCA] ([ID_Marca], [Descripcion_Marca]) VALUES (6, N'Sandvik')
GO
SET IDENTITY_INSERT [dbo].[TBL_MARCA] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_ORDENTRABAJO] ON 

GO
INSERT [dbo].[TBL_ORDENTRABAJO] ([Id_OT], [Numero_OT], [Fecha_OT], [Estado_OT], [Descripcion_OT], [FechaRegiro_OT], [FechaModificacion_OT]) VALUES (1, N'0000000001', CAST(N'2018-05-06' AS Date), N'Trabajado', N'prueba', CAST(N'2018-05-06 22:40:02.597' AS DateTime), CAST(N'2018-05-06 22:59:23.510' AS DateTime))
GO
INSERT [dbo].[TBL_ORDENTRABAJO] ([Id_OT], [Numero_OT], [Fecha_OT], [Estado_OT], [Descripcion_OT], [FechaRegiro_OT], [FechaModificacion_OT]) VALUES (2, N'0000000002', CAST(N'2018-05-06' AS Date), N'Trabajado', N'Prueba dos de registro', CAST(N'2018-05-06 22:53:46.373' AS DateTime), CAST(N'2018-05-06 22:59:29.667' AS DateTime))
GO
INSERT [dbo].[TBL_ORDENTRABAJO] ([Id_OT], [Numero_OT], [Fecha_OT], [Estado_OT], [Descripcion_OT], [FechaRegiro_OT], [FechaModificacion_OT]) VALUES (3, N'0000000003', CAST(N'2018-05-06' AS Date), N'Trabajado', N'Prueba 3 de registro', CAST(N'2018-05-06 23:00:24.983' AS DateTime), CAST(N'2018-05-06 23:00:45.727' AS DateTime))
GO
INSERT [dbo].[TBL_ORDENTRABAJO] ([Id_OT], [Numero_OT], [Fecha_OT], [Estado_OT], [Descripcion_OT], [FechaRegiro_OT], [FechaModificacion_OT]) VALUES (4, N'0000000004', CAST(N'2018-05-06' AS Date), N'Programado', N'Orden Trabajo 4', CAST(N'2018-05-06 23:01:26.237' AS DateTime), NULL)
GO
SET IDENTITY_INSERT [dbo].[TBL_ORDENTRABAJO] OFF
GO
/****** Object:  StoredProcedure [dbo].[SPD_Delete_Equipo]    Script Date: 6/05/2018 23:04:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SPD_Delete_Equipo]
@Id_Equipo as int
as
Update TBL_EQUIPO set Activo_Equipo= 0
GO
/****** Object:  StoredProcedure [dbo].[SPI_Insert_Equipo]    Script Date: 6/05/2018 23:04:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  Procedure  [dbo].[SPI_Insert_Equipo]
@Descripcion_Equipo as varchar(100),
@Id_Marca as int,
@Modelo_Equipo as varchar(50),
@Serie_Equipo as varchar(50),
@CantBase_Equipo as int
as
Insert Into TBL_Equipo( Descripcion_Equipo,Id_Marca,Modelo_Equipo,Serie_Equipo,CantBase_Equipo, FechaRegistro_Equipo)
Values( @Descripcion_Equipo,@Id_Marca,@Modelo_Equipo,@Serie_Equipo,@CantBase_Equipo, SYSDATETIME())
GO
/****** Object:  StoredProcedure [dbo].[SPI_Insertar_DetalleOrdenTrabajo]    Script Date: 6/05/2018 23:04:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SPI_Insertar_DetalleOrdenTrabajo]
@Id_OT as int,
@Id_Equipo int,
@CantEquipo_OT int
as
Insert Into TBL_DETALLEORDENTRABAJO(Id_OT,Id_Equipo,CantEquipo_OT) values(@Id_OT,@Id_Equipo,@CantEquipo_OT)
Update TBL_EQUIPO set CantComprometida_Equipo= (CantComprometida_Equipo+@CantEquipo_OT) where Id_Equipo=@Id_Equipo


GO
/****** Object:  StoredProcedure [dbo].[SPI_Insertar_OrdenTrabajo]    Script Date: 6/05/2018 23:04:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE Procedure [dbo].[SPI_Insertar_OrdenTrabajo]
@Descripcion_OT as varchar(200),
@Estado_OT as varchar(20),
@Id_OT as int out,
@NumeroOT as varchar(10) out
as
Insert Into TBL_ORDENTRABAJO (Fecha_OT,Estado_OT,Descripcion_OT,FechaRegiro_OT)Values(SYSDATETIME(),@Estado_OT,@Descripcion_OT,SYSDATETIME())
set @Id_OT = @@IDENTITY
set @NumeroOT=RIGHT('0000000000' + Ltrim(Rtrim(@Id_OT)),10)
Update  TBL_ORDENTRABAJO set Numero_OT=@NumeroOT  where Id_OT=@Id_OT

GO
/****** Object:  StoredProcedure [dbo].[SPS_Select_Equipo]    Script Date: 6/05/2018 23:04:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[SPS_Select_Equipo]
as
Select Id_Equipo, Descripcion_Equipo, e.Id_Marca,Modelo_Equipo, m.Descripcion_Marca, Serie_Equipo,CantBase_Equipo,CantComprometida_Equipo,
(CantBase_Equipo-CantComprometida_Equipo) as CantDisponible_Equipo ,Activo_Equipo
from TBL_EQUIPO e inner join TBL_MARCA m on e.Id_Marca= m.ID_Marca

GO
/****** Object:  StoredProcedure [dbo].[SPS_Select_Equipo_Busqueda]    Script Date: 6/05/2018 23:04:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SPS_Select_Equipo_Busqueda]
as
Select Id_Equipo, Descripcion_Equipo,Modelo_Equipo, m.Descripcion_Marca, Serie_Equipo,(CantBase_Equipo-CantComprometida_Equipo) as CantDisponible_Equipo
from TBL_EQUIPO e inner join TBL_MARCA m on e.Id_Marca= m.ID_Marca
where Activo_Equipo=1
GO
/****** Object:  StoredProcedure [dbo].[SPS_Select_Marca]    Script Date: 6/05/2018 23:04:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SPS_Select_Marca]
as
Select Id_Marca, Descripcion_Marca from TBL_MARCA
GO
/****** Object:  StoredProcedure [dbo].[SPS_Select_OrdeneTrabajo]    Script Date: 6/05/2018 23:04:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[SPS_Select_OrdeneTrabajo]
as
Select Id_OT, Numero_OT,Descripcion_OT, Fecha_OT, Estado_OT
 from TBL_ORDENTRABAJO 

GO
/****** Object:  StoredProcedure [dbo].[SPS_Select_OrdeneTrabajoDetalle]    Script Date: 6/05/2018 23:04:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SPS_Select_OrdeneTrabajoDetalle]
@Id_OT as int
as
Select dt.Id_Equipo, dt.CantEquipo_OT
from TBL_ORDENTRABAJO ot inner join TBL_DETALLEORDENTRABAJO dt on ot.Id_OT = dt.Id_OT
WHERE ot.Id_OT=@Id_OT

GO
/****** Object:  StoredProcedure [dbo].[SPU_Cambiar_Estado]    Script Date: 6/05/2018 23:04:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SPU_Cambiar_Estado]
@Id_Equipo as int,
@Estado as bit 
as
Update TBL_EQUIPO set Activo_Equipo= @Estado
GO
/****** Object:  StoredProcedure [dbo].[SPU_Update_Equipo]    Script Date: 6/05/2018 23:04:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SPU_Update_Equipo]
@Id_Equipo as int,
@Descripcion_Equipo as varchar(100),
@Id_Marca as int,
@Modelo_Equipo as varchar(50),
@Serie_Equipo as varchar(50),
@CantBase_Equipo as int
as
Update TBL_EQUIPO set Descripcion_Equipo=@Descripcion_Equipo, Id_Marca=@Id_Marca, Modelo_Equipo=@Modelo_Equipo,Serie_Equipo=@Serie_Equipo, CantBase_Equipo=@CantBase_Equipo,
FechaModificacion_Equipo= SYSDATETIME() 
Where Id_Equipo=@Id_Equipo

GO
/****** Object:  StoredProcedure [dbo].[SPU_Update_LiberarStockComprometidoEquipo]    Script Date: 6/05/2018 23:04:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SPU_Update_LiberarStockComprometidoEquipo]
@Id_Equipo as int,
@ID_CantidadLiberar as int
as
Update TBL_EQUIPO set CantComprometida_Equipo= (CantComprometida_Equipo-@ID_CantidadLiberar) where Id_Equipo=@Id_Equipo

GO
/****** Object:  StoredProcedure [dbo].[SPU_Update_OrdenTrabajo]    Script Date: 6/05/2018 23:04:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SPU_Update_OrdenTrabajo]
@Estado_OT as varchar(20),
@Id_OT int
as
Update TBL_ORDENTRABAJO set Estado_OT=@Estado_OT,FechaModificacion_OT=SYSDATETIME() where Id_OT=@Id_OT
GO
