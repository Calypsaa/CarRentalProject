using Core.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string SuccessMessage = "Araba eklendi";
        public static string ErrorMessage = "Araba Eklenemedi";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Giriş Başarılı.";
        public static string UserNotFound = "Kullanıcı bulunanamdı";
        public static string PasswordError = "Şifre hatalı.";
        public static string SuccessfulLogin = "Kayıt başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten kayıtlı";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
