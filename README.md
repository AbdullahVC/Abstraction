# **Çalışan Görevleri Programı**

Bu proje, bir şirketin çalışanlarını temsil eden basit bir C# uygulamasıdır. Uygulama, farklı pozisyonlarda çalışanları temsil eden sınıflar oluşturur ve her çalışanın görevini konsol ekranında yazdırır. Proje, nesne yönelimli programlamanın (OOP) soyutlama (abstraction) ilkesini kullanır.

## **Özellikler**

- **Calisan Sınıfı (Abstract):**
  - `Ad`, `Soyad`, `Departman` gibi ortak özellikleri barındıran abstract bir sınıftır.
  - `Gorev` adında bir abstract metod içerir. Bu metot, türetilmiş sınıflar tarafından ezilerek (override edilerek) kendi görev tanımlarını yapar.

- **Derived Sınıflar:**
  - **YazilimGelistiricisi**: `Calisan` sınıfından türetilmiştir. `Gorev` metodunu override ederek "Yazılım geliştirici olarak çalışıyorum." mesajını verir.
  - **ProjeYoneticisi**: `Calisan` sınıfından türetilmiştir. `Gorev` metodunu override ederek "Proje yöneticisi olarak çalışıyorum." mesajını verir.
  - **SatısTemsilcisi**: `Calisan` sınıfından türetilmiştir. `Gorev` metodunu override ederek "Satış temsilcisi olarak çalışıyorum." mesajını verir.

## **Kullanım**

1. Program çalıştırıldığında, `Calisan` sınıfından türetilmiş olan `YazilimGelistiricisi`, `ProjeYoneticisi` ve `SatısTemsilcisi` sınıflarından nesneler oluşturulur.
2. Her bir çalışan nesnesi için `Ad`, `Soyad` ve `Departman` bilgileri manuel olarak atanır.
3. Ardından, her çalışanın `Gorev()` metodu çağrılır ve konsol ekranında ilgili çalışanın yaptığı iş belirtilir.

## **Kullanılan Teknolojiler**

- **C# Programlama Dili:** Uygulamanın ana programlama dilidir.
- **.NET Core:** Uygulamanın geliştirilmesi ve çalıştırılması için kullanılan platformdur.
- **Nesne Yönelimli Programlama (OOP):** Projede abstraction (soyutlama) prensibi kullanılarak çalışanların görev tanımları yapılmıştır.

