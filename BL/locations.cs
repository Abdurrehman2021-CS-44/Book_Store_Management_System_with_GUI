using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreManagementSystem.DL;
using System.IO;

namespace BookStoreManagementSystem.BL
{
    class locations
    {
        private static string pathBookInfo = "BooksData.txt";
        private static string pathUsers = "UserPass.txt";
        private static string pathNewspapers = "Newspapers.txt";
        private static string pathMagazines = "Magazines.txt";
        private static string pathNotices = "Notices.txt";
        private static string pathCustomer = "CustomerBooks.txt";

        public static string PathBookInfo
        {
            get => pathBookInfo;
            set => pathBookInfo = value;
        }
        public static string PathUsers
        {
            get => pathUsers;
            set => pathUsers = value;
        }
        public static string PathNewspapers
        {
            get => pathNewspapers;
            set => pathNewspapers = value;
        }
        public static string PathMagazines
        {
            get => pathMagazines;
            set => pathMagazines = value;
        }
        public static string PathNotices
        {
            get => pathNotices;
            set => pathNotices = value;
        }
        public static string PathCustomer
        {
            get => pathCustomer;
            set => pathCustomer = value;
        }
    }
}
