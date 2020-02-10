using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace BE
{
    public class Enums
    {
        public enum Area { All, North, South, Center, Jerusalem, }
        public enum SubArea{Afula, Ashdod, Beersheba, Dimona, Eilat, Givatayim,Haifa, Herzliya, Jerusalem, Nahariya, Netanya, TelAviv,  }
        public enum Type { Zimmer, Hotel, Camping, Apartment, Villa, Guesthouses, }
        public enum Option { Necessary, possible,uninterested, }
        public enum OptionForUnit {Yes,No }
        public enum BankName {BankHapoalim,BankLeumi,BankMizrahi,InternationalBank,DiscountBank,    }
        public enum Status {Treated,NotTreated, MailSent,ClosedLackOfResponse, }

        public static List<string> GetArea()
        {
            return new List<string> { "All", "North", "South", "Center", "Jerusalem" };
        }
        public static List<string> GetSubArea()
        {  
          return new List<string>  { "Afula", "Ashdod", "Beersheba", "Dimona", "Eilat", "Givatayim", "Haifa", "Herzliya", "Jerusalem", "Nahariya", "Netanya", "TelAviv" };
        } 
        public static List<string> GetTypeOfUnit()
        {
            return new List<string> { "Zimmer", "Hotel", "Camping", "Apartment", "Villa", "Guesthouses" };
        }
        public static List<string> GetOption()
        {
            return new List<string> { "Yes","No" };
        }
        public static List<string> GetOptionForUnit()
        {
            return new List<string> { "Necessary", "possible", "uninterested" };
        }
        public static List<string> GetBankName()
        { 
            return new List<string> { "BankHapoalim", "BankLeumi", "BankMizrahi", "InternationalBank", "DiscountBank," };
        }
        public static List<string> GetStatus()
        { 
            return new List<string> { "Treated", "NotTreated", "MailSent", "ClosedLackOfResponse" };
        }



    }
}
