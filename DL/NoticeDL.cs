using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreManagementSystem.BL;
using System.IO;

namespace BookStoreManagementSystem.DL
{
    class NoticeDL
    {
        private static List<Notice> notices = new List<Notice>();

        internal static List<Notice> Notices
        {
            get => notices;
            set => notices = value;
        }

        public static void addIntoNoticeList(Notice notice)
        {
            notices.Add(notice);
        }

        public static bool readFromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record = "";
                while ((record = file.ReadLine()) != null)
                {
                    string notice = record;
                    Notice ntc = new Notice(notice);
                    addIntoNoticeList(ntc);
                }
                file.Close();
                return true;
            }
            else
                return false;
        }

        public static void storeIntoFile(string path, string notice)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(notice);
            file.Flush();
            file.Close();
        }

        public static void storeAllDataIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Notice notice in Notices)
            {
                file.WriteLine(notice);
            }
            file.Flush();
            file.Close();
        }
    }
}
