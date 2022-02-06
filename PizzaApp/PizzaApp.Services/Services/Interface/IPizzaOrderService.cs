using PizzaApp.Domain.Enums;
using PizzaApp.Domain.Models;
using System.Collections.Generic;

namespace PizzaApp.Services.Services.Interface
{
    public interface IPizzaOrderService
    {
        List<Pizza> GetMenu();
        List<Order> GetAllOrders();
        Order GetOrderById(int id);
        int GetOrderCount();
        string GetMostPopularPizza();
        Order GetLastOrder();
        void MakeNewOrder(Order order);
        Pizza GetPizzaFromMenu(string pizzaName, PizzaSize pizzaSize);
    }
}
