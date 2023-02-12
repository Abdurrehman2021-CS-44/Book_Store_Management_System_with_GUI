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
    public partial class frmLoginPage : Form
    {
        public frmLoginPage()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text == "" && txtPassword.Text == "")
                    throw new Exception("Both Username && Password is empty");
                if (txtUserName.Text == "")
                    throw new Exception("Username is empty");
                if (txtPassword.Text == "")
                    throw new Exception("Password is empty");
                MUser user = new MUser(txtUserName.Text, txtPassword.Text);
                MUser u = MUserDL.signIn(user);
                if (u != null)
                {
                    if (u.isAdmin())
                    {
                        this.Hide();
                        frmAdminPage form = new frmAdminPage();
                        form.Show();
                    }
                    else
                    {
                        this.Hide();
                        frmUserPage form = new frmUserPage();
                        form.Show();
                    }
                }
                else
                    MessageBox.Show("Invalid Username & Password");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void linLblCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmSignUp form = new frmSignUp();
            form.Show();
        }

        private void frmLoginPage_Load(object sender, EventArgs e)
        {
            clearDataFromForm();
        }

        private void clearDataFromForm()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLoginPage_Resize(object sender, EventArgs e)
        {

        }
        private void frmLoginPage_FormClosed(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
