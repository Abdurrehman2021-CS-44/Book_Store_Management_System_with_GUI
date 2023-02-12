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
    public partial class ucUsers : UserControl
    {
        public ucUsers()
        {
            InitializeComponent();
        }

        private void gvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MUser user = (MUser)gvUsers.CurrentRow.DataBoundItem;
            if (gvUsers.Columns["Delete"].Index == e.ColumnIndex)
            {
                MUserDL.UserList.Remove(user);
                MUserDL.storeAllDataIntoFile(BL.locations.PathUsers);
                dataBind();
            }
            else if (gvUsers.Columns["Edit"].Index == e.ColumnIndex)
            {
                frmEditUser form = new frmEditUser(user);
                form.ShowDialog();
                MUserDL.storeAllDataIntoFile(BL.locations.PathUsers);
                dataBind();
            }
        }
        private void dataBind()
        {
            gvUsers.DataSource = null;
            gvUsers.DataSource = MUserDL.UserList;
            gvUsers.Refresh();
            gvUsers.ForeColor = Color.Black;
        }

        private void ucUsers_Load(object sender, EventArgs e)
        {
            dataBind();
            cmbSort.Items.Add("Username");
            cmbSort.Items.Add("Password");
            cmbSort.Items.Add("Role");
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSort.Text == "Userame")
            {
                List<MUser> user = MUserDL.UserList.OrderBy(o => o.UserName).ToList();
                MUserDL.UserList = user;
                dataBind();
            }
            if (cmbSort.Text == "Password")
            {
                List<MUser> user = MUserDL.UserList.OrderBy(o => o.Password).ToList();
                MUserDL.UserList = user;
                dataBind();
            }
            if (cmbSort.Text == "Role")
            {
                List<MUser> user = MUserDL.UserList.OrderBy(o => o.Role).ToList();
                MUserDL.UserList = user;
                dataBind();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
