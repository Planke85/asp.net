using System.Collections.Generic;
using EStoreApp.Web.Models.Domain;
using EStoreApp.Web.Models.Enums;
using System.Linq;
using System.Threading.Tasks;

namespace EStoreApp.Web
{
    public class StaticDB
    {
        public static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Samsung S21",
                Price = 850,
                Category = Category.Phones,
                IsOnPromotion = true,
                Description = "Ekran 6.2 , Rezolucija 1080x2400, Procesor Octa Core 2.9GHz, Memorija 128/8Gb"
            },
            new Product
            {
                Id = 2,
                Name = "Samsung S21 Ultra",
                Price = 1100,
                Category = Category.Phones,
                IsOnPromotion = false,
                Description = "Ekran 6.8 , Rezolucija 1440x3200, Procesor Octa Core 2.9GHz, Memorija 256/12Gb"
            },
            new Product
            {
                Id = 3,
                Name = "Iphone 12 Pro",
                Price = 1200,
                Category = Category.Phones,
                IsOnPromotion = true,
                Description = "Ekran 6.1 , Ekran XDR Oled, Procesor Apple A14 Bionic, Memorija 256/6Gb"
            },
            new Product
            {
                Id = 4,
                Name = "Asus Rog Zephyrus G14",
                Price = 1500,
                Category = Category.Laptops,
                IsOnPromotion = false,
                Description = "Ekran 14, Procesor Ryzen 9 5900X, Memorija 1TB, Ram 16GB"
            },
            new Product
            {
                Id = 5,
                Name = "HP Omen",
                Price = 900,
                Category = Category.Laptops,
                IsOnPromotion = true,
                Description = "Ekran 17, Procesor Intel i7-10750H, Memorija 1TB, Ram 16GB"
            },
            new Product
            {
                Id = 6,
                Name = "MSGW7",
                Price = 3000,
                Category = Category.PC,
                IsOnPromotion = false,
                Description = "Procesor Intel i7-10700, Memorija 500GB, Ram 32GB"
            },
            new Product
            {
                Id = 7,
                Name = "Lenovo Legion T5",
                Price = 1100,
                Category = Category.PC,
                IsOnPromotion = true,
                Description = "Procesor Intel i9-10900, Memorija 1TB, Ram 32GB"
            },
            new Product
            {
                Id = 8,
                Name = "Logitec H540",
                Price = 50,
                Category = Category.Headphones,
                IsOnPromotion = true,
                Description = "Frekvencija 20Hz to 20kHz, duzina 1.8m"
            },
            new Product
            {
                Id = 9,
                Name = "Rampage",
                Price = 20,
                Category = Category.Headphones,
                IsOnPromotion = false,
                Description = "Usb 7.1 RGB"
            }

        };
    }
}
