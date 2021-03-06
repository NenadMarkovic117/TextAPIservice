USE [master]
GO
/****** Object:  Database [Task_AM]    Script Date: 7/15/2022 8:50:41 PM ******/
CREATE DATABASE [Task_AM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Task_AM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Task_AM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Task_AM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Task_AM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Task_AM] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Task_AM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Task_AM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Task_AM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Task_AM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Task_AM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Task_AM] SET ARITHABORT OFF 
GO
ALTER DATABASE [Task_AM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Task_AM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Task_AM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Task_AM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Task_AM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Task_AM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Task_AM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Task_AM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Task_AM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Task_AM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Task_AM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Task_AM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Task_AM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Task_AM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Task_AM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Task_AM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Task_AM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Task_AM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Task_AM] SET  MULTI_USER 
GO
ALTER DATABASE [Task_AM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Task_AM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Task_AM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Task_AM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Task_AM] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Task_AM] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Task_AM] SET QUERY_STORE = OFF
GO
USE [Task_AM]
GO
/****** Object:  Table [dbo].[UserText]    Script Date: 7/15/2022 8:50:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserText](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TEXT] [varchar](1000) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[UserText] ON 

INSERT [dbo].[UserText] ([ID], [TEXT]) VALUES (1, N'test 1')
INSERT [dbo].[UserText] ([ID], [TEXT]) VALUES (2, N'this is just one of texts')
INSERT [dbo].[UserText] ([ID], [TEXT]) VALUES (3, N'this is just two of those texts')
INSERT [dbo].[UserText] ([ID], [TEXT]) VALUES (4, N'test 4')
INSERT [dbo].[UserText] ([ID], [TEXT]) VALUES (5, N'pera je mikin brat')
INSERT [dbo].[UserText] ([ID], [TEXT]) VALUES (6, N'mika je lazin brat')
SET IDENTITY_INSERT [dbo].[UserText] OFF
GO
USE [master]
GO
ALTER DATABASE [Task_AM] SET  READ_WRITE 
GO
