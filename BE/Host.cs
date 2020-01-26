using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace BE
{
    public class Host
    {
        private long hostKey;
        private string privateName;
        private string familyName;
        private string phoneNumber;
        private string mailAddress;
        private BankBranch bankBranchDetails;
        private int bankAccountNumber;
        private bool collectionClearance;
        private int numOfUnits;//*

       
        //properties
        public long HostKey
        {
            get { return hostKey; }
            set { hostKey = value; }
        }
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
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string MailAddress
        {
            get { return mailAddress; }
            set { mailAddress = value; }
        }
        public BankBranch BankBranchDetails
        {
            get { return bankBranchDetails; }
            set { bankBranchDetails = value; }
        }
        public int BankAccountNumber
        {
            get { return bankAccountNumber; }
            set { bankAccountNumber = value; }
        }
        public bool CollectionClearance
        {
            get { return collectionClearance; }
            set { collectionClearance = value; }
        }
        public int NumOfUnits
        {
            get { return numOfUnits; }
            set { numOfUnits = value; }
        }

        public string FullName
        {
            get
            {
                return this.familyName + " " + this.privateName;
            }
        }
        //printing method
        public override string ToString()
        {
            return "Host ID: " + this.hostKey + " Name: " + this.privateName + " " + this.familyName + " Phone no.: " + this.phoneNumber + " Email address: " + this.mailAddress + " Bank account information: " + this.bankBranchDetails.ToString() + " Collection clearance: " + this.collectionClearance;
        }
        // public Host() { }
    }
}
