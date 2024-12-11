using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RanAswanuPOS.EntityDao;

namespace RanAswanuPOS.Entity
{
    class Order
    {
        private long orderId;
        private DateTime orderDate;
        private int numberOfItems;
        private double netPrice;
        private double shippingCharge;
        private double totalPrice;
        private String orderStatus;
        private long customerId;
        private String customerName;
        private Customer customer;
        
        private OrderDao daoObject = new OrderDao();

        public long OrderId { get => orderId; set => orderId = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public int NumberOfItems { get => numberOfItems; set => numberOfItems = value; }
        public double NetPrice { get => netPrice; set => netPrice = value; }
        public double ShippingCharge { get => shippingCharge; set => shippingCharge = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string OrderStatus { get => orderStatus; set => orderStatus = value; }
        public long CustomerId { get => customerId; set => customerId = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        internal Customer Customer { get => customer; set => customer = value; }

        //public static List<Order> getAllOrders()
        //{
        //     return new OrderDao().getAllOrders();
        //}

        public static List<Order> getAllOrdersWithDateRangeAndCustomerNames(DateTime startDate, DateTime endDate)
        {
            return new OrderDao().getAllOrdersWithDateRangeAndCustomerNames(startDate, endDate);
        }
        public static List<Order> getOrderLessDetailed(DateTime startDate, DateTime endDate)
        {
            return new OrderDao().getAllOrdersLessDetailed(startDate, endDate);
        }



        public Order(long orderId, DateTime orderDate, long customerId, int numberOfItems, double netPrice,
                    double shippingCharge, double totalPrice, String orderStatus)
        {
            this.orderId = orderId;
            this.orderDate = orderDate;
            this.numberOfItems = numberOfItems;
            this.netPrice = netPrice;
            this.shippingCharge = shippingCharge;
            this.totalPrice = totalPrice;
            this.orderStatus = orderStatus;
            this.customerId = customerId;
        }

        public Order(long orderId, DateTime orderDate, long customerId, int numberOfItems, double netPrice,
                    double shippingCharge, double totalPrice, String orderStatus, Customer customer)
        {
            this.orderId = orderId;
            this.orderDate = orderDate;
            this.numberOfItems = numberOfItems;
            this.netPrice = netPrice;
            this.shippingCharge = shippingCharge;
            this.totalPrice = totalPrice;
            this.orderStatus = orderStatus;
            this.customerId = customerId;
            this.customer = customer;
        }

        public Order(long orderId, DateTime orderDate, long customerId, int numberOfItems, 
                    double totalPrice, String orderStatus, Customer customer)
        {
            this.orderId = orderId;
            this.orderDate = orderDate;
            this.numberOfItems = numberOfItems;
            this.totalPrice = totalPrice;
            this.orderStatus = orderStatus;
            this.customerId = customerId;
            this.customer = customer;
        }





    }
}
