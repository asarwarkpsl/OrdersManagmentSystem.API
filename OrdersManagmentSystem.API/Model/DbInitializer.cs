using OrdersManagmentSystem.API.Context;

namespace OrdersManagmentSystem.API.Model
{
    public class DbInitializer
    {
        public static void Initialize(OrderContext context)
        {
            var orderitems = new OrderItem[]
            {
                new OrderItem
                {
                    ProductID= "3345",
                    Price = 23.2m,
                    SellerID = "8790",
                    ShippingLimitDate = DateTime.Now.AddDays(5),
                    FreightValue = 12.2m
                },
                new OrderItem
                {
                    ProductID= "3328",
                    Price = 23.2m,
                    SellerID = "8790",
                    ShippingLimitDate = DateTime.Now.AddDays(5),
                    FreightValue = 12.2m
                },
                new OrderItem
                {
                    ProductID= "2209",
                    Price = 23.2m,
                    SellerID = "8790",
                    ShippingLimitDate = DateTime.Now.AddDays(5),
                    FreightValue = 12.2m
                },
            };

            var order = new Order
            {
                CustomerID = "2213",
                OrderApprovedAt = DateTime.Now.AddDays(-2),
                OrderDeliveredCarrierDate = DateTime.Now.AddDays(-2),   
                OrderDeliveredCUstomerDate = DateTime.Now.AddDays(-2),  
                OrderEstimatedDeliveredDate = DateTime.Now.AddDays(-2),
                OrderStatus = "Delivered",
                Items = new List<OrderItem>
                {
                     new OrderItem
                    {
                        ProductID= "3345",
                        Price = 23.2m,
                        SellerID = "8790",
                        ShippingLimitDate = DateTime.Now.AddDays(5),
                        FreightValue = 12.2m
                    },
                    new OrderItem
                    {
                        ProductID= "3328",
                        Price = 23.2m,
                        SellerID = "8790",
                        ShippingLimitDate = DateTime.Now.AddDays(5),
                        FreightValue = 12.2m
                    },
                    new OrderItem
                    {
                        ProductID= "2209",
                        Price = 23.2m,
                        SellerID = "8790",
                        ShippingLimitDate = DateTime.Now.AddDays(5),
                        FreightValue = 12.2m
                    }
                }
            };
            context.Add(order);

            // Order: 2
            order = new Order
            {
                CustomerID = "2213",
                OrderApprovedAt = DateTime.Now.AddDays(-2),
                OrderDeliveredCarrierDate = DateTime.Now.AddDays(-2),
                OrderDeliveredCUstomerDate = DateTime.Now.AddDays(-2),
                OrderEstimatedDeliveredDate = DateTime.Now.AddDays(-2),
                OrderStatus = "Delivered",
                Items = new List<OrderItem>
                {
                     new OrderItem
                    {
                        ProductID= "3345",
                        Price = 23.2m,
                        SellerID = "8790",
                        ShippingLimitDate = DateTime.Now.AddDays(5),
                        FreightValue = 12.2m
                    },
                    new OrderItem
                    {
                        ProductID= "3328",
                        Price = 23.2m,
                        SellerID = "8790",
                        ShippingLimitDate = DateTime.Now.AddDays(5),
                        FreightValue = 12.2m
                    },
                    new OrderItem
                    {
                        ProductID= "2209",
                        Price = 23.2m,
                        SellerID = "8790",
                        ShippingLimitDate = DateTime.Now.AddDays(5),
                        FreightValue = 12.2m
                    }
                }
            };
            context.Add(order);


            //Order: 3
            order = new Order
            {
                CustomerID = "2213",
                OrderApprovedAt = DateTime.Now.AddDays(-2),
                OrderDeliveredCarrierDate = DateTime.Now.AddDays(-2),
                OrderDeliveredCUstomerDate = DateTime.Now.AddDays(-2),
                OrderEstimatedDeliveredDate = DateTime.Now.AddDays(-2),
                OrderStatus = "Delivered",
                Items = new List<OrderItem>
                {
                     new OrderItem
                    {
                        ProductID= "3345",
                        Price = 23.2m,
                        SellerID = "8790",
                        ShippingLimitDate = DateTime.Now.AddDays(5),
                        FreightValue = 12.2m
                    },
                    new OrderItem
                    {
                        ProductID= "3328",
                        Price = 23.2m,
                        SellerID = "8790",
                        ShippingLimitDate = DateTime.Now.AddDays(5),
                        FreightValue = 12.2m
                    },
                    new OrderItem
                    {
                        ProductID= "2209",
                        Price = 23.2m,
                        SellerID = "8790",
                        ShippingLimitDate = DateTime.Now.AddDays(5),
                        FreightValue = 12.2m
                    }
                }
            };
            context.Add(order);

            //Order: 4
            order = new Order
            {
                CustomerID = "2213",
                OrderApprovedAt = DateTime.Now.AddDays(-2),
                OrderDeliveredCarrierDate = DateTime.Now.AddDays(-2),
                OrderDeliveredCUstomerDate = DateTime.Now.AddDays(-2),
                OrderEstimatedDeliveredDate = DateTime.Now.AddDays(-2),
                OrderStatus = "Delivered",
                Items = new List<OrderItem>
                {
                     new OrderItem
                    {
                        ProductID= "3345",
                        Price = 23.2m,
                        SellerID = "8790",
                        ShippingLimitDate = DateTime.Now.AddDays(5),
                        FreightValue = 12.2m
                    },
                    new OrderItem
                    {
                        ProductID= "3328",
                        Price = 23.2m,
                        SellerID = "8790",
                        ShippingLimitDate = DateTime.Now.AddDays(5),
                        FreightValue = 12.2m
                    },
                    new OrderItem
                    {
                        ProductID= "2209",
                        Price = 23.2m,
                        SellerID = "8790",
                        ShippingLimitDate = DateTime.Now.AddDays(5),
                        FreightValue = 12.2m
                    }
                }
            };
            context.Add(order);

            //Order: 5
            order = new Order
            {
                CustomerID = "2213",
                OrderApprovedAt = DateTime.Now.AddDays(-2),
                OrderDeliveredCarrierDate = DateTime.Now.AddDays(-2),
                OrderDeliveredCUstomerDate = DateTime.Now.AddDays(-2),
                OrderEstimatedDeliveredDate = DateTime.Now.AddDays(-2),
                OrderStatus = "Delivered",
                Items = new List<OrderItem>
                {
                     new OrderItem
                    {
                        ProductID= "3345",
                        Price = 23.2m,
                        SellerID = "8790",
                        ShippingLimitDate = DateTime.Now.AddDays(5),
                        FreightValue = 12.2m
                    },
                    new OrderItem
                    {
                        ProductID= "3328",
                        Price = 23.2m,
                        SellerID = "8790",
                        ShippingLimitDate = DateTime.Now.AddDays(5),
                        FreightValue = 12.2m
                    },
                    new OrderItem
                    {
                        ProductID= "2209",
                        Price = 23.2m,
                        SellerID = "8790",
                        ShippingLimitDate = DateTime.Now.AddDays(5),
                        FreightValue = 12.2m
                    }
                }
            };
            context.Add(order);

            //order: 6
            order = new Order
            {
                CustomerID = "2213",
                OrderApprovedAt = DateTime.Now.AddDays(-2),
                OrderDeliveredCarrierDate = DateTime.Now.AddDays(-2),
                OrderDeliveredCUstomerDate = DateTime.Now.AddDays(-2),
                OrderEstimatedDeliveredDate = DateTime.Now.AddDays(-2),
                OrderStatus = "Delivered",
                Items = new List<OrderItem>
                {
                     new OrderItem
                    {
                        ProductID= "3345",
                        Price = 23.2m,
                        SellerID = "8790",
                        ShippingLimitDate = DateTime.Now.AddDays(5),
                        FreightValue = 12.2m
                    },
                    new OrderItem
                    {
                        ProductID= "3328",
                        Price = 23.2m,
                        SellerID = "8790",
                        ShippingLimitDate = DateTime.Now.AddDays(5),
                        FreightValue = 12.2m
                    },
                    new OrderItem
                    {
                        ProductID= "2209",
                        Price = 23.2m,
                        SellerID = "8790",
                        ShippingLimitDate = DateTime.Now.AddDays(5),
                        FreightValue = 12.2m
                    }
                }
            };
            context.Add(order);

            context.SaveChanges();
        }
    }
}
