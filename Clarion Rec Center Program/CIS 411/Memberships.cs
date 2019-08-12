using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_411
{
    class Memberships
    {
        private string membershipID;

        public string MembershipID
        {
            get { return membershipID; }
            set { membershipID = value; }
        }
        private string duration;

        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        private string cost;

        public string Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        private string restricted;

        public string Restricted
        {
            get { return restricted; }
            set { restricted = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private string active;

        public string Active
        {
            get { return active; }
            set { active = value; }
        }
        private string daypass;

        public string Daypass
        {
            get { return daypass; }
            set { daypass = value; }
        }
        private DateTime expiration;

        public DateTime Expiration
        {
            get { return expiration; }
            set { expiration = value; }
        }
        private string expirationType;

        public string ExpirationType
        {
            get { return expirationType; }
            set { expirationType = value; }
        }

        public Memberships()
        {
            this.membershipID = " ";
            this.duration = " ";
            this.cost = " ";
            this.restricted = " ";
            this.description = " ";
            this.active = " ";
            this.daypass = " ";
            this.expiration = DateTime.Now;
            this.expirationType = " ";
        }

        public Memberships(string pMembershipID, string pDuration, string pCost, string pRestricted, string pDescription, string pActive, string pDaypass, DateTime pExpiration, string pExpirationType)
        {
            this.membershipID = pMembershipID;
            this.duration = pDuration;
            this.cost = pCost;
            this.restricted = pRestricted;
            this.description = pDescription;
            this.active = pActive;
            this.daypass = pDaypass;
            this.expiration = pExpiration;
            this.expirationType = pExpirationType;
        }

        /*
        public string MembershipID { get { return membershipID; } set { membershipID = value; } }
        public string Duration { get => duration; set => duration = value; }
        public string Cost { get => cost; set => cost = value; }
        public string Restricted { get => restricted; set => restricted = value; }
        public string Description { get => description; set => description = value; }
        public string Active { get => active; set => active = value; }
        public string Daypass { get => daypass; set => daypass = value; }
        public DateTime Expiration { get => expiration; set => expiration = value; }
        public string ExpirationType { get => expirationType; set => expirationType = value; }
        */
    }
}