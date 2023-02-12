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
    public partial class ucNewspaper : UserControl
    {
        public ucNewspaper()
        {
            InitializeComponent();
        }

        private void ucNewspaper_Load(object sender, EventArgs e)
        {
            dataBind();
            gvNewspapers.ForeColor = Color.Black;
            cmbSort.Items.Add("Country");
            cmbSort.Items.Add("Company");
            cmbSort.Items.Add("Language");
            cmbSort.Items.Add("Pages");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddNewspaper form = new frmAddNewspaper();
            form.ShowDialog();
            dataBind();
        }

        private void gvNewspapers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BL.NewspaperInfo newspaper = (NewspaperInfo)gvNewspapers.CurrentRow.DataBoundItem;
            if (gvNewspapers.Columns["Delete"].Index == e.ColumnIndex)
            {
                NewspaperInfoDL.NewspaperList.Remove(newspaper);
                NewspaperInfoDL.storeAllDataIntoFile(locations.PathNewspapers);
                dataBind();
            }
            else if (gvNewspapers.Columns["View"].Index == e.ColumnIndex)
            {
                MessageBox.Show("Link : " + newspaper.Link);
            }
        }

        private void dataBind()
        {
            gvNewspapers.DataSource = null;
            gvNewspapers.DataSource = NewspaperInfoDL.NewspaperList;
            gvNewspapers.Refresh();
            gvNewspapers.Columns["Link"].Visible = false;
            gvNewspapers.Columns["companyName"].HeaderText = "Company";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbAdd_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
