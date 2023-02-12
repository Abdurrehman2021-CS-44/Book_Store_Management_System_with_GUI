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
    public partial class ucViewNotices : UserControl
    {
        public ucViewNotices()
        {
            InitializeComponent();
        }

        private void gvViewNotices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataBind()
        {
            gvViewNotices.DataSource = null;
            gvViewNotices.DataSource = NoticeDL.Notices;
            gvViewNotices.Refresh();
            gvViewNotices.ForeColor = Color.Black;
            gvViewNotices.Columns["check"].Visible = false;
        }

        private void ucViewNotices_Load(object sender, EventArgs e)
        {
            dataBind();
        }
    }
}
