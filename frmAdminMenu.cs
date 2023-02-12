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
    public partial class frmAdminPage : Form
    {
        public frmAdminPage()
        {
            InitializeComponent();
        }

        private void frmAdminPage_Load(object sender, EventArgs e)
        {
            ucBooks2.Visible = false;
            ucUsers2.Visible = false;
            ucNewspaper2.Visible = false;
            ucMagazines2.Visible = false;
            ucNotices1.Visible = false;
            ucOrderedBooks1.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucBooks2.Visible = true;
            ucUsers2.Visible = false;
            ucNewspaper2.Visible = false;
            ucMagazines2.Visible = false;
            ucNotices1.Visible = false;
            ucOrderedBooks1.Visible = false;
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void ucBooks1_Load(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ucBooks2.Visible = false;
            ucUsers2.Visible = true;
            ucNewspaper2.Visible = false;
            ucMagazines2.Visible = false;
            ucNotices1.Visible = false;
            ucOrderedBooks1.Visible = false;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucUsers1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   
            ucBooks2.Visible = false;
            ucUsers2.Visible = false;
            ucNewspaper2.Visible = true;
            ucMagazines2.Visible = false;
            ucNotices1.Visible = false;
            ucOrderedBooks1.Visible = false;
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }

        private void btnMagazines_Click(object sender, EventArgs e)
        {
            ucBooks2.Visible = false;
            ucUsers2.Visible = false;
            ucNewspaper2.Visible = false;
            ucMagazines2.Visible = true;
            ucNotices1.Visible = false;
            ucOrderedBooks1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucBooks2.Visible = false;
            ucUsers2.Visible = false;
            ucNewspaper2.Visible = false;
            ucMagazines2.Visible = false;
            ucNotices1.Visible = true;
            ucOrderedBooks1.Visible = false;
        }
        private void btnReqOrder_Click(object sender, EventArgs e)
        {
            ucBooks2.Visible = false;
            ucUsers2.Visible = false;
            ucNewspaper2.Visible = false;
            ucMagazines2.Visible = false;
            ucNotices1.Visible = false;
            ucOrderedBooks1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLoginPage form = new frmLoginPage();
            form.Show();
        }
    }
}
