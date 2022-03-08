using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {

        public static string NameInvalid =  "isim Geçersiz";
        public static string MaintenanceTime = "sistem bakımda";
        public static string Listed = "listelendi";
        public static string Update = "Güncellendi";
        public static string Delete = "Güncellendi";
        public const string  Create = "Eklendi";



        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
       
        public static string ProductsListed = "Ürün listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoryde en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Bu isim zaten eklidir.";

        public static string CategoryLimitExeded = "Kategory Limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt olundu.";

        public static string UserNotFound = "Kullancı bulunamadı.";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş ";
        public static string UserAlreadyExists = "Kullancı mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";
    }
}
