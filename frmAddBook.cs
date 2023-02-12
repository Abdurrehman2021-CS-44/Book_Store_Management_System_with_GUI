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
    public partial class frmAddNewBook : Form
    {
        public frmAddNewBook()
        {
            InitializeComponent();
        }

        private void frmAddNewBook_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                BookInfo b = new BookInfo(txtAuthor.Text, txtName.Text, txtCateg.Text, int.Parse(txtAmount.Text), float.Parse(txtPrice.Text), int.Parse(txtMin.Text));
                BookInfoDL.addIntoList(b);
                BookInfoDL.storeIntoFile(BL.locations.PathBookInfo, b);
                this.Hide();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCateg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMin_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblMax_Click(object sender, EventArgs e)
        {

        }

        private void lblCateg_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblAuthor_Click(object sender, EventArgs e)
        {

        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMax_Click_1(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtMin_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                BookInfo b = new BookInfo(txtAuthor.Text, txtName.Text, txtCateg.Text, int.Parse(txtAmount.Text), float.Parse(txtPrice.Text), int.Parse(txtMin.Text));
                BookInfoDL.addIntoList(b);
                BookInfoDL.storeIntoFile(BL.locations.PathBookInfo, b);
                this.Hide();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
