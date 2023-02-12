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
    public partial class frmEditUser : Form
    {
        private MUser previous;
        public frmEditUser(MUser user)
        {
            InitializeComponent();
            this.previous = user;
        }

        private void frmEditUser_Load(object sender, EventArgs e)
        {
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("User");
            txtUserName.Text = previous.UserName;
            txtPassword.Text = previous.Password;
            cmbRole.Text = previous.Role;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                MUser updated = new MUser(txtUserName.Text, txtPassword.Text, cmbRole.Text);
                MUserDL.editUserFromList(previous, updated);
                this.Hide();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
