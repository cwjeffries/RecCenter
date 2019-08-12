using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_411
{
    class StudentWorker
    {
        private string wUserName;
        private string wFirstName;
        private string wLastName;
        private string password;
        private string active;

        public StudentWorker()
        {
            this.wUserName = "";
            this.wFirstName = "";
            this.wLastName = "";
        }

        public StudentWorker(string wUserName, string wFirstName, string wLastName)
        {
            this.wUserName = wUserName;
            this.wFirstName = wFirstName;
            this.wLastName = wLastName;
        }

        public string WUserName { get { return wUserName; } set { wUserName = value; }  }
        public string WFirstName { get { return wFirstName; } set { wFirstName = value; } }
        public string WLastName { get { return wLastName; } set { wLastName = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Active { get { return active; } set { active = value; } }
    }
}
