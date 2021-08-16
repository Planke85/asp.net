using EStoreApp.Web.Models.Domain;
using EStoreApp.Web.Models.ViewModels;

namespace EStoreApp.Web.Models.Mapper
{
    public static class ProductMapper
    {
        public static ProductDetailsViewModel ProductToProductDetailsViewmodel(this Product Product)
        {
            return new ProductDetailsViewModel
            {
                Id = Product.Id,
                Name = Product.Name,
                Price = Product.Price,
                Category = Product.Category,
                IsOnPromotion = Product.IsOnPromotion,
                Description = Product.Description
            };
        }
    }
}
