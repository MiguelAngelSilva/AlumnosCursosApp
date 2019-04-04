USE [master]
GO


/****** Object:  Database [TecsoLoggerDB]    Script Date: 3/4/2019 04:25:37 ******/
CREATE DATABASE [TecsoLoggerDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TecsoLoggerDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\TecsoLoggerDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TecsoLoggerDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\TecsoLoggerDB_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [TecsoLoggerDB] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TecsoLoggerDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [TecsoLoggerDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [TecsoLoggerDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [TecsoLoggerDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [TecsoLoggerDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [TecsoLoggerDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [TecsoLoggerDB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [TecsoLoggerDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [TecsoLoggerDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [TecsoLoggerDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [TecsoLoggerDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [TecsoLoggerDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [TecsoLoggerDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [TecsoLoggerDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [TecsoLoggerDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [TecsoLoggerDB] SET  DISABLE_BROKER 
GO

ALTER DATABASE [TecsoLoggerDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [TecsoLoggerDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [TecsoLoggerDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [TecsoLoggerDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [TecsoLoggerDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [TecsoLoggerDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [TecsoLoggerDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [TecsoLoggerDB] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [TecsoLoggerDB] SET  MULTI_USER 
GO

ALTER DATABASE [TecsoLoggerDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [TecsoLoggerDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [TecsoLoggerDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [TecsoLoggerDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [TecsoLoggerDB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [TecsoLoggerDB] SET  READ_WRITE 
GO

