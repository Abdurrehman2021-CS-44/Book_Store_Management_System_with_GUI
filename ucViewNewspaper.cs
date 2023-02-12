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
    public partial class ucViewNewspaper : UserControl
    {
        public ucViewNewspaper()
        {
            InitializeComponent();
        }

        private void gvViewNewspapers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BL.NewspaperInfo newspaper = (NewspaperInfo)gvViewNewspapers.CurrentRow.DataBoundItem;
            if (gvViewNewspapers.Columns["View"].Index == e.ColumnIndex)
            {
                MessageBox.Show("Link : " + newspaper.Link);
            }
        }

        private void dataBind()
        {
            gvViewNewspapers.DataSource = null;
            gvViewNewspapers.DataSource = NewspaperInfoDL.NewspaperList;
            gvViewNewspapers.Refresh();
            gvViewNewspapers.ForeColor = Color.Black;
            gvViewNewspapers.Columns["Link"].Visible = false;
            gvViewNewspapers.Columns["companyName"].HeaderText = "Company";
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSort.Text == "Country")
            {
                List<NewspaperInfo> newspaper = NewspaperInfoDL.NewspaperList.OrderBy(o => o.Country).ToList();
                NewspaperInfoDL.NewspaperList = newspaper;
                dataBind();
            }
            if (cmbSort.Text == "Language")
            {
                List<NewspaperInfo> newspaper = NewspaperInfoDL.NewspaperList.OrderBy(o => o.Language).ToList();
                NewspaperInfoDL.NewspaperList = newspaper;
                dataBind();
            }
            if (cmbSort.Text == "Company")
            {
                List<NewspaperInfo> newspaper = NewspaperInfoDL.NewspaperList.OrderBy(o => o.CompanyName).ToList();
                NewspaperInfoDL.NewspaperList = newspaper;
                dataBind();
            }
            if (cmbSort.Text == "Pages")
            {
                List<NewspaperInfo> newspaper = NewspaperInfoDL.NewspaperList.OrderBy(o => o.Pages).ToList();
                NewspaperInfoDL.NewspaperList = newspaper;
                dataBind();
            }
        }

        private void ucViewNewspaper_Load(object sender, EventArgs e)
        {
            dataBind();
            cmbSort.Items.Add("Country");
            cmbSort.Items.Add("Company");
            cmbSort.Items.Add("Language");
            cmbSort.Items.Add("Pages");
        }
    }
}
