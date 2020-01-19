using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace BE
{
    public class BankBranch
    {
        private int bankNumber;
        private Enums.BankName bankName;
        private int branchNumber;
        private string branchAddress;
        private Enums.SubArea branchCity;

        //constructors
      //  public BankBranch() { }
     /*   public BankBranch( int bankNumber1, Enums.BankName bankName1, int branchNumber1, string branchAddress1 , Enums.SubArea branchCity1)
        {
        bankNumber= bankNumber1;
        bankName= bankName1;
        branchNumber=  branchNumber1;
        branchAddress=  branchAddress1;
        branchCity= branchCity1;

        }*/

        //properties:

        public int BankNumber
        {
            get { return bankNumber; }
            set { bankNumber = value; }
        }
        public Enums.BankName BankName
        {
            get { return bankName; }
            set { bankName = value; }
        }
        public int BranchNumber
        {
            get { return branchNumber; }
            set { branchNumber = value; }
        }
        public string BranchAddress
        {
            get { return branchAddress; }
            set { branchAddress = value; }
        }
        public Enums.SubArea BranchCity
        {
            get { return branchCity; }
            set { branchCity = value; }
        }
        //printing method
        public override string ToString()
        {
            return "Bank account no.: "+this.bankNumber + " Bank name: " + this.bankName + " Branch no.: " + this.branchNumber + " Branch address: " + this.branchAddress + " City: " + this.branchCity;
        }
      
    }
}
