using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BE
{
    public class Configuration
    {
        // public const int NumOfDaysInMonth = 31;
        // public const int NumOfMonthsInYear = 12;
        private static List<long> serialKeys = new List<long> { 9999999 ,10, 1999999, 2 };
        //public static long serialGuestKey { get; set; } = 9999999;
        //public static int serialBankNumber { get; set; } = 10;
        //public static long serialGuestRequestKey { get; set; } =9999999;
        //public static long serialHostKey { get; set; } = 9999999;
        //public static long serialHostingUnitKey { get; set; } = 9999999;
        //public static long serialOrderKey { get; set; } =1999999;
        //public static double serviceCharge { get; set; } = 0.2;//עמלה

            public  List<long> GetSerialKeys() { return serialKeys; }
        public static long GetNewSerialBankNumber() { return serialKeys[1]; }
        public static long GetNewSerialGuestRequestKey() { return serialKeys[0]++; }
        public static long GetNewSerialGuestKey() { return serialKeys[0]++; }
        public  static        long GetNewSerialHostKey() { return serialKeys[0]++; }
        public  static        long GetNewSerialHostingUnitKey() { return serialKeys[0]++; }
        public  static        long GetNewSerialOrderKey() { return serialKeys[2]++; }
        public static double GetServiceCharge() { return serialKeys[3]/10; }
               
    }          
}
