## Kütüphane Otomasyon Sistemi (Veritabanı Yönetim Sistemi Final Projesi)

Bu proje, bir kütüphanenin kitap, üye, ödünç alma ve ceza süreçlerini dijital ortamda yönetmek için geliştirilmiş kapsamlı bir masaüstü uygulamasıdır.

## 🚀Öne Çıkan Özellikler

* **Giriş (Login) Ekranı:** Rol tabanlı (Admin/Görevli) erişim kontrolü ve güvenli giriş.
* **Üye Yönetimi:** Üye kayıt, güncelleme ve silme. "Üye Durum Özeti" butonu ile borç ve kitap analizi.
* **Kitap Yönetimi:** Kitap stok takibi, kategori yönetimi ve stok kontrolü.
* **Ödünç/Teslim İşlemleri:** Saklı yordamlar ile kitap verme ve otomatik ceza hesaplamalı iade süreçleri.
* **Ceza Sistemi:** Geciken kitaplar için tarih bazlı ceza listeleme ve toplam borç takibi.
* **Dinamik Sorgu Paneli:** Kullanıcının seçtiği kriterlere (Yıl, Yazar, Kategori vb.) göre anlık SQL oluşturan ve sonuçları Excel/PDF formatında indiren gelişmiş arama modülü.

## 🛠Kullanılan Teknolojiler

* **Dil:** C# (WinForms)
* **Veritabanı:** Microsoft SQL Server
* **Veri Erişimi:** ADO.NET & Stored Procedures
* **Raporlama:** HTML Tabanlı Dinamik PDF Çıktısı


## ⚙️Kurulum ve Veritabanı Bağlantısı
Projeyi kendi bilgisayarınızda çalıştırmak için aşağıdaki adımları izleyin:

1. Veritabanı Kurulumu
* SQL Server Management Studio (SSMS) uygulamasını açın.
* `KutuphaneDB`adında boş bir veritabanı oluşturun.
* Proje klasöründeki `SQL/` dizininde bulunan `.sql` dosyasını SSMS içine sürükleyin ve Execute butonuna basarak tabloları, triggerları ve saklı yordamları (stored procedures) oluşturun.

2. Bağlantı Ayarları (Connection String)
* Projenin veritabanınıza bağlanabilmesi için şu değişikliği yapmalısınız:
* Visual Studio'da projeyi açın.
* Formların kod kısmındaki (veya varsa App.config içindeki) bağlantı cümlesini bulun: ` string cs = @"Data Source=.\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True;TrustServerCertificate=True"; `
* Server kısmını kendi SQL Server adınızla (Örn: `localhost` veya `BILGISAYAR-ADI\SQLEXPRESS`) değiştirin.

3. Uygulamayı Başlatma
* Visual Studio üzerinden projenizi derleyin (Build).
* Giriş ekranı için varsayılan kullanıcı bilgilerini kullanın:
* Kullanıcı Adı: `admin` (veya veritabanına eklediğiniz kullanıcı)
* Şifre: `1234`

## 💻 Gerekli Araçlar
* Visual Studio 2019/2022 (.NET masaüstü geliştirme paketi yüklü olmalı).
* SQL Server (Express sürümü yeterlidir) ve SSMS.
* .NET Framework 4.7.2 veya üzeri.

## 📂 Dosya Yapısı
* `KutuphaneOtomasyonu.sln`: Projeyi Visual Studio'da açan ana dosya.
* `SQL/`: Veritabanı tablolarını, tetikleyicileri (trigger) ve saklı yordamları (stored procedure) içeren SQL scriptleri.
* `Rapor/`: Proje teknik raporu ve ekran görüntüleri.

