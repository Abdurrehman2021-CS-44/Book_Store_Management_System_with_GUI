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
    public partial class frmAddMagazine : Form
    {
        public frmAddMagazine()
        {
            InitializeComponent();
        }

        private void frmAddMagazine_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string date = dtpDate.Text;
            int counter = 0;
            string year = "", month = "", day = "";
            for (int i = 0; i < date.Length; i++)
            {
                if (date[i] == '-')
                {
                    counter++;
                }
                if (counter == 0)
                {
                    if (date[i] != '-')
                        day = day + int.Parse(date[i].ToString());
                }
                if (counter == 2)
                {
                    if (date[i] != '-')
                        month = month + date[i].ToString();
                }
                if (counter == 4)
                {
                    if (date[i] != '-')
                        year = year + date[i].ToString();
                }
            }
            try
            {
                MagazinesInfo magazine = new MagazinesInfo(txtCountry.Text, txtCompany.Text, txtLanguage.Text, txtLink.Text, int.Parse(month), int.Parse(day), int.Parse(year), txtCateg.Text);
                MagazinesInfoDL.addIntoList(magazine);
                MagazinesInfoDL.storeIntoFile(locations.PathMagazines, magazine);
                this.Hide();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
