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
    public partial class ucViewMagazines : UserControl
    {
        public ucViewMagazines()
        {
            InitializeComponent();
        }

        private void gvViewMagazines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BL.MagazinesInfo magazine = (MagazinesInfo)gvViewMagazines.CurrentRow.DataBoundItem;
            if (gvViewMagazines.Columns["View"].Index == e.ColumnIndex)
            {
                MessageBox.Show("Link : " + magazine.Link);
            }
        }

        private void dataBind()
        {
            gvViewMagazines.DataSource = null;
            gvViewMagazines.DataSource = MagazinesInfoDL.MagazinesList;
            gvViewMagazines.Refresh();
            gvViewMagazines.ForeColor = Color.Black;
            gvViewMagazines.Columns["Link"].Visible = false;
            gvViewMagazines.Columns["companyName"].HeaderText = "Company";
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSort.Text == "Country")
            {
                List<MagazinesInfo> magazine = MagazinesInfoDL.MagazinesList.OrderBy(o => o.Country).ToList();
                MagazinesInfoDL.MagazinesList = magazine;
                dataBind();
            }
            if (cmbSort.Text == "Language")
            {
                List<MagazinesInfo> magazine = MagazinesInfoDL.MagazinesList.OrderBy(o => o.Language).ToList();
                MagazinesInfoDL.MagazinesList = magazine;
                dataBind();
            }
            if (cmbSort.Text == "Company")
            {
                List<MagazinesInfo> magazine = MagazinesInfoDL.MagazinesList.OrderBy(o => o.CompanyName).ToList();
                MagazinesInfoDL.MagazinesList = magazine;
                dataBind();
            }
            if (cmbSort.Text == "Category")
            {
                List<MagazinesInfo> magazine = MagazinesInfoDL.MagazinesList.OrderBy(o => o.Category).ToList();
                MagazinesInfoDL.MagazinesList = magazine;
                dataBind();
            }
        }

        private void ucViewMagazines_Load(object sender, EventArgs e)
        {
            dataBind();
            cmbSort.Items.Add("Country");
            cmbSort.Items.Add("Company");
            cmbSort.Items.Add("Language");
            cmbSort.Items.Add("Category");
        }
    }
}
