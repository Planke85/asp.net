using PizzaApp.Domain.Enums;

namespace PizzaApp.Web.Models
{
    public class PizzaViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public PizzaSize PizzaSize { get; set; }
        public string Image { get; set; }
    }
}
