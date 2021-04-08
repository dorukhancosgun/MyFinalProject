using Core.Entities.Concrete;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductCountOfCategoryError = "";
        public static string ProductAdded = "Urun eklendi";
        public static string ProductNameInvalid = "Urun ismi gecersiz";
        public static string MaintenanceTime = "Sistem bakimda";
        public static string ProductsListed = "Urunler Listelendi";
        public static string ProductNameAlreadyExist = "Bu isim daha onceden var.";
        public static string CategoryLimitExceeded = "Kategori limiti asildigi icin yeni urun eklenemiyor.";
        public static string AuthorizationDenied = "Yetkiniz yoktur.";
        public static string AccessTokenCreated = "Access Token olusturuldu.";
        public static string UserAlreadyExists = "Kullanici mevcut.";
        public static string SuccessfulLogin = "Giris yapildi.";
        public static string PasswordError = "Sifre hatali.";
        public static string UserNotFound = "Kullanici bulunamadi.";
        public static string UserRegistered = "Sisteme kayit yapildi.";
    }
}
