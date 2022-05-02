using PizzaStore.Models;
using PizzaStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaStore.Services
{
    public class OrderService : IOrderService
    {
        private OrderContext _context;
        public OrderService(OrderContext context)
        {
            _context = context;
        }

        public ResponseModel DeleteOrderById(int orderId)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Order _order = GetOrderDetailsById(orderId);
                if (_order != null)
                {
                    _context.Remove<Order>(_order);
                    _context.SaveChanges();
                    model.IsSuccess = true;
                    model.Messsage = "Order Deleted Successfully";
                }
                else
                {
                    model.IsSuccess = false;
                    model.Messsage = "Order Not Found";
                }
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }

        public List<Order> GetAllOrders()
        {
            List<Order> orders;
            try
            {
                orders = _context.Set<Order>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return orders;
        }

        public Order GetOrderDetailsById(int orderId)
        {
            Order order;
            try
            {
                order = _context.Find<Order>(orderId);
            }
            catch (Exception)
            {
                throw;
            }
            return order; ;
        }

        public ResponseModel SaveOrder(Order orderModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Order _order = GetOrderDetailsById(orderModel.OrderId);
                if (_order != null)
                {
                    _order.UserID = orderModel.UserID;
                    _order.Address = orderModel.Address;
                    _order.Email = orderModel.Email;
                    _order.Pizzas = orderModel.Pizzas;
                    _order.PhoneNumber = orderModel.PhoneNumber;
                    _order.Notes = orderModel.Notes;
                    _order.OrderTime = orderModel.OrderTime;
                    _order.HST = orderModel.HST;
                    _order.Delivery_Charge = orderModel.Delivery_Charge;
                    _order.Total_bill = orderModel.Total_bill;
                    _order.ModeOfPayment = orderModel.ModeOfPayment;
                    _order.EstimateDeliveryTime = orderModel.EstimateDeliveryTime;
                    _order.Transcation_Id = orderModel.Transcation_Id;
                    _context.Update<Order>(_order);
                    model.Messsage = "Order Updated Successfully";
                }
                else
                {
                    _context.Add<Order>(orderModel);
                    model.Messsage = "Order Sent Successfully";
                }
                _context.SaveChanges();
                model.IsSuccess = true;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }
    }
}
