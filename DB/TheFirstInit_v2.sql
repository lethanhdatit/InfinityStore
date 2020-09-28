USE [master]
GO
/****** Object:  Database [InfinityStoreDB]    Script Date: 9/28/2020 5:36:37 PM ******/
CREATE DATABASE [InfinityStoreDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'InfinityStoreDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\InfinityStoreDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'InfinityStoreDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\InfinityStoreDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [InfinityStoreDB] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [InfinityStoreDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [InfinityStoreDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [InfinityStoreDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [InfinityStoreDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [InfinityStoreDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [InfinityStoreDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [InfinityStoreDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [InfinityStoreDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [InfinityStoreDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [InfinityStoreDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [InfinityStoreDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [InfinityStoreDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [InfinityStoreDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [InfinityStoreDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [InfinityStoreDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [InfinityStoreDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [InfinityStoreDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [InfinityStoreDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [InfinityStoreDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [InfinityStoreDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [InfinityStoreDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [InfinityStoreDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [InfinityStoreDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [InfinityStoreDB] SET RECOVERY FULL 
GO
ALTER DATABASE [InfinityStoreDB] SET  MULTI_USER 
GO
ALTER DATABASE [InfinityStoreDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [InfinityStoreDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [InfinityStoreDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [InfinityStoreDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [InfinityStoreDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'InfinityStoreDB', N'ON'
GO
ALTER DATABASE [InfinityStoreDB] SET QUERY_STORE = OFF
GO
USE [InfinityStoreDB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [InfinityStoreDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[AvatarUrl] [nvarchar](max) NULL,
	[FName] [nvarchar](50) NOT NULL,
	[Gender] [bit] NOT NULL,
	[LName] [nvarchar](50) NOT NULL,
	[MName] [nvarchar](50) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Attributes]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attributes](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[IsDesc] [bit] NOT NULL,
	[Status] [tinyint] NOT NULL,
 CONSTRAINT [PK_ProductOptions] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AttributeTranslations]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttributeTranslations](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[LanguageID] [bigint] NOT NULL,
	[AttributeID] [bigint] NOT NULL,
	[Name] [nvarchar](256) NULL,
	[ImgURL] [ntext] NULL,
	[Status] [tinyint] NOT NULL,
 CONSTRAINT [PK_AttributeTranslations] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ParentID] [bigint] NULL,
	[SortOrder] [bigint] NOT NULL,
	[Status] [tinyint] NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoryAttributes]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryAttributes](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[CategoryID] [bigint] NOT NULL,
	[AttributeID] [bigint] NOT NULL,
	[Status] [tinyint] NOT NULL,
 CONSTRAINT [PK_CategoryOptionValue] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoryTranslations]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryTranslations](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[CategoryID] [bigint] NOT NULL,
	[LanguageID] [bigint] NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
	[ImgURL] [varchar](512) NULL,
	[Status] [tinyint] NOT NULL,
 CONSTRAINT [PK_CategoryTranslations] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GlobalSettings]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GlobalSettings](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](64) NOT NULL,
	[Value] [nvarchar](128) NULL,
	[Description] [nvarchar](512) NULL,
	[Status] [tinyint] NOT NULL,
 CONSTRAINT [PK_GlobalSettings] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Languages]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Languages](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[TwoLetterISO] [varchar](2) NOT NULL,
	[ThreeLetterISO] [varchar](3) NULL,
	[Name] [nvarchar](128) NOT NULL,
	[DisplayName] [nvarchar](256) NULL,
	[NativeName] [nvarchar](256) NULL,
	[EnglishName] [nvarchar](128) NULL,
	[Status] [tinyint] NOT NULL,
	[IsDefault] [bit] NOT NULL,
 CONSTRAINT [PK_Languages] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MerchantStoreProducts]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MerchantStoreProducts](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MerchantStoreID] [bigint] NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[Status] [tinyint] NOT NULL,
	[CreatedTS] [datetime2](7) NOT NULL,
	[LastModifiedTS] [datetime2](7) NULL,
	[CreatedBy] [bigint] NOT NULL,
	[LastModifiedBy] [bigint] NULL,
 CONSTRAINT [PK_MerchantStoreProducts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MerchantStores]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MerchantStores](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[OwnerId] [nvarchar](450) NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Description] [ntext] NULL,
	[Hotline] [varchar](20) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[CreatedTS] [datetime2](7) NOT NULL,
	[LastModifiedTS] [datetime2](7) NULL,
	[CreatedBy] [bigint] NOT NULL,
	[LastModifiedBy] [bigint] NULL,
 CONSTRAINT [PK_MerchantStores] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OptionImages]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OptionImages](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[OptionTranslationID] [bigint] NOT NULL,
	[ImgURL] [ntext] NOT NULL,
	[Status] [tinyint] NOT NULL,
 CONSTRAINT [PK_OptionImages] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Options]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Options](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[AttributeID] [bigint] NOT NULL,
	[Status] [tinyint] NOT NULL,
 CONSTRAINT [PK_Options] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OptionTranslations]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OptionTranslations](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[LanguageID] [bigint] NOT NULL,
	[OptionID] [bigint] NOT NULL,
	[Name] [nvarchar](256) NULL,
	[Description] [ntext] NULL,
	[Status] [tinyint] NOT NULL,
 CONSTRAINT [PK_OptionTranslations] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[OrderID] [bigint] NOT NULL,
	[ProductInstanceID] [bigint] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [bigint] NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ReferenceID] [bigint] NULL,
	[PromotionID] [bigint] NULL,
	[CustomerID] [nvarchar](450) NULL,
	[PaymentProviderID] [bigint] NULL,
	[ShippingMethodID] [bigint] NOT NULL,
	[WarehouseID] [bigint] NULL,
	[PickupAddress] [nvarchar](256) NOT NULL,
	[PickupProvince] [nvarchar](256) NOT NULL,
	[PickupDistrict] [nvarchar](256) NOT NULL,
	[PickupCommune] [nvarchar](256) NULL,
	[PickupPhone] [varchar](20) NOT NULL,
	[PickupTS] [nvarchar](512) NULL,
	[CustomerPhone] [varchar](20) NOT NULL,
	[CustomerEmail] [varchar](128) NULL,
	[CustomerName] [nvarchar](128) NOT NULL,
	[CustomerProvince] [nvarchar](256) NOT NULL,
	[CustomerDistrict] [nvarchar](256) NOT NULL,
	[CustomerCommune] [nvarchar](256) NULL,
	[CustomerAddress] [nvarchar](256) NOT NULL,
	[DeliveryTS] [nvarchar](512) NULL,
	[ShippingConfig] [tinyint] NULL,
	[ShippingPayer] [tinyint] NULL,
	[ShippingBarter] [tinyint] NULL,
	[ShippingStatus] [tinyint] NOT NULL,
	[ShippingStatusName] [tinyint] NOT NULL,
	[ShippingFee] [bigint] NULL,
	[ShippingInsuranceFee] [bigint] NULL,
	[TotalValue] [bigint] NOT NULL,
	[PromotionValue] [bigint] NULL,
	[ActuallyValue] [bigint] NOT NULL,
	[Note] [nvarchar](512) NULL,
	[Status] [tinyint] NOT NULL,
	[CreatedTS] [datetime2](7) NOT NULL,
	[LastModifiedTS] [datetime2](7) NULL,
	[CreatedBy] [bigint] NOT NULL,
	[LastModifiedBy] [bigint] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentProviders]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentProviders](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ClientKey] [ntext] NOT NULL,
	[SecretKey] [ntext] NOT NULL,
	[Status] [tinyint] NOT NULL,
 CONSTRAINT [PK_PaymentProviders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentProviderTranslations]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentProviderTranslations](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[LanguageID] [bigint] NOT NULL,
	[PaymentProviderID] [bigint] NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[ImgURL] [ntext] NULL,
	[Status] [tinyint] NOT NULL,
 CONSTRAINT [PK_PaymentProviderTranslations] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductCategories]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategories](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[CategoryID] [bigint] NOT NULL,
	[Status] [tinyint] NOT NULL,
 CONSTRAINT [PK_ProductCategories] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductInstances]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductInstances](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[CurrentPrice] [bigint] NOT NULL,
	[OriginalPrice] [bigint] NOT NULL,
	[Weight] [int] NOT NULL,
	[Height] [int] NOT NULL,
	[Rating] [float] NULL,
	[Status] [tinyint] NOT NULL,
 CONSTRAINT [PK_ProductInstances] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ISBN] [varchar](20) NULL,
	[SKU] [varchar](20) NULL,
	[Status] [tinyint] NOT NULL,
	[RatingAvg] [float] NULL,
	[ViewCount] [bigint] NULL,
	[CreatedTS] [datetime2](7) NOT NULL,
	[LastModifiedTS] [datetime2](7) NULL,
	[CreatedBy] [bigint] NOT NULL,
	[LastModifiedBy] [bigint] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductTranslations]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductTranslations](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[LanguageID] [bigint] NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
	[Description] [ntext] NULL,
	[Tag] [ntext] NULL,
	[Keyword] [nvarchar](256) NULL,
	[MetaKeyword] [nvarchar](256) NULL,
	[MetaDescription] [nvarchar](256) NULL,
	[SeoAlias] [varchar](512) NULL,
	[Status] [tinyint] NOT NULL,
	[CreatedTS] [datetime2](7) NOT NULL,
	[LastModifiedTS] [datetime2](7) NULL,
	[CreatedBy] [bigint] NOT NULL,
	[LastModifiedBy] [bigint] NULL,
 CONSTRAINT [PK_ProductDetails] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductVariations]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductVariations](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[OptionID] [bigint] NOT NULL,
	[ProductInstanceID] [bigint] NOT NULL,
	[AttributeID] [bigint] NOT NULL,
	[Status] [tinyint] NOT NULL,
 CONSTRAINT [PK_ProductOptionValues] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductWarehouses]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductWarehouses](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductInstanceID] [bigint] NOT NULL,
	[WarehouseID] [bigint] NOT NULL,
	[QuantityStock] [int] NOT NULL,
	[ImportPrice] [bigint] NOT NULL,
 CONSTRAINT [PK_ProductWarehouses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RolePermissions]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolePermissions](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[RoleID] [nvarchar](450) NOT NULL,
	[Permissions] [ntext] NULL,
 CONSTRAINT [PK_RolePermissions] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShippingMethods]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShippingMethods](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ShippingProviderID] [bigint] NOT NULL,
	[Status] [tinyint] NOT NULL,
 CONSTRAINT [PK_ShippingMethods] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShippingMethodTranslations]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShippingMethodTranslations](
	[ID] [bigint] NOT NULL,
	[LanguageID] [bigint] NOT NULL,
	[ShippingMethodID] [bigint] NOT NULL,
	[Status] [tinyint] NOT NULL,
	[ImgURL] [ntext] NULL,
	[Name] [nvarchar](256) NOT NULL,
	[Description] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShippingProviders]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShippingProviders](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ClientKey] [ntext] NOT NULL,
	[SecretKey] [ntext] NOT NULL,
	[Status] [tinyint] NOT NULL,
 CONSTRAINT [PK_ShippingProviders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShippingProviderTranslations]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShippingProviderTranslations](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[LanguageID] [bigint] NOT NULL,
	[ShippingProviderID] [bigint] NOT NULL,
	[Status] [tinyint] NOT NULL,
	[ImgURL] [ntext] NULL,
	[Name] [nvarchar](256) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_ShippingProviderTranslations] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShippingProviderWarehouses]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShippingProviderWarehouses](
	[WarehouseID] [bigint] NOT NULL,
	[ShippingProviderID] [bigint] NOT NULL,
	[ExternalCode] [varchar](128) NOT NULL,
	[ExternalAddress] [nvarchar](512) NOT NULL,
	[ExternalStatus] [tinyint] NOT NULL,
	[LastModifiedTS] [datetime2](7) NULL,
	[CreatedTS] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ShippingProviderWarehouses_1] PRIMARY KEY CLUSTERED 
(
	[WarehouseID] ASC,
	[ShippingProviderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ExternalTransID] [varchar](max) NOT NULL,
	[PaymentProviderID] [bigint] NOT NULL,
	[OrderID] [bigint] NOT NULL,
	[Amount] [float] NOT NULL,
	[Fee] [float] NOT NULL,
	[Result] [ntext] NOT NULL,
	[Message] [nvarchar](max) NOT NULL,
	[Status] [tinyint] NOT NULL,
 CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouses]    Script Date: 9/28/2020 5:36:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouses](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MerchantID] [bigint] NULL,
	[Name] [nvarchar](512) NOT NULL,
	[Phone] [varchar](20) NOT NULL,
	[Email] [varchar](128) NULL,
	[ManagerName] [nvarchar](128) NOT NULL,
	[Address] [nvarchar](256) NOT NULL,
	[Province] [nvarchar](256) NOT NULL,
	[District] [nvarchar](256) NOT NULL,
	[Commune] [nvarchar](256) NULL,
	[IsDefault] [bit] NOT NULL,
	[LastModifiedTS] [datetime2](7) NULL,
	[CreatedTS] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Warehouses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([ID], [ParentID], [SortOrder], [Status]) VALUES (1, NULL, 1, 1)
INSERT [dbo].[Categories] ([ID], [ParentID], [SortOrder], [Status]) VALUES (2, NULL, 2, 1)
INSERT [dbo].[Categories] ([ID], [ParentID], [SortOrder], [Status]) VALUES (3, NULL, 3, 1)
INSERT [dbo].[Categories] ([ID], [ParentID], [SortOrder], [Status]) VALUES (4, NULL, 4, 1)
INSERT [dbo].[Categories] ([ID], [ParentID], [SortOrder], [Status]) VALUES (5, 1, 1, 1)
INSERT [dbo].[Categories] ([ID], [ParentID], [SortOrder], [Status]) VALUES (6, 1, 2, 1)
INSERT [dbo].[Categories] ([ID], [ParentID], [SortOrder], [Status]) VALUES (7, 1, 3, 1)
INSERT [dbo].[Categories] ([ID], [ParentID], [SortOrder], [Status]) VALUES (8, 2, 1, 1)
INSERT [dbo].[Categories] ([ID], [ParentID], [SortOrder], [Status]) VALUES (9, 2, 2, 1)
INSERT [dbo].[Categories] ([ID], [ParentID], [SortOrder], [Status]) VALUES (10, 2, 3, 1)
INSERT [dbo].[Categories] ([ID], [ParentID], [SortOrder], [Status]) VALUES (11, 3, 1, 1)
INSERT [dbo].[Categories] ([ID], [ParentID], [SortOrder], [Status]) VALUES (12, 3, 2, 1)
INSERT [dbo].[Categories] ([ID], [ParentID], [SortOrder], [Status]) VALUES (13, 3, 3, 1)
INSERT [dbo].[Categories] ([ID], [ParentID], [SortOrder], [Status]) VALUES (14, 4, 1, 1)
INSERT [dbo].[Categories] ([ID], [ParentID], [SortOrder], [Status]) VALUES (15, 4, 2, 1)
INSERT [dbo].[Categories] ([ID], [ParentID], [SortOrder], [Status]) VALUES (16, 4, 3, 1)
INSERT [dbo].[Categories] ([ID], [ParentID], [SortOrder], [Status]) VALUES (17, 5, 1, 1)
INSERT [dbo].[Categories] ([ID], [ParentID], [SortOrder], [Status]) VALUES (18, 5, 2, 1)
INSERT [dbo].[Categories] ([ID], [ParentID], [SortOrder], [Status]) VALUES (19, 6, 1, 1)
INSERT [dbo].[Categories] ([ID], [ParentID], [SortOrder], [Status]) VALUES (22, 6, 2, 1)
INSERT [dbo].[Categories] ([ID], [ParentID], [SortOrder], [Status]) VALUES (23, 8, 1, 1)
INSERT [dbo].[Categories] ([ID], [ParentID], [SortOrder], [Status]) VALUES (24, 11, 2, 1)
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[CategoryTranslations] ON 

INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (1, 1, 2, N'Electronic Devices', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (2, 2, 2, N'Babies & Toys', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (3, 3, 2, N'Home & Lifestyle', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (4, 4, 2, N'Fashion Accessories', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (5, 5, 2, N'Audio', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (6, 6, 2, N'Desktops Computers', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (7, 7, 2, N'Laptops', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (8, 8, 2, N'Baby Gear', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (9, 9, 2, N'Toys & Games', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (10, 10, 2, N'Milk Formula & Baby Food', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (11, 11, 2, N'Kitchen & Dining', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (12, 12, 2, N'Hand Tools', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (13, 13, 2, N'Laundry & Cleaning', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (14, 14, 2, N'Women''s Watches', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (15, 15, 2, N'Men''s Jewellery', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (16, 16, 2, N'Sunglasses', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (17, 17, 2, N'Headphones & Headsets', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (18, 18, 2, N'DJ Equipment', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (19, 19, 2, N'Gaming Desktops', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (20, 22, 2, N'DIY', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (21, 23, 2, N'Strollers', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (22, 24, 2, N'Knives & Accessories', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (23, 1, 1, N'Thiết bị điện tử', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (24, 2, 1, N'Trẻ em & đồ chơi', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (25, 3, 1, N'Đồ gia dụng & Đời sống', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (26, 4, 1, N'Phụ kiện thời trang', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (27, 5, 1, N'Âm thanh', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (28, 6, 1, N'Máy tính để bàn', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (29, 7, 1, N'
Máy tính xách tay', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (30, 8, 1, N'Phụ kiện trẻ em', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (31, 9, 1, N'Đồ chơi & Games', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (32, 10, 1, N'
Sữa & thức ăn trẻ em', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (33, 11, 1, N'Nhà bếp và Phòng ăn', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (34, 12, 1, N'
Dụng cụ cầm tay', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (35, 13, 1, N'Thiết bị giặt & vệ sinh', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (36, 14, 1, N'
Đồng hồ nữ', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (37, 15, 1, N'Trang sức nam', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (38, 16, 1, N'Kính râm', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (39, 17, 1, N'Tai nghe', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (40, 18, 1, N'Thiết bị DJ', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (41, 19, 1, N'Máy tính chơi game', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (42, 22, 1, N'DIY', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (43, 23, 1, N'
Xe đẩy', NULL, 1)
INSERT [dbo].[CategoryTranslations] ([ID], [CategoryID], [LanguageID], [Name], [ImgURL], [Status]) VALUES (44, 24, 1, N'
Dao & Phụ kiện', NULL, 1)
SET IDENTITY_INSERT [dbo].[CategoryTranslations] OFF
SET IDENTITY_INSERT [dbo].[Languages] ON 

INSERT [dbo].[Languages] ([ID], [TwoLetterISO], [ThreeLetterISO], [Name], [DisplayName], [NativeName], [EnglishName], [Status], [IsDefault]) VALUES (1, N'vi', N'vie', N'Vietnamese', N'Vietnamese', N'Tiếng Việt', N'Vietnamese', 1, 0)
INSERT [dbo].[Languages] ([ID], [TwoLetterISO], [ThreeLetterISO], [Name], [DisplayName], [NativeName], [EnglishName], [Status], [IsDefault]) VALUES (2, N'en', N'eng', N'English (United States)', N'English (United States)', N'English', N'English (United States)', 1, 1)
SET IDENTITY_INSERT [dbo].[Languages] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 9/28/2020 5:36:38 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 9/28/2020 5:36:38 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 9/28/2020 5:36:38 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 9/28/2020 5:36:38 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 9/28/2020 5:36:38 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 9/28/2020 5:36:38 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 9/28/2020 5:36:38 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  DEFAULT (N'') FOR [FName]
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  DEFAULT (CONVERT([bit],(0))) FOR [Gender]
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  DEFAULT (N'') FOR [LName]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AttributeTranslations]  WITH CHECK ADD  CONSTRAINT [FK_AttributeTranslations_Attributes] FOREIGN KEY([AttributeID])
REFERENCES [dbo].[Attributes] ([ID])
GO
ALTER TABLE [dbo].[AttributeTranslations] CHECK CONSTRAINT [FK_AttributeTranslations_Attributes]
GO
ALTER TABLE [dbo].[AttributeTranslations]  WITH CHECK ADD  CONSTRAINT [FK_AttributeTranslations_Languages] FOREIGN KEY([LanguageID])
REFERENCES [dbo].[Languages] ([ID])
GO
ALTER TABLE [dbo].[AttributeTranslations] CHECK CONSTRAINT [FK_AttributeTranslations_Languages]
GO
ALTER TABLE [dbo].[Categories]  WITH CHECK ADD  CONSTRAINT [FK_Categories_Categories] FOREIGN KEY([ParentID])
REFERENCES [dbo].[Categories] ([ID])
GO
ALTER TABLE [dbo].[Categories] CHECK CONSTRAINT [FK_Categories_Categories]
GO
ALTER TABLE [dbo].[CategoryAttributes]  WITH CHECK ADD  CONSTRAINT [FK_CategoryOptionValue_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([ID])
GO
ALTER TABLE [dbo].[CategoryAttributes] CHECK CONSTRAINT [FK_CategoryOptionValue_Categories]
GO
ALTER TABLE [dbo].[CategoryAttributes]  WITH CHECK ADD  CONSTRAINT [FK_CategoryOptionValue_OptionValues] FOREIGN KEY([AttributeID])
REFERENCES [dbo].[Attributes] ([ID])
GO
ALTER TABLE [dbo].[CategoryAttributes] CHECK CONSTRAINT [FK_CategoryOptionValue_OptionValues]
GO
ALTER TABLE [dbo].[CategoryTranslations]  WITH CHECK ADD  CONSTRAINT [FK_CategoryTranslations_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([ID])
GO
ALTER TABLE [dbo].[CategoryTranslations] CHECK CONSTRAINT [FK_CategoryTranslations_Categories]
GO
ALTER TABLE [dbo].[CategoryTranslations]  WITH CHECK ADD  CONSTRAINT [FK_CategoryTranslations_Languages] FOREIGN KEY([LanguageID])
REFERENCES [dbo].[Languages] ([ID])
GO
ALTER TABLE [dbo].[CategoryTranslations] CHECK CONSTRAINT [FK_CategoryTranslations_Languages]
GO
ALTER TABLE [dbo].[MerchantStoreProducts]  WITH CHECK ADD  CONSTRAINT [FK_MerchantStoreProducts_MerchantStores] FOREIGN KEY([MerchantStoreID])
REFERENCES [dbo].[MerchantStores] ([ID])
GO
ALTER TABLE [dbo].[MerchantStoreProducts] CHECK CONSTRAINT [FK_MerchantStoreProducts_MerchantStores]
GO
ALTER TABLE [dbo].[MerchantStoreProducts]  WITH CHECK ADD  CONSTRAINT [FK_MerchantStoreProducts_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ID])
GO
ALTER TABLE [dbo].[MerchantStoreProducts] CHECK CONSTRAINT [FK_MerchantStoreProducts_Products]
GO
ALTER TABLE [dbo].[MerchantStores]  WITH CHECK ADD  CONSTRAINT [FK_MerchantStores_MerchantStores] FOREIGN KEY([OwnerId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[MerchantStores] CHECK CONSTRAINT [FK_MerchantStores_MerchantStores]
GO
ALTER TABLE [dbo].[OptionImages]  WITH CHECK ADD  CONSTRAINT [FK_OptionImages_OptionTranslations] FOREIGN KEY([OptionTranslationID])
REFERENCES [dbo].[OptionTranslations] ([ID])
GO
ALTER TABLE [dbo].[OptionImages] CHECK CONSTRAINT [FK_OptionImages_OptionTranslations]
GO
ALTER TABLE [dbo].[Options]  WITH CHECK ADD  CONSTRAINT [FK_Options_Attributes] FOREIGN KEY([AttributeID])
REFERENCES [dbo].[Attributes] ([ID])
GO
ALTER TABLE [dbo].[Options] CHECK CONSTRAINT [FK_Options_Attributes]
GO
ALTER TABLE [dbo].[OptionTranslations]  WITH CHECK ADD  CONSTRAINT [FK_OptionTranslations_Languages] FOREIGN KEY([LanguageID])
REFERENCES [dbo].[Languages] ([ID])
GO
ALTER TABLE [dbo].[OptionTranslations] CHECK CONSTRAINT [FK_OptionTranslations_Languages]
GO
ALTER TABLE [dbo].[OptionTranslations]  WITH CHECK ADD  CONSTRAINT [FK_OptionTranslations_Options] FOREIGN KEY([OptionID])
REFERENCES [dbo].[Options] ([ID])
GO
ALTER TABLE [dbo].[OptionTranslations] CHECK CONSTRAINT [FK_OptionTranslations_Options]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([ID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_ProductInstances] FOREIGN KEY([ProductInstanceID])
REFERENCES [dbo].[ProductInstances] ([ID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_ProductInstances]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_AspNetUsers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_AspNetUsers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Orders] FOREIGN KEY([ReferenceID])
REFERENCES [dbo].[Orders] ([ID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Orders]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_PaymentProviders] FOREIGN KEY([PaymentProviderID])
REFERENCES [dbo].[PaymentProviders] ([ID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_PaymentProviders]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_ShippingMethods] FOREIGN KEY([ShippingMethodID])
REFERENCES [dbo].[ShippingMethods] ([ID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_ShippingMethods]
GO
ALTER TABLE [dbo].[PaymentProviderTranslations]  WITH CHECK ADD  CONSTRAINT [FK_PaymentProviderTranslations_Languages] FOREIGN KEY([LanguageID])
REFERENCES [dbo].[Languages] ([ID])
GO
ALTER TABLE [dbo].[PaymentProviderTranslations] CHECK CONSTRAINT [FK_PaymentProviderTranslations_Languages]
GO
ALTER TABLE [dbo].[PaymentProviderTranslations]  WITH CHECK ADD  CONSTRAINT [FK_PaymentProviderTranslations_PaymentProviders] FOREIGN KEY([PaymentProviderID])
REFERENCES [dbo].[PaymentProviders] ([ID])
GO
ALTER TABLE [dbo].[PaymentProviderTranslations] CHECK CONSTRAINT [FK_PaymentProviderTranslations_PaymentProviders]
GO
ALTER TABLE [dbo].[ProductCategories]  WITH CHECK ADD  CONSTRAINT [FK_ProductCategories_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([ID])
GO
ALTER TABLE [dbo].[ProductCategories] CHECK CONSTRAINT [FK_ProductCategories_Categories]
GO
ALTER TABLE [dbo].[ProductCategories]  WITH CHECK ADD  CONSTRAINT [FK_ProductCategories_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ID])
GO
ALTER TABLE [dbo].[ProductCategories] CHECK CONSTRAINT [FK_ProductCategories_Products]
GO
ALTER TABLE [dbo].[ProductInstances]  WITH CHECK ADD  CONSTRAINT [FK_ProductInstances_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ID])
GO
ALTER TABLE [dbo].[ProductInstances] CHECK CONSTRAINT [FK_ProductInstances_Products]
GO
ALTER TABLE [dbo].[ProductTranslations]  WITH CHECK ADD  CONSTRAINT [FK_ProductDetails_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ID])
GO
ALTER TABLE [dbo].[ProductTranslations] CHECK CONSTRAINT [FK_ProductDetails_Products]
GO
ALTER TABLE [dbo].[ProductTranslations]  WITH CHECK ADD  CONSTRAINT [FK_ProductTranslations_Languages] FOREIGN KEY([LanguageID])
REFERENCES [dbo].[Languages] ([ID])
GO
ALTER TABLE [dbo].[ProductTranslations] CHECK CONSTRAINT [FK_ProductTranslations_Languages]
GO
ALTER TABLE [dbo].[ProductVariations]  WITH CHECK ADD  CONSTRAINT [FK_ProductOptionValues_OptionValues] FOREIGN KEY([AttributeID])
REFERENCES [dbo].[Attributes] ([ID])
GO
ALTER TABLE [dbo].[ProductVariations] CHECK CONSTRAINT [FK_ProductOptionValues_OptionValues]
GO
ALTER TABLE [dbo].[ProductVariations]  WITH CHECK ADD  CONSTRAINT [FK_ProductOptionValues_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ID])
GO
ALTER TABLE [dbo].[ProductVariations] CHECK CONSTRAINT [FK_ProductOptionValues_Products]
GO
ALTER TABLE [dbo].[ProductVariations]  WITH CHECK ADD  CONSTRAINT [FK_ProductVariations_Options] FOREIGN KEY([OptionID])
REFERENCES [dbo].[Options] ([ID])
GO
ALTER TABLE [dbo].[ProductVariations] CHECK CONSTRAINT [FK_ProductVariations_Options]
GO
ALTER TABLE [dbo].[ProductVariations]  WITH CHECK ADD  CONSTRAINT [FK_ProductVariations_ProductInstances] FOREIGN KEY([ProductInstanceID])
REFERENCES [dbo].[ProductInstances] ([ID])
GO
ALTER TABLE [dbo].[ProductVariations] CHECK CONSTRAINT [FK_ProductVariations_ProductInstances]
GO
ALTER TABLE [dbo].[ProductWarehouses]  WITH CHECK ADD  CONSTRAINT [FK_ProductWarehouses_ProductInstances] FOREIGN KEY([ProductInstanceID])
REFERENCES [dbo].[ProductInstances] ([ID])
GO
ALTER TABLE [dbo].[ProductWarehouses] CHECK CONSTRAINT [FK_ProductWarehouses_ProductInstances]
GO
ALTER TABLE [dbo].[ProductWarehouses]  WITH CHECK ADD  CONSTRAINT [FK_ProductWarehouses_Warehouses] FOREIGN KEY([WarehouseID])
REFERENCES [dbo].[Warehouses] ([ID])
GO
ALTER TABLE [dbo].[ProductWarehouses] CHECK CONSTRAINT [FK_ProductWarehouses_Warehouses]
GO
ALTER TABLE [dbo].[RolePermissions]  WITH CHECK ADD  CONSTRAINT [FK_RolePermissions_AspNetRoles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[AspNetRoles] ([Id])
GO
ALTER TABLE [dbo].[RolePermissions] CHECK CONSTRAINT [FK_RolePermissions_AspNetRoles]
GO
ALTER TABLE [dbo].[ShippingMethods]  WITH CHECK ADD  CONSTRAINT [FK_ShippingMethods_ShippingProviders] FOREIGN KEY([ShippingProviderID])
REFERENCES [dbo].[ShippingProviders] ([ID])
GO
ALTER TABLE [dbo].[ShippingMethods] CHECK CONSTRAINT [FK_ShippingMethods_ShippingProviders]
GO
ALTER TABLE [dbo].[ShippingMethodTranslations]  WITH CHECK ADD  CONSTRAINT [FK_ShippingMethodTranslations_Languages] FOREIGN KEY([LanguageID])
REFERENCES [dbo].[Languages] ([ID])
GO
ALTER TABLE [dbo].[ShippingMethodTranslations] CHECK CONSTRAINT [FK_ShippingMethodTranslations_Languages]
GO
ALTER TABLE [dbo].[ShippingMethodTranslations]  WITH CHECK ADD  CONSTRAINT [FK_ShippingMethodTranslations_ShippingMethods] FOREIGN KEY([ShippingMethodID])
REFERENCES [dbo].[ShippingMethods] ([ID])
GO
ALTER TABLE [dbo].[ShippingMethodTranslations] CHECK CONSTRAINT [FK_ShippingMethodTranslations_ShippingMethods]
GO
ALTER TABLE [dbo].[ShippingProviderTranslations]  WITH CHECK ADD  CONSTRAINT [FK_ShippingProviderTranslations_Languages] FOREIGN KEY([LanguageID])
REFERENCES [dbo].[Languages] ([ID])
GO
ALTER TABLE [dbo].[ShippingProviderTranslations] CHECK CONSTRAINT [FK_ShippingProviderTranslations_Languages]
GO
ALTER TABLE [dbo].[ShippingProviderTranslations]  WITH CHECK ADD  CONSTRAINT [FK_ShippingProviderTranslations_ShippingProviders] FOREIGN KEY([ShippingProviderID])
REFERENCES [dbo].[ShippingProviders] ([ID])
GO
ALTER TABLE [dbo].[ShippingProviderTranslations] CHECK CONSTRAINT [FK_ShippingProviderTranslations_ShippingProviders]
GO
ALTER TABLE [dbo].[ShippingProviderWarehouses]  WITH CHECK ADD  CONSTRAINT [FK_ShippingProviderWarehouses_ShippingProviders] FOREIGN KEY([ShippingProviderID])
REFERENCES [dbo].[ShippingProviders] ([ID])
GO
ALTER TABLE [dbo].[ShippingProviderWarehouses] CHECK CONSTRAINT [FK_ShippingProviderWarehouses_ShippingProviders]
GO
ALTER TABLE [dbo].[ShippingProviderWarehouses]  WITH CHECK ADD  CONSTRAINT [FK_ShippingProviderWarehouses_Warehouses] FOREIGN KEY([WarehouseID])
REFERENCES [dbo].[Warehouses] ([ID])
GO
ALTER TABLE [dbo].[ShippingProviderWarehouses] CHECK CONSTRAINT [FK_ShippingProviderWarehouses_Warehouses]
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_Transactions_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([ID])
GO
ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [FK_Transactions_Orders]
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_Transactions_PaymentProviders] FOREIGN KEY([PaymentProviderID])
REFERENCES [dbo].[PaymentProviders] ([ID])
GO
ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [FK_Transactions_PaymentProviders]
GO
ALTER TABLE [dbo].[Warehouses]  WITH CHECK ADD  CONSTRAINT [FK_Warehouses_MerchantStores] FOREIGN KEY([MerchantID])
REFERENCES [dbo].[MerchantStores] ([ID])
GO
ALTER TABLE [dbo].[Warehouses] CHECK CONSTRAINT [FK_Warehouses_MerchantStores]
GO
USE [master]
GO
ALTER DATABASE [InfinityStoreDB] SET  READ_WRITE 
GO
