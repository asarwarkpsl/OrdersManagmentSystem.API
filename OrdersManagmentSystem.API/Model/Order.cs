using System.ComponentModel.DataAnnotations.Schema;

namespace OrdersManagmentSystem.API.Model
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderApprovedAt { get; set; }
        public DateTime OrderDeliveredCarrierDate { get; set; }
        public DateTime OrderDeliveredCUstomerDate { get; set; }
        public DateTime OrderEstimatedDeliveredDate { get; set; }

        public List<OrderItem> Items { get; set; }
    }
}
