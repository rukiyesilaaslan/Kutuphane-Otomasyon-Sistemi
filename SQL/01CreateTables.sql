USE KutuphaneDB;
GO

-- =============================================
-- KULLANICI TABLOSU
-- Sisteme giriş yapan admin ve görevli bilgileri
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'KULLANICI')
BEGIN
    CREATE TABLE KULLANICI (
        KullaniciID INT IDENTITY(1,1) PRIMARY KEY,
        KullaniciAdi NVARCHAR(50) NOT NULL UNIQUE,
        Sifre NVARCHAR(100) NOT NULL,
        Rol NVARCHAR(20) NOT NULL
    );
END
GO

SELECT * FROM KULLANICI;
-- =============================================
-- UYE TABLOSU
-- Kütüphaneye kayıtlı üye bilgileri tutulur
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'UYE')
BEGIN
    CREATE TABLE UYE (
        UyeID INT IDENTITY(1,1) PRIMARY KEY,
        Ad NVARCHAR(50) NOT NULL,
        Soyad NVARCHAR(50) NOT NULL,
        TCNo CHAR(11) NOT NULL UNIQUE,
        Telefon NVARCHAR(15),
        Email NVARCHAR(100),
        KayitTarihi DATE NOT NULL DEFAULT GETDATE()
    );
END
GO

IF COL_LENGTH('UYE', 'ToplamBorc') IS NULL
BEGIN
ALTER TABLE UYE
ADD ToplamBorc DECIMAL(10,2) NOT NULL DEFAULT 0;
END
GO

-- =============================================
-- KATEGORI TABLOSU
-- Kitap kategorileri tutulur
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'KATEGORI')
BEGIN
    CREATE TABLE KATEGORI (
        KategoriID INT IDENTITY(1,1) PRIMARY KEY,
        KategoriAdi NVARCHAR(50) NOT NULL UNIQUE
    );
END
GO

-- =============================================
-- KITAP TABLOSU
-- Kütüphanedeki kitap bilgileri tutulur
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'KITAP')
BEGIN
    CREATE TABLE KITAP (
        KitapID INT IDENTITY(1,1) PRIMARY KEY,
        KitapAdi NVARCHAR(100) NOT NULL,
        Yazar NVARCHAR(100) NOT NULL,
        YayinYili INT,
        KategoriID INT NOT NULL,

        CONSTRAINT FK_KITAP_KATEGORI
        FOREIGN KEY (KategoriID)
        REFERENCES KATEGORI(KategoriID)
    );
END
GO
IF COL_LENGTH('KITAP', 'MevcutAdet') IS NULL
BEGIN
    ALTER TABLE KITAP
    ADD MevcutAdet INT NOT NULL DEFAULT 0;
END
GO

IF COL_LENGTH('KITAP', 'ToplamAdet') IS NULL
BEGIN
    ALTER TABLE KITAP
    ADD ToplamAdet INT NOT NULL DEFAULT 1;
END
GO
UPDATE KITAP
SET MevcutAdet = ToplamAdet; 
WHERE MevcutAdet = 1;
ALTER TABLE KITAP ADD Yayinevi NVARCHAR(100);
GO

-- =============================================
-- ODUNC TABLOSU
-- Üyelerin ödünç aldığı kitaplar tutulur
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ODUNC')
BEGIN
    CREATE TABLE ODUNC (
        OduncID INT IDENTITY(1,1) PRIMARY KEY,
        UyeID INT NOT NULL,
        KitapID INT NOT NULL,
        OduncTarihi DATE NOT NULL DEFAULT GETDATE(),
        IadeTarihi DATE NULL,

        CONSTRAINT FK_ODUNC_UYE
        FOREIGN KEY (UyeID)
        REFERENCES UYE(UyeID),

        CONSTRAINT FK_ODUNC_KITAP
        FOREIGN KEY (KitapID)
        REFERENCES KITAP(KitapID)
    );
END
GO

IF COL_LENGTH('ODUNC', 'SonTeslimTarihi') IS NULL
BEGIN
    ALTER TABLE ODUNC
    ADD SonTeslimTarihi DATE NOT NULL;
END
GO


-- =============================================
-- CEZA TABLOSU
-- Geç iade edilen kitaplar için ceza bilgileri
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'CEZA')
BEGIN
    CREATE TABLE CEZA (
        CezaID INT IDENTITY(1,1) PRIMARY KEY,
        OduncID INT NOT NULL,
        CezaTutari DECIMAL(6,2) NOT NULL,
        Aciklama NVARCHAR(200),

        CONSTRAINT FK_CEZA_ODUNC
        FOREIGN KEY (OduncID)
        REFERENCES ODUNC(OduncID)
    );
END
GO
IF COL_LENGTH('CEZA', 'UyeID') IS NULL
BEGIN
    ALTER TABLE CEZA
    ADD UyeID INT NOT NULL;
END
GO

IF NOT EXISTS (
    SELECT * FROM sys.foreign_keys 
    WHERE name = 'FK_CEZA_UYE'
)
BEGIN
    ALTER TABLE CEZA
    ADD CONSTRAINT FK_CEZA_UYE
    FOREIGN KEY (UyeID) REFERENCES UYE(UyeID);
END
GO


-- =============================================
-- LOG TABLOSU
-- Sistem işlemlerinin kaydı tutulur
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'LOG')
BEGIN
    CREATE TABLE LOG (
        LogID INT IDENTITY(1,1) PRIMARY KEY,
        TabloAdi NVARCHAR(50),
        Islem NVARCHAR(50),
        IslemTarihi DATETIME DEFAULT GETDATE()
    );
END
GO


-- =============================================
-- STORED PROCEDURE: Kitap Ekleme
-- =============================================
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'sp_KitapEkle')
    DROP PROCEDURE sp_KitapEkle;
GO

CREATE PROCEDURE sp_KitapEkle
    @KitapAdi NVARCHAR(100),
    @Yazar NVARCHAR(100),
    @YayinYili INT,
    @KategoriID INT
AS
BEGIN
    INSERT INTO KITAP (KitapAdi, Yazar, YayinYili, KategoriID)
    VALUES (@KitapAdi, @Yazar, @YayinYili, @KategoriID);
END
GO


-- =============================================
-- TRIGGER: KITAP tablosuna INSERT olunca LOG kaydı
-- =============================================
IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'tr_Kitap_Log')
    DROP TRIGGER tr_Kitap_Log;
GO

CREATE TRIGGER tr_Kitap_Log
ON KITAP
AFTER INSERT
AS
BEGIN
    INSERT INTO LOG (TabloAdi, Islem, IslemTarihi)
    SELECT
        'KITAP',
        'INSERT',
        GETDATE()
    FROM inserted;
END
GO
SELECT KitapAdi, Yazar, ToplamAdet, MevcutAdet
FROM KITAP;



SELECT * FROM KULLANICI;
SELECT * FROM UYE;
SELECT * FROM KATEGORI;
SELECT * FROM KITAP;
SELECT * FROM ODUNC;
SELECT * FROM CEZA;
SELECT * FROM LOG;
