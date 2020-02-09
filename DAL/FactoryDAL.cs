////namespace DAL
////{
////    public class FactoryDAL
////    {
////        static Idal instance = null;
////        public static Idal GetFactory()
////        {
////            if (instance == null)
////               // instance = new DAL_XML();
////                instance = new Dal_imp();
////            return instance;
////        }
////    }
////}
namespace DAL
{
    public class FactoryDAL
{
    static Idal instance = null;
        public static Idal GetFactory(string typeDAL)
    {
        switch (typeDAL)
        {
            case "List":
                instance = new Dal_imp();
                return instance;
            case "XML":
                instance = new DAL_XML();
                return instance;
            default: return null;
        }
    }
}
}