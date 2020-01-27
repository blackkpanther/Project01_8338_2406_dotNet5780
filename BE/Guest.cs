namespace BE
{
    public class Guest
    {
        private long guestKey;
        private string familyName;
        private string privateName;
        private string mailAddress;
        private long bankAccountNumber;

        public long GuestKey
            {
            get { return guestKey; }
            set { guestKey = value; }
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
        public string MailAddress
        {
            get { return mailAddress; }
            set { mailAddress = value; }
        }
        public long BankAccountNumber
        {
            get { return bankAccountNumber; }
            set { bankAccountNumber = value; }
        }

        public override string ToString()
        {
            return "First Name: " + privateName + " Last Name: " + familyName + " Email: " + mailAddress + " BankAccount Number: " + bankAccountNumber;
        }
        //public override string ToString()
        //{
        //    return "guest ";
        //}
    }
}
