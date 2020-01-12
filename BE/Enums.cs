using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace BE
{
  public class Enums
    {
        // GuestRequest:
        public enum Area
        {
            All,
            North,
            South,
            Center,
            Jerusalem,
        }
        public enum SubArea
        {
            Afula,
            Ashdod,
            Beersheba,
            Dimona,
            Eilat,
            Givatayim,
            Haifa,
            Herzliya,
            Jerusalem,
            Nahariya,
            Netanya,
            TelAviv,

        }

        public enum Type
        {
            Zimmer,
            Hotel,
            Camping,
            Apartment,
            Villa,
            Guesthouses,

        }

        public enum Option
        {
            Necessary,
            possible,
            uninterested,
        }

        //BankBranch:

        public enum BankName
        {
            BankHapoalim,
            BankLeumi,
            BankMizrahi,
            InternationalBank,
            DiscountBank,
            
        }

        //Order:

        public enum Status
        {
            Treated,
            NotTreated,
            MailSent,
            ClosedLackOfResponse,
        }
    }
}
