using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
namespace PL
{
    class Program//
    {
        static void Main(string[] args)
        {
            Ibl bl = FactoryBL.GetFactory();

            //var HostList = ListOfHost();
            var GuestRequestList = ListOfGuestRequest();
            var HostingUnitList = ListOfHostingUnit();
            var OrderList = ListOfOrder();
            #region delete
            // Host H1 = HostList.ElementAt(0);
            // GuestRequest G1 = GuestRequestList.ElementAt(0);
            HostingUnit H11 = HostingUnitList.ElementAt(0);
            // Order O1 = OrderList.ElementAt(0);
            #endregion
            #region update
            // Host H2 = HostList.ElementAt(1);
            GuestRequest G2 = GuestRequestList.ElementAt(1);
            HostingUnit H22 = HostingUnitList.ElementAt(1);
            Order O2 = OrderList.ElementAt(1);
            #endregion
            #region printTest before add
            foreach (var item in bl.GetGuestRequestList())
            {
                Console.WriteLine(item.ToString() + "\n");
            }
            foreach (var item in bl.GetHostingUnitList())
            {
                Console.WriteLine(item.ToString() + "\n");
            }
            foreach (var item in bl.GetOrderList())
            {
                Console.WriteLine(item.ToString() + "\n");
            }
            #endregion
            #region add
            /*   Console.WriteLine("\n Add host\n");
            for (int i = 0; i < HostList.Count(); i++)
            {
                try
                {
                    bl.AddHost(HostList.ElementAt(i));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }*/
            Console.WriteLine("\nGuest request Add\n");
            for (int i = 0; i < GuestRequestList.Count(); i++)
            {
                try
                {
                    bl.AddGuestRequest(GuestRequestList.ElementAt(i));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("\nHosting unit Add\n");
            for (int i = 0; i < HostingUnitList.Count(); i++)
            {
                try
                {
                    bl.AddHostingUnit(HostingUnitList.ElementAt(i));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("\nOrder Add\n");
            for (int i = 0; i < OrderList.Count(); i++)
            {
                try
                {
                    bl.AddOrder(OrderList.ElementAt(i));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            #endregion

            #region printTest before update
            foreach (var item in bl.GetGuestRequestList())
            {
                Console.WriteLine(item.ToString() + "\n");
            }
            foreach (var item in bl.GetHostingUnitList())
            {
                Console.WriteLine(item.ToString() + "\n");
            }
            foreach (var item in bl.GetOrderList())
            {
                Console.WriteLine(item.ToString() + "\n");
            }
            #endregion
            #region update
            /*   Console.WriteLine("\n update host\n");
            for (int i = 0; i < HostList.Count(); i++)
            {
                try
                {
                    bl.UpdateHost(HostList.ElementAt(i));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }*/
            Console.WriteLine("\nGuest request Update \n");
            for (int i = 0; i < GuestRequestList.Count(); i++)
            {
                try
                {
                    bl.UpdateGuestRequest(ref G2, G2.Status);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("\nHosting unit update\n");
            for (int i = 0; i < HostingUnitList.Count(); i++)
            {
                try
                {
                    bl.UpdateHostingUnit(ref H22, H22.Diary);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("\nOrder update\n");
            for (int i = 0; i < OrderList.Count(); i++)
            {
                try
                {
                    bl.UpdateOrder(ref O2, O2.Status);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            #endregion
            #region printTest after update
            foreach (var item in bl.GetGuestRequestList())
            {
                Console.WriteLine(item.ToString() + "\n");
            }
            foreach (var item in bl.GetHostingUnitList())
            {
                Console.WriteLine(item.ToString() + "\n");
            }
            foreach (var item in bl.GetOrderList())
            {
                Console.WriteLine(item.ToString() + "\n");
            }
            #endregion
            #region delete hostingUnit
            try
            {
                string name = H11.UnitName;
                bl.DeleteHostingUnit(H11);
                Console.WriteLine("unit: " + name + " deleted/n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("unit didn't deleted/n");
            }
            //do it again to make sure it realy deleded
            try
            {
                string name = H11.UnitName;
                bl.DeleteHostingUnit(H11);
                Console.WriteLine("unit: " + name + " deleted/n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("unit didn't deleted/n");
            }

            #endregion
        }


        /*static IEnumerable<Host> ListOfHost()
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
        }*/
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
                    UnitName="aa",
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
                    UnitName="aa",
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
                    UnitName="aa",
                    Diary=null,//לבדוק!!!!
               SubArea=Enums.SubArea.Dimona
                }
            };
        }
        static IEnumerable<Order> ListOfOrder()
        {
            return new List<Order>
            {
                 new Order
                 {
                     HostingUnitKey=100000001,
                     GuestRequestKey=100000001,
                     OrderKey =100000001,
                     Status= Enums.Status.MailSent,
                     CreateDate= new DateTime(2021,2,2),
                     OrderDate=new DateTime(2021,2,7),
                     Fee= 65
                 },
                 new Order
                 {
                     HostingUnitKey=100000001,
                     GuestRequestKey=100000001,
                     OrderKey =100000001,
                     Status= Enums.Status.MailSent,
                     CreateDate= new DateTime(2021,2,2),
                     OrderDate=new DateTime(2021,2,7),
                     Fee= 65
                 },
                 new Order
                 {
                     HostingUnitKey=100000001,
                     GuestRequestKey=100000001,
                     OrderKey =100000001,
                     Status= Enums.Status.MailSent,
                     CreateDate= new DateTime(2021,2,2),
                     OrderDate=new DateTime(2021,2,7),
                     Fee= 65
                 }
            };
        }
    }

}



