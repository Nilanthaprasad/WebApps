using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RanAswanuPOS
{
    public partial class Main : Form
    {
        private int childFormNumber = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void ShowForm(Form frmShow)
        {
            FormCollection collection = Application.OpenForms;
            foreach (Form frm in collection)
            {
                if (frm.GetType() == frmShow.GetType())
                {
                    frm.Focus();
                    return;
                }
            }

            frmShow.MdiParent = this;
            frmShow.Show();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Orders());
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Invoice());
        }
    }
}
