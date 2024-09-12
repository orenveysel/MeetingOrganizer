# Meeting Organizer

## Proje Hakkında
**Meeting Organizer**, kullanıcıların toplantılarını kaydedebileceği, görüntüleyebileceği, güncelleyebileceği ve silebileceği basit bir uygulamadır. Bu uygulama, toplantıların tarih ve saat bilgilerini yönetmeyi kolaylaştırır. Kullanıcılar toplantılarının tarihlerini, başlangıç ve bitiş saatlerini kaydederek bir liste halinde görüntüleyebilir ve gerektiğinde güncelleyebilirler.

## Özellikler
- Yeni toplantı ekleme
- Toplantı listesini görüntüleme
- Toplantıları güncelleme
- Toplantıları silme

## Teknolojiler
Bu proje şu teknolojiler kullanılarak geliştirilmiştir:
- **ASP.NET Core MVC**
- **MySQL** (Veritabanı)
- **AJAX** (Sayfa yenilenmeden veri işlemleri)
- **JavaScript / jQuery**
- **Bootstrap** (CSS framework)
- **HTML5/CSS3**

## Kurulum

### Gereksinimler
Bu projeyi çalıştırmak için aşağıdaki araçların sisteminize kurulmuş olması gerekir:
- **.NET Core SDK 8.0**
- **MySQL**
- **Visual Studio 2022**

### Adımlar
1. **Projeyi Klonlayın**:
    ```bash
    git clone https://github.com/orenveysel/MeetingOrganizer.git
    ```

2. **Veritabanı Bağlantısını Yapılandırın**:
    - `/MeetingOrganizer.DAL/DbContexts/AppDbContext.cs` dosyasındaki veritabanı bağlantı ayarlarını düzenleyin. Aşağıdaki gibi ayarlamalısınız:
    ```
    var connectionString = "Server=localhost;Database=MeetingOrganizerAppDb;Uid=root;Pwd=YourPassword";
    ```

3. **Veritabanını Oluşturun**:
    - Proje dizininde aşağıdaki komutu çalıştırarak veritabanını oluşturun:
    ```bash
    dotnet ef migrations add InitialCreate
    dotnet ef database update
    ```

4. **Projeyi Çalıştırın**:
    - Proje dizininde şu komutu kullanarak uygulamayı çalıştırabilirsiniz:
    ```bash
    dotnet run
    ```

5. **Tarayıcıda Açın**:
    - Uygulama varsayılan olarak `https://localhost:7136` adresinde çalışır. Bu adrese giderek uygulamayı kullanabilirsiniz.

## Kullanım
1. **Yeni Toplantı Ekleme**:
    - Ana sayfada "Yeni Toplantı Ekle" formunu doldurun ve "Toplantı Ekle" butonuna tıklayın. 
    - Toplantılar listenizde yeni eklediğiniz toplantıyı görebilirsiniz.

2. **Toplantı Güncelleme**:
    - Bir toplantının yanındaki "Güncelle" butonuna tıklayın. Güncellemek istediğiniz bilgileri değiştirip formu kaydedin.

3. **Toplantı Silme**:
    - Bir toplantının yanındaki "Sil" butonuna tıklayarak toplantıyı silebilirsiniz.

## Ekran Görüntüleri

- Yeni Toplantı Ekleme, Toplantı Güncelleme/Silme ve Toplantı Listesi Görünümü:

![image](https://github.com/user-attachments/assets/1f0c9440-2544-4d97-876f-819d19e64ec2)

