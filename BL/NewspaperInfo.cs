using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagementSystem.BL
{
    class NewspaperInfo : General
    {
        private int pages;


        public NewspaperInfo(string country, string companyName, string language, string link, int month, int day, int year ,int pages) : base(country, companyName, language, month, day, year, link)
        {
            this.pages = pages;
        }

        public int Pages 
        {
            get => pages;
            set => pages = value;
        }
    }
}
