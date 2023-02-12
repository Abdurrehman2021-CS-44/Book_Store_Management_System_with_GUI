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
    public partial class ucViewBooks : UserControl
    {
        public ucViewBooks()
        {
            InitializeComponent();
        }

        private void gvViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataBind()
        {
            gvViewBooks.DataSource = null;
            gvViewBooks.DataSource = BookInfoDL.BookList;
            gvViewBooks.Refresh();
            gvViewBooks.ForeColor = Color.Black;
            gvViewBooks.Columns["BAuthor"].HeaderText = "Author";
            gvViewBooks.Columns["BName"].HeaderText = "Name";
            gvViewBooks.Columns["BCateg"].HeaderText = "Category";
            gvViewBooks.Columns["AmountOfBook"].HeaderText = "Amount of Books";
            gvViewBooks.Columns["BPrice"].HeaderText = "Price";
            gvViewBooks.Columns["MinimumBooks"].HeaderText = "Minimum Books";
        }

        private void ucViewBooks_Load(object sender, EventArgs e)
        {
            dataBind();
            cbSort.Items.Add("Name");
            cbSort.Items.Add("Price");
            cbSort.Items.Add("Amount of Book");
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSort.Text == "Name")
            {
                List<BookInfo> b = BookInfoDL.BookList.OrderBy(o => o.BName).ToList();
                BookInfoDL.BookList = b;
                dataBind();
            }
            if (cbSort.Text == "Price")
            {
                List<BookInfo> b = BookInfoDL.BookList.OrderByDescending(o => o.BPrice).ToList();
                BookInfoDL.BookList = b;
                dataBind();
            }
            if (cbSort.Text == "Amount of Book")
            {
                List<BookInfo> b = BookInfoDL.BookList.OrderByDescending(o => o.AmountOfBook).ToList();
                BookInfoDL.BookList = b;
                dataBind();
            }
        }
    }
}
