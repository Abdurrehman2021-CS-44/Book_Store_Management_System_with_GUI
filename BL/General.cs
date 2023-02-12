using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagementSystem.BL
{
    class General
    {
        protected string country;
        protected string companyName;
        protected string language;
        protected string link;
        private int month;
        private int day;
        private int year;
        public General(string country, string companyName, string language, int month, int day, int year, string link)
        {
            this.country = country;
            this.companyName = companyName;
            this.language = language;
            this.link = link;
            this.month = month;
            this.day = day;
            this.year = year;
        }

        public string Country
        {
            get => country;
            set => country = value;
        }
        public string CompanyName
        {
            get => companyName;
            set => companyName = value;
        }
        public string Language
        {
            get => language;
            set => language = value;
        }
        public string Link
        {
            get => link;
            set => link = value;
        }
        public int Month
        {
            get => month;
            set => month = value;
        }
        public int Day
        {
            get => day;
            set => day = value;
        }
        public int Year
        {
            get => year;
            set => year = value;
        }
    }
}
