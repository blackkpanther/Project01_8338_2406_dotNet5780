using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BE
{
    public class HostingUnit
    {
        private long hostingUnitKey = 0;
        private Host owner;
        private string unitName;
        //private bool[,] diary;
        public List<DateTime> AllDates { get; set; }
        private Enums.SubArea subArea;// *
        private Enums.Area area;
        private Enums.Type type;
        private int adults;//max number of adults 
        private int children;//max num of children
        private Enums.OptionForUnit pool;//
        private Enums.OptionForUnit jacuzzi;
        private Enums.OptionForUnit garden;
        private Enums.OptionForUnit childrensAttractions;
        private long pricePerNight;// *
        public List<string> Uris { get; set; }
        // private string uri;// "https://img.mako.co.il/2014/10/13/asnbsdnsn05_c.jpg",
        //private Calendar Calendar;
        //public List<string> Uris { get { return Uris; } set { Uris = value; } }
        //properties:

        //public List<string> Uris
        //{
        //    get { return uris; }
        //    set { uris = value; }

        //}

        public long HostingUnitKey
        {
            get { return hostingUnitKey; }
            set { hostingUnitKey = value; }
        }
        public Host Owner
        {
            get;
            set;
        }
        public string UnitName
        {
            get { return unitName; }
            set { unitName = value; }
        }
        //public bool[,] Diary
        //{
        //    get { return diary; }
        //    set { diary = value; }
        //}
        public Enums.SubArea SubArea
        {
            get { return subArea; }
            set { subArea = value; }
        }
        public Enums.Area Area
        {
            get { return area; }
            set { area = value; }
        }
        public Enums.Type Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Adults
        {
            get { return adults; }
            set { adults = value; }
        }
        public int Children
        {
            get { return children; }
            set { children = value; }
        }
        public Enums.OptionForUnit Pool
        {
            get { return pool; }
            set { pool = value; }
        }
        public Enums.OptionForUnit Jacuzzi
        {
            get { return jacuzzi; }
            set { jacuzzi = value; }
        }
        public Enums.OptionForUnit Garden
        {
            get { return garden; }
            set { garden = value; }
        }
        public Enums.OptionForUnit ChildrensAttractions
        {
            get { return childrensAttractions; }
            set { childrensAttractions = value; }
        }
        public long PricePerNight
        {
            get { return pricePerNight; }
            set { pricePerNight = value; }
        }
        /*public string Uri
          {
          get { return uri; }
          set { uri = value; }
          }*/
        //printing method
        public override string ToString()
        {
            return "Hosting unit key: " + this.hostingUnitKey + " Owner: " + this.owner.PrivateName + " " + this.owner.FamilyName + " Hosting unit name: " + this.UnitName /*+ " Diary: " + this.diary*/;
        }
        public HostingUnit() { }
    }
}
