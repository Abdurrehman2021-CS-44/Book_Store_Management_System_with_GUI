using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreManagementSystem.BL;
using System.IO;

namespace BookStoreManagementSystem.DL
{
    class CustomerDL
    {
        private static Customer customer = new Customer("Ali", "#Address", "823789");

        internal static Customer Customer
        {
            get => customer;
            set => customer = value;
        }
        
        public static void addIntoList(BookInfo book)
        {
            customer.Products.Add(book);
        }

        public static string parseData(string record, int field)
        {
            int commaCount = 1;
            string item = "";
            foreach (char i in record)
            {
                if (i == ',')
                {
                    commaCount++;
                }
                else if (commaCount == field)
                {
                    if (i != ',')
                        item = item + i;
                }
            }
            return item;
        }

        public static bool readFromList(string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record = "";
                while ((record = file.ReadLine()) != null)
                {
                    string bAuthor = parseData(record, 1);
                    string bName = parseData(record, 2);
                    string bCateg = parseData(record, 3);
                    int amountOfBooks = int.Parse(parseData(record, 4));
                    float bPrice = float.Parse(parseData(record, 5));
                    int minimumBooks = int.Parse(parseData(record, 6));
                    BookInfo book = new BookInfo(bAuthor, bName, bCateg, amountOfBooks, bPrice, minimumBooks);
                    addIntoList(book);
                }
                file.Close();
                return true;
            }
            else
                return false;
        }

        public static void storeIntoFile(string path, BookInfo book)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(book.BAuthor + "," + book.BName + "," + book.BCateg + "," + book.AmountOfBook + "," + book.BPrice + "," + book.MinimumBooks);
            file.Flush();
            file.Close();
        }

        public static void storeAllDataIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (BookInfo book in customer.Products)
            {
                file.WriteLine(book.BAuthor + "," + book.BName + "," + book.BCateg + "," + book.AmountOfBook + "," + book.BPrice + "," + book.MinimumBooks);
            }
            file.Flush();
            file.Close();
        }
    }
}
