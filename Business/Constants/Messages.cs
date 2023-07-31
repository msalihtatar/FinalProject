using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
