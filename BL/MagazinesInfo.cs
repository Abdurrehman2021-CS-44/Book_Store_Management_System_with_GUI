using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagementSystem.BL
{
    class MagazinesInfo : General
    {
        private string category;

        public MagazinesInfo(string country, string companyName, string language, string link, int month, int day, int year  ,string category) : base(country, companyName, language, month, day, year, link)
        {
            this.category = category;
        }

        public string Category
        {
            get => category;
            set => category = value;
        }
    }
}
