using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeShop.Models
{
    public class Order
    {
        // Private fields with proper naming conventions
        private string customerName;
        private DateTime orderDate;
        private DateTime orderTime;
        private List<OrderItem> orderItems;
        private decimal totalCost;

        // Properties using C# naming conventions
        public string CustomerName
        {
            get { return this.customerName; }
            private set { this.customerName = value; }
        }

        public DateTime OrderDate
        {
            get { return this.orderDate; }
            private set { this.orderDate = value; }
        }

        public DateTime OrderTime
        {
            get { return this.orderTime; }
            private set { this.orderTime = value; }
        }

        public List<OrderItem> OrderItems
        {
            get { return this.orderItems; }
            private set { this.orderItems = value; }
        }
        public decimal TotalCost
        {
            get { return this.totalCost; }
             set { this.totalCost = value; }
        }


        public Order(string customerName)
        {
            CustomerName = customerName;
            OrderDate = DateTime.Today;
            OrderTime = DateTime.Now;
            OrderItems = new List<OrderItem>();
            TotalCost = 0;
        }
        public Order(string customerName, List<OrderItem> orders)
        {
            CustomerName = customerName;
            OrderDate = DateTime.Today;
            OrderTime = DateTime.Now;
            OrderItems = orders;
            TotalCost = 0;
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public decimal CalculateTotalCost()
        {
            decimal totalCost = 0;
            foreach (var orderItem in OrderItems)
            {
                totalCost += orderItem.CalculateItemTotal();
            }
            return totalCost;
        }


    }
}
