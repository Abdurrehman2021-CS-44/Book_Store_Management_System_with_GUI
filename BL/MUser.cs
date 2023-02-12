using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagementSystem.BL
{
    public class MUser
    {
        private string userName;
        private string password;
        private string role;

        public MUser(string userName, string password, string role)
        {
            this.userName = userName;
            this.password = password;
            this.role = role;
        }
        public MUser(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
            this.role = "/NA";
        }

        public string UserName
        {
            get => userName;
            set => userName = value;
        }
        public string Password
        {
            get => password;
            set => password = value;
        }
        public string Role
        {
            get => role;
            set => role = value;
        }
        public bool isAdmin()
        {
            if (role == "Admin")
            {
                return true;
            }
            return false;
        }
    }
}
