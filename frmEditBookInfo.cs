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
    public partial class frmEditBookInfo : Form
    {
        private BookInfo previous;
        public frmEditBookInfo(BookInfo book)
        {
            InitializeComponent();
            this.previous = book;
        }

        private void frmEditBookInfo_Load(object sender, EventArgs e)
        {
            txtAuthor.Text = previous.BAuthor;
            txtName.Text = previous.BName;
            txtCateg.Text = previous.BCateg;
            int Amount = previous.AmountOfBook;
            txtAmount.Text = Amount.ToString();
            float Price = previous.BPrice;
            txtPrice.Text = Price.ToString();
            int Minimum = previous.MinimumBooks;
            txtMin.Text = Minimum.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                BookInfo updated = new BookInfo(txtAuthor.Text, txtName.Text, txtCateg.Text, int.Parse(txtAmount.Text), float.Parse(txtPrice.Text), int.Parse(txtMin.Text));
                BookInfoDL.editUserFromList(previous, updated);
                this.Hide();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
