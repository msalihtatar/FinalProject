using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün bulunabilir.";
        public static string ProductNameAlreadyExists = "Aynı isimde birden fazla ürün olamaz.";
        public static string CategoryLimitExceed = "En fazla 15 kategori bulunabilir.";
        public static string AuthorizationDenied = "İşlem engellendi. Yetkiniz bulunmamaktadır.";
        internal static string PasswordError = "Kullanıcı adı veya şifre hatalı.";
        internal static string UserNotFound = "Kullanıcı bulunamadı.";
        internal static string SuccessfulLogin = "Giriş başarılı.";
        internal static string UserAlreadyExists = "Kullanıcı sistemde mevcuttur.";
        internal static string AccessTokenCreated = "Token oluşturuldu.";
        internal static string UserRegistered = "Kullanıcı kaydedildi.";
    }
}
