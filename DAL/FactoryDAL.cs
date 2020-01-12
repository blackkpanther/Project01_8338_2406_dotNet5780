using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DAL
{
    public class FactoryDAL
    {

        static Idal instance = null;

        public static Idal GetFactory()
        {
            if (instance == null)
                instance = new Dal_imp();
            return instance;
        }



    }
}
