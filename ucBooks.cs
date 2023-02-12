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
    public partial class ucBooks : UserControl
    {
        public ucBooks()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            dataBind();
            cbSort.Items.Add("Name");
            cbSort.Items.Add("Price");
            cbSort.Items.Add("Amount of Book");
        }

        private void gvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BookInfo b = (BookInfo)gvBooks.CurrentRow.DataBoundItem;
            if (gvBooks.Columns["Delete"].Index == e.ColumnIndex)
            {
                BookInfoDL.BookList.Remove(b);
                BookInfoDL.storeAllDataIntoFile(BL.locations.PathBookInfo);
                dataBind();
            }
            else if (gvBooks.Columns["Edit"].Index == e.ColumnIndex)
            {
                frmEditBookInfo form = new frmEditBookInfo(b);
                form.ShowDialog();
                BookInfoDL.storeAllDataIntoFile(BL.locations.PathBookInfo);
                dataBind();
            }
        }
        private void dataBind()
        {
            gvBooks.DataSource = null;
            gvBooks.DataSource = BookInfoDL.BookList;
            gvBooks.Refresh();
            gvBooks.ForeColor = Color.Black;
            gvBooks.Columns["BAuthor"].HeaderText = "Author";
            gvBooks.Columns["BName"].HeaderText = "Name";
            gvBooks.Columns["BCateg"].HeaderText = "Category";
            gvBooks.Columns["AmountOfBook"].HeaderText = "Amount of Books";
            gvBooks.Columns["BPrice"].HeaderText = "Price";
            gvBooks.Columns["MinimumBooks"].HeaderText = "Minimum Books";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNewBook form = new frmAddNewBook();
            form.ShowDialog();
            dataBind();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
