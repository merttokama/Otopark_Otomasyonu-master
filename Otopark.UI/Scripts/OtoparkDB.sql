USE [OtoparkDB]
GO
/****** Object:  Table [dbo].[TBL_ABONE_BILGILERI]    Script Date: 23.02.2018 09:31:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_ABONE_BILGILERI](
	[ABONE_ID] [int] IDENTITY(1,1) NOT NULL,
	[AD] [nvarchar](max) NOT NULL,
	[SOYAD] [nvarchar](max) NOT NULL,
	[ADRES] [nvarchar](max) NULL,
	[ILCE] [nvarchar](max) NULL,
	[IL] [nvarchar](max) NULL,
	[TELEFON] [nvarchar](11) NOT NULL,
	[KAYIT_TARIHI] [nvarchar](max) NULL,
 CONSTRAINT [PK_TBL_ABONE_BILGILERI] PRIMARY KEY CLUSTERED 
(
	[ABONE_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_ABONELIKLER]    Script Date: 23.02.2018 09:31:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_ABONELIKLER](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ABONE_ID] [int] NOT NULL,
	[BASLANGIC_TARIHI] [datetime] NOT NULL,
	[BITIS_TARIHI] [datetime] NULL,
	[ABONE_UCRETI] [decimal](18, 0) NOT NULL,
	[KAYIT_TARIHI] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TBL_ABONELIKLER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_GIRIS_CIKIS_KAYITLARI]    Script Date: 23.02.2018 09:31:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_GIRIS_CIKIS_KAYITLARI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ABONE_ID] [int] NOT NULL,
	[ARAC_PLAKA] [nvarchar](10) NOT NULL,
	[GIRIS_TARIHI] [datetime] NOT NULL,
	[CIKIS_TARIHI] [datetime] NULL,
	[SURE_DAKIKA] [int] NULL,
	[UCRET] [decimal](18, 0) NULL,
	[KAYIT_TARIHI] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TBL_GIRIS_CIKIS_KAYITLARI] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_TARIFELER]    Script Date: 23.02.2018 09:31:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_TARIFELER](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ILK_SAAT] [nvarchar](max) NOT NULL,
	[SON_SAAT] [nvarchar](max) NOT NULL,
	[UCRET] [decimal](18, 0) NOT NULL,
	[AKTIF] [bit] NOT NULL,
	[KAYIT_TARIHI] [nvarchar](max) NULL,
 CONSTRAINT [PK_TBL_TARIFELER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TBL_ABONE_BILGILERI] ON 

INSERT [dbo].[TBL_ABONE_BILGILERI] ([ABONE_ID], [AD], [SOYAD], [ADRES], [ILCE], [IL], [TELEFON], [KAYIT_TARIHI]) VALUES (1, N'Abone Olmayan', N'Müşteri', N'YOK', N'YOK', N'YOK', N'00000000000', N'')
INSERT [dbo].[TBL_ABONE_BILGILERI] ([ABONE_ID], [AD], [SOYAD], [ADRES], [ILCE], [IL], [TELEFON], [KAYIT_TARIHI]) VALUES (2, N'Mert', N'Tokama', N'Cengiz Topel Caddesi', N'Ümraniye', N'İstanbul', N'05071189355', N'2018-02-23 00:00:00.000')
INSERT [dbo].[TBL_ABONE_BILGILERI] ([ABONE_ID], [AD], [SOYAD], [ADRES], [ILCE], [IL], [TELEFON], [KAYIT_TARIHI]) VALUES (3, N'Faruk', N'Tokama', N'Cengiz Topel Caddesi', N'Ümraniye', N'İstanbul', N'05424209388', N'22.02.2018 09:41:13')
INSERT [dbo].[TBL_ABONE_BILGILERI] ([ABONE_ID], [AD], [SOYAD], [ADRES], [ILCE], [IL], [TELEFON], [KAYIT_TARIHI]) VALUES (5, N'Gülistan', N'Tokama', N'Cengiz Topel Caddesi', N'Ümraniye', N'İstanbul', N'05058055040', N'23.02.2018 01:49:52')
INSERT [dbo].[TBL_ABONE_BILGILERI] ([ABONE_ID], [AD], [SOYAD], [ADRES], [ILCE], [IL], [TELEFON], [KAYIT_TARIHI]) VALUES (6, N'Emine Hatun', N'Üstün', N'Hacı Adil Yolu, Çayır Çimen Sok', N'Levent', N'İstanbul', N'05317070178', N'23.02.2018 01:54:43')
INSERT [dbo].[TBL_ABONE_BILGILERI] ([ABONE_ID], [AD], [SOYAD], [ADRES], [ILCE], [IL], [TELEFON], [KAYIT_TARIHI]) VALUES (7, N'Yeşim', N'Sakız', N'Ortabayır Mahallesi, Talatpaşa Cd', N'Kağıthane', N'İstanbul', N'05342009072', N'23.02.2018 01:56:19')
SET IDENTITY_INSERT [dbo].[TBL_ABONE_BILGILERI] OFF
SET IDENTITY_INSERT [dbo].[TBL_ABONELIKLER] ON 

INSERT [dbo].[TBL_ABONELIKLER] ([ID], [ABONE_ID], [BASLANGIC_TARIHI], [BITIS_TARIHI], [ABONE_UCRETI], [KAYIT_TARIHI]) VALUES (6, 2, CAST(N'2018-02-23T01:57:28.000' AS DateTime), CAST(N'2019-02-23T01:57:28.000' AS DateTime), CAST(500 AS Decimal(18, 0)), N'23.02.2018 01:57:28')
INSERT [dbo].[TBL_ABONELIKLER] ([ID], [ABONE_ID], [BASLANGIC_TARIHI], [BITIS_TARIHI], [ABONE_UCRETI], [KAYIT_TARIHI]) VALUES (7, 3, CAST(N'2018-02-23T01:57:28.000' AS DateTime), CAST(N'2019-02-23T01:57:28.000' AS DateTime), CAST(500 AS Decimal(18, 0)), N'23.02.2018 01:57:28')
INSERT [dbo].[TBL_ABONELIKLER] ([ID], [ABONE_ID], [BASLANGIC_TARIHI], [BITIS_TARIHI], [ABONE_UCRETI], [KAYIT_TARIHI]) VALUES (8, 5, CAST(N'2018-02-23T01:57:28.000' AS DateTime), CAST(N'2019-02-23T01:57:28.000' AS DateTime), CAST(500 AS Decimal(18, 0)), N'23.02.2018 01:57:28')
INSERT [dbo].[TBL_ABONELIKLER] ([ID], [ABONE_ID], [BASLANGIC_TARIHI], [BITIS_TARIHI], [ABONE_UCRETI], [KAYIT_TARIHI]) VALUES (9, 6, CAST(N'2018-02-23T01:57:28.000' AS DateTime), CAST(N'2018-08-20T01:57:28.000' AS DateTime), CAST(1000 AS Decimal(18, 0)), N'23.02.2018 01:57:28')
INSERT [dbo].[TBL_ABONELIKLER] ([ID], [ABONE_ID], [BASLANGIC_TARIHI], [BITIS_TARIHI], [ABONE_UCRETI], [KAYIT_TARIHI]) VALUES (10, 7, CAST(N'2018-02-23T01:57:28.000' AS DateTime), CAST(N'2018-08-20T01:57:28.000' AS DateTime), CAST(1000 AS Decimal(18, 0)), N'23.02.2018 01:57:28')
SET IDENTITY_INSERT [dbo].[TBL_ABONELIKLER] OFF
SET IDENTITY_INSERT [dbo].[TBL_GIRIS_CIKIS_KAYITLARI] ON 

INSERT [dbo].[TBL_GIRIS_CIKIS_KAYITLARI] ([ID], [ABONE_ID], [ARAC_PLAKA], [GIRIS_TARIHI], [CIKIS_TARIHI], [SURE_DAKIKA], [UCRET], [KAYIT_TARIHI]) VALUES (6, 2, N'26 GS 93', CAST(N'2018-02-22T01:59:38.000' AS DateTime), CAST(N'2018-02-23T03:27:36.000' AS DateTime), 2, CAST(30 AS Decimal(18, 0)), N'23.02.2018 01:59:38')
INSERT [dbo].[TBL_GIRIS_CIKIS_KAYITLARI] ([ID], [ABONE_ID], [ARAC_PLAKA], [GIRIS_TARIHI], [CIKIS_TARIHI], [SURE_DAKIKA], [UCRET], [KAYIT_TARIHI]) VALUES (7, 3, N'34 FT 1970', CAST(N'2018-02-22T01:59:38.000' AS DateTime), CAST(N'2018-02-23T03:27:28.000' AS DateTime), 2, CAST(36 AS Decimal(18, 0)), N'23.02.2018 01:59:38')
INSERT [dbo].[TBL_GIRIS_CIKIS_KAYITLARI] ([ID], [ABONE_ID], [ARAC_PLAKA], [GIRIS_TARIHI], [CIKIS_TARIHI], [SURE_DAKIKA], [UCRET], [KAYIT_TARIHI]) VALUES (8, 5, N'35 GCT 973', CAST(N'2018-02-23T02:01:04.000' AS DateTime), NULL, NULL, CAST(0 AS Decimal(18, 0)), N'23.02.2018 02:01:04')
INSERT [dbo].[TBL_GIRIS_CIKIS_KAYITLARI] ([ID], [ABONE_ID], [ARAC_PLAKA], [GIRIS_TARIHI], [CIKIS_TARIHI], [SURE_DAKIKA], [UCRET], [KAYIT_TARIHI]) VALUES (9, 6, N'34 EHU 240', CAST(N'2018-02-23T02:01:37.000' AS DateTime), NULL, NULL, CAST(0 AS Decimal(18, 0)), N'23.02.2018 02:01:37')
INSERT [dbo].[TBL_GIRIS_CIKIS_KAYITLARI] ([ID], [ABONE_ID], [ARAC_PLAKA], [GIRIS_TARIHI], [CIKIS_TARIHI], [SURE_DAKIKA], [UCRET], [KAYIT_TARIHI]) VALUES (10, 7, N'34 YS 842', CAST(N'2018-02-23T02:02:15.000' AS DateTime), NULL, NULL, CAST(0 AS Decimal(18, 0)), N'23.02.2018 02:02:15')
SET IDENTITY_INSERT [dbo].[TBL_GIRIS_CIKIS_KAYITLARI] OFF
SET IDENTITY_INSERT [dbo].[TBL_TARIFELER] ON 

INSERT [dbo].[TBL_TARIFELER] ([ID], [ILK_SAAT], [SON_SAAT], [UCRET], [AKTIF], [KAYIT_TARIHI]) VALUES (3, N'22.02.2018 08:00:00', N'22.02.2018 09:00:00', CAST(15 AS Decimal(18, 0)), 1, N'23.02.2018 01:58:28')
INSERT [dbo].[TBL_TARIFELER] ([ID], [ILK_SAAT], [SON_SAAT], [UCRET], [AKTIF], [KAYIT_TARIHI]) VALUES (4, N'22.02.2018 08:00:00', N'28.02.2018 00:00:00', CAST(215 AS Decimal(18, 0)), 1, N'23.02.2018 01:58:28')
SET IDENTITY_INSERT [dbo].[TBL_TARIFELER] OFF
ALTER TABLE [dbo].[TBL_ABONELIKLER]  WITH CHECK ADD  CONSTRAINT [FK_TBL_ABONELIKLER_TBL_ABONE_BILGILERI] FOREIGN KEY([ABONE_ID])
REFERENCES [dbo].[TBL_ABONE_BILGILERI] ([ABONE_ID])
GO
ALTER TABLE [dbo].[TBL_ABONELIKLER] CHECK CONSTRAINT [FK_TBL_ABONELIKLER_TBL_ABONE_BILGILERI]
GO
ALTER TABLE [dbo].[TBL_GIRIS_CIKIS_KAYITLARI]  WITH CHECK ADD  CONSTRAINT [FK_TBL_GIRIS_CIKIS_KAYITLARI_TBL_ABONE_BILGILERI] FOREIGN KEY([ABONE_ID])
REFERENCES [dbo].[TBL_ABONE_BILGILERI] ([ABONE_ID])
GO
ALTER TABLE [dbo].[TBL_GIRIS_CIKIS_KAYITLARI] CHECK CONSTRAINT [FK_TBL_GIRIS_CIKIS_KAYITLARI_TBL_ABONE_BILGILERI]
GO
/****** Object:  StoredProcedure [dbo].[addAboneBilgi]    Script Date: 23.02.2018 09:31:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[addAboneBilgi]
( @ad nvarchar(max), @soyad nvarchar(max), @adres nvarchar(max), @ilce nvarchar(max), @il nvarchar(max), @telefon nvarchar(11),  @kayitTarihi nvarchar(max)
)
as
insert into TBL_ABONE_BILGILERI(AD,SOYAD,ADRES,ILCE,IL,TELEFON,KAYIT_TARIHI) Values ( @ad, @soyad, @adres, @ilce, @il, @telefon, @kayitTarihi) 
GO
/****** Object:  StoredProcedure [dbo].[addAbonelik]    Script Date: 23.02.2018 09:31:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[addAbonelik]
( @aboneId int, @baslangicTarihi datetime, @bitisTarihi datetime, @aboneUcret decimal, @kayitTarihi nvarchar(max)
)
as
insert into TBL_ABONELIKLER(ABONE_ID,BASLANGIC_TARIHI,BITIS_TARIHI,ABONE_UCRETI,KAYIT_TARIHI) Values ( @aboneId, @baslangicTarihi, @bitisTarihi, @aboneUcret, @kayitTarihi) 
GO
/****** Object:  StoredProcedure [dbo].[addAracGirisi]    Script Date: 23.02.2018 09:31:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[addAracGirisi]
( @aboneId int, @aracPlaka nvarchar(10), @girisTarihi datetime, @kayitTarihi nvarchar(max),
@ucret int
)
as
insert into TBL_GIRIS_CIKIS_KAYITLARI(ABONE_ID,ARAC_PLAKA,GIRIS_TARIHI,KAYIT_TARIHI, UCRET) Values ( @aboneId, @aracPlaka, @girisTarihi, @kayitTarihi, @ucret) 
GO
/****** Object:  StoredProcedure [dbo].[addTarife]    Script Date: 23.02.2018 09:31:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[addTarife]
( @ilkSaat nvarchar(max), @sonSaat nvarchar(max), @ucret decimal, @aktif bit, @kayitTarihi nvarchar(max)
)
as
insert into TBL_TARIFELER(ILK_SAAT,SON_SAAT,UCRET,AKTIF,KAYIT_TARIHI) Values ( @ilkSaat, @sonSaat, @ucret, @aktif, @kayitTarihi) 
GO
/****** Object:  StoredProcedure [dbo].[selectAboneBilgi]    Script Date: 23.02.2018 09:31:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[selectAboneBilgi]
as select * from TBL_ABONE_BILGILERI
GO
/****** Object:  StoredProcedure [dbo].[selectAboneligiAktifOlanlar]    Script Date: 23.02.2018 09:31:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[selectAboneligiAktifOlanlar]
as 
select AB.AD, AB.SOYAD, AB.ADRES, AB.IL, AB.ILCE, AB.TELEFON, AB.KAYIT_TARIHI from TBL_ABONE_BILGILERI AB
join TBL_ABONELIKLER A on
A.ABONE_ID = AB.ABONE_ID 
where
(BITIS_TARIHI >= GETDATE() and BASLANGIC_TARIHI <= GETDATE())
GO
/****** Object:  StoredProcedure [dbo].[selectAbonelikler]    Script Date: 23.02.2018 09:31:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectAbonelikler]
as select * from TBL_ABONELIKLER
GO
/****** Object:  StoredProcedure [dbo].[selectAylikRapor]    Script Date: 23.02.2018 09:31:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectAylikRapor]
(
@ay int
)
as  
select ARAC_PLAKA, GIRIS_TARIHI, CIKIS_TARIHI, SURE_DAKIKA ,UCRET from TBL_GIRIS_CIKIS_KAYITLARI where @ay=month(CIKIS_TARIHI)
GO
/****** Object:  StoredProcedure [dbo].[selectAylikUcretToplam]    Script Date: 23.02.2018 09:31:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[selectAylikUcretToplam]
(
 @BaslangicTarihi  datetime,
 @BitisTarihi  datetime
)
as   
select sum(UCRET) from TBL_GIRIS_CIKIS_KAYITLARI where	 CIKIS_TARIHI between @BaslangicTarihi and @BitisTarihi
GO
/****** Object:  StoredProcedure [dbo].[selectGirisCikisKayitlari]    Script Date: 23.02.2018 09:31:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectGirisCikisKayitlari]
as select * from TBL_GIRIS_CIKIS_KAYITLARI
GO
/****** Object:  StoredProcedure [dbo].[selectOtoparktakiAraclar]    Script Date: 23.02.2018 09:31:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[selectOtoparktakiAraclar]
as 
select ID, ARAC_PLAKA, GIRIS_TARIHI from TBL_GIRIS_CIKIS_KAYITLARI
where (CIKIS_TARIHI is null) 
GO
/****** Object:  StoredProcedure [dbo].[selectPlakaHareketleri]    Script Date: 23.02.2018 09:31:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[selectPlakaHareketleri]
(@aracPlaka nvarchar(10))
as 
select ARAC_PLAKA, GIRIS_TARIHI, CIKIS_TARIHI, SURE_DAKIKA from TBL_GIRIS_CIKIS_KAYITLARI
where  ARAC_PLAKA=@aracPlaka
GO
/****** Object:  StoredProcedure [dbo].[selectTarifeler]    Script Date: 23.02.2018 09:31:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectTarifeler]
as select * from TBL_TARIFELER
GO
/****** Object:  StoredProcedure [dbo].[updateAracCikisi]    Script Date: 23.02.2018 09:31:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[updateAracCikisi]
( @id int, @cikisTarihi datetime, @sureDakika int, @ucret decimal 
)
as
update TBL_GIRIS_CIKIS_KAYITLARI set CIKIS_TARIHI=@cikisTarihi, SURE_DAKIKA=@sureDakika, UCRET=@ucret where ID=@id
GO
