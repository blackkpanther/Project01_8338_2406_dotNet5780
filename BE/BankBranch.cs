namespace BE
{
    public class BankBranch
    {
        private int bankNumber;
        private string bankName;
        private int branchNumber;
        private string branchAddress;
        private string branchCity;

        //constructors
          public BankBranch()
        {
            BankNumber = 1;
            BankName = Enums.BankName.BankLeumi;
            BranchNumber = 111;
            BranchAddress = "aaaa aaaa";
            BranchCity = Enums.SubArea.Afula;
            }
        /*   public BankBranch( int bankNumber1, Enums.BankName bankName1, int branchNumber1, string branchAddress1 , Enums.SubArea branchCity1)
           {
           bankNumber= bankNumber1;
           bankName= bankName1;
           branchNumber=  branchNumber1;
           branchAddress=  branchAddress1;
           branchCity= branchCity1;

           }*/

        /*  public BankBranch()
          {
              bankNumber = 10;
              bankName = Enums.BankName.BankHapoalim;
              branchNumber = 10;
              branchAddress = "aa10";
              branchCity = Enums.SubArea.Afula;
          }*/
        //properties:

        public int BankNumber
        {
            get { return bankNumber; }
            set { bankNumber = value; }
        }
        public string BankName
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
        public string BranchCity
        {
            get { return branchCity; }
            set { branchCity = value; }
        }
        //printing method
        public override string ToString()
        {
            return "Bank account no.: " + this.bankNumber + " Bank name: " + this.bankName + " Branch no.: " + this.branchNumber + " Branch address: " + this.branchAddress + " City: " + this.branchCity;
        }

    }
}
