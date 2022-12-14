USE [master]
GO
/****** Object:  Database [marketbarkod]    Script Date: 28.03.2022 06:40:47 ******/
CREATE DATABASE [marketbarkod]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'marketbarkod', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\marketbarkod.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'marketbarkod_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\marketbarkod_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [marketbarkod] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [marketbarkod].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [marketbarkod] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [marketbarkod] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [marketbarkod] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [marketbarkod] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [marketbarkod] SET ARITHABORT OFF 
GO
ALTER DATABASE [marketbarkod] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [marketbarkod] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [marketbarkod] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [marketbarkod] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [marketbarkod] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [marketbarkod] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [marketbarkod] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [marketbarkod] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [marketbarkod] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [marketbarkod] SET  DISABLE_BROKER 
GO
ALTER DATABASE [marketbarkod] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [marketbarkod] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [marketbarkod] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [marketbarkod] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [marketbarkod] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [marketbarkod] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [marketbarkod] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [marketbarkod] SET RECOVERY FULL 
GO
ALTER DATABASE [marketbarkod] SET  MULTI_USER 
GO
ALTER DATABASE [marketbarkod] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [marketbarkod] SET DB_CHAINING OFF 
GO
ALTER DATABASE [marketbarkod] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [marketbarkod] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [marketbarkod] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [marketbarkod] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [marketbarkod] SET QUERY_STORE = OFF
GO
USE [marketbarkod]
GO
USE [marketbarkod]
GO
/****** Object:  Sequence [dbo].[alisveris_no_sequence]    Script Date: 28.03.2022 06:40:48 ******/
CREATE SEQUENCE [dbo].[alisveris_no_sequence] 
 AS [bigint]
 START WITH 1278920
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [marketbarkod]
GO
/****** Object:  Sequence [dbo].[calisan_no_sequence]    Script Date: 28.03.2022 06:40:48 ******/
CREATE SEQUENCE [dbo].[calisan_no_sequence] 
 AS [bigint]
 START WITH -9223372036854775808
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [marketbarkod]
GO
/****** Object:  Sequence [dbo].[dep_no_sequence]    Script Date: 28.03.2022 06:40:48 ******/
CREATE SEQUENCE [dbo].[dep_no_sequence] 
 AS [bigint]
 START WITH 400
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [marketbarkod]
GO
/****** Object:  Sequence [dbo].[grup_no_sequence]    Script Date: 28.03.2022 06:40:48 ******/
CREATE SEQUENCE [dbo].[grup_no_sequence] 
 AS [bigint]
 START WITH 20010
 INCREMENT BY 10
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [marketbarkod]
GO
/****** Object:  Sequence [dbo].[mus_car_no_sequence]    Script Date: 28.03.2022 06:40:48 ******/
CREATE SEQUENCE [dbo].[mus_car_no_sequence] 
 AS [bigint]
 START WITH 13200
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [marketbarkod]
GO
/****** Object:  Sequence [dbo].[satis_no_sequence]    Script Date: 28.03.2022 06:40:48 ******/
CREATE SEQUENCE [dbo].[satis_no_sequence] 
 AS [bigint]
 START WITH 22000
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [marketbarkod]
GO
/****** Object:  Sequence [dbo].[stok_no_sequence]    Script Date: 28.03.2022 06:40:48 ******/
CREATE SEQUENCE [dbo].[stok_no_sequence] 
 AS [bigint]
 START WITH 1278920
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [marketbarkod]
GO
/****** Object:  Sequence [dbo].[sube_no_sequence]    Script Date: 28.03.2022 06:40:48 ******/
CREATE SEQUENCE [dbo].[sube_no_sequence] 
 AS [bigint]
 START WITH 120000
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [marketbarkod]
GO
/****** Object:  Sequence [dbo].[tedar_no_sequence]    Script Date: 28.03.2022 06:40:48 ******/
CREATE SEQUENCE [dbo].[tedar_no_sequence] 
 AS [bigint]
 START WITH 300
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [marketbarkod]
GO
/****** Object:  Sequence [dbo].[urun_no_sequence]    Script Date: 28.03.2022 06:40:48 ******/
CREATE SEQUENCE [dbo].[urun_no_sequence] 
 AS [bigint]
 START WITH 1000
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
/****** Object:  Table [dbo].[calisanlar]    Script Date: 28.03.2022 06:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[calisanlar](
	[calisan_no] [int] NOT NULL,
	[isim] [varchar](15) NULL,
	[soyisim] [varchar](15) NULL,
	[dogum_tarihi] [date] NULL,
	[dogum_yeri] [varchar](12) NULL,
	[adres] [varchar](100) NULL,
	[telefon] [varchar](12) NULL,
	[cinsiyet] [varchar](5) NULL,
	[ise_giris_tarihi] [date] NULL,
	[gorev] [varchar](35) NULL,
	[tc_no] [varchar](12) NULL,
	[maas] [int] NULL,
	[prim] [int] NULL,
	[calisan_id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_CALISANLAR] PRIMARY KEY CLUSTERED 
(
	[calisan_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__calisanl__E61FE7CACF7B37C4] UNIQUE NONCLUSTERED 
(
	[tc_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detaysatis]    Script Date: 28.03.2022 06:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detaysatis](
	[musteri_id] [int] NULL,
	[urunadi] [nvarchar](50) NULL,
	[miktari] [nvarchar](50) NULL,
	[satisfiyati] [nvarchar](50) NULL,
	[toplamfiyati] [nvarchar](50) NULL,
	[tarih] [nvarchar](50) NULL,
	[detaysatis_id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_detaysatis] PRIMARY KEY CLUSTERED 
(
	[detaysatis_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kullanici]    Script Date: 28.03.2022 06:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullanici](
	[kullanici_id] [int] NOT NULL,
	[sifre] [nvarchar](16) NULL,
 CONSTRAINT [PK_kullanici] PRIMARY KEY CLUSTERED 
(
	[kullanici_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[musteriler]    Script Date: 28.03.2022 06:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[musteriler](
	[isim] [varchar](15) NULL,
	[soyisim] [varchar](15) NULL,
	[adres] [varchar](100) NULL,
	[telefon] [varchar](12) NULL,
	[email] [varchar](30) NULL,
	[tc_no] [varchar](12) NOT NULL,
	[musteri_id] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_musteriler] PRIMARY KEY CLUSTERED 
(
	[musteri_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__musteril__AB6E6164EE61F3D1] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__musteril__E61FE7CADB2F17B9] UNIQUE NONCLUSTERED 
(
	[tc_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[satis]    Script Date: 28.03.2022 06:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[satis](
	[tarih] [nvarchar](50) NULL,
	[satis_id] [int] IDENTITY(1,1) NOT NULL,
	[toplamsepetmiktari] [float] NULL,
	[odeme] [nvarchar](50) NULL,
	[musteri_id] [int] NULL,
	[calisan_id] [nvarchar](50) NULL,
 CONSTRAINT [PK_satis] PRIMARY KEY CLUSTERED 
(
	[satis_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sepet]    Script Date: 28.03.2022 06:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sepet](
	[barkodno] [int] NULL,
	[urunadi] [nvarchar](50) NULL,
	[miktari] [int] NULL,
	[satisfiyati] [decimal](18, 2) NULL,
	[toplamfiyati] [decimal](18, 2) NULL,
	[tarih] [nvarchar](50) NULL,
	[sepet_id] [int] IDENTITY(1,1) NOT NULL,
	[odeme] [nvarchar](50) NULL,
	[musteri_id] [nvarchar](50) NULL,
	[calisan_id] [nvarchar](50) NULL,
	[toplamsepetmiktari] [int] NULL,
 CONSTRAINT [PK_sepet] PRIMARY KEY CLUSTERED 
(
	[sepet_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stok_tedarikci]    Script Date: 28.03.2022 06:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stok_tedarikci](
	[tedarikci_id] [int] NULL,
	[stok_id] [int] NULL,
	[ürün_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stoklar]    Script Date: 28.03.2022 06:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stoklar](
	[tedarikci_no] [int] NULL,
	[giris_tarihi] [date] NULL,
	[urun_sayisi] [int] NULL,
	[uretim_tarihi] [date] NULL,
	[raf_omru] [int] NULL,
	[stok_id] [int] NOT NULL,
 CONSTRAINT [PK_STOKLAR] PRIMARY KEY CLUSTERED 
(
	[stok_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tedarikciler]    Script Date: 28.03.2022 06:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tedarikciler](
	[tedarikci_id] [int] IDENTITY(1,1) NOT NULL,
	[firma_isim] [varchar](35) NULL,
	[adres] [varchar](100) NULL,
	[telefon] [varchar](12) NULL,
	[email] [varchar](30) NULL,
 CONSTRAINT [PK_TEDARIKCILER] PRIMARY KEY CLUSTERED 
(
	[tedarikci_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__tedarikc__AB6E61645AE2AE5F] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[urun_gruplari]    Script Date: 28.03.2022 06:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[urun_gruplari](
	[grup_id] [int] NOT NULL,
	[nitelik] [varchar](30) NULL,
	[kdv] [varchar](50) NULL,
	[saklama_kriteri] [varchar](30) NULL,
 CONSTRAINT [PK_URUN_GRUPLARI] PRIMARY KEY CLUSTERED 
(
	[grup_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[urunler]    Script Date: 28.03.2022 06:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[urunler](
	[barkodno] [int] NOT NULL,
	[grup_no] [int] NULL,
	[urun_adi] [varchar](25) NULL,
	[marka] [varchar](25) NULL,
	[gramaj] [varchar](50) NULL,
	[fiyat] [varchar](50) NULL,
	[stok_sayısı] [int] NULL,
	[urun_id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_URUNLER] PRIMARY KEY CLUSTERED 
(
	[barkodno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ürün_stok]    Script Date: 28.03.2022 06:40:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ürün_stok](
	[stok_id] [int] NULL,
	[urun_id] [int] NULL,
	[stok_sayisi] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[calisanlar]  WITH CHECK ADD  CONSTRAINT [FK_calisanlar_kullanici] FOREIGN KEY([calisan_no])
REFERENCES [dbo].[kullanici] ([kullanici_id])
GO
ALTER TABLE [dbo].[calisanlar] CHECK CONSTRAINT [FK_calisanlar_kullanici]
GO
ALTER TABLE [dbo].[sepet]  WITH CHECK ADD  CONSTRAINT [FK_sepet_urunler] FOREIGN KEY([barkodno])
REFERENCES [dbo].[urunler] ([barkodno])
GO
ALTER TABLE [dbo].[sepet] CHECK CONSTRAINT [FK_sepet_urunler]
GO
ALTER TABLE [dbo].[stok_tedarikci]  WITH CHECK ADD  CONSTRAINT [FK_stok_tedarikci_stoklar] FOREIGN KEY([stok_id])
REFERENCES [dbo].[stoklar] ([stok_id])
GO
ALTER TABLE [dbo].[stok_tedarikci] CHECK CONSTRAINT [FK_stok_tedarikci_stoklar]
GO
ALTER TABLE [dbo].[stok_tedarikci]  WITH CHECK ADD  CONSTRAINT [FK_stok_tedarikci_tedarikciler] FOREIGN KEY([tedarikci_id])
REFERENCES [dbo].[tedarikciler] ([tedarikci_id])
GO
ALTER TABLE [dbo].[stok_tedarikci] CHECK CONSTRAINT [FK_stok_tedarikci_tedarikciler]
GO
ALTER TABLE [dbo].[stok_tedarikci]  WITH CHECK ADD  CONSTRAINT [FK_stok_tedarikci_urunler] FOREIGN KEY([ürün_id])
REFERENCES [dbo].[urunler] ([barkodno])
GO
ALTER TABLE [dbo].[stok_tedarikci] CHECK CONSTRAINT [FK_stok_tedarikci_urunler]
GO
ALTER TABLE [dbo].[urunler]  WITH CHECK ADD  CONSTRAINT [FK_urunler_urun_gruplari] FOREIGN KEY([grup_no])
REFERENCES [dbo].[urun_gruplari] ([grup_id])
GO
ALTER TABLE [dbo].[urunler] CHECK CONSTRAINT [FK_urunler_urun_gruplari]
GO
ALTER TABLE [dbo].[ürün_stok]  WITH CHECK ADD  CONSTRAINT [FK_ürün_stok_stoklar] FOREIGN KEY([stok_id])
REFERENCES [dbo].[stoklar] ([stok_id])
GO
ALTER TABLE [dbo].[ürün_stok] CHECK CONSTRAINT [FK_ürün_stok_stoklar]
GO
ALTER TABLE [dbo].[ürün_stok]  WITH CHECK ADD  CONSTRAINT [FK_ürün_stok_urunler] FOREIGN KEY([urun_id])
REFERENCES [dbo].[urunler] ([barkodno])
GO
ALTER TABLE [dbo].[ürün_stok] CHECK CONSTRAINT [FK_ürün_stok_urunler]
GO
USE [master]
GO
ALTER DATABASE [marketbarkod] SET  READ_WRITE 
GO
