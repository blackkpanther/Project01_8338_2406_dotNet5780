using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BL;
using DAL;
using DS;
namespace PL
{
    class Program
    {
        static void Main(string[] args)
        {
            Ibl bl = FactoryBL.GetFactory();
            var HostList = ListOfHost();
            var GuestRequestKeyList = ListOfGuestRequest();
            var HostingUnitList = ListOfHostingUnit();
        }

        static IEnumerable<Host> ListOfHost()
        {
            return new List<Host>
            {
                new Host
                {
                    HostKey = 10000001,
                    PrivateName = "A",
                    FamilyName = "AA",
                    PhoneNumber = "0000000000",
                    MailAddress = "aaa@gmail.com",
                    BankBranchDetails = new BankBranch
                    {
                        BankNumber = 1,
                        BankName = Enums.BankName.BankLeumi,
                        BranchNumber = 111,
                        BranchAddress = "aaaa aaaa",
                        BranchCity = Enums.SubArea.Afula
                    },
                    BankAccountNumber = 111,
                    CollectionClearance = true
                },
                new Host
                {
                    HostKey = 10000002,
                    PrivateName = "B",
                    FamilyName = "BB",
                    PhoneNumber = "0000000000",
                    MailAddress = "bbb@gmail.com",
                    BankBranchDetails = new BankBranch
                    {
                        BankNumber = 2,
                        BankName = Enums.BankName.BankLeumi,
                        BranchNumber = 222,
                        BranchAddress = "bbbb bbbb",
                        BranchCity = Enums.SubArea.Afula
                    },
                    BankAccountNumber = 222,
                    CollectionClearance = false
                },
                new Host
                {
                    HostKey = 10000003,
                    PrivateName = "C",
                    FamilyName = "CC",
                    PhoneNumber = "0000000000",
                    MailAddress = "ccc@gmail.com",
                    BankBranchDetails = new BankBranch
                    {
                        BankNumber = 3,
                        BankName = Enums.BankName.BankLeumi,
                        BranchNumber = 333,
                        BranchAddress = "cccc cccc",
                        BranchCity = Enums.SubArea.Afula
                    },
                    BankAccountNumber = 333,
                    CollectionClearance = true
                }
                  };
        }
        static IEnumerable<GuestRequest> ListOfGuestRequest()
        {
            return new List<GuestRequest>
            {
                new GuestRequest
                {
                     GuestRequestKey = 10000001,
                     PrivateName ="A",
                     FamilyName= "AA",
                     MailAddress = "aaa@gmail.com",
                     Status = Enums.Status.MailSent,
                     RegistrationDate = new DateTime(2021,1,1),
                     EntryDate = new DateTime(2021,2,2),
                     ReleaseDate= new DateTime(2021,2,4),
                     Area = Enums.Area.Center,
                     SubArea = Enums.SubArea.Ashdod,
                     Type = Enums.Type.Camping,
                     Adults = 1,
                     Children =1,
                     Pool = Enums.Option.possible,
                     Jacuzzi =  Enums.Option.uninterested,
                     Garden = Enums.Option.possible,
                     ChildrensAttractions= Enums.Option.uninterested,
                     Signed=true
                },
                 new GuestRequest
                {
                     GuestRequestKey = 10000002,
                     PrivateName ="B",
                     FamilyName= "BB",
                     MailAddress = "bbb@gmail.com",
                     Status = Enums.Status.MailSent,
                     RegistrationDate = new DateTime(2021,2,2),
                     EntryDate = new DateTime(2021,3,3),
                     ReleaseDate= new DateTime(2021,2,5),
                     Area = Enums.Area.Center,
                     SubArea = Enums.SubArea.Ashdod,
                     Type = Enums.Type.Camping,
                     Adults = 2,
                     Children =2,
                     Pool = Enums.Option.possible,
                     Jacuzzi =  Enums.Option.uninterested,
                     Garden = Enums.Option.possible,
                     ChildrensAttractions= Enums.Option.uninterested,
                     Signed=true
                },
                  new GuestRequest
                {
                     GuestRequestKey = 10000003,
                     PrivateName ="C",
                     FamilyName= "CC",
                     MailAddress = "ccc@gmail.com",
                     Status = Enums.Status.MailSent,
                     RegistrationDate = new DateTime(2021,1,1),
                     EntryDate = new DateTime(2021,2,2),
                     ReleaseDate= new DateTime(2021,2,4),
                     Area = Enums.Area.Center,
                     SubArea = Enums.SubArea.Ashdod,
                     Type = Enums.Type.Camping,
                     Adults = 3,
                     Children =3,
                     Pool = Enums.Option.possible,
                     Jacuzzi =  Enums.Option.uninterested,
                     Garden = Enums.Option.possible,
                     ChildrensAttractions= Enums.Option.uninterested,
                     Signed=true
                },
            };

        }

        static IEnumerable<HostingUnit> ListOfHostingUnit()
        {
            return new List<HostingUnit>
            {
                new HostingUnit
                {
                    HostingUnitKey=100000001,
                    Owner=new Host
                                   {
                    HostKey = 10000001,
                    PrivateName = "A",
                    FamilyName = "AA",
                    PhoneNumber = "0000000000",
                    MailAddress = "aaa@gmail.com",
                    BankBranchDetails = new BankBranch
                    {
                        BankNumber = 1,
                        BankName = Enums.BankName.BankLeumi,
                        BranchNumber = 111,
                        BranchAddress = "aaaa aaaa",
                        BranchCity = Enums.SubArea.Afula
                    },
                    BankAccountNumber = 111,
                    CollectionClearance = true
                },
                    HostringUnitName="aa",
                    Diary=null,//לבדוק!!!!
               SubArea=Enums.SubArea.Dimona


                },
                new HostingUnit
                {
                    HostingUnitKey=100000001,
                    Owner=new Host
                   {
                    HostKey = 10000001,
                    PrivateName = "A",
                    FamilyName = "AA",
                    PhoneNumber = "0000000000",
                    MailAddress = "aaa@gmail.com",
                    BankBranchDetails = new BankBranch
                    {
                        BankNumber = 1,
                        BankName = Enums.BankName.BankLeumi,
                        BranchNumber = 111,
                        BranchAddress = "aaaa aaaa",
                        BranchCity = Enums.SubArea.Afula
                    },
                    BankAccountNumber = 111,
                    CollectionClearance = true
                },
                    HostringUnitName="aa",
                    Diary=null,//לבדוק!!!!
               SubArea=Enums.SubArea.Dimona


                },
                new HostingUnit
                {
                    HostingUnitKey=100000001,
                    Owner=new Host
                                   {
                    HostKey = 10000001,
                    PrivateName = "A",
                    FamilyName = "AA",
                    PhoneNumber = "0000000000",
                    MailAddress = "aaa@gmail.com",
                    BankBranchDetails = new BankBranch
                    {
                        BankNumber = 1,
                        BankName = Enums.BankName.BankLeumi,
                        BranchNumber = 111,
                        BranchAddress = "aaaa aaaa",
                        BranchCity = Enums.SubArea.Afula
                    },
                    BankAccountNumber = 111,
                    CollectionClearance = true
                },
                    HostringUnitName="aa",
                    Diary=null,//לבדוק!!!!
               SubArea=Enums.SubArea.Dimona


                }
            };







        }




    }

}



