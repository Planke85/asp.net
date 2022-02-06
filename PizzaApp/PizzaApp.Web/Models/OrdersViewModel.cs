using System.Collections.Generic;

namespace PizzaApp.Web.Models
{
    public class OrdersViewModel
    {
        public int OrdersCount { get; set; }
        public string LastOrderedPizza { get; set; }
        public string MostPopularPizza { get; set; }
        public string NameOfFirstCustomer { get; set; }
        public List<OrderItemViewModel> Orders { get; set; }
    }
}
