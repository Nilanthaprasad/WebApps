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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUserName.Text;
            String password = txtPassword.Text;
            if (!username.Equals("") && !password.Equals(""))
            {
                User user = new User(username, password);
                if (user.checkValidCredenttials())
                { 
                    Main main = new Main();
                    main.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                }
            }
            else
            {
                MessageBox.Show("Enter values for both fields");
            }
        }
    }
}
