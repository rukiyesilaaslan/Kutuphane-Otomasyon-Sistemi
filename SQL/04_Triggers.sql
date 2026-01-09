USE KutuphaneDB;
GO

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'TR_ODUNC_INSERT')
    DROP TRIGGER TR_ODUNC_INSERT;
GO

CREATE TRIGGER TR_ODUNC_INSERT
ON ODUNC
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE K
    SET K.MevcutAdet = K.MevcutAdet - 1
    FROM KITAP K
    INNER JOIN inserted I ON K.KitapID = I.KitapID;

    INSERT INTO LOG (TabloAdi, Islem, IslemTarihi)
    VALUES ('ODUNC', 'ODUNC tablosuna kayıt eklendi', GETDATE());
END;
GO

EXEC sp_YeniOduncVer
    @UyeID = 1,
    @KitapID = 1,
    @IslemYapanKullaniciID = 1;

SELECT KitapID, KitapAdi, MevcutAdet FROM KITAP;
SELECT * FROM ODUNC;
SELECT * FROM LOG;

-------------------------------------------
IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'TR_ODUNC_UPDATE_TESLIM')
    DROP TRIGGER TR_ODUNC_UPDATE_TESLIM;
GO

CREATE TRIGGER TR_ODUNC_UPDATE_TESLIM
ON ODUNC
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE K
    SET K.MevcutAdet = K.MevcutAdet + 1
    FROM KITAP K
    INNER JOIN inserted I ON K.KitapID = I.KitapID
    INNER JOIN deleted D ON D.OduncID = I.OduncID
    WHERE D.IadeTarihi IS NULL
      AND I.IadeTarihi IS NOT NULL;

    INSERT INTO LOG (TabloAdi, Islem, IslemTarihi)
    SELECT
        'ODUNC',
        'Kitap teslim alındı',
        GETDATE()
    FROM inserted I
    INNER JOIN deleted D ON D.OduncID = I.OduncID
    WHERE D.IadeTarihi IS NULL
      AND I.IadeTarihi IS NOT NULL;
END;
GO

SELECT * FROM ODUNC;

UPDATE ODUNC
SET IadeTarihi = GETDATE()
WHERE OduncID = 1;

SELECT KitapID, KitapAdi, MevcutAdet FROM KITAP;
SELECT * FROM LOG;

---------------------------------------

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'TR_CEZA_INSERT')
    DROP TRIGGER TR_CEZA_INSERT;
GO

CREATE TRIGGER TR_CEZA_INSERT
ON CEZA
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE U
    SET U.ToplamBorc = U.ToplamBorc + I.CezaTutari
    FROM UYE U
    INNER JOIN inserted I ON U.UyeID = I.UyeID;

    INSERT INTO LOG (TabloAdi, Islem, IslemTarihi)
    VALUES ('CEZA', 'Ceza eklendi, üye borcu güncellendi', GETDATE());
END;
GO

SELECT UyeID, ToplamBorc FROM UYE;

INSERT INTO CEZA (OduncID, UyeID, CezaTutari, Aciklama)
VALUES (1, 1, 25, N'Geç teslim');

SELECT UyeID, ToplamBorc FROM UYE;
SELECT * FROM CEZA;
SELECT * FROM LOG;

-------------------------------------

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'TR_UYE_DELETE_BLOCK')
    DROP TRIGGER TR_UYE_DELETE_BLOCK;
GO

CREATE TRIGGER TR_UYE_DELETE_BLOCK
ON UYE
INSTEAD OF DELETE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM ODUNC O
        INNER JOIN deleted D ON O.UyeID = D.UyeID
        WHERE O.IadeTarihi IS NULL
    )
    BEGIN
        RAISERROR('Üyenin aktif ödünç kaydı olduğu için silinemez.', 16, 1);
        RETURN;
    END

    IF EXISTS (
        SELECT 1
        FROM deleted
        WHERE ToplamBorc > 0
    )
    BEGIN
        RAISERROR('Üyenin borcu bulunduğu için silinemez.', 16, 1);
        RETURN;
    END

    DELETE FROM UYE
    WHERE UyeID IN (SELECT UyeID FROM deleted);
END;
GO

DELETE FROM UYE WHERE UyeID = 1;
INSERT INTO UYE (Ad, Soyad, TCNo)
VALUES ('Test', 'Sil', '99999999999');

SELECT * FROM UYE;

DELETE FROM UYE WHERE TCNo = '99999999999';
