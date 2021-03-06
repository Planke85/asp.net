using EStoreApp.Web.Models.Enums;

namespace EStoreApp.Web.Models.Domain
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public Category Category { get; set; }

        public bool IsOnPromotion { get; set; }

        public string Description { get; set; }

    }
}
