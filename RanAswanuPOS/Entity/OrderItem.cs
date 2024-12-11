using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RanAswanuPOS.EntityDao;

namespace RanAswanuPOS.Entity
{
    class OrderItem
    {
        private Product product;
        private int quantity;
        private double lineSubtotal;
        private double lineTotal;
        private OrderItemDao daoObject = new OrderItemDao();


        public OrderItem(Product product, int quantity, double lineSubtotal, double lineTotal)
        {
            this.Product = product;
            this.Quantity = quantity;
            this.LineSubtotal = lineSubtotal;
            this.LineTotal = lineTotal;
        }

       

        public int Quantity { get => quantity; set => quantity = value; }
        public double LineSubtotal { get => lineSubtotal; set => lineSubtotal = value; }
        public double LineTotal { get => lineTotal; set => lineTotal = value; }
        internal Product Product { get => product; set => product = value; }

        public static List<OrderItem> getOrderItems(int orderId)
        {
           return  new OrderItemDao().getOrderItems(orderId);
        }

        public static List<OrderItem> getOrderItemsWithCustomerObject(int orderId, Customer customer)
        {
            return new OrderItemDao().getOrderItemsWithCustomer(orderId, customer);
        }
    }
}
