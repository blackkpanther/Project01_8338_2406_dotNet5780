namespace BL
{
    public static class FactoryBL

    {

        static Ibl instance = null;

        public static Ibl GetFactory()
        {
            if (instance == null)
                instance = new BL_imp();
            return instance;
        }



    }
}
