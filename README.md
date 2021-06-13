# ReCapProject - Rent A Car System

## 	&#128204; Proje Hakkında

&nbsp;&nbsp; N-Katmanlı Solid mimari yapısı ile hazırlanan, **EntityFramework** kullanarak CRUD operasyonları, **Jwt** teknikleri ile token alarak güvenli bir şekilde kayıt olma ve giriş işlemlerini yapıyoruz. **Caching**, **Validation**, **Transaction**, **Performance** gibi işlemleri Aspect Oriented Programming (AOP) mantığını kullanarak gerçekleştiriyoruz.Proje içerisindeki kaynaklar kolayca değiştirilebilir ve yapılacak olan bütün işlemler için hiçbir şekilde kod değişikliğine gerek duyulmamaktadır.Oluşturulan farklı katmanlar sayesinde **Plug and Play (Tak ve Çalıştır.)** ortamı  oluşturulmuştur.

* ### Backend Teknolojileri ve Teknikleri

>MsSql</br>
Asp.Net Core for Restful api</br>
EntityFramework Core</br>
Autofac</br>
FluentValidation</br>
Layered Architecture Design Pattern</br> 
Inversion Of Control (IOC)</br>
Aspect Oriented Programming (AOP)</br>
JWT

## &#128218; Katmanlar

* ### Entities Katmanı

&nbsp;&nbsp; **Entities Katmanı**'nda Dtos ve Concrete olmak üzere iki adet klasör bulunmaktadır.Concrete klasörü veri tabanından gelen somut nesnelerin özelliklerini tutmak için, Dtos klasörü ise veri tabanında birbiri ile ilişkili olan nesnelerin ilişkili özelliklerini birlikte kullanabilmek için oluşturulmuştur.

#### &#128194; Dtos 

>  &#128196; [CarDetailDto.cs ](https://github.com/Serkanydn/ReCapProject/blob/master/Entities/DTOs/CarDetailDto.cs)</br>
&#128196; [CustomerDetailDto.cs ](https://github.com/Serkanydn/ReCapProject/blob/master/Entities/DTOs/CustomerDetailDto.cs)</br>
 &#128196; [RentalDetailDto.cs ](https://github.com/Serkanydn/ReCapProject/blob/master/Entities/DTOs/RentalDetailDto.cs)</br>
 &#128196; [UserForLoginDto.cs](https://github.com/Serkanydn/ReCapProject/blob/master/Entities/DTOs/UserForLoginDto.cs)</br>
 &#128196; [UserForRegisterDto.cs ](https://github.com/Serkanydn/ReCapProject/blob/master/Entities/DTOs/UserForRegisterDto.cs)</br>



#### &#128194; Concrete


> &#128196; [Brand.cs ](https://github.com/Serkanydn/ReCapProject/blob/master/Entities/Concrete/Brand.cs)</br>
 &#128196; [Car.cs ](https://github.com/Serkanydn/ReCapProject/blob/master/Entities/Concrete/Car.cs)</br>
 &#128196; [CarImage.cs ](https://github.com/Serkanydn/ReCapProject/blob/master/Entities/Concrete/CarImage.cs)</br>
 &#128196; [Color.cs](https://github.com/Serkanydn/ReCapProject/blob/master/Entities/Concrete/Color.cs)</br>
 &#128196; [Customer.cs ](https://github.com/Serkanydn/ReCapProject/blob/master/Entities/Concrete/Customer.cs)</br>
 &#128196; [Rental.cs ](https://github.com/Serkanydn/ReCapProject/blob/master/Entities/Concrete/Rental.cs)</br>
 &#128196; [Payment.cs ](https://github.com/Serkanydn/ReCapProject/blob/master/Entities/Concrete/Payment.cs)</br>


* ### Core Katmanı


&nbsp;&nbsp; Core Katmanı evrensel bir katmandır. Geliştirilecek her projede kullanılabilir, isimlendirme kuralları ve oluşturulma düzeni sebebi ile oldukça kullanışlıdır. Core Katmanı'nda DataAccess, Entities, Utilities, Aspects, CrossCuttingConcerns, DependencyResolvers ve Extensions klasörleri bulunmaktadır. Aspects klasörü Caching, Validation, Transaction,Performance işlemleri için Autofac attribute altyapısını hazırlar.CrossCuttingConcerns klasöründe Validation ve Cache yönetimi proje içerisinde generics olarak genelleştirildi.DependencyResolvers klasöründe servis konfigürasyonları yapıldı.DataAccess klasöründe bütün CRUD operasyonları ve Databaseler generics olarak yapılandırıldı.Extensions içerisinde Jwt için yönetimi kolaylaştıran genişlemeler yapıldı.Utilities içerisinde iş metodu kurallarının yönetimi kolaylaştırıldı, belge ekleme işlemleri kodlandı, aspectlerin araya girebilmesi için alt yapı hazırlandı, Results yapısı kurularak hata yönetimi, Jwt ve hashing teknikleriyle güvenlik yapılandırıldı.


#### &#128194; Core

>&#128196; [Autofac ](https://github.com/Serkanydn/ReCapProject/tree/master/Core/Aspect/Autofac)</br>
 &#128196; [CrossCuttingConcerns.cs ](https://github.com/Serkanydn/ReCapProject/tree/master/Core/CrossCuttingConcerns)</br>
 &#128196; [DataAccess](https://github.com/Serkanydn/ReCapProject/tree/master/Core/DataAccess)</br>
 &#128196; [DependencyResolvers](https://github.com/Serkanydn/ReCapProject/tree/master/Core/DependencyResolvers)</br>
 &#128196; [Entity](https://github.com/Serkanydn/ReCapProject/tree/master/Core/Entity)</br>
 &#128196; [Extensions](https://github.com/Serkanydn/ReCapProject/tree/master/Core/Extensions)</br>
 &#128196; [Utilities](https://github.com/Serkanydn/ReCapProject/tree/master/Core/Utilities)</br>


* ### Data Access Katmanı

&nbsp;&nbsp; Database bağlantısı yapıp gerekli olan datalara ulaşmak için kullandığımız katman.Bu katmanda sadece datalara ulaşmak için gerekli olan kodları yazıyoruz.

#### &#128194; DataAccess

>&#128196; [Abstract](https://github.com/Serkanydn/ReCapProject/tree/master/DataAccess/Abstract)</br>
 &#128196; [EntityFramework](https://github.com/Serkanydn/ReCapProject/tree/master/DataAccess/Concrete/EntityFramework)</br>

* ### Business Katmanı
&nbsp;&nbsp; Core katmanında altyapısı hazır olan servislerin yönetimlerini ve iş kurallarını yazdığımız katmandır.

#### &#128194; Concrete
> &#128196; [AuthManager.cs ](https://github.com/Serkanydn/ReCapProject/blob/master/Business/Concrete/AuthManager.cs)</br>
 &#128196; [BrandManager.cs ](https://github.com/Serkanydn/ReCapProject/blob/master/Business/Concrete/BrandManager.cs)</br>
&#128196; [CarImageManager.cs ](https://github.com/Serkanydn/ReCapProject/blob/master/Business/Concrete/CarImageManager.cs)</br>
 &#128196; [ColorManager.cs ](https://github.com/Serkanydn/ReCapProject/blob/master/Business/Concrete/ColorManager.cs)</br>
 &#128196; [CustomerManager.cs ](https://github.com/Serkanydn/ReCapProject/blob/master/Business/Concrete/CustomerManager.cs)</br>
 &#128196; [PaymentManager.cs ](https://github.com/Serkanydn/ReCapProject/blob/master/Business/Concrete/PaymentManager.cs)</br>
 &#128196; [RentalManager.cs ](https://github.com/Serkanydn/ReCapProject/blob/master/Business/Concrete/RentalManager.cs)</br>
 &#128196; [UserManager.cs ](https://github.com/Serkanydn/ReCapProject/blob/master/Business/Concrete/UserManager.cs)</br>


&#128196; [Frontend](https://github.com/Serkanydn/ReCapFrontend)</br>


