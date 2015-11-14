using System;
using System.Collections.Generic;
using System.Web.Http;

namespace AngularAuthDemo.Api.Controllers
{
    [RoutePrefix("api/Orders")]
    public class OrdersController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(Order.CreateOrders());
        }
    }

    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string ShipperCity { get; set; }
        public Boolean IsShipped { get; set; }

        public static List<Order> CreateOrders()
        {
            var orderList = new List<Order>
            {
                new Order {OrderID = 10248, CustomerName = "Han Meimei", ShipperCity = "Shanghai", IsShipped = true },
                new Order {OrderID = 10249, CustomerName = "Li Lei", ShipperCity = "Beijing", IsShipped = false},
                new Order {OrderID = 10250,CustomerName = "Zhang San", ShipperCity = "Nanjing", IsShipped = false },
                new Order {OrderID = 10251,CustomerName = "Wang Ermazi", ShipperCity = "Suzhou", IsShipped = false},
                new Order {OrderID = 10252,CustomerName = "Li Si", ShipperCity = "Nanchang", IsShipped = true}
            };

            return orderList;
        }
    }
}
