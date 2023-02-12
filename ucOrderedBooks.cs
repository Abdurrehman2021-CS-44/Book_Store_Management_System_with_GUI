using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStoreManagementSystem.BL;
using BookStoreManagementSystem.DL;

namespace BookStoreManagementSystem
{
    public partial class ucOrderedBooks : UserControl
    {
        
        public ucOrderedBooks()
        {
            InitializeComponent();
            
        }

        private void gvOrderedBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BookInfo book = (BookInfo)gvOrderedBooks.CurrentRow.DataBoundItem;
            if (gvOrderedBooks.Columns["View"].Index == e.ColumnIndex)
            {
                MessageBox.Show("The amount of books is less than threshold");
            }
        }

        private void dataBind()
        {
            BookInfoDL.booksToBeOrderedList();
            gvOrderedBooks.DataSource = null;
            gvOrderedBooks.DataSource = BookInfoDL.BooksToBeOrdered;
            gvOrderedBooks.Refresh();
            gvOrderedBooks.ForeColor = Color.Black;

            gvOrderedBooks.Columns["BAuthor"].HeaderText = "Author";
            gvOrderedBooks.Columns["BName"].HeaderText = "Name";
            gvOrderedBooks.Columns["BCateg"].HeaderText = "Category";
            gvOrderedBooks.Columns["AmountOfBook"].HeaderText = "Amount of Books";
            gvOrderedBooks.Columns["BPrice"].HeaderText = "Price";
            gvOrderedBooks.Columns["MinimumBooks"].HeaderText = "Minimum Books";
        }

        private void ucOrderedBooks_Load(object sender, EventArgs e)
        {
            dataBind();
        }

    }
}
