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
    public partial class ucBuyProduct : UserControl
    {
        public ucBuyProduct()
        {
            InitializeComponent();
            CustomerDL.readFromList(locations.PathCustomer);
        }

        private void gvMyBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BookInfo b = (BookInfo)gvMyBooks.CurrentRow.DataBoundItem;
            if (gvMyBooks.Columns["Delete"].Index == e.ColumnIndex)
            {
                CustomerDL.Customer.Products.Remove(b);
                CustomerDL.storeAllDataIntoFile(locations.PathCustomer);
                dataBind();
            }
        }

        private void dataBind()
        {
            gvMyBooks.DataSource = null;
            gvMyBooks.DataSource = CustomerDL.Customer.Products;
            gvMyBooks.Refresh();
            gvMyBooks.ForeColor = Color.Black;
            gvMyBooks.Columns["BAuthor"].HeaderText = "Author";
            gvMyBooks.Columns["BName"].HeaderText = "Name";
            gvMyBooks.Columns["BCateg"].HeaderText = "Category";
            gvMyBooks.Columns["AmountOfBook"].HeaderText = "Amount of Books";
            gvMyBooks.Columns["BPrice"].HeaderText = "Price";
            gvMyBooks.Columns["MinimumBooks"].HeaderText = "Minimum Books";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSort.Text == "Name")
            {
                List<BookInfo> b = BookInfoDL.BookList.OrderBy(o => o.BName).ToList();
                BookInfoDL.BookList = b;
                dataBind();
            }
            if (cmbSort.Text == "Price")
            {
                List<BookInfo> b = BookInfoDL.BookList.OrderByDescending(o => o.BPrice).ToList();
                BookInfoDL.BookList = b;
                dataBind();
            }
            if (cmbSort.Text == "Amount of Book")
            {
                List<BookInfo> b = BookInfoDL.BookList.OrderByDescending(o => o.AmountOfBook).ToList();
                BookInfoDL.BookList = b;
                dataBind();
            }
        }

        private void ucBuyProduct_Load(object sender, EventArgs e)
        {
            dataBind();
        }

        private void btnBuyBook_Click(object sender, EventArgs e)
        {
            frmBuyBook form = new frmBuyBook();
            form.ShowDialog();
            dataBind();
        }
    }
}
