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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text == "" && txtPassword.Text == "" && cmbRole.Text != "")
                    throw new Exception("All Input is empty!");
                if (txtUserName.Text == "")
                    throw new Exception("Username is empty!");
                if (txtPassword.Text == "")
                    throw new Exception("Password is empty!");
                if (cmbRole.Text == "")
                    throw new Exception("Role is empty!");
                MUser user = new MUser(txtUserName.Text, txtPassword.Text, cmbRole.Text);
                MUserDL.addIntoList(user);
                MUserDL.storeIntoFile(locations.PathUsers, user);
                this.Hide();
                frmLoginPage login = new frmLoginPage();
                login.Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("User");
            clearDataFromForm();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void clearDataFromForm()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            cmbRole.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginPage login = new frmLoginPage();
            login.Show();
        }
    }
}
