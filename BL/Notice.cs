using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagementSystem.BL
{
    class Notice
    {
        private string notice;
        private bool check;

        public Notice(string notice)
        {
            this.notice = notice;
            this.check = true;
        }

        public string Notices
        {
            get => notice;
            set => notice = value;
        }
        public bool Check
        {
            get => check;
            set => check = value;
        }
    }
}
