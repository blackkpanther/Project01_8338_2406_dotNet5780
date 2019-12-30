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
               

       

        }

        static IEnumerable<Host> ListOfHost()
        {
            return new List<Host>
            {
                new Host {  PrivateName = "A", FamilyName ="AA", PhoneNumber= "0000000000", MailAddress="aaa@gmail.com",BankAccountNumber= new BankBranch(1, Enums.BankName.BankLeumi, 111 ,"aaaa aaaa" ,Enums.SubArea.Afula) ,    }



            }

        }


    }
}
