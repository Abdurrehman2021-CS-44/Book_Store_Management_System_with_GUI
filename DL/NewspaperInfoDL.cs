using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreManagementSystem.BL;
using System.IO;

namespace BookStoreManagementSystem.DL
{
    class NewspaperInfoDL
    {
        private static List<NewspaperInfo> newspaperList = new List<NewspaperInfo>();

        internal static List<NewspaperInfo> NewspaperList
        {
            get => newspaperList;
            set => newspaperList = value;
        }

        public static void addIntoList(NewspaperInfo newspaper)
        {
            newspaperList.Add(newspaper);
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
                    int pages = int.Parse(parseData(record, 5));
                    int month = int.Parse(parseData(record, 6));
                    int day = int.Parse(parseData(record, 7));
                    int year = int.Parse(parseData(record, 8));
                    NewspaperInfo newspaper = new NewspaperInfo(country, companyName, language, link, month, day, year, pages);
                    addIntoList(newspaper);
                }
                file.Close();
                return true;
            }
            else
                return false;
        }

        public static void storeIntoFile(string path, NewspaperInfo newspaper)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(newspaper.Country + "," + newspaper.CompanyName + "," + newspaper.Language + "," + newspaper.Link + "," + newspaper.Pages + "," + newspaper.Month + "," + newspaper.Day + "," + newspaper.Year);
            file.Flush();
            file.Close();
        }
        public static void storeAllDataIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (NewspaperInfo newspaper in newspaperList)
            {
                file.WriteLine(newspaper.Country + "," + newspaper.CompanyName + "," + newspaper.Language + "," + newspaper.Link + "," + newspaper.Pages + "," + newspaper.Month + "," + newspaper.Day + "," + newspaper.Year);
            }
            file.Flush();
            file.Close();
        }
    }
}
