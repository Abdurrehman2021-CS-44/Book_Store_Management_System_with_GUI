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
    public partial class frmAddNotices : Form
    {
        public frmAddNotices()
        {
            InitializeComponent();
        }

        private void lblEnter_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNotice.Text == "")
                    throw new Exception("Text bar is empty");

                Notice ntc = new Notice(txtNotice.Text);
                NoticeDL.addIntoNoticeList(ntc);
                this.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
