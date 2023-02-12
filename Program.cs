using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStoreManagementSystem.BL;
using BookStoreManagementSystem.DL;

namespace BookStoreManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DL.MUserDL.readFromFile(locations.PathUsers);
            DL.BookInfoDL.readFromList(BL.locations.PathBookInfo);
            DL.NewspaperInfoDL.readFromList(locations.PathNewspapers);
            DL.MagazinesInfoDL.readFromList(locations.PathMagazines);
            DL.NoticeDL.readFromFile(locations.PathNotices);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmUserPage());
        }
    }
}
