using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreManagementSystem.BL;
using System.IO;

namespace BookStoreManagementSystem.DL
{
    class MUserDL
    {
        private static List<MUser> userList = new List<MUser>();

        internal static List<MUser> UserList
        {
            get => userList;
            set => userList = value;
        }

        public static void addIntoList(MUser user)
        {
            userList.Add(user);
        }
        public static MUser signIn(MUser u)
        {
            foreach (MUser user in userList)
            {
                if (user.UserName == u.UserName && user.Password == u.Password)
                {
                    return user;
                }
            }
            return null;
        }
        public static string parseData(int field, string record)
        {
            int commaCount = 1;
            string item = "";
            foreach (var i in record)
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
        public static bool readFromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record = "";
                while ((record = file.ReadLine()) != null)
                {
                    string userName = parseData(1, record);
                    string password = parseData(2, record);
                    string role = parseData(3, record);
                    MUser user = new MUser(userName, password, role);
                    addIntoList(user);
                }
                file.Close();
                return true;
            }
            else
                return false;
        }
        public static void storeIntoFile(string path, MUser u)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(u.UserName + "," + u.Password + "," + u.Role);
            file.Flush();
            file.Close();
        }
        public static void deleteUserFromList(MUser u)
        {
            int index = 0;
            foreach (MUser user in userList)
            {
                if (user.UserName == u.UserName && user.Password == u.Password && user.Role == u.Role)
                {
                    userList.RemoveAt(index);
                }
                index++;
            }
        }
        public static void editUserFromList(MUser previous, MUser updated)
        {
            foreach (MUser i in userList)
            {
                if (i.UserName == previous.UserName && i.Password == previous.Password && i.Role == previous.Role)
                {
                    i.UserName = updated.UserName;
                    i.Password = updated.Password;
                    i.Role = updated.Role;
                }
            }
        }
        public static void storeAllDataIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (MUser i in userList)
            {
                file.WriteLine(i.UserName + "," + i.Password + "," + i.Role);
            }
            file.Flush();
            file.Close();
        }
    }
}
