using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace BE
{
   public class HostingUnit
    {
        private int hostingUnitKey;
        private Host owner;
        private string hostringUnitName;
        private bool[,] diary;
        private Enums.SubArea subArea;// *

        //properties:

        public int HostingUnitKey
        {
            get { return hostingUnitKey; }
            set { hostingUnitKey = value; }
        }
        public Host Owner
        {
            get;
            set;
        }
        public string HostringUnitName
        {
            get { return hostringUnitName; }
            set { hostringUnitName = value; }
        }
        public bool[,] Diary
        {
            get { return diary; }
            set { diary = value; }
        }
        public Enums.SubArea SubArea
        {
            get { return subArea; }
            set { subArea = value; }
        }

        //printing method
        public override string ToString()
        {
            return "Hosting unit key: " + this.hostingUnitKey + " Owner: " + this.owner.PrivateName + " " + this.owner.FamilyName + " Hosting unit name: " + this.hostringUnitName + " Diary: " + this.diary;
        }
        public HostingUnit() { }
    }
}
