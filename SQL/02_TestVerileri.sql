USE KutuphaneDB;
GO

-- KULLANICI
IF NOT EXISTS (SELECT 1 FROM KULLANICI WHERE KullaniciAdi = 'admin')
INSERT INTO KULLANICI (KullaniciAdi, Sifre, Rol)
VALUES ('admin', '1234', 'Admin');

IF NOT EXISTS (SELECT 1 FROM KULLANICI WHERE KullaniciAdi = 'gorevli1')
INSERT INTO KULLANICI (KullaniciAdi, Sifre, Rol)
VALUES ('gorevli1', '1234', 'Gorevli');

INSERT INTO KULLANICI (KullaniciAdi, Sifre, Rol) 
VALUES 
('gorevli2', '1234', 'Gorevli'),
('gorevli3', '1234', 'Gorevli');
GO


-- KATEGORI
IF NOT EXISTS (SELECT 1 FROM KATEGORI WHERE KategoriAdi = N'Roman')
INSERT INTO KATEGORI (KategoriAdi) VALUES (N'Roman');

IF NOT EXISTS (SELECT 1 FROM KATEGORI WHERE KategoriAdi = N'Bilim')
INSERT INTO KATEGORI (KategoriAdi) VALUES (N'Bilim');

IF NOT EXISTS (SELECT 1 FROM KATEGORI WHERE KategoriAdi = N'Tarih')
INSERT INTO KATEGORI (KategoriAdi) VALUES (N'Tarih');
 
IF NOT EXISTS (SELECT 1 FROM KATEGORI WHERE KategoriAdi = N'Bilgisayar')
INSERT INTO KATEGORI (KategoriAdi) VALUES (N'Bilgisayar');
EXEC sp_KitapEkle
    @KitapAdi = N'Suç ve Ceza',
    @Yazar = N'Dostoyevski',
    @YayinYili = 1866,
    @KategoriID = 1;

EXEC sp_KitapEkle
    @KitapAdi = N'İnsan Neyle Yaşar',
    @Yazar = N'Tolstoy',
    @YayinYili = 1885,
    @KategoriID = 1;

SELECT * FROM KULLANICI;
SELECT * FROM KATEGORI;
SELECT * FROM KITAP;

SELECT * FROM UYE;
