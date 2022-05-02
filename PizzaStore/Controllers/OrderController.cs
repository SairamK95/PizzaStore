using Microsoft.AspNetCore.Mvc;
using PizzaStore.Models;
using PizzaStore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PizzaStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IOrderService _orderService;
        public OrderController(IOrderService service)
        {
            _orderService = service;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public IActionResult GetAllOrders()
        {
            try
            {
                var orders = _orderService.GetAllOrders();
                if (orders == null) return NotFound();
                return Ok(orders);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public IActionResult GetOrderById(int id)
        {
            try
            {
                var order = _orderService.GetOrderDetailsById(id);
                if (order == null) return NotFound();
                return Ok(order);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // POST api/<OrderController>
        [HttpPost]
        public IActionResult SaveOrder([FromBody] Order orderModel)
        {
            try
            {
                var model = _orderService.SaveOrder(orderModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [HttpPut("{id}")]
        public IActionResult EditOrder(int id,[FromBody] Order orderModel)
        {
            try
            {
                orderModel.OrderId = id;
                var model = _orderService.SaveOrder(orderModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            try
            {
                var model = _orderService.DeleteOrderById(id);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
