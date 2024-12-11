using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RanAswanuPOS.Entity;

namespace RanAswanuPOS
{
    public partial class Orders : Form
    {
        Dictionary<long, Customer> customerList = new Dictionary<long, Customer>();
        public Orders()
        {
            InitializeComponent();
            loadOrders();
            adjustDateFieldValues();
        }

        private void adjustDateFieldValues()
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-2);
        }

        private void loadOrders()
        {
            dgvOrders.Rows.Clear();
            customerList.Clear();
            List<Order> orders = Order.getAllOrdersWithDateRangeAndCustomerNames(dtpStartDate.Value, dtpEndDate.Value);
            if (orders.Count > 0)
            {
                int i = 0;
                Order order;
                while (i < orders.Count)
                {
                    order = (Order)orders[i];
                    customerList.Add(order.OrderId, order.Customer);

                    dgvOrders.Rows.Add(order.OrderId, order.OrderDate, order.CustomerId, order.Customer.FirstName, order.Customer.LastName, order.NumberOfItems,
                                      order.NetPrice, order.ShippingCharge, order.TotalPrice, order.OrderStatus, order.Customer.Email, order.Customer.City, order.Customer.PostCode);
                    i++;
                }
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if(dtpStartDate.Value > dtpEndDate.Value)
            {
                MessageBox.Show("Start Date is older than the End Date");
            }
            else
            {
                loadOrders();
            }
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                MessageBox.Show("Start Date is older than the End Date");
            }
            else
            {
                loadOrders();
            }
        }

        private void dgvOrders_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int orderid = Convert.ToInt32(dgvOrders.Rows[dgvOrders.SelectedRows[0].Index].Cells[0].Value) ;
                String firstName = Convert.ToString(dgvOrders.Rows[dgvOrders.SelectedRows[0].Index].Cells[3].Value);
                String lastName = Convert.ToString(dgvOrders.Rows[dgvOrders.SelectedRows[0].Index].Cells[4].Value);
                double total = Convert.ToDouble(dgvOrders.Rows[dgvOrders.SelectedRows[0].Index].Cells[8].Value);

                OrderDetails frm = new OrderDetails(orderid, firstName, lastName, total, customerList[orderid]);
                frm.Show();
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please select a record");
            }
        }

        private void dgvOrders_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderid = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells[0].Value);
            String firstName = Convert.ToString(dgvOrders.Rows[e.RowIndex].Cells[3].Value);
            String lastName = Convert.ToString(dgvOrders.Rows[e.RowIndex].Cells[4].Value);
            double total = Convert.ToDouble(dgvOrders.Rows[e.RowIndex].Cells[8].Value);
            OrderDetails frm = new OrderDetails(orderid, firstName, lastName, total,customerList[orderid]);
            frm.Show();
            //MessageBox.Show(e.RowIndex.ToString());
        }
    }
}
