using BE;

namespace DAL
{
    public static class Cloning
    {
        public static Guest Clone(this Guest original)
        {
            Guest target = new Guest();
            target.GuestKey = original.GuestKey;
            target.PrivateName = original.PrivateName;
            target.FamilyName = original.FamilyName;
            target.MailAddress = original.MailAddress;
            target.BankAccountNumber = original.BankAccountNumber;
            return target;
        }
        public static BankBranch Clone(this BankBranch original)
        {
            BankBranch target = new BankBranch();
            target.BankName = original.BankName;
            target.BankNumber = original.BankNumber;
            target.BranchAddress = original.BranchAddress;
            target.BranchCity = original.BranchCity;
            target.BranchNumber = original.BranchNumber;
            return target;
        }
        public static GuestRequest Clone(this GuestRequest original)
        {
            GuestRequest target = new GuestRequest();
            target.Adults = original.Adults;
            target.Area = original.Area;
            target.Children = original.Children;
            target.ChildrensAttractions = original.ChildrensAttractions;
            target.EntryDate = original.EntryDate;
           // target.Guest1 = original.Guest1;
             target.FamilyName = original.FamilyName;
            target.Garden = original.Garden;
            target.GuestRequestKey = original.GuestRequestKey;
            target.Jacuzzi = original.Jacuzzi;
            target.MailAddress = original.MailAddress;
            target.Pool = original.Pool;
            target.PrivateName = original.PrivateName;
            target.RegistrationDate = original.RegistrationDate;
            target.ReleaseDate = original.ReleaseDate;
            target.Status = original.Status;
            target.SubArea = original.SubArea;
            target.Type = original.Type;
            return target;
        }
        public static Host Clone(this Host original)
        {
            Host target = new Host();
            target.BankAccountNumber = original.BankAccountNumber;
            target.BankBranchDetails = original.BankBranchDetails;
            target.CollectionClearance = original.CollectionClearance;
            target.FamilyName = original.FamilyName;
            target.HostKey = original.HostKey;
            target.MailAddress = target.MailAddress;
            target.PhoneNumber = target.PhoneNumber;
            target.PrivateName = original.PrivateName;
            return target;
        }
        public static HostingUnit Clone(this HostingUnit original)
        {
            HostingUnit target = new HostingUnit();
            target.AllDates = original.AllDates;
            target.HostingUnitKey = original.HostingUnitKey;
            target.UnitName = original.UnitName;
            target.Owner = original.Owner;
            target.SubArea = original.SubArea;
            return target;
        }
        public static Order Clone(this Order original)
        {
            Order target = new Order();
            target.GuestRequestKey = original.GuestRequestKey;
            target.HostingUnitKey = original.HostingUnitKey;
            target.OrderDate = original.OrderDate;
            target.OrderKey = original.OrderKey;
            target.Status = original.Status;
            return target;
        }
    }
}
