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
    public partial class frmUserPage : Form
    {
        public frmUserPage()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginPage form = new frmLoginPage();
            form.Show();
        }

        private void btnViewBooks_Click(object sender, EventArgs e)
        {
            ucViewBooks1.Visible = true;
            ucViewNewspaper1.Visible = false;
            ucViewMagazines1.Visible = false;
            ucViewNotices1.Visible = false;
            ucBuyProduct1.Visible = false;
            ucAddEmployee1.Visible = false;
        }

        private void frmUserPage_Load(object sender, EventArgs e)
        {
            ucViewBooks1.Visible = false;
            ucViewNewspaper1.Visible = false;
            ucViewMagazines1.Visible = false;
            ucViewNotices1.Visible = false;
            ucBuyProduct1.Visible = false;
            ucAddEmployee1.Visible = false;
        }

        private void btnBuyBook_Click(object sender, EventArgs e)
        {
            ucViewBooks1.Visible = false;
            ucViewNewspaper1.Visible = false;
            ucViewMagazines1.Visible = false;
            ucViewNotices1.Visible = false;
            ucBuyProduct1.Visible = true;
            ucAddEmployee1.Visible = false;
        }

        private void btnNewspaper_Click(object sender, EventArgs e)
        {
            ucViewBooks1.Visible = false;
            ucViewNewspaper1.Visible = true;
            ucViewMagazines1.Visible = false;
            ucViewNotices1.Visible = false;
            ucBuyProduct1.Visible = false;
            ucAddEmployee1.Visible = false;
        }

        private void btnMagazines_Click(object sender, EventArgs e)
        {
            ucViewBooks1.Visible = false;
            ucViewNewspaper1.Visible = false;
            ucViewMagazines1.Visible = true;
            ucViewNotices1.Visible = false;
            ucBuyProduct1.Visible = false;
            ucAddEmployee1.Visible = false;
        }

        private void btnNotice_Click(object sender, EventArgs e)
        {
            ucViewBooks1.Visible = false;
            ucViewNewspaper1.Visible = false;
            ucViewMagazines1.Visible = false;
            ucViewNotices1.Visible = true;
            ucBuyProduct1.Visible = false;
            ucAddEmployee1.Visible = false;
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            ucViewBooks1.Visible = false;
            ucViewNewspaper1.Visible = false;
            ucViewMagazines1.Visible = false;
            ucViewNotices1.Visible = false;
            ucBuyProduct1.Visible = false;
            ucAddEmployee1.Visible = true;
            //this.Close();
            //frmLoginPage form = new frmLoginPage();
            //form.Show();
        }
    }
}
