using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreManagementSystem.DL;

namespace BookStoreManagementSystem.BL
{
    class Customer
    {
        private string cusName;
        private string cusAddress;
        private string phoneNumber;
        private List<BookInfo> products;
        private List<float> bills;

        public Customer(string cusName, string cusAddress, string phoneNumber)
        {
            this.cusName = cusName;
            this.cusAddress = cusAddress;
            this.phoneNumber = phoneNumber;
            products = new List<BookInfo>();
            bills = new List<float>();
        }

        public string CusName
        {
            get => cusName;
            set => cusName = value;
        }
        public string CusAddress
        {
            get => cusAddress;
            set => cusAddress = value;
        }
        public string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }
        public List<BookInfo> Products
        {
            get => products;
            set => products = value; 
        }
        public List<float> Bills
        {
            get => bills;
            set => bills = value;
        }

        public BookInfo BookInfo
        {
            get => default;
            set
            {
            }
        }
    }
}
