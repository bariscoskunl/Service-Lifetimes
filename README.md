# Service Lifetimes in ASP.NET Core

Bu proje, ASP.NET Core'da servis ömürlerini (**Transient**, **Scoped**, **Singleton**) somutlaştırmak ve Dependency Injection mekanizmasının nesne ömürlerini nasıl yönettiğini gözlemlemek amacıyla geliştirilmiştir.

## 🚀 Proje Amacı
Uygulama, aynı HTTP isteği içerisinde her servis tipinden ikişer örnek enjekte ederek, üretilen **GUID** değerleri üzerinden farkları bir tablo üzerinde görselleştirir.

## 🛠️ Kullanılan Yapılar
- **ASP.NET Core 10.0 MVC**
- **Dependency Injection** (Built-in IoC Container)
- **Interface Segregation** & **Inheritance** prensipleri

## 📊 Servis Ömürleri Özeti
- **Transient:** Her çağrıldığında (enjeksiyonda) yeni bir nesne oluşturulur.
- **Scoped:** Bir HTTP isteği (Request) boyunca tek bir nesne oluşturulur ve paylaşılır.
- **Singleton:** Uygulama ayağa kalktığından itibaren sadece bir kez nesne oluşturulur ve her yerde aynı nesne kullanılır.

---
*Bu proje, [Medium](https://medium.com/@bariscoskun441) üzerindeki teknik blog yazım için kaynak kod olarak hazırlanmıştır.*
