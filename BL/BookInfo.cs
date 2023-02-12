using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagementSystem.BL
{
    public class BookInfo
    {
        private string bAuthor;
        private string bName;
        private string bCateg;
        private int amountOfBooks;
        private float bPrice;
        private int minimumBooks;

        public BookInfo(string bAuthor, string bName, string bCateg, int amountOfBooks, float bPrice, int minimumBooks)
        {
            this.bAuthor = bAuthor;
            this.bName = bName;
            this.BCateg = bCateg;
            this.amountOfBooks = amountOfBooks;
            this.bPrice = bPrice;
            this.minimumBooks = minimumBooks;
        }

        public string BAuthor
        {
            get => bAuthor;
            set => bAuthor = value;
        }

        public string BName
        {
            get => bName;
            set => bName = value;
        }

        public string BCateg
        {
            get => bCateg;
            set => bCateg = value;
        }

        public int AmountOfBook
        {
            get => amountOfBooks;
            set => amountOfBooks = value;
        }

        public float BPrice
        {
            get => bPrice;
            set => bPrice = value;
        }

        public int MinimumBooks
        {
            get => minimumBooks;
            set => minimumBooks = value;
        }
    }
}
