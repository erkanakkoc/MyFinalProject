using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //static yaparsak new lemeye gerek kalmaz. sadece bir kere kullanırız.
        //Temel mesajlar buraya konur
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        internal static string MaintenanceTime ="Sistem bakımda";
        internal static string ProductsListed ="Ürünler listelendi";
        //Public ler pascal case yazılır. İlk harf büyük.
    }
}
