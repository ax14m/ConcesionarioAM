USE [master]
GO
/****** Object:  Database [concesionario]    Script Date: 10/11/2020 4:35:20 p.m. ******/
CREATE DATABASE [concesionario]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'concesionario', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\concesionario.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'concesionario_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\concesionario_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [concesionario] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [concesionario].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [concesionario] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [concesionario] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [concesionario] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [concesionario] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [concesionario] SET ARITHABORT OFF 
GO
ALTER DATABASE [concesionario] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [concesionario] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [concesionario] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [concesionario] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [concesionario] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [concesionario] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [concesionario] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [concesionario] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [concesionario] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [concesionario] SET  DISABLE_BROKER 
GO
ALTER DATABASE [concesionario] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [concesionario] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [concesionario] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [concesionario] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [concesionario] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [concesionario] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [concesionario] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [concesionario] SET RECOVERY FULL 
GO
ALTER DATABASE [concesionario] SET  MULTI_USER 
GO
ALTER DATABASE [concesionario] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [concesionario] SET DB_CHAINING OFF 
GO
ALTER DATABASE [concesionario] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [concesionario] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [concesionario] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'concesionario', N'ON'
GO
ALTER DATABASE [concesionario] SET QUERY_STORE = OFF
GO
USE [concesionario]
GO
/****** Object:  Table [dbo].[conductor]    Script Date: 10/11/2020 4:35:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[conductor](
	[id] [int] NOT NULL,
	[nombre] [varchar](25) NULL,
	[tipo_licencia] [nchar](10) NULL,
	[id_vehiculo] [int] NOT NULL,
	[id_tipo_conductor] [int] NOT NULL,
 CONSTRAINT [PK_conductor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[contrato]    Script Date: 10/11/2020 4:35:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[contrato](
	[id] [int] NOT NULL,
	[id_conductor] [int] NOT NULL,
	[id_vehiculo] [int] NOT NULL,
 CONSTRAINT [PK_contrato] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ruta]    Script Date: 10/11/2020 4:35:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ruta](
	[id] [int] NOT NULL,
	[estacion] [varchar](25) NULL,
	[id_vehiculo] [int] NOT NULL,
 CONSTRAINT [PK_ruta] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_conductor]    Script Date: 10/11/2020 4:35:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_conductor](
	[id] [int] NOT NULL,
	[tipo_persona] [varchar](25) NULL,
 CONSTRAINT [PK_tipo_conductor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Vehiculo]    Script Date: 10/11/2020 4:35:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Vehiculo](
	[id] [int] NOT NULL,
	[nombre] [nchar](25) NULL,
 CONSTRAINT [PK_Tipo_Vehiculo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculo]    Script Date: 10/11/2020 4:35:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculo](
	[id] [int] NOT NULL,
	[marca] [varchar](50) NULL,
	[modelo] [varchar](25) NULL,
	[matricula] [varchar](6) NULL,
	[año] [int] NULL,
	[id_tipo_vehiculo] [int] NOT NULL,
 CONSTRAINT [PK_Vehiculo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Tipo_Vehiculo] ([id], [nombre]) VALUES (1, N'camion                   ')
GO
INSERT [dbo].[Tipo_Vehiculo] ([id], [nombre]) VALUES (4, N'Motocicleta              ')
GO
ALTER TABLE [dbo].[conductor]  WITH CHECK ADD  CONSTRAINT [FK_conductor_contrato] FOREIGN KEY([id_vehiculo])
REFERENCES [dbo].[contrato] ([id])
GO
ALTER TABLE [dbo].[conductor] CHECK CONSTRAINT [FK_conductor_contrato]
GO
ALTER TABLE [dbo].[conductor]  WITH CHECK ADD  CONSTRAINT [FK_conductor_tipo_conductor] FOREIGN KEY([id_vehiculo])
REFERENCES [dbo].[tipo_conductor] ([id])
GO
ALTER TABLE [dbo].[conductor] CHECK CONSTRAINT [FK_conductor_tipo_conductor]
GO
ALTER TABLE [dbo].[ruta]  WITH CHECK ADD  CONSTRAINT [FK_ruta_Vehiculo1] FOREIGN KEY([id])
REFERENCES [dbo].[Vehiculo] ([id])
GO
ALTER TABLE [dbo].[ruta] CHECK CONSTRAINT [FK_ruta_Vehiculo1]
GO
ALTER TABLE [dbo].[Vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculo_contrato] FOREIGN KEY([id])
REFERENCES [dbo].[contrato] ([id])
GO
ALTER TABLE [dbo].[Vehiculo] CHECK CONSTRAINT [FK_Vehiculo_contrato]
GO
ALTER TABLE [dbo].[Vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculo_Tipo_Vehiculo] FOREIGN KEY([id_tipo_vehiculo])
REFERENCES [dbo].[Tipo_Vehiculo] ([id])
GO
ALTER TABLE [dbo].[Vehiculo] CHECK CONSTRAINT [FK_Vehiculo_Tipo_Vehiculo]
GO
/****** Object:  StoredProcedure [dbo].[addTipoVehiculo]    Script Date: 10/11/2020 4:35:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[addTipoVehiculo]
(
	@id int,
	@nombre varchar(25)
)

as insert into  Tipo_Vehiculo values(@id, @nombre)
GO
/****** Object:  StoredProcedure [dbo].[addVehiculo]    Script Date: 10/11/2020 4:35:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[addVehiculo] 

(

@id int,
@marca varchar(25),
@modelo varchar (25),
@placa varchar (6),
@anio varchar (25),
@id_tipo_vehiculo int

)

as insert into Vehiculo values (@id,@marca,@modelo,@placa,@anio,@id_tipo_vehiculo)
GO
/****** Object:  StoredProcedure [dbo].[deleteTipoVehiculo]    Script Date: 10/11/2020 4:35:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[deleteTipoVehiculo]
@id int

as
begin
DELETE

from Tipo_Vehiculo
where id = @id

end
GO
/****** Object:  StoredProcedure [dbo].[updateTipoVehiculo]    Script Date: 10/11/2020 4:35:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[updateTipoVehiculo]
@id int,
@nombre nchar(25)

as
begin
UPDATE Tipo_Vehiculo
 set
 id = @id,
	nombre= @nombre
	where   id = @id
end
GO
USE [master]
GO
ALTER DATABASE [concesionario] SET  READ_WRITE 
GO
