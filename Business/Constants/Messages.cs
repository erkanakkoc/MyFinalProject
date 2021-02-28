using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //static yaparsak new lemeye gerek kalmaz. sadece bir kere kullanırız.
        //Temel mesajlar buraya konur
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime ="Sistem bakımda.";
        public static string ProductsListed ="Ürünler listelendi.";
        public static string ProductCountOfCategoryError = "Bu kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var.";
        public static string CategoryLimitExceeded = "Kategori limiti aşıldı.";
        public static string AuthorizationDenied ="Yetkiniz yok.";
        public static string UserRegistered = "Kayıt oldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola hatası.";
        public static string SuccessfulLogin = "Başarılı giriş.";
        public static string UserAlreadyExists = "Kullanıcı mevcut.";
        public static string AccessTokenCreated="Token oluşturuldu.";
        //Public ler pascal case yazılır. İlk harf büyük.
    }
}
