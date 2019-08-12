using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_411
{
    class DataPass
    {
        private string activeUser;

        private int selectedMembership;

        private string customerName;

        private string customerPhone;

        private Nullable<int> cardNum;

        private DateTime transactDate;

        private string paymentType;

        private double transactCost;

        private string newMemb;

        private DateTime expireDate;

        private string needsSync;
   
        public DataPass()
        {
            this.ActiveUser = "s_kdickenshe"; //temporary hard code
            this.SelectedMembership = 0;
            this.CustomerName = "";
            this.CustomerPhone = "";
            this.CardNum = 0;
            this.TransactDate = DateTime.Now;
            this.PaymentType = "";
            this.TransactCost = 0.0;
            this.NewMemb = "";
            this.ExpireDate = DateTime.Now;
            this.NeedsSync = "";
        }

        public DataPass(string activeUser, int selectedMembership, string customerName, string customerPhone, 
            string insertString, Nullable<int> cardNum, DateTime transactDate, string paymentType, double transactCost, 
            string newMemb, DateTime expireDate, string needsSync)
        {
            this.ActiveUser = activeUser;
            this.SelectedMembership = selectedMembership;
            this.CustomerName = customerName;
            this.CustomerPhone = customerPhone;
            this.CardNum = cardNum;
            this.TransactDate = transactDate;
            this.PaymentType = paymentType;
            this.TransactCost = transactCost;
            this.NewMemb = newMemb;
            this.ExpireDate = expireDate;
            this.NeedsSync = needsSync;
        }


        //getters and setters
        public string ActiveUser { get { return activeUser; } set { activeUser = value; } }
        public int SelectedMembership { get { return selectedMembership; } set { selectedMembership = value; } }
        public string CustomerName { get { return customerName; } set { customerName = value; } }
        public string CustomerPhone { get { return customerPhone; } set { customerPhone = value; } }
        public Nullable<int> CardNum { get { return cardNum; } set { cardNum = value; } }
        public DateTime TransactDate { get { return transactDate; } set { transactDate = value; } }
        public string PaymentType { get { return paymentType; } set { paymentType = value; } }
        public double TransactCost { get { return transactCost; } set { transactCost = value; } }
        public string NewMemb { get { return newMemb; } set { newMemb = value; } }
        public DateTime ExpireDate { get { return expireDate; } set { expireDate = value; } }
        public string NeedsSync { get { return needsSync; } set { needsSync = value; } }
    }

}
