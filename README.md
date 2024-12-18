# Pratik - First Relation
Merhaba,
Bu proje C# ile Patika+ 12.hafta First Relation uygulaması için yapılmış bir uygulamadır.

## 📚 Proje Hakkında
Bu proje, aşağıdaki konuları öğrenmeye yardımcı olmak için tasarlanmıştır:
- MVC Yapısını kullanmak ve anlamak
- ASP.NET Core Kullanmak
- Entity Framework Kullanmak

 
## İstenilen Görev: 
Pratik - Code First Relation
Code First Yaklaşımı ile Veri Tabanı ve İlişkiler Oluşturma

Entity Framework Core kullanarak Code First yaklaşımını uygulamanız gerekiyor.

   1. User Tablosu:

        - `Id`: int, birincil anahtar ve otomatik artan.

        - `Username`: string, kullanıcının kullanıcı adı.

        - `Genre`: string, filmin türü (örneğin: "Action", "Comedy", "Drama").

        - `Email`: int, kullanıcının e-posta adresi.
          
   2. Post Tablosu:

        - `Id`: int, birincil anahtar ve otomatik artan.

        - `Title`: string, gönderinin başlığı.

        - `Content`: string, gönderinin içeriği.

        - `UserId`: int, gönderinin yazarı (kullanıcının kimliği).

Bir kullanıcının birden fazla gönderisi olabilir, ancak her gönderi yalnızca bir kullanıcıya ait olacak.
Context sınıfımızın ismi PatikaSecondDbContext olsun.
Veritabanı ismi PatikaCodeFirstDb2 olsun.
Veritabanında tablolar Users ve Posts olsun.
