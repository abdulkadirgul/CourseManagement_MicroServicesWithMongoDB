using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseServices.Order.Domain.OrderAggregate
{
    public class OrderItem
    {
        public string ProductId { get;private set; }
        public string ProductName { get; private set; }
        public string PictureUrl { get; private set; }
        public decimal Price { get; private set; }

        public OrderItem(string productId, string productName, string pictureUrl, decimal price)
        {
            ProductId = productId;
            ProductName = productName;
            PictureUrl = pictureUrl;
            Price = price;
        }
    }
    
}
