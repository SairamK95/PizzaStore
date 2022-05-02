using PizzaStore.Models;
using PizzaStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaStore.Services
{
    public interface IOrderService
    {
        
        /// <summary>
        /// get list of all orders
        /// </summary>
        /// <returns></returns>
        List<Order> GetAllOrders();

        /// <summary>
        /// get order details by id
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        Order GetOrderDetailsById(int orderId);

        /// <summary>
        ///  add edit order
        /// </summary>
        /// <param name="orderModel"></param>
        /// <returns></returns>
        ResponseModel SaveOrder(Order orderModel);
        /// <summary>
        /// delete an order
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        ResponseModel DeleteOrderById(int orderId);
    }
}

