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
    public partial class frmAddNewspaper : Form
    {
        public frmAddNewspaper()
        {
            InitializeComponent();
        }

        private void lblCountry_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                NewspaperInfo newspaper = new NewspaperInfo(txtCountry.Text, txtCompany.Text, txtLanguage.Text, txtLink.Text, int.Parse(month), int.Parse(day), int.Parse(year) ,int.Parse(txtPage.Text));
                if (int.Parse(txtPage.Text) <= 0 || int.Parse(txtPage.Text) >= 25)
                {
                    throw new Exception("You can not add pages in negative! Or more than 25");
                }
                NewspaperInfoDL.addIntoList(newspaper);
                NewspaperInfoDL.storeIntoFile(locations.PathNewspapers, newspaper);
                this.Hide();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLink_Click(object sender, EventArgs e)
        {

        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
