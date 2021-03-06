USE [master]
GO
/****** Object:  Database [CBA_PMINT]    Script Date: 10/25/2017 12:26:39 PM ******/
CREATE DATABASE [CBA_PMINT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CBA_PMINT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\CBA_PMINT.mdf' , SIZE = 14528KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CBA_PMINT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\CBA_PMINT_log.ldf' , SIZE = 3520KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CBA_PMINT] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CBA_PMINT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CBA_PMINT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CBA_PMINT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CBA_PMINT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CBA_PMINT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CBA_PMINT] SET ARITHABORT OFF 
GO
ALTER DATABASE [CBA_PMINT] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CBA_PMINT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CBA_PMINT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CBA_PMINT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CBA_PMINT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CBA_PMINT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CBA_PMINT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CBA_PMINT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CBA_PMINT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CBA_PMINT] SET DISABLE_BROKER 
GO
ALTER DATABASE [CBA_PMINT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CBA_PMINT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CBA_PMINT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CBA_PMINT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CBA_PMINT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CBA_PMINT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CBA_PMINT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CBA_PMINT] SET RECOVERY FULL 
GO
ALTER DATABASE [CBA_PMINT] SET  MULTI_USER 
GO
ALTER DATABASE [CBA_PMINT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CBA_PMINT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CBA_PMINT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CBA_PMINT] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [CBA_PMINT] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CBA_PMINT', N'ON'
GO
USE [CBA_PMINT]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Adm Agency]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adm Agency](
	[ID] [smallint] NOT NULL DEFAULT ((0)),
	[Agency] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Adm Agency] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Adm Asset Type]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adm Asset Type](
	[ID] [smallint] NOT NULL DEFAULT ((0)),
	[Asset Type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Adm Asset Type] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Adm Clearance Status]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adm Clearance Status](
	[ID] [smallint] NOT NULL CONSTRAINT [DF__Adm Contract__ID__75A278F5]  DEFAULT ((0)),
	[Clearance Status] [nvarchar](50) NOT NULL,
 CONSTRAINT [Adm Contract Status$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Adm Contract Vehicle]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adm Contract Vehicle](
	[ID] [smallint] NOT NULL DEFAULT ((0)),
	[Vehicle Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Adm Contract Vehicle] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Adm Degree]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adm Degree](
	[ID] [smallint] NOT NULL CONSTRAINT [DF__Adm Degree__ID__76969D2E]  DEFAULT ((0)),
	[Degree] [nvarchar](25) NULL,
	[Offset] [int] NULL CONSTRAINT [DF__Adm Degre__Offse__778AC167]  DEFAULT ((0)),
 CONSTRAINT [Adm Degree$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Adm Exit Reason]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adm Exit Reason](
	[ID] [smallint] NOT NULL DEFAULT ((0)),
	[Exit Reason] [nvarchar](100) NOT NULL,
 CONSTRAINT [Ref Exit Reason$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Adm Info Risk]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adm Info Risk](
	[ID] [smallint] NOT NULL DEFAULT ((0)),
	[Info Risk] [nvarchar](50) NOT NULL,
 CONSTRAINT [Adm Clearance$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Adm Prefix]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adm Prefix](
	[Prefix] [nvarchar](5) NOT NULL,
 CONSTRAINT [PK_Adm Prefix] PRIMARY KEY CLUSTERED 
(
	[Prefix] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Adm Proficiency]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adm Proficiency](
	[Proficiency ID] [smallint] NOT NULL DEFAULT ((0)),
	[Proficiency] [nvarchar](20) NULL,
 CONSTRAINT [PK_Adm Proficiency] PRIMARY KEY CLUSTERED 
(
	[Proficiency ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Adm Requisition Status]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adm Requisition Status](
	[ID] [smallint] NOT NULL DEFAULT ((0)),
	[Status] [nvarchar](25) NOT NULL,
 CONSTRAINT [Adm Requisition Status$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Adm Resume Status]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adm Resume Status](
	[ID] [smallint] NOT NULL DEFAULT ((0)),
	[Status] [nvarchar](25) NOT NULL,
 CONSTRAINT [Adm Resume Status$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Adm Security Clearance]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adm Security Clearance](
	[ID] [smallint] NOT NULL DEFAULT ((0)),
	[Security Clearance] [nvarchar](50) NULL,
	[Security Clearance Abbreviation] [nvarchar](10) NULL,
 CONSTRAINT [PK_Adm Security Clearance] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Adm Suffix]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adm Suffix](
	[Suffix] [nvarchar](5) NOT NULL,
 CONSTRAINT [PK_Adm Suffix] PRIMARY KEY CLUSTERED 
(
	[Suffix] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[UserId] [nvarchar](128) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AspNetUsers] (
    [Id]                   NVARCHAR (128)  NOT NULL,
    [Email]                NVARCHAR (256)  NULL,
    [EmailConfirmed]       BIT             NOT NULL,
    [PasswordHash]         NVARCHAR (MAX)  NULL,
    [SecurityStamp]        NVARCHAR (MAX)  NULL,
    [PhoneNumber]          NVARCHAR (MAX)  NULL,
    [PhoneNumberConfirmed] BIT             NOT NULL,
    [TwoFactorEnabled]     BIT             NOT NULL,
    [LockoutEndDateUtc]    DATETIME        NULL,
    [LockoutEnabled]       BIT             NOT NULL,
    [AccessFailedCount]    INT             NOT NULL,
    [UserName]             NVARCHAR (256)  NOT NULL,
    [FirstName]            NVARCHAR (MAX)  NULL,
    [LastName]             NVARCHAR (MAX)  NULL,
    [userRole]             NVARCHAR (MAX)  NULL,
    [ProfilePicture]       VARBINARY (MAX) NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex]
    ON [dbo].[AspNetUsers]([UserName] ASC);

GO
/****** Object:  Table [dbo].[Certifications]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Certifications](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Staff ID] [int] NOT NULL,
	[Certification] [nvarchar](50) NOT NULL,
	[Issuing Agency] [nvarchar](50) NOT NULL,
	[Certification ID] [nvarchar](25) NULL,
	[Date Issued] [datetime2](0) NOT NULL,
	[Expiration Date] [datetime2](0) NULL,
	[Created On] [datetime2](7) NOT NULL,
	[Created By] [nvarchar](max) NOT NULL,
	[Modified On] [datetime2](7) NOT NULL,
	[Modified By] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Cetifications] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Contract]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contract](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Customer ID] [int] NOT NULL,
	[POP Start] [datetime2](0) NOT NULL,
	[POP End] [datetime2](0) NOT NULL,
	[Program Manager ID] [int] NOT NULL,
	[IsPrime] [bit] NOT NULL,
	[FillByDuration] [smallint] NULL,
	[Created On] [datetime2](7) NOT NULL,
	[Created By] [nvarchar](max) NOT NULL,
	[Modified On] [datetime2](7) NOT NULL,
	[Modified By] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Contract] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Contract Position]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contract Position](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Contract ID] [int] NOT NULL,
	[Role ID] [int] NOT NULL,
	[Contract WBS ID] [nchar](10) NULL,
	[Position #] [smallint] NOT NULL,
	[Info Risk ID] [smallint] NOT NULL,
	[LCAT ID] [int] NOT NULL,
	[DateNeeded] [datetime2](7) NULL,
	[Requisition Status ID] [smallint] NOT NULL,
	[Required Security Clearance ID] [smallint] NULL,
	[Created On] [datetime2](7) NOT NULL,
	[Created By] [nvarchar](max) NOT NULL,
	[Modified On] [datetime2](7) NOT NULL,
	[Modified By] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Contract Position] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Contract WBS]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contract WBS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Contract ID] [int] NOT NULL,
	[Area] [nvarchar](50) NOT NULL,
	[Level 1] [nchar](2) NULL,
	[Level 2] [nchar](2) NULL,
	[Level 3] [nchar](2) NULL,
	[Level 4] [nchar](2) NULL,
	[Level 5] [nchar](2) NULL,
	[Created On] [datetime2](7) NOT NULL,
	[Created By] [nvarchar](max) NOT NULL,
	[Modified On] [datetime2](7) NOT NULL,
	[Modified By] [nvarchar](max) NOT NULL,
 CONSTRAINT [Adm Area$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Education]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Education](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Staff ID] [int] NOT NULL,
	[School] [nvarchar](100) NOT NULL,
	[Degree ID] [smallint] NOT NULL,
	[Completed Date] [datetime2](0) NOT NULL,
	[Created On] [datetime2](7) NOT NULL,
	[Created By] [nvarchar](max) NOT NULL,
	[Modified On] [datetime2](7) NOT NULL,
	[Modified By] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Education] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Position Forecast]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Position Forecast](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Contract Position ID] [int] NULL,
	[Pay Period ID] [int] NULL,
	[FTE] [decimal](5, 2) NULL,
	[Hours] [decimal](5, 2) NULL,
	[Created On] [datetime2](7) NOT NULL,
	[Created By] [nvarchar](max) NOT NULL,
	[Modified On] [datetime2](7) NOT NULL,
	[Modified By] [nvarchar](max) NOT NULL,
 CONSTRAINT [Requisition Hours$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ref Asset]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ref Asset](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Asset Name] [nvarchar](50) NOT NULL,
	[Asset Type ID] [smallint] NOT NULL,
 CONSTRAINT [PK_Ref Asset] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ref Company]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ref Company](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Company] [nvarchar](50) NOT NULL,
 CONSTRAINT [Ref Company$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ref Contract LCAT]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ref Contract LCAT](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Contract ID] [int] NULL,
	[Vehicle LCAT ID] [int] NULL,
	[ESF LCAT] [nvarchar](100) NULL,
	[Description] [nvarchar](1000) NULL,
	[Years of Experience with Degree] [smallint] NULL,
 CONSTRAINT [Ref LCAT$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ref Contract Vehicle LCAT]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ref Contract Vehicle LCAT](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Contract Vehicle ID] [smallint] NOT NULL,
	[LCAT] [nvarchar](50) NOT NULL,
	[LCAT Description] [nvarchar](1000) NOT NULL,
	[Years of Experience with Degree] [smallint] NOT NULL,
	[Degree ID] [smallint] NOT NULL,
 CONSTRAINT [PK_Ref Vehicle LCAT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ref Customer]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ref Customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Customer] [nvarchar](50) NULL,
	[Agency ID] [smallint] NULL,
 CONSTRAINT [PK_Ref Customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ref Pay Period]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ref Pay Period](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Period #] [smallint] NULL,
	[Year] [smallint] NULL,
	[Month] [smallint] NULL,
	[Start] [datetime2](0) NULL,
	[End] [datetime2](0) NULL,
 CONSTRAINT [Ref Pay Period$ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ref Role]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ref Role](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Role] [nvarchar](100) NOT NULL,
 CONSTRAINT [Ref Role$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ref Skill]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ref Skill](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Skill] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Ref Skill] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ref Telework Agreement]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ref Telework Agreement](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Telework Agreement] [nvarchar](255) NULL,
 CONSTRAINT [Ref Telework Agreement Type$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ref Training]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ref Training](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Contract ID] [int] NULL,
	[Training] [nvarchar](100) NOT NULL,
	[Date Due] [datetime2](0) NOT NULL,
	[Instructions] [nvarchar](max) NULL,
 CONSTRAINT [PK_Ref Training] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Security Workflow]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Security Workflow](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Contract ID] [int] NOT NULL,
	[Display Order] [smallint] NOT NULL,
	[Workflow] [nvarchar](50) NOT NULL,
	[Always Display] [bit] NOT NULL,
	[Clearance Status ID] [smallint] NOT NULL,
	[Created On] [datetime2](7) NOT NULL,
	[Created By] [nvarchar](max) NOT NULL,
	[Modified On] [datetime2](7) NOT NULL,
	[Modified By] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Contract Security Workflow] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Staff]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Staff](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Person Key] [int] NULL,
	[Company ID] [int] NOT NULL,
	[Staff Name]  AS (([Last Name]+', ')+[First Name]) PERSISTED,
	[Prefix] [nvarchar](5) NULL,
	[Last Name] [nvarchar](25) NOT NULL,
	[First Name] [nvarchar](25) NULL,
	[Middle Initial] [nvarchar](2) NULL,
	[Suffix] [nvarchar](5) NULL,
	[Alias] [nvarchar](50) NULL,
	[Location] [nvarchar](50) NULL,
	[Cell Phone] [nchar](10) NULL,
	[Personal Cell Phone] [nchar](10) NULL,
	[Desk Phone] [nchar](10) NULL,
	[Company Email] [nvarchar](100) NULL,
	[IsForeign National] [bit] NULL CONSTRAINT [DF_Staff_IsForeign National]  DEFAULT ((0)),
	[IsBillable] [bit] NULL CONSTRAINT [DF_Staff_IsExempt]  DEFAULT ((0)),
	[Years of Experience] [smallint] NOT NULL CONSTRAINT [DF_Staff_Years of Experience]  DEFAULT ((0)),
	[Hire Date] [datetime2](0) NULL,
	[Exit Date] [datetime2](0) NULL,
	[Exit Note] [nvarchar](max) NULL,
	[Exit Reason ID] [smallint] NULL,
	[Is Eligible for Rehire] [bit] NULL CONSTRAINT [DF_Staff_Is Eligible for Rehire]  DEFAULT ((0)),
	[Created On] [datetime2](7) NULL,
	[Created By] [nvarchar](max) NULL,
	[Modified On] [datetime2](7) NULL,
	[Modified By] [nvarchar](max) NULL,
 CONSTRAINT [Staff$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Staff Asset]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff Asset](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Staff ID] [int] NOT NULL,
	[Contract ID] [int] NULL,
	[Asset ID] [int] NOT NULL,
	[Item Number] [nvarchar](25) NULL,
	[Date Issued] [datetime2](0) NULL,
	[Date Returrned] [datetime2](0) NULL,
	[Notes] [nvarchar](max) NULL,
	[Created On] [datetime2](7) NOT NULL,
	[Created By] [nvarchar](max) NOT NULL,
	[Modified On] [datetime2](7) NOT NULL,
	[Modified By] [nvarchar](max) NOT NULL
 CONSTRAINT [PK_Staff Asset] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Staff Clearance]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff Clearance](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Staff ID] [int] NULL,
	[Security Clearance ID] [smallint] NULL,
	[Date Authorized] [datetime2](0) NULL,
	[Contract ID] [int] NULL,
	[Created On] [datetime2](7) NOT NULL,
	[Created By] [nvarchar](max) NOT NULL,
	[Modified On] [datetime2](7) NOT NULL,
	[Modified By] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Staff Clearance] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Staff Clearance Workflow]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff Clearance Workflow](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Staff Clearance ID] [int] NOT NULL,
	[Security Workflow ID] [int] NOT NULL,
	[Is Active] [bit] NOT NULL,
	[Entry Date] [datetime2](0) NOT NULL,
	[Exit Date] [datetime2](0) NOT NULL,
	[Created On] [datetime2](7) NOT NULL,
	[Created By] [nvarchar](max) NOT NULL,
	[Modified On] [datetime2](7) NOT NULL,
	[Modified By] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Security Clearance] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Staff Position]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff Position](
	[Staff ID] [int] IDENTITY(1,1) NOT NULL,
	[Contract Position ID] [int] NOT NULL,
	[IsActive] [bit] NULL,
	[Planned Start Date] [datetime2](0) NULL,
	[Active Start Date] [datetime2](0) NULL,
	[Active End Date] [datetime2](0) NULL,
	[Telework Agreement ID] [int] NULL,
	[Resume Status ID] [smallint] NULL,
	[Is Resume Compliant] [bit] NULL,
	[Is LCAT Compliant] [bit] NULL,
	[Compliance Notes] [nvarchar](max) NULL,
	[Email Address] [nvarchar](100) NULL,
	[Desk Phone] [nchar](10) NULL,
	[Cell Phone] [nchar](10) NULL,
	[Created On] [datetime2](7) NOT NULL,
	[Created By] [nvarchar](max) NOT NULL,
	[Modified On] [datetime2](7) NOT NULL,
	[Modified By] [nvarchar](max) NOT NULL,
 CONSTRAINT [Staff Position$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[Staff ID] ASC,
	[Contract Position ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Staff Skill]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff Skill](
	[Staff ID] [int] NOT NULL,
	[Skill ID] [int] NOT NULL,
	[Proficiency ID] [smallint] NOT NULL,
	[Created On] [datetime2](7) NOT NULL,
	[Created By] [nvarchar](max) NOT NULL,
	[Modified On] [datetime2](7) NOT NULL,
	[Modified By] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Staff Skill] PRIMARY KEY CLUSTERED 
(
	[Staff ID] ASC,
	[Skill ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Staff Training]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff Training](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Staff ID] [int] NOT NULL,
	[Training ID] [int] NOT NULL,
	[Date Completed] [datetime2](0) NULL,
	[Created On] [datetime2](7) NOT NULL,
	[Created By] [nvarchar](max) NOT NULL,
	[Modified On] [datetime2](7) NOT NULL,
	[Modified By] [nvarchar](max) NOT NULL
 CONSTRAINT [PK_Staff Training] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Workshare]    Script Date: 10/25/2017 12:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Workshare](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Contract Position ID] [int] NULL,
	[Company ID] [int] NULL,
	[Date Released] [datetime] NULL,
	[IsPrimary] [bit] NULL,
	[Created On] [datetime2](7) NOT NULL,
	[Created By] [nvarchar](max) NOT NULL,
	[Modified On] [datetime2](7) NOT NULL,
	[Modified By] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Workshare] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Index [Adm Contract Status$ID]    Script Date: 10/25/2017 12:26:39 PM ******/
CREATE NONCLUSTERED INDEX [Adm Contract Status$ID] ON [dbo].[Adm Clearance Status]
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [Adm Degree$Degree]    Script Date: 10/25/2017 12:26:39 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [Adm Degree$Degree] ON [dbo].[Adm Degree]
(
	[Degree] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [Adm Requisition Status$Status]    Script Date: 10/25/2017 12:26:39 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [Adm Requisition Status$Status] ON [dbo].[Adm Requisition Status]
(
	[Status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [Adm Resume Status$Status]    Script Date: 10/25/2017 12:26:39 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [Adm Resume Status$Status] ON [dbo].[Adm Resume Status]
(
	[Status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 10/25/2017 12:26:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 10/25/2017 12:26:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_RoleId]    Script Date: 10/25/2017 12:26:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 10/25/2017 12:26:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserRoles]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [Adm Area$Area]    Script Date: 10/25/2017 12:26:39 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [Adm Area$Area] ON [dbo].[Contract WBS]
(
	[Area] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Requisition Hours$Composite]    Script Date: 10/25/2017 12:26:39 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [Requisition Hours$Composite] ON [dbo].[Position Forecast]
(
	[Contract Position ID] ASC,
	[Pay Period ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Requisition Hours$Ref Pay PeriodRequisition Hours]    Script Date: 10/25/2017 12:26:39 PM ******/
CREATE NONCLUSTERED INDEX [Requisition Hours$Ref Pay PeriodRequisition Hours] ON [dbo].[Position Forecast]
(
	[Pay Period ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Requisition Hours$RequisitionRequisition Hours]    Script Date: 10/25/2017 12:26:39 PM ******/
CREATE NONCLUSTERED INDEX [Requisition Hours$RequisitionRequisition Hours] ON [dbo].[Position Forecast]
(
	[Contract Position ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [Ref Company$NORM_OrderByIndex]    Script Date: 10/25/2017 12:26:39 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [Ref Company$NORM_OrderByIndex] ON [dbo].[Ref Company]
(
	[Company] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Ref Pay Period$YearMonthStart]    Script Date: 10/25/2017 12:26:39 PM ******/
CREATE NONCLUSTERED INDEX [Ref Pay Period$YearMonthStart] ON [dbo].[Ref Pay Period]
(
	[Year] ASC,
	[Month] ASC,
	[Start] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Ref Role$ID]    Script Date: 10/25/2017 12:26:39 PM ******/
CREATE NONCLUSTERED INDEX [Ref Role$ID] ON [dbo].[Ref Role]
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [Ref Role$Role]    Script Date: 10/25/2017 12:26:39 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [Ref Role$Role] ON [dbo].[Ref Role]
(
	[Role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Staff$Company ID]    Script Date: 10/25/2017 12:26:39 PM ******/
CREATE NONCLUSTERED INDEX [Staff$Company ID] ON [dbo].[Staff]
(
	[Company ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [Staff$Last Name]    Script Date: 10/25/2017 12:26:39 PM ******/
CREATE NONCLUSTERED INDEX [Staff$Last Name] ON [dbo].[Staff]
(
	[Last Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Staff$Ref CompanyStaff]    Script Date: 10/25/2017 12:26:39 PM ******/
CREATE NONCLUSTERED INDEX [Staff$Ref CompanyStaff] ON [dbo].[Staff]
(
	[Company ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ARITHABORT ON
SET CONCAT_NULL_YIELDS_NULL ON
SET QUOTED_IDENTIFIER ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
SET NUMERIC_ROUNDABORT OFF

GO
/****** Object:  Index [Staff$Staff Name]    Script Date: 10/25/2017 12:26:39 PM ******/
CREATE NONCLUSTERED INDEX [Staff$Staff Name] ON [dbo].[Staff]
(
	[Staff Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Staff Position$Position ID]    Script Date: 10/25/2017 12:26:39 PM ******/
CREATE NONCLUSTERED INDEX [Staff Position$Position ID] ON [dbo].[Staff Position]
(
	[Contract Position ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Staff Position$PositionStaff Position]    Script Date: 10/25/2017 12:26:39 PM ******/
CREATE NONCLUSTERED INDEX [Staff Position$PositionStaff Position] ON [dbo].[Staff Position]
(
	[Contract Position ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Staff Position$Staff ID]    Script Date: 10/25/2017 12:26:39 PM ******/
CREATE NONCLUSTERED INDEX [Staff Position$Staff ID] ON [dbo].[Staff Position]
(
	[Staff ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Staff Position$StaffStaff Position]    Script Date: 10/25/2017 12:26:39 PM ******/
CREATE NONCLUSTERED INDEX [Staff Position$StaffStaff Position] ON [dbo].[Staff Position]
(
	[Staff ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Contract Position] ADD  CONSTRAINT [DF_Contract Position_Position #]  DEFAULT ((1)) FOR [Position #]
GO
ALTER TABLE [dbo].[Position Forecast] ADD  CONSTRAINT [DF__Requisiti__Hours__0E6E26BF]  DEFAULT ((0)) FOR [Hours]
GO
ALTER TABLE [dbo].[Ref Training] ADD  CONSTRAINT [DF_Ref Training_Contract ID]  DEFAULT ((0)) FOR [Contract ID]
GO
ALTER TABLE [dbo].[Security Workflow] ADD  CONSTRAINT [DF_Contract Security Workflow_Always Display]  DEFAULT ((0)) FOR [Always Display]
GO
ALTER TABLE [dbo].[Staff Position] ADD  CONSTRAINT [DF__Staff Pos__IsAct__4E53A1AA]  DEFAULT ((0)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Staff Position] ADD  CONSTRAINT [DF__Staff Pos__Is Re__4F47C5E3]  DEFAULT ((0)) FOR [Is Resume Compliant]
GO
ALTER TABLE [dbo].[Staff Position] ADD  CONSTRAINT [DF__Staff Pos__Is LC__503BEA1C]  DEFAULT ((0)) FOR [Is LCAT Compliant]
GO
ALTER TABLE [dbo].[Staff Skill] ADD  CONSTRAINT [DF_Staff Skill_Proficiency ID]  DEFAULT ((0)) FOR [Proficiency ID]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Certifications]  WITH CHECK ADD  CONSTRAINT [FK_Cetifications_Staff] FOREIGN KEY([Staff ID])
REFERENCES [dbo].[Staff] ([ID])
GO
ALTER TABLE [dbo].[Certifications] CHECK CONSTRAINT [FK_Cetifications_Staff]
GO
ALTER TABLE [dbo].[Contract]  WITH CHECK ADD  CONSTRAINT [FK_Contract_Ref Customer] FOREIGN KEY([Customer ID])
REFERENCES [dbo].[Ref Customer] ([ID])
GO
ALTER TABLE [dbo].[Contract] CHECK CONSTRAINT [FK_Contract_Ref Customer]
GO
ALTER TABLE [dbo].[Contract]  WITH NOCHECK ADD  CONSTRAINT [FK_Contract_Staff] FOREIGN KEY([Program Manager ID])
REFERENCES [dbo].[Staff] ([ID])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Contract] NOCHECK CONSTRAINT [FK_Contract_Staff]
GO
ALTER TABLE [dbo].[Contract Position]  WITH CHECK ADD  CONSTRAINT [FK_Contract Position_Adm Info Risk] FOREIGN KEY([Info Risk ID])
REFERENCES [dbo].[Adm Info Risk] ([ID])
GO
ALTER TABLE [dbo].[Contract Position] CHECK CONSTRAINT [FK_Contract Position_Adm Info Risk]
GO
ALTER TABLE [dbo].[Contract Position]  WITH CHECK ADD  CONSTRAINT [FK_Contract Position_Adm Requisition Status] FOREIGN KEY([Requisition Status ID])
REFERENCES [dbo].[Adm Requisition Status] ([ID])
GO
ALTER TABLE [dbo].[Contract Position] CHECK CONSTRAINT [FK_Contract Position_Adm Requisition Status]
GO
ALTER TABLE [dbo].[Contract Position]  WITH CHECK ADD  CONSTRAINT [FK_Contract Position_Adm Security Clearance] FOREIGN KEY([Required Security Clearance ID])
REFERENCES [dbo].[Adm Security Clearance] ([ID])
GO
ALTER TABLE [dbo].[Contract Position] CHECK CONSTRAINT [FK_Contract Position_Adm Security Clearance]
GO
ALTER TABLE [dbo].[Contract Position]  WITH CHECK ADD  CONSTRAINT [FK_Contract Position_Contract WBS] FOREIGN KEY([Contract ID])
REFERENCES [dbo].[Contract WBS] ([ID])
GO
ALTER TABLE [dbo].[Contract Position] CHECK CONSTRAINT [FK_Contract Position_Contract WBS]
GO
ALTER TABLE [dbo].[Contract Position]  WITH CHECK ADD  CONSTRAINT [FK_Contract Position_Contract1] FOREIGN KEY([Contract ID])
REFERENCES [dbo].[Contract] ([ID])
GO
ALTER TABLE [dbo].[Contract Position] CHECK CONSTRAINT [FK_Contract Position_Contract1]
GO
ALTER TABLE [dbo].[Contract Position]  WITH CHECK ADD  CONSTRAINT [FK_Contract Position_Ref LCAT] FOREIGN KEY([LCAT ID])
REFERENCES [dbo].[Ref Contract LCAT] ([ID])
GO
ALTER TABLE [dbo].[Contract Position] CHECK CONSTRAINT [FK_Contract Position_Ref LCAT]
GO
ALTER TABLE [dbo].[Contract Position]  WITH CHECK ADD  CONSTRAINT [FK_Contract Position_Ref Role] FOREIGN KEY([Role ID])
REFERENCES [dbo].[Ref Role] ([ID])
GO
ALTER TABLE [dbo].[Contract Position] CHECK CONSTRAINT [FK_Contract Position_Ref Role]
GO
ALTER TABLE [dbo].[Education]  WITH CHECK ADD  CONSTRAINT [FK_Education_Adm Degree] FOREIGN KEY([Degree ID])
REFERENCES [dbo].[Adm Degree] ([ID])
GO
ALTER TABLE [dbo].[Education] CHECK CONSTRAINT [FK_Education_Adm Degree]
GO
ALTER TABLE [dbo].[Education]  WITH CHECK ADD  CONSTRAINT [FK_Education_Staff] FOREIGN KEY([Staff ID])
REFERENCES [dbo].[Staff] ([ID])
GO
ALTER TABLE [dbo].[Education] CHECK CONSTRAINT [FK_Education_Staff]
GO
ALTER TABLE [dbo].[Position Forecast]  WITH CHECK ADD  CONSTRAINT [FK_Position Forecast_Contract Position] FOREIGN KEY([Contract Position ID])
REFERENCES [dbo].[Contract Position] ([ID])
GO
ALTER TABLE [dbo].[Position Forecast] CHECK CONSTRAINT [FK_Position Forecast_Contract Position]
GO
ALTER TABLE [dbo].[Position Forecast]  WITH CHECK ADD  CONSTRAINT [Requisition Hours$Ref Pay PeriodRequisition Hours] FOREIGN KEY([Pay Period ID])
REFERENCES [dbo].[Ref Pay Period] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Position Forecast] CHECK CONSTRAINT [Requisition Hours$Ref Pay PeriodRequisition Hours]
GO
ALTER TABLE [dbo].[Ref Asset]  WITH CHECK ADD  CONSTRAINT [FK_Ref Asset_Adm Asset Type] FOREIGN KEY([Asset Type ID])
REFERENCES [dbo].[Adm Asset Type] ([ID])
GO
ALTER TABLE [dbo].[Ref Asset] CHECK CONSTRAINT [FK_Ref Asset_Adm Asset Type]
GO
ALTER TABLE [dbo].[Ref Contract LCAT]  WITH CHECK ADD  CONSTRAINT [FK_Ref Contract LCAT_Ref Vehicle LCAT] FOREIGN KEY([Vehicle LCAT ID])
REFERENCES [dbo].[Ref Contract Vehicle LCAT] ([ID])
GO
ALTER TABLE [dbo].[Ref Contract LCAT] CHECK CONSTRAINT [FK_Ref Contract LCAT_Ref Vehicle LCAT]
GO
ALTER TABLE [dbo].[Ref Contract LCAT]  WITH CHECK ADD  CONSTRAINT [FK_Ref LCAT_Contract1] FOREIGN KEY([Contract ID])
REFERENCES [dbo].[Contract] ([ID])
GO
ALTER TABLE [dbo].[Ref Contract LCAT] CHECK CONSTRAINT [FK_Ref LCAT_Contract1]
GO
ALTER TABLE [dbo].[Ref Contract Vehicle LCAT]  WITH CHECK ADD  CONSTRAINT [FK_Ref Contract Vehicle LCAT_Adm Degree] FOREIGN KEY([Degree ID])
REFERENCES [dbo].[Adm Degree] ([ID])
GO
ALTER TABLE [dbo].[Ref Contract Vehicle LCAT] CHECK CONSTRAINT [FK_Ref Contract Vehicle LCAT_Adm Degree]
GO
ALTER TABLE [dbo].[Ref Contract Vehicle LCAT]  WITH CHECK ADD  CONSTRAINT [FK_Ref Vehicle LCAT_Adm Contract Vehicle] FOREIGN KEY([Contract Vehicle ID])
REFERENCES [dbo].[Adm Contract Vehicle] ([ID])
GO
ALTER TABLE [dbo].[Ref Contract Vehicle LCAT] CHECK CONSTRAINT [FK_Ref Vehicle LCAT_Adm Contract Vehicle]
GO
ALTER TABLE [dbo].[Ref Customer]  WITH CHECK ADD  CONSTRAINT [FK_Ref Customer_Adm Agency] FOREIGN KEY([Agency ID])
REFERENCES [dbo].[Adm Agency] ([ID])
GO
ALTER TABLE [dbo].[Ref Customer] CHECK CONSTRAINT [FK_Ref Customer_Adm Agency]
GO
ALTER TABLE [dbo].[Ref Training]  WITH CHECK ADD  CONSTRAINT [FK_Ref Training_Contract] FOREIGN KEY([Contract ID])
REFERENCES [dbo].[Contract] ([ID])
GO
ALTER TABLE [dbo].[Ref Training] CHECK CONSTRAINT [FK_Ref Training_Contract]
GO
ALTER TABLE [dbo].[Security Workflow]  WITH CHECK ADD  CONSTRAINT [FK_Contract Security Workflow_Contract] FOREIGN KEY([Contract ID])
REFERENCES [dbo].[Contract] ([ID])
GO
ALTER TABLE [dbo].[Security Workflow] CHECK CONSTRAINT [FK_Contract Security Workflow_Contract]
GO
ALTER TABLE [dbo].[Security Workflow]  WITH CHECK ADD  CONSTRAINT [FK_Ref Security Workflow_Adm Clearance Status] FOREIGN KEY([Clearance Status ID])
REFERENCES [dbo].[Adm Clearance Status] ([ID])
GO
ALTER TABLE [dbo].[Security Workflow] CHECK CONSTRAINT [FK_Ref Security Workflow_Adm Clearance Status]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Adm Exit Reason] FOREIGN KEY([Exit Reason ID])
REFERENCES [dbo].[Adm Exit Reason] ([ID])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_Adm Exit Reason]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Adm Prefix] FOREIGN KEY([Prefix])
REFERENCES [dbo].[Adm Prefix] ([Prefix])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_Adm Prefix]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Adm Suffix] FOREIGN KEY([Suffix])
REFERENCES [dbo].[Adm Suffix] ([Suffix])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_Adm Suffix]
GO
ALTER TABLE [dbo].[Staff]  WITH NOCHECK ADD  CONSTRAINT [Staff$Ref CompanyStaff] FOREIGN KEY([Company ID])
REFERENCES [dbo].[Ref Company] ([ID])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [Staff$Ref CompanyStaff]
GO
ALTER TABLE [dbo].[Staff Asset]  WITH NOCHECK ADD  CONSTRAINT [FK_Staff Asset_Contract] FOREIGN KEY([Contract ID])
REFERENCES [dbo].[Contract] ([ID])
GO
ALTER TABLE [dbo].[Staff Asset] CHECK CONSTRAINT [FK_Staff Asset_Contract]
GO
ALTER TABLE [dbo].[Staff Asset]  WITH CHECK ADD  CONSTRAINT [FK_Staff Asset_Ref Asset] FOREIGN KEY([Asset ID])
REFERENCES [dbo].[Ref Asset] ([ID])
GO
ALTER TABLE [dbo].[Staff Asset] CHECK CONSTRAINT [FK_Staff Asset_Ref Asset]
GO
ALTER TABLE [dbo].[Staff Asset]  WITH CHECK ADD  CONSTRAINT [FK_Staff Asset_Staff] FOREIGN KEY([Staff ID])
REFERENCES [dbo].[Staff] ([ID])
GO
ALTER TABLE [dbo].[Staff Asset] CHECK CONSTRAINT [FK_Staff Asset_Staff]
GO
ALTER TABLE [dbo].[Staff Clearance]  WITH CHECK ADD  CONSTRAINT [FK_Staff Clearance_Adm Security Clearance] FOREIGN KEY([Security Clearance ID])
REFERENCES [dbo].[Adm Security Clearance] ([ID])
GO
ALTER TABLE [dbo].[Staff Clearance] CHECK CONSTRAINT [FK_Staff Clearance_Adm Security Clearance]
GO
ALTER TABLE [dbo].[Staff Clearance]  WITH CHECK ADD  CONSTRAINT [FK_Staff Clearance_Contract] FOREIGN KEY([Contract ID])
REFERENCES [dbo].[Contract] ([ID])
GO
ALTER TABLE [dbo].[Staff Clearance] CHECK CONSTRAINT [FK_Staff Clearance_Contract]
GO
ALTER TABLE [dbo].[Staff Clearance]  WITH CHECK ADD  CONSTRAINT [FK_Staff Clearance_Staff] FOREIGN KEY([ID])
REFERENCES [dbo].[Staff] ([ID])
GO
ALTER TABLE [dbo].[Staff Clearance] CHECK CONSTRAINT [FK_Staff Clearance_Staff]
GO
ALTER TABLE [dbo].[Staff Clearance Workflow]  WITH CHECK ADD  CONSTRAINT [FK_Security Clearance_Contract Security Workflow] FOREIGN KEY([Security Workflow ID])
REFERENCES [dbo].[Security Workflow] ([ID])
GO
ALTER TABLE [dbo].[Staff Clearance Workflow] CHECK CONSTRAINT [FK_Security Clearance_Contract Security Workflow]
GO
ALTER TABLE [dbo].[Staff Clearance Workflow]  WITH CHECK ADD  CONSTRAINT [FK_Staff Clearance Worrkflow_Staff Clearance] FOREIGN KEY([Staff Clearance ID])
REFERENCES [dbo].[Staff Clearance] ([ID])
GO
ALTER TABLE [dbo].[Staff Clearance Workflow] CHECK CONSTRAINT [FK_Staff Clearance Worrkflow_Staff Clearance]
GO
ALTER TABLE [dbo].[Staff Position]  WITH CHECK ADD  CONSTRAINT [FK_Staff Position_Adm Resume Status] FOREIGN KEY([Resume Status ID])
REFERENCES [dbo].[Adm Resume Status] ([ID])
GO
ALTER TABLE [dbo].[Staff Position] CHECK CONSTRAINT [FK_Staff Position_Adm Resume Status]
GO
ALTER TABLE [dbo].[Staff Position]  WITH CHECK ADD  CONSTRAINT [FK_Staff Position_Contract Position] FOREIGN KEY([Contract Position ID])
REFERENCES [dbo].[Contract Position] ([ID])
GO
ALTER TABLE [dbo].[Staff Position] CHECK CONSTRAINT [FK_Staff Position_Contract Position]
GO
ALTER TABLE [dbo].[Staff Position]  WITH CHECK ADD  CONSTRAINT [FK_Staff Position_Ref Telework Agreement] FOREIGN KEY([Telework Agreement ID])
REFERENCES [dbo].[Ref Telework Agreement] ([ID])
GO
ALTER TABLE [dbo].[Staff Position] CHECK CONSTRAINT [FK_Staff Position_Ref Telework Agreement]
GO
ALTER TABLE [dbo].[Staff Position]  WITH CHECK ADD  CONSTRAINT [FK_Staff Position_Staff] FOREIGN KEY([Staff ID])
REFERENCES [dbo].[Staff] ([ID])
GO
ALTER TABLE [dbo].[Staff Position] CHECK CONSTRAINT [FK_Staff Position_Staff]
GO
ALTER TABLE [dbo].[Staff Skill]  WITH CHECK ADD  CONSTRAINT [FK_Staff Skill_Adm Proficiency] FOREIGN KEY([Proficiency ID])
REFERENCES [dbo].[Adm Proficiency] ([Proficiency ID])
GO
ALTER TABLE [dbo].[Staff Skill] CHECK CONSTRAINT [FK_Staff Skill_Adm Proficiency]
GO
ALTER TABLE [dbo].[Staff Skill]  WITH CHECK ADD  CONSTRAINT [FK_Staff Skill_Ref Skill] FOREIGN KEY([Skill ID])
REFERENCES [dbo].[Ref Skill] ([ID])
GO
ALTER TABLE [dbo].[Staff Skill] CHECK CONSTRAINT [FK_Staff Skill_Ref Skill]
GO
ALTER TABLE [dbo].[Staff Skill]  WITH CHECK ADD  CONSTRAINT [FK_Staff Skill_Staff] FOREIGN KEY([Staff ID])
REFERENCES [dbo].[Staff] ([ID])
GO
ALTER TABLE [dbo].[Staff Skill] CHECK CONSTRAINT [FK_Staff Skill_Staff]
GO
ALTER TABLE [dbo].[Staff Training]  WITH CHECK ADD  CONSTRAINT [FK_Staff Training_Ref Training] FOREIGN KEY([Training ID])
REFERENCES [dbo].[Ref Training] ([ID])
GO
ALTER TABLE [dbo].[Staff Training] CHECK CONSTRAINT [FK_Staff Training_Ref Training]
GO
ALTER TABLE [dbo].[Staff Training]  WITH CHECK ADD  CONSTRAINT [FK_Staff Training_Staff] FOREIGN KEY([Staff ID])
REFERENCES [dbo].[Staff] ([ID])
GO
ALTER TABLE [dbo].[Staff Training] CHECK CONSTRAINT [FK_Staff Training_Staff]
GO
ALTER TABLE [dbo].[Workshare]  WITH CHECK ADD  CONSTRAINT [FK_Workshare_Contract Position] FOREIGN KEY([Contract Position ID])
REFERENCES [dbo].[Contract Position] ([ID])
GO
ALTER TABLE [dbo].[Workshare] CHECK CONSTRAINT [FK_Workshare_Contract Position]
GO
ALTER TABLE [dbo].[Workshare]  WITH CHECK ADD  CONSTRAINT [FK_Workshare_Ref Company] FOREIGN KEY([Company ID])
REFERENCES [dbo].[Ref Company] ([ID])
GO
ALTER TABLE [dbo].[Workshare] CHECK CONSTRAINT [FK_Workshare_Ref Company]
GO
ALTER TABLE [dbo].[Adm Requisition Status]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Adm Requisition Status$Status$disallow_zero_length] CHECK  ((len([Status])>(0)))
GO
ALTER TABLE [dbo].[Adm Requisition Status] CHECK CONSTRAINT [SSMA_CC$Adm Requisition Status$Status$disallow_zero_length]
GO
ALTER TABLE [dbo].[Adm Resume Status]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Adm Resume Status$Status$disallow_zero_length] CHECK  ((len([Status])>(0)))
GO
ALTER TABLE [dbo].[Adm Resume Status] CHECK CONSTRAINT [SSMA_CC$Adm Resume Status$Status$disallow_zero_length]
GO
ALTER TABLE [dbo].[Contract WBS]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Adm Area$Area$disallow_zero_length] CHECK  ((len([Area])>(0)))
GO
ALTER TABLE [dbo].[Contract WBS] CHECK CONSTRAINT [SSMA_CC$Adm Area$Area$disallow_zero_length]
GO
ALTER TABLE [dbo].[Ref Company]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Ref Company$Company$disallow_zero_length] CHECK  ((len([Company])>(0)))
GO
ALTER TABLE [dbo].[Ref Company] CHECK CONSTRAINT [SSMA_CC$Ref Company$Company$disallow_zero_length]
GO
ALTER TABLE [dbo].[Ref Contract LCAT]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Ref LCAT$ESF LCAT$disallow_zero_length] CHECK  ((len([ESF LCAT])>(0)))
GO
ALTER TABLE [dbo].[Ref Contract LCAT] CHECK CONSTRAINT [SSMA_CC$Ref LCAT$ESF LCAT$disallow_zero_length]
GO
ALTER TABLE [dbo].[Ref Role]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Ref Role$Role$disallow_zero_length] CHECK  ((len([Role])>(0)))
GO
ALTER TABLE [dbo].[Ref Role] CHECK CONSTRAINT [SSMA_CC$Ref Role$Role$disallow_zero_length]
GO
ALTER TABLE [dbo].[Staff]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Staff$Last Name$disallow_zero_length] CHECK  ((len([Last Name])>(0)))
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [SSMA_CC$Staff$Last Name$disallow_zero_length]
GO
ALTER TABLE [dbo].[Staff]  WITH NOCHECK ADD  CONSTRAINT [SSMA_CC$Staff$Staff Name$disallow_zero_length] CHECK  ((len([Staff Name])>(0)))
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [SSMA_CC$Staff$Staff Name$disallow_zero_length]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Agency', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Gov''t Cabinet Agencies or Commercial Areas' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Agency', @level2type=N'COLUMN',@level2name=N'Agency'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'List of Agencies.  Used as a High Level Reporting Category for Gov''t or commercial assignments' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Agency'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Asset Type', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Asset Type is a Categorization of Assets (IT, Parking, Badge, etc...)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Asset Type', @level2type=N'COLUMN',@level2name=N'Asset Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'List of Asset Types.  Used for High Level Category Reporting' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Asset Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Clearance Status', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Contract Status].[ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Clearance Status', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Status of Staff Members Security Clearance' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Clearance Status', @level2type=N'COLUMN',@level2name=N'Clearance Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Contract Status].[Clearance Status]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Clearance Status', @level2type=N'COLUMN',@level2name=N'Clearance Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Status List for a staff member''s Security Clearance' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Clearance Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Contract Status]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Clearance Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Contract Status].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Clearance Status', @level2type=N'CONSTRAINT',@level2name=N'Adm Contract Status$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Contract Status].[ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Clearance Status', @level2type=N'INDEX',@level2name=N'Adm Contract Status$ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Contract Vehicle', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Contract Vehicle Name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Contract Vehicle', @level2type=N'COLUMN',@level2name=N'Vehicle Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'List of Contract Vehicles' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Contract Vehicle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Degree', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Degree].[ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Degree', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Degree Title' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Degree', @level2type=N'COLUMN',@level2name=N'Degree'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Degree].[Degree]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Degree', @level2type=N'COLUMN',@level2name=N'Degree'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Number of years of experience to add to the base years required for a position' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Degree', @level2type=N'COLUMN',@level2name=N'Offset'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Degree].[Offset]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Degree', @level2type=N'COLUMN',@level2name=N'Offset'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'List of Educational Degrees' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Degree'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Degree]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Degree'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Degree].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Degree', @level2type=N'CONSTRAINT',@level2name=N'Adm Degree$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Degree].[Degree]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Degree', @level2type=N'INDEX',@level2name=N'Adm Degree$Degree'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Exit Reason', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Exit Reason].[ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Exit Reason', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Reason for Leaving a Position' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Exit Reason', @level2type=N'COLUMN',@level2name=N'Exit Reason'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Exit Reason].[Exit Reason]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Exit Reason', @level2type=N'COLUMN',@level2name=N'Exit Reason'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'List of Standard Reasons for Staff Terminating association with T-Rex' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Exit Reason'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Exit Reason]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Exit Reason'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Exit Reason].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Exit Reason', @level2type=N'CONSTRAINT',@level2name=N'Ref Exit Reason$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Info Risk', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Clearance].[ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Info Risk', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Information Risk Level' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Info Risk', @level2type=N'COLUMN',@level2name=N'Info Risk'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Clearance].[Clearance]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Info Risk', @level2type=N'COLUMN',@level2name=N'Info Risk'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'List of Infomation Risk Levels' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Info Risk'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Clearance]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Info Risk'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Clearance].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Info Risk', @level2type=N'CONSTRAINT',@level2name=N'Adm Clearance$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Name Prefix' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Prefix', @level2type=N'COLUMN',@level2name=N'Prefix'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'List of Name Prefixes' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Prefix'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'List of Proficiency Ratings' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Proficiency'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Requisition Status', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Requisition Status].[ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Requisition Status', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Requisition Status indicating the status of the formal requisition requirements' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Requisition Status', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Requisition Status].[Status]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Requisition Status', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'List of the Requisition Status' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Requisition Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Requisition Status]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Requisition Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Requisition Status].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Requisition Status', @level2type=N'CONSTRAINT',@level2name=N'Adm Requisition Status$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Requisition Status].[Status]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Requisition Status', @level2type=N'INDEX',@level2name=N'Adm Requisition Status$Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Resume Status', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Resume Status].[ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Resume Status', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Compliance Status for a Staff Members Resume' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Resume Status', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Resume Status].[Status]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Resume Status', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'List of Resume Status Indicators' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Resume Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Resume Status]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Resume Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Resume Status].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Resume Status', @level2type=N'CONSTRAINT',@level2name=N'Adm Resume Status$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Resume Status].[Status]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Resume Status', @level2type=N'INDEX',@level2name=N'Adm Resume Status$Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Security Clearance', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Security Clearance Type' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Security Clearance', @level2type=N'COLUMN',@level2name=N'Security Clearance'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Security Clearance Abreviation' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Security Clearance', @level2type=N'COLUMN',@level2name=N'Security Clearance Abbreviation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'List of Security Clearance Types,  (Public Trust, Top Secret, Etc..)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Security Clearance'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Name Suffix' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Suffix', @level2type=N'COLUMN',@level2name=N'Suffix'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'List of Name Suffixs' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Suffix'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System Generated Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Certifications', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to Staff Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Certifications', @level2type=N'COLUMN',@level2name=N'Staff ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Certification achieved' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Certifications', @level2type=N'COLUMN',@level2name=N'Certification'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Agency that issued this certification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Certifications', @level2type=N'COLUMN',@level2name=N'Issuing Agency'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The identification Number provided by the issuing agency' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Certifications', @level2type=N'COLUMN',@level2name=N'Certification ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this certification was achieved' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Certifications', @level2type=N'COLUMN',@level2name=N'Date Issued'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this certification expires' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Certifications', @level2type=N'COLUMN',@level2name=N'Expiration Date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was created' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Certifications', @level2type=N'COLUMN',@level2name=N'Created On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Refeence to the User Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Certifications', @level2type=N'COLUMN',@level2name=N'Created By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was last modified' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Certifications', @level2type=N'COLUMN',@level2name=N'Modified On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User who modified this record last' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Certifications', @level2type=N'COLUMN',@level2name=N'Modified By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Certifications achieved by Staff Members' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Certifications'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System Generated Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Customer Table.  Indicates the Customer associated with this contract' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract', @level2type=N'COLUMN',@level2name=N'Customer ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Start Date for this Contract' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract', @level2type=N'COLUMN',@level2name=N'POP Start'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'End Date for this Contract' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract', @level2type=N'COLUMN',@level2name=N'POP End'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Staff Table.  Indicates the Program Manager for the Contract' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract', @level2type=N'COLUMN',@level2name=N'Program Manager ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Flag to indicate T-Rex is the Prime on this contract' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract', @level2type=N'COLUMN',@level2name=N'IsPrime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Default number of days provided for a sub to fill a position based on Workshare agreements' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract', @level2type=N'COLUMN',@level2name=N'FillByDuration'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was created' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract', @level2type=N'COLUMN',@level2name=N'Created On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the User Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract', @level2type=N'COLUMN',@level2name=N'Created By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was last modified' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract', @level2type=N'COLUMN',@level2name=N'Modified On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User who modified this record last' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract', @level2type=N'COLUMN',@level2name=N'Modified By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'List of Contracts' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System Generated Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract Position', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Contract Table.  Indicates the Contract associated with this position' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract Position', @level2type=N'COLUMN',@level2name=N'Contract ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Ref_Role Table.  Indicates the Job Title' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract Position', @level2type=N'COLUMN',@level2name=N'Role ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Incemental Number indicating the number of positions in this role' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract Position', @level2type=N'COLUMN',@level2name=N'Position #'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the adm Clearance Table.  Indicates the Information Risk Level for this Position' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract Position', @level2type=N'COLUMN',@level2name=N'Info Risk ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the [Ref LCAT] Table.  Indicates the LCAT associated with this position' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract Position', @level2type=N'COLUMN',@level2name=N'LCAT ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the [Adm Requisition Status] Table.  Indicates the status of the Requisition associated with this Position.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract Position', @level2type=N'COLUMN',@level2name=N'Requisition Status ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key: Reference the Adm Security Clearance Table.  The Security Clearance Required for this Position' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract Position', @level2type=N'COLUMN',@level2name=N'Required Security Clearance ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was created' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract Position', @level2type=N'COLUMN',@level2name=N'Created On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the User Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract Position', @level2type=N'COLUMN',@level2name=N'Created By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was last modified' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract Position', @level2type=N'COLUMN',@level2name=N'Modified On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User who modified this record last' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract Position', @level2type=N'COLUMN',@level2name=N'Modified By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'List of Positions required for a contract' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract Position'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System Generated Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract WBS', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Contract Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract WBS', @level2type=N'COLUMN',@level2name=N'Contract ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Title of the Team' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract WBS', @level2type=N'COLUMN',@level2name=N'Area'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'WBS Level 2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract WBS', @level2type=N'COLUMN',@level2name=N'Level 2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'WBS Level 2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract WBS', @level2type=N'COLUMN',@level2name=N'Level 3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'WBS Level 2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract WBS', @level2type=N'COLUMN',@level2name=N'Level 4'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'WBS Level 2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract WBS', @level2type=N'COLUMN',@level2name=N'Level 5'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was created' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract WBS', @level2type=N'COLUMN',@level2name=N'Created On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the User Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract WBS', @level2type=N'COLUMN',@level2name=N'Created By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was last modified' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract WBS', @level2type=N'COLUMN',@level2name=N'Modified On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User who modified this record last' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract WBS', @level2type=N'COLUMN',@level2name=N'Modified By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Adm Area]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contract WBS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System Generated Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Education', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to Staff Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Education', @level2type=N'COLUMN',@level2name=N'Staff ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The School associated with this degree' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Education', @level2type=N'COLUMN',@level2name=N'School'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Adm Degree Table.  Identifies the Degree that was achieved' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Education', @level2type=N'COLUMN',@level2name=N'Degree ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The date this degree was achieved' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Education', @level2type=N'COLUMN',@level2name=N'Completed Date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was created' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Education', @level2type=N'COLUMN',@level2name=N'Created On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the User Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Education', @level2type=N'COLUMN',@level2name=N'Created By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was last modified' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Education', @level2type=N'COLUMN',@level2name=N'Modified On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User who modified this record last' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Education', @level2type=N'COLUMN',@level2name=N'Modified By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Requisition Hours].[ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Position Forecast', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference the Contract Position Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Position Forecast', @level2type=N'COLUMN',@level2name=N'Contract Position ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Requisition Hours].[Requisition ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Position Forecast', @level2type=N'COLUMN',@level2name=N'Contract Position ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key: Reference to the Ref Pay Period Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Position Forecast', @level2type=N'COLUMN',@level2name=N'Pay Period ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Requisition Hours].[Pay Period ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Position Forecast', @level2type=N'COLUMN',@level2name=N'Pay Period ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Planned FTE''s for the PayPeriod' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Position Forecast', @level2type=N'COLUMN',@level2name=N'FTE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Number of Hours per FTE Planned' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Position Forecast', @level2type=N'COLUMN',@level2name=N'Hours'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Requisition Hours].[Hours]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Position Forecast', @level2type=N'COLUMN',@level2name=N'Hours'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was created' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Position Forecast', @level2type=N'COLUMN',@level2name=N'Created On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foriegn Key:  Reference to the User Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Position Forecast', @level2type=N'COLUMN',@level2name=N'Created By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was last modified' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Position Forecast', @level2type=N'COLUMN',@level2name=N'Modified On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User who modified this record last' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Position Forecast', @level2type=N'COLUMN',@level2name=N'Modified By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Forecast for Position' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Position Forecast'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Requisition Hours]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Position Forecast'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Requisition Hours].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Position Forecast', @level2type=N'CONSTRAINT',@level2name=N'Requisition Hours$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Requisition Hours].[Composite]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Position Forecast', @level2type=N'INDEX',@level2name=N'Requisition Hours$Composite'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Requisition Hours].[Ref Pay PeriodRequisition Hours]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Position Forecast', @level2type=N'INDEX',@level2name=N'Requisition Hours$Ref Pay PeriodRequisition Hours'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Requisition Hours].[RequisitionRequisition Hours]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Position Forecast', @level2type=N'INDEX',@level2name=N'Requisition Hours$RequisitionRequisition Hours'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Requisition Hours].[Ref Pay PeriodRequisition Hours]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Position Forecast', @level2type=N'CONSTRAINT',@level2name=N'Requisition Hours$Ref Pay PeriodRequisition Hours'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System Generated Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Asset', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Name of the Asset' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Asset', @level2type=N'COLUMN',@level2name=N'Asset Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key: Reference to the Adm Asset Type Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Asset', @level2type=N'COLUMN',@level2name=N'Asset Type ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System Generated Unique Identifier' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Company', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Company].[ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Company', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Company Name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Company', @level2type=N'COLUMN',@level2name=N'Company'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Company].[Company]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Company', @level2type=N'COLUMN',@level2name=N'Company'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'List of Companies that are associated with T-Rex' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Company'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Company]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Company'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Company].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Company', @level2type=N'CONSTRAINT',@level2name=N'Ref Company$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Company].[NORM_OrderByIndex]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Company', @level2type=N'INDEX',@level2name=N'Ref Company$NORM_OrderByIndex'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System Generated Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Contract LCAT', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref LCAT].[ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Contract LCAT', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Contract Table.  Indicates the Contract this LCAT is valid for' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Contract LCAT', @level2type=N'COLUMN',@level2name=N'Contract ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Ref Vehicle LCAT Table.  Indicates the Vehicle Type LCAT the Contract LCAT matches.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Contract LCAT', @level2type=N'COLUMN',@level2name=N'Vehicle LCAT ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Labor Category Title' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Contract LCAT', @level2type=N'COLUMN',@level2name=N'ESF LCAT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref LCAT].[ESF LCAT]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Contract LCAT', @level2type=N'COLUMN',@level2name=N'ESF LCAT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Job Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Contract LCAT', @level2type=N'COLUMN',@level2name=N'Description'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Years of Experience Required for this Labor Category' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Contract LCAT', @level2type=N'COLUMN',@level2name=N'Years of Experience with Degree'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref LCAT]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Contract LCAT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref LCAT].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Contract LCAT', @level2type=N'CONSTRAINT',@level2name=N'Ref LCAT$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System Generated Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Contract Vehicle LCAT', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Contract Vehicle Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Contract Vehicle LCAT', @level2type=N'COLUMN',@level2name=N'Contract Vehicle ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'LCAT Title' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Contract Vehicle LCAT', @level2type=N'COLUMN',@level2name=N'LCAT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Years of expierence required with a Bachelor degree' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Contract Vehicle LCAT', @level2type=N'COLUMN',@level2name=N'Years of Experience with Degree'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Adm Degree Table.  Indicates the minimum degree reguired for this LCAT' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Contract Vehicle LCAT', @level2type=N'COLUMN',@level2name=N'Degree ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System Generated Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Customer', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Customer Name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Customer', @level2type=N'COLUMN',@level2name=N'Customer'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Adm Agency Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Customer', @level2type=N'COLUMN',@level2name=N'Agency ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System Generated Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Pay Period', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Pay Period].[ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Pay Period', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Pay Period Title' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Pay Period', @level2type=N'COLUMN',@level2name=N'Period #'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Pay Period].[Period #]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Pay Period', @level2type=N'COLUMN',@level2name=N'Period #'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Year Associated with Pay Period' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Pay Period', @level2type=N'COLUMN',@level2name=N'Year'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Pay Period].[Year]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Pay Period', @level2type=N'COLUMN',@level2name=N'Year'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Month Associated with Pay Period' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Pay Period', @level2type=N'COLUMN',@level2name=N'Month'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Pay Period].[Month]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Pay Period', @level2type=N'COLUMN',@level2name=N'Month'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Stat Date of Pay Period' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Pay Period', @level2type=N'COLUMN',@level2name=N'Start'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Pay Period].[Start]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Pay Period', @level2type=N'COLUMN',@level2name=N'Start'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'End Date of Pay Period' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Pay Period', @level2type=N'COLUMN',@level2name=N'End'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Pay Period].[End]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Pay Period', @level2type=N'COLUMN',@level2name=N'End'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Pay Period]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Pay Period'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Pay Period].[ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Pay Period', @level2type=N'CONSTRAINT',@level2name=N'Ref Pay Period$ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Pay Period].[YearMonthStart]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Pay Period', @level2type=N'INDEX',@level2name=N'Ref Pay Period$YearMonthStart'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System Generated Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Role', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Role].[ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Role', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Job Title' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Role', @level2type=N'COLUMN',@level2name=N'Role'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Role].[Role]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Role', @level2type=N'COLUMN',@level2name=N'Role'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Role]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Role'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Role].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Role', @level2type=N'CONSTRAINT',@level2name=N'Ref Role$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Role].[ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Role', @level2type=N'INDEX',@level2name=N'Ref Role$ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Role].[Role]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Role', @level2type=N'INDEX',@level2name=N'Ref Role$Role'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System Generated Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Skill', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Skill Set' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Skill', @level2type=N'COLUMN',@level2name=N'Skill'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System Generated Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Telework Agreement', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Telework Agreement Type].[ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Telework Agreement', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Telework Agreement' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Telework Agreement', @level2type=N'COLUMN',@level2name=N'Telework Agreement'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Telework Agreement Type].[Telework Agreement Type]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Telework Agreement', @level2type=N'COLUMN',@level2name=N'Telework Agreement'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'List of Telewok Agreements' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Telework Agreement'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Telework Agreement Type]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Telework Agreement'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Ref Telework Agreement Type].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Telework Agreement', @level2type=N'CONSTRAINT',@level2name=N'Ref Telework Agreement Type$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System Generated Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Training', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Contract Table.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Training', @level2type=N'COLUMN',@level2name=N'Contract ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Title for Training' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Training', @level2type=N'COLUMN',@level2name=N'Training'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date Training Required to be completed by' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Training', @level2type=N'COLUMN',@level2name=N'Date Due'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Basic Instructions for Training' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Training', @level2type=N'COLUMN',@level2name=N'Instructions'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'List of Training Required by Contract' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ref Training'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System Generated Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Security Workflow', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Contract Table.  Indicates the contract associated with this workflow step' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Security Workflow', @level2type=N'COLUMN',@level2name=N'Contract ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Incremental Number.  Indicates the Order to display the steps' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Security Workflow', @level2type=N'COLUMN',@level2name=N'Display Order'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Title given for a single phase of the security clearance process' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Security Workflow', @level2type=N'COLUMN',@level2name=N'Workflow'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Flag to indicate that this Workflow item should be allowed to be selected out of sequence' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Security Workflow', @level2type=N'COLUMN',@level2name=N'Always Display'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key; Reference to the Adm Clearance Status Table.  Indicates a status based of the current step' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Security Workflow', @level2type=N'COLUMN',@level2name=N'Clearance Status ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was created' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Security Workflow', @level2type=N'COLUMN',@level2name=N'Created On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the User Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Security Workflow', @level2type=N'COLUMN',@level2name=N'Created By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was last modified' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Security Workflow', @level2type=N'COLUMN',@level2name=N'Modified On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User who modified this record last' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Security Workflow', @level2type=N'COLUMN',@level2name=N'Modified By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'List of Steps Required to obtain security clearance by Contract' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Security Workflow'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System Generated Unique Identifier' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff].[ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to UNANET.  Unique identification for all staff members' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Person Key'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff].[Person Code]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Person Key'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Ref_Company Table.  Indicates the Company this Staff Member works for.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Company ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff].[Company ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Company ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Computed Staff Name based on Last Name, First Name, Middle Initial and Suffix' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Staff Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff].[Staff Name]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Staff Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Adm Prefix Table.  Name Prefix' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Prefix'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Staff members Last Name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Last Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff].[Last Name]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Last Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Staff Members First Name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'First Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff].[First Name]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'First Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Staff Members Middle Initial' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Middle Initial'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to Adm Suffix Table .  Name Suffix' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Suffix'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Alternative name for this Staff Member' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Alias'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff].[Alias]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Alias'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Location where this staff member has their primary office' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Location'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Staff Members Company Cell Phone Number' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Cell Phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Staff Members Personal Cell Phone Number' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Personal Cell Phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Staff Members Desk Phone Number' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Desk Phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Staff Members Company Email' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Company Email'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Flag to indicate this Staff Member is a Foreign National' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'IsForeign National'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Flag to indicate this staff member is able to charge to a contract' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'IsBillable'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The years of experience at the date of Hire' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Years of Experience'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date Staff Member first reported to work' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Hire Date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this Staff Member terminated thie employment or association with T-Rex' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Exit Date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Notes of termination' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Exit Note'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Adm Exit Reason Table.  Indicates why this employee is being terminated' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Exit Reason ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Flag to indicate this staff member is eligible for Rehire' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Is Eligible for Rehire'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was created' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Created On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the User Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Created By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was last modified' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Modified On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User who modified this record last' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Modified By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'List of all staff.  This includes T-Rex employees, sub-contractors and contract workers' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'CONSTRAINT',@level2name=N'Staff$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff].[Company ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'INDEX',@level2name=N'Staff$Company ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff].[Last Name]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'INDEX',@level2name=N'Staff$Last Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff].[Ref CompanyStaff]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'INDEX',@level2name=N'Staff$Ref CompanyStaff'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff].[Staff Name]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'INDEX',@level2name=N'Staff$Staff Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff].[Ref CompanyStaff]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'CONSTRAINT',@level2name=N'Staff$Ref CompanyStaff'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Staff Contract Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Asset', @level2type=N'COLUMN',@level2name=N'Staff ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Contract Table.  0 indicates a TRex Asset' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Asset', @level2type=N'COLUMN',@level2name=N'Contract ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Contract Asset Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Asset', @level2type=N'COLUMN',@level2name=N'Asset ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was created' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Asset', @level2type=N'COLUMN',@level2name=N'Created On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the User Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Asset', @level2type=N'COLUMN',@level2name=N'Created By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was last modified' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Asset', @level2type=N'COLUMN',@level2name=N'Modified On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User who modified this record last' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Asset', @level2type=N'COLUMN',@level2name=N'Modified By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System Generated Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Clearance', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Staff Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Clearance', @level2type=N'COLUMN',@level2name=N'Staff ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Adm Security Clearance Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Clearance', @level2type=N'COLUMN',@level2name=N'Security Clearance ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date the Security Clearance was granted' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Clearance', @level2type=N'COLUMN',@level2name=N'Date Authorized'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Contract Table.  ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Clearance', @level2type=N'COLUMN',@level2name=N'Contract ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was created' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Clearance', @level2type=N'COLUMN',@level2name=N'Created On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the User Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Clearance', @level2type=N'COLUMN',@level2name=N'Created By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was last modified' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Clearance', @level2type=N'COLUMN',@level2name=N'Modified On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User who modified this record last' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Clearance', @level2type=N'COLUMN',@level2name=N'Modified By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System Generated Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Clearance Workflow', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Staff Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Clearance Workflow', @level2type=N'COLUMN',@level2name=N'Staff Clearance ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Ref Security Workflow Table.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Clearance Workflow', @level2type=N'COLUMN',@level2name=N'Security Workflow ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'A Flag to indicate this is the active status for the staff member' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Clearance Workflow', @level2type=N'COLUMN',@level2name=N'Is Active'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date when the staff member entered this stage of thier security clearance' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Clearance Workflow', @level2type=N'COLUMN',@level2name=N'Entry Date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date the staff member completed this phase and moved to the next phase of the process' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Clearance Workflow', @level2type=N'COLUMN',@level2name=N'Exit Date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was created' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Clearance Workflow', @level2type=N'COLUMN',@level2name=N'Created On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the User Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Clearance Workflow', @level2type=N'COLUMN',@level2name=N'Created By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was last modified' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Clearance Workflow', @level2type=N'COLUMN',@level2name=N'Modified On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User who modified this record last' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Clearance Workflow', @level2type=N'COLUMN',@level2name=N'Modified By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'History of status as a user moves through the security clearance workflow' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Clearance Workflow'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key: Reference to the Staff Table.  Indicates the staff member filling a position' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'Staff ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff Position].[Staff ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'Staff ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Contract Position Table.  Indicates to Position being filled' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'Contract Position ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff Position].[Position ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'Contract Position ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Flag to indicate this Staff member is currently filling this role' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'IsActive'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff Position].[IsActive]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'IsActive'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this staff member should begin charging to this position' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'Planned Start Date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this staff member became active' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'Active Start Date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff Position].[Active Start Date]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'Active Start Date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this Staff member ended this position' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'Active End Date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff Position].[Active End Date]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'Active End Date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foriegn Key:  References the [Ref Telework Agreement] Table.  Indicates any telework agreement with this position' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'Telework Agreement ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foriegn Key:  Reference to the [adm Resume Status] Table.  Indicates the current status of a staff members resume' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'Resume Status ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff Position].[Resume Status ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'Resume Status ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Flag to indicate Resume is compliant with contract' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'Is Resume Compliant'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff Position].[Is Resume Compliant]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'Is Resume Compliant'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Flag to indicate Staff Member is compliant with LCAT requirements' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'Is LCAT Compliant'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff Position].[Is LCAT Compliant]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'Is LCAT Compliant'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Additional Notes about a staff members compliance to work in this position' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'Compliance Notes'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff Position].[Compliance Notes]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'Compliance Notes'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Email Address to use for this position' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'Email Address'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Phone Number to use for this position' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'Desk Phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was created' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'Created On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the User Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'Created By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was last modified' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'Modified On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User who modified this record last' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'COLUMN',@level2name=N'Modified By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff Position]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff Position].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'CONSTRAINT',@level2name=N'Staff Position$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff Position].[Position ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'INDEX',@level2name=N'Staff Position$Position ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff Position].[PositionStaff Position]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'INDEX',@level2name=N'Staff Position$PositionStaff Position'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff Position].[Staff ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'INDEX',@level2name=N'Staff Position$Staff ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Master Requisitions.[Staff Position].[StaffStaff Position]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Position', @level2type=N'INDEX',@level2name=N'Staff Position$StaffStaff Position'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to Staff Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Skill', @level2type=N'COLUMN',@level2name=N'Staff ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Ref Skill Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Skill', @level2type=N'COLUMN',@level2name=N'Skill ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of a self rating of a staff members poficiency in a particular skill set' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Skill', @level2type=N'COLUMN',@level2name=N'Proficiency ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'A self rating of a staff members proficiency in a particular skill set' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Adm Proficiency', @level2type=N'COLUMN',@level2name=N'Proficiency'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was created' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Skill', @level2type=N'COLUMN',@level2name=N'Created On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foriegn Key:  Reference to the User Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Skill', @level2type=N'COLUMN',@level2name=N'Created By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was last modified' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Skill', @level2type=N'COLUMN',@level2name=N'Modified On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User who modified this record last' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Skill', @level2type=N'COLUMN',@level2name=N'Modified By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'A Skill associated with a Staff member' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Skill'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System-Generated Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Training', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foriegn Key:  Reference to the Staff Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Training', @level2type=N'COLUMN',@level2name=N'Staff ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foriegn Key:  Reference to the Ref Training Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Training', @level2type=N'COLUMN',@level2name=N'Training ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date the Training was completed' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Training', @level2type=N'COLUMN',@level2name=N'Date Completed'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was created' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Training', @level2type=N'COLUMN',@level2name=N'Created On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foriegn Key:  Reference to the User Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Training', @level2type=N'COLUMN',@level2name=N'Created By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was last modified' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Training', @level2type=N'COLUMN',@level2name=N'Modified On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User who modified this record last' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Training', @level2type=N'COLUMN',@level2name=N'Modified By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'List of Training Required for Staff Members' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff Training'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'System Generated Unique Identification' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Workshare', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key:  Reference to the Contract Position Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Workshare', @level2type=N'COLUMN',@level2name=N'Contract Position ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Company that is authorized to fill this position' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Workshare', @level2type=N'COLUMN',@level2name=N'Company ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this position was released to this company to fill' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Workshare', @level2type=N'COLUMN',@level2name=N'Date Released'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Flag to indicate this company is the primary provider for this position' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Workshare', @level2type=N'COLUMN',@level2name=N'IsPrimary'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was created' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Workshare', @level2type=N'COLUMN',@level2name=N'Created On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foriegn Key:  Refeence to the User Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Workshare', @level2type=N'COLUMN',@level2name=N'Created By'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Date this record was last modified' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Workshare', @level2type=N'COLUMN',@level2name=N'Modified On'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User who modified this record last' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Workshare', @level2type=N'COLUMN',@level2name=N'Modified By'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Table of user roles' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetRoles'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Name of a user role' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetRoles', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Table of user claims as type and value pairs' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUserClaims'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Unique string identifier for a particular claim type' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUserClaims', @level2type=N'COLUMN',@level2name=N'ClaimType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Value of claim' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUserClaims', @level2type=N'COLUMN',@level2name=N'ClaimValue'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Reference to a particular user''s ID:  References AspNetUsers.Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUserClaims', @level2type=N'COLUMN',@level2name=N'UserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Table of external logins linked to via AspNetUsers.Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUserLogins'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key references AspNetUsers.Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUserLogins', @level2type=N'COLUMN',@level2name=N'UserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Name of the service which provided the login' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUserLogins', @level2type=N'COLUMN',@level2name=N'LoginProvider'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'A unique key associated with the user on the service provider of the login' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUserLogins', @level2type=N'COLUMN',@level2name=N'ProviderKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Table of user roles associated with particular users' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUserRoles'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key references AspNetUsers.Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUserRoles', @level2type=N'COLUMN',@level2name=N'UserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Foreign Key references AspNetRoles.Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUserRoles', @level2type=N'COLUMN',@level2name=N'RoleId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Table of all user information' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUsers'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User''s email address' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUsers', @level2type=N'COLUMN',@level2name=N'Email'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'A flag representing whether the user has confirmed their email address' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUsers', @level2type=N'COLUMN',@level2name=N'EmailConfirmed'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Hashed password of the user' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUsers', @level2type=N'COLUMN',@level2name=N'PasswordHash'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'A random value that should change whenever the user''s credentials have changed' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUsers', @level2type=N'COLUMN',@level2name=N'SecurityStamp'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User''s phone number' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUsers', @level2type=N'COLUMN',@level2name=N'PhoneNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'A flag representing whether the user has confirmed their phone number' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUsers', @level2type=N'COLUMN',@level2name=N'PhoneNumberConfirmed'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'A flag representing whether two factor authentication is enabled for the user' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUsers', @level2type=N'COLUMN',@level2name=N'TwoFactorEnabled'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DateTime in UTC when lockout ends; anytime in the past is considered not locked out' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUsers', @level2type=N'COLUMN',@level2name=N'LockoutEndDateUtc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'A flag representing whether lockout is enabled for the user' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUsers', @level2type=N'COLUMN',@level2name=N'LockoutEnabled'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'A count of access failures used for lockout purposes' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUsers', @level2type=N'COLUMN',@level2name=N'AccessFailedCount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Username' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUsers', @level2type=N'COLUMN',@level2name=N'UserName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The user''s first name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUsers', @level2type=N'COLUMN',@level2name=N'FirstName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The user''s last name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUsers', @level2type=N'COLUMN',@level2name=N'FirstName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The user''s role' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUsers', @level2type=N'COLUMN',@level2name=N'userRole'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The user''s picture used for their profile' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AspNetUsers', @level2type=N'COLUMN',@level2name=N'ProfilePicture'
GO


USE [master]
GO
ALTER DATABASE [CBA_PMINT] SET  READ_WRITE 
GO
