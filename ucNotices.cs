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
    public partial class ucNotices : UserControl
    {
        public ucNotices()
        {
            InitializeComponent();
        }

        private void gvNotices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Notice notice = (Notice)gvNotices.CurrentRow.DataBoundItem;
            if (gvNotices.Columns["Delete"].Index == e.ColumnIndex)
            {
                NoticeDL.Notices.Remove(notice);
                dataBind();
            }
        }

        private void dataBind()
        {
            gvNotices.DataSource = null;
            gvNotices.DataSource = NoticeDL.Notices;
            gvNotices.Refresh();
            gvNotices.ForeColor = Color.Black;
            gvNotices.Columns["check"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNotices form = new frmAddNotices();
            form.ShowDialog();
            dataBind();
        }

        private void ucNotices_Load(object sender, EventArgs e)
        {
            dataBind();
        }
    }
}
