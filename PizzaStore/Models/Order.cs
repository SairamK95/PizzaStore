using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaStore.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public int UserID { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Pizzas { get; set; }
        public string Notes { get; set; }
        public double Delivery_Charge{ get; set; }
        public double HST { get; set; }
        public double Total_bill { get; set; }
        public string Transcation_Id { get; set; }
        public DateTime OrderTime { get; set; }
        public string ModeOfPayment { get; set; }
        public string PhoneNumber { get; set; }
        public string EstimateDeliveryTime { get; set; }
    }
}
