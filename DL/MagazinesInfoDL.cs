using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreManagementSystem.BL;
using System.IO;

namespace BookStoreManagementSystem.DL
{
    class MagazinesInfoDL
    {
        private static List<MagazinesInfo> magazinesList = new List<MagazinesInfo>();

        internal static List<MagazinesInfo> MagazinesList
        {
            get => magazinesList;
            set => magazinesList = value;
        }

        public static void addIntoList(MagazinesInfo magazine)
        {
            magazinesList.Add(magazine);
        }

        public static string parseData(string record, int field)
        {
            int commaCount = 1;
            string item = "";
            foreach (char i in record)
            {
                if (i == ',')
                {
                    commaCount++;
                }
                else if (commaCount == field)
                {
                    if (i != ',')
                        item = item + i;
                }
            }
            return item;
        }

        public static bool readFromList(string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record = "";
                while ((record = file.ReadLine()) != null)
                {
                    string country = parseData(record, 1);
                    string companyName = parseData(record, 2);
                    string language = parseData(record, 3);
                    string link = (parseData(record, 4));
                    string category = parseData(record, 5);
                    int month = int.Parse(parseData(record, 6));
                    int day = int.Parse(parseData(record, 7));
                    int year = int.Parse(parseData(record, 8));
                    MagazinesInfo magazine = new MagazinesInfo(country, companyName, language, link, month, day, year , category);
                    addIntoList(magazine);
                }
                file.Close();
                return true;
            }
            else
                return false;
        }

        public static void storeIntoFile(string path, MagazinesInfo magazine)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(magazine.Country + "," + magazine.CompanyName + "," + magazine.Language + "," + magazine.Link + "," +  magazine.Category + "," + magazine.Month + "," + magazine.Day + "," + magazine.Year);
            file.Flush();
            file.Close();
        }

        public static void storeAllDataIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (MagazinesInfo magazine in magazinesList)
            {
                file.WriteLine(magazine.Country + "," + magazine.CompanyName + "," + magazine.Language + "," + magazine.Link + "," + magazine.Category + "," + magazine.Month + "," + magazine.Day + "," + magazine.Year);
            }
            file.Flush();
            file.Close();
        }
    }
}
