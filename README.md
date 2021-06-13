# ReCapProject - Rent A Car System

## Proje Hakkında

N-Katmanlı Solid mimari yapısı ile hazırlanan, EntityFramework kullanılarak CRUD işlemlerinin yapıldığı, kayıt olma giriş yapabilme Jwt teknikleri ile token alarak güvenliği sağlanan, Caching, Validation, Transaction,Performance işlemlerini Autofac paketi ile oluşturulan Aspectleri kullanarak gerçekleştiren, Wpf arayüzü ile çalışan, araç Kiralama iş yerlerine yönelik örnek bir projedir.Proje içerisinde data kaynakları kolayca değiştirilebilir, yeni nesneler eklenebilir, bütün iş istekleri değiştirilebilir.Yapılacak olanlar eski kodları bozmadan sürekli ekleme ile yapılabilir.Proje sürdürülebilirlik prensibini yerine getirmektedir.

### Backend Teknolojileri ve Teknikleri

MsSql, Asp.Net Core for Restful api,EntityFramework Core,Autofac,FluentValidation
Layered Architecture Design Pattern,IOC, AOP, Aspects, JWT

## Katmanlar

### Entities Katmanı

Entities Katmanı'nda Dtos ve Concrete olmak üzere iki adet klasör bulunmaktadır.Concrete klasörü veri tabanından gelen somut nesnelerin özelliklerini tutmak için oluşturulmuştur.Dtos klasörü ise veri tabanında birbiri ile ilişkili olan nesnelerin ilişkili özelliklerini birlikte kullanabilmek için oluşturulmuştur.

#### Dtos


#### Concrete




### Core Katmanı


Core Katmanı evrensel bir katmandır. Geliştirilecek her projede kullanılabilir, isimlendirme kuralları ve oluşturulma düzeni sebebi ile oldukça kullanışlıdır. Core Katmanı'nda DataAccess, Entities, Utilities, Aspects, CrossCuttingConcerns, DependencyResolvers ve Extensions klasörleri bulunmaktadır. Aspects kasörü Caching, Validation, Transaction,Performance işlemlerinin Autofac attribute altyapısını hazırlar.CrossCuttingConcerns klasöründe Validation ve Cache yönetimi proje içerisinde, dikey katmanda dinamik çalışabilmesi için (generics)genelleştirildi.DependencyResolvers klasöründe servis konfigrasyonları yapıldı.DataAccess klasöründe bütün CRUD operasyonları ve DataBaseler generic olarak yapılandırıldı.Extensions içerisinde Jwt için yönetimi kolaylaştıran genişlemeler yapıldı.Utilities içerisinde iş metodu kurallarının yönetimi kolaylaştırıldı, belge ekleme işlemleri kodlandı,Aspectlerin araya girebilmesi için alt yapı hazırlandı ve ezilmeyi bekliyor, Results yapısı kurularak hata yönetimi yapılandırıldı, Jwt ve hashing teknikleriyle güvenlik yapılandırıldı.


#### Core


##Data Access Katmanı
Data Access Katmanı'nda Abstract interfaceleri barındıran ve Concrete classları barındıran klasörler bulunmaktadır.Crud operasyonlarını core katmanından miras alarak gerçekleştirmektedir.Gelebilecek iş kodları için altyapı burada hazırlanır.Objelerin data transferleri için kullanacağı data baseler ve varlıkların bağlantıları Data Access Katmanı'nda yapılandırıldı.

### DataAccess


### Business Katmanı
Business Katmanı'nda altyapısı hazır olan bütün serviserin yönetimleri yazıldı.Sürekli değişebilen iş kodlarımızı altyapıyı değiştirmeden ekleyebildiğimiz katmandır.Sürekliliğin korunduğu ReCap projemde birçok değişikliğin sadece burada yapılıyor olması yönetimi, sürekli gelişimi çok kolaylaştırmaktadır.

#### Concrete


