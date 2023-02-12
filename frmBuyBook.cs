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
    public partial class frmBuyBook : Form
    {
        BookInfo b;
        public frmBuyBook()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBuyBook_Load(object sender, EventArgs e)
        {
            lblQuantity.Visible = false;
            txtHowMany.Visible = false;
            btnCancel.Visible = false;
            btnBuy.Visible = false;
            lblCheckMessage.Visible = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            foreach (BookInfo book in BookInfoDL.BookList)
            {
                if (txtName.Text == book.BName)
                {
                    lblQuantity.Visible = true;
                    txtHowMany.Visible = true;
                    btnCancel.Visible = true;
                    btnBuy.Visible = true;
                    lblCheckMessage.Visible = true;
                    lblCheckMessage.ForeColor = Color.Green;
                    lblCheckMessage.Text = "Exist";
                    b = book;
                    break;
                }
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                b.AmountOfBook = int.Parse(txtHowMany.Text);
                CustomerDL.Customer.Products.Add(b);
                CustomerDL.addIntoList(b);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
