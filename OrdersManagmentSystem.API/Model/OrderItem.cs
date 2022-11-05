using System.ComponentModel.DataAnnotations.Schema;

namespace OrdersManagmentSystem.API.Model
{
    public class OrderItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public String ProductID { get; set; }
        public String SellerID { get; set; }
        public DateTime ShippingLimitDate { get; set; }
        public decimal Price { get; set; }
        public decimal FreightValue { get; set; }
    }
}
