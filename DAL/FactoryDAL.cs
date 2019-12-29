using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DAL
{
    public class FactoryDAL
    {
        public static Idal getDal()
        {
            return Dal_imp.Instance;

        }
    }
}
