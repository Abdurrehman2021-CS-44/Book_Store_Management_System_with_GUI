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
    public partial class ucMagazines : UserControl
    {
        public ucMagazines()
        {
            InitializeComponent();
        }

        private void ucMagazines_Load(object sender, EventArgs e)
        {
            dataBind();
            cmbSort.Items.Add("Country");
            cmbSort.Items.Add("Company");
            cmbSort.Items.Add("Language");
            cmbSort.Items.Add("Category");
        }

        private void gvMagazines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BL.MagazinesInfo magazine = (MagazinesInfo)gvMagazines.CurrentRow.DataBoundItem;
            if (gvMagazines.Columns["Delete"].Index == e.ColumnIndex)
            {
                MagazinesInfoDL.MagazinesList.Remove(magazine);
                MagazinesInfoDL.storeAllDataIntoFile(locations.PathNewspapers);
                dataBind();
            }
            else if (gvMagazines.Columns["View"].Index == e.ColumnIndex)
            {
                MessageBox.Show("Link : " + magazine.Link);
            }
        }
        private void dataBind()
        {
            gvMagazines.DataSource = null;
            gvMagazines.DataSource = MagazinesInfoDL.MagazinesList;
            gvMagazines.Refresh();
            gvMagazines.ForeColor = Color.Black;
            gvMagazines.Columns["Link"].Visible = false;
            gvMagazines.Columns["companyName"].HeaderText = "Company";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddMagazine form = new frmAddMagazine();
            form.ShowDialog();
            dataBind();
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
    }
}
