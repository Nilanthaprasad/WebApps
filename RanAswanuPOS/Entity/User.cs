using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RanAswanuPOS.EntityDao;

namespace RanAswanuPOS.Entity
{
    class User
    {
        private String username;
        private String password;
        private UserDao daoObject;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public User(String username, String password)
        {
            this.username = username;
            this.password = password;
            daoObject = new UserDao();
        }

        public bool checkValidCredenttials()
        {

        }
    }
}
