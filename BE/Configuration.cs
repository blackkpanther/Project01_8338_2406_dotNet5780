namespace BE
{
    public class Configuration
    {
        public const int NumOfDaysInMonth = 31;
        public const int NumOfMonthsInYear = 12;

        private static long serialGuestKey= 10000000;
        private static int serialBankNumber = 10;
        private static long serialGuestRequestKey = 10000000;
        private static long serialHostKey = 10000000;
        private static long serialHostingUnitKey = 10000000;
        private static long serialOrderKey = 20000000;
        private static double serviceCharge= 0.2;//עמלה

        public static int GetNewSerialBankNumber() { return serialBankNumber++; }
        public static long GetNewSerialGuestRequestKey() { return serialGuestRequestKey++; }
        public static long GetNewSerialGuestKey() { return serialGuestRequestKey++; }
        public static long GetNewSerialHostKey() { return serialHostKey++; }
        public static long GetNewSerialHostingUnitKey() { return serialHostingUnitKey++; }
        public static long GetNewSerialOrderKey() { return serialOrderKey++; }
        public static double GetServiceCharge() { return serviceCharge; }

    }
}
