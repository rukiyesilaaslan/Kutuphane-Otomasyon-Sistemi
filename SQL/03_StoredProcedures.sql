USE KutuphaneDB;
GO

IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'sp_YeniOduncVer')
    DROP PROCEDURE sp_YeniOduncVer;
GO

CREATE PROCEDURE sp_YeniOduncVer
    @UyeID INT,
    @KitapID INT,
    @IslemYapanKullaniciID INT
AS
BEGIN
    SET NOCOUNT ON;

    IF (
        SELECT COUNT(*)
        FROM ODUNC
        WHERE UyeID = @UyeID
          AND IadeTarihi IS NULL
    ) >= 5
    BEGIN
        RAISERROR('Üye ödünç alma limitini aşmıştır.', 16, 1);
        RETURN;
    END

    IF NOT EXISTS (
        SELECT 1
        FROM KITAP
        WHERE KitapID = @KitapID
          AND MevcutAdet > 0
    )
    BEGIN
        RAISERROR('Kitap stokta yok.', 16, 1);
        RETURN;
    END

    INSERT INTO ODUNC (UyeID, KitapID, OduncTarihi, SonTeslimTarihi)
    VALUES (
        @UyeID,
        @KitapID,
        GETDATE(),
        DATEADD(DAY, 15, GETDATE())
    );

    UPDATE KITAP
    SET MevcutAdet = MevcutAdet - 1
    WHERE KitapID = @KitapID;
END
GO

SELECT * FROM ODUNC;
SELECT KitapID, KitapAdi, ToplamAdet, MevcutAdet FROM KITAP;
------------------------------------------------

IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'sp_KitapTeslimAl')
    DROP PROCEDURE sp_KitapTeslimAl;
GO

CREATE PROCEDURE sp_KitapTeslimAl
    @OduncID INT,
    @TeslimTarihi DATE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @SonTeslim DATE;
    DECLARE @GecikmeGun INT;
    DECLARE @KitapID INT;
    DECLARE @UyeID INT;

    SELECT 
        @SonTeslim = SonTeslimTarihi,
        @KitapID = KitapID,
        @UyeID = UyeID
    FROM ODUNC
    WHERE OduncID = @OduncID
      AND IadeTarihi IS NULL;

    IF @SonTeslim IS NULL
    BEGIN
        RAISERROR('Geçerli bir iade kaydı bulunamadı.', 16, 1);
        RETURN;
    END

    UPDATE ODUNC
    SET IadeTarihi = @TeslimTarihi
    WHERE OduncID = @OduncID;

    UPDATE KITAP
    SET MevcutAdet = MevcutAdet + 1
    WHERE KitapID = @KitapID;

    SET @GecikmeGun = DATEDIFF(DAY, @SonTeslim, @TeslimTarihi);

    IF @GecikmeGun > 0
    BEGIN
        INSERT INTO CEZA (OduncID, UyeID, CezaTutari, Aciklama)
        VALUES (
            @OduncID,
            @UyeID,
            @GecikmeGun * 5,
            CONCAT(@GecikmeGun, ' gün gecikme')
        );
    END
END
GO


SELECT * FROM ODUNC;
SELECT * FROM CEZA;
SELECT KitapID, KitapAdi, ToplamAdet, MevcutAdet FROM KITAP;
SELECT * FROM UYE;  
SELECT * FROM KITAP;
---------------------------------------------
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'sp_UyeOzetRapor')
    DROP PROCEDURE sp_UyeOzetRapor;
GO

CREATE PROCEDURE sp_UyeOzetRapor
    @UyeID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        U.UyeID,
        U.Ad,
        U.Soyad,

        -- Toplam aldığı kitap sayısı
        (SELECT COUNT(*) FROM ODUNC O WHERE O.UyeID = U.UyeID) AS ToplamAldigiKitapSayisi,

        -- Şu an elinde olan kitap sayısı
        (SELECT COUNT(*) FROM ODUNC O WHERE O.UyeID = U.UyeID AND O.IadeTarihi IS NULL) AS IadeEdilmemisKitapSayisi,

        -- CEZA tablosundan anlık hesaplanan gerçek borç
        ISNULL((SELECT SUM(CezaTutari) FROM CEZA WHERE UyeID = U.UyeID), 0) AS ToplamCezaTutari

    FROM UYE U
    WHERE U.UyeID = @UyeID;
END
GO

-------------------------------------------------
CREATE OR ALTER PROCEDURE dbo.sp_KitapEkle
    @KitapAdi NVARCHAR(100),
    @Yazar NVARCHAR(100),
    @YayinYili INT,
    @KategoriID INT,
    @Yayinevi NVARCHAR(100), 
    @ToplamAdet INT
AS
BEGIN
    INSERT INTO KITAP (KitapAdi, Yazar, YayinYili, KategoriID, Yayinevi, ToplamAdet, MevcutAdet)
    VALUES (@KitapAdi, @Yazar, @YayinYili, @KategoriID, @Yayinevi, @ToplamAdet, @ToplamAdet);
END
GO
