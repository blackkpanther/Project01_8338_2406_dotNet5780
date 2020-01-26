namespace DAL
{
    public class FactoryDAL
    {

        static Idal instance = null;

        public static Idal GetFactory()
        {
            if (instance == null)
                instance = new DAL_XML();
            return instance;
        }



    }
}
