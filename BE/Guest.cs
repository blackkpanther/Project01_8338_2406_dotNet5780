using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    class Guest
    {
        private string privateName;
        private string familyName;
        private string mailAddress;
        private long bankAcoountNumber;

        public string PrivateName
        {
            get { return privateName; }
            set { privateName = value; }
        }
        public string FamilyName
        {
            get { return familyName; }
            set { familyName = value; }
        }
        public string MailAddress
        {
            get { return mailAddress; }
            set { mailAddress = value; }
        }
        public long BankAccountNumber
        {
            get { return bankAcoountNumber; }
            set { bankAcoountNumber = value; }
        }
    }
}

