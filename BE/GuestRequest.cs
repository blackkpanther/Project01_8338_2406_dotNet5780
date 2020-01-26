using System;

namespace BE
{
    public class GuestRequest
    {
        private long guestRequestKey;
        private string privateName;
        private string familyName;
        private string mailAddress;
        private Enums.Status status;
        private DateTime registrationDate;
        private DateTime entryDate;
        private DateTime releaseDate;
        private Enums.Area area;
        private Enums.SubArea subArea;
        private Enums.Type type;
        private int adults;
        private int children;
        private Enums.Option pool;
        private Enums.Option jacuzzi;
        private Enums.Option garden;
        private Enums.Option childrensAttractions;
        private bool signed;//הרשאה לחיוב חשבון בנק


        //properties:

        public long GuestRequestKey
        {
            get;
            set;
        }
        public string PrivateName
        {
            get { return privateName; }
            set { privateName = value; }
        }
        public string FamilyName
        {
            get { return familyName; }
            set { familyName = value; }
        }
        public string MailAddress
        {
            get { return mailAddress; }
            set { mailAddress = value; }
        }
        public Enums.Status Status
        {
            get { return status; }
            set { status = value; }
        }
        public DateTime RegistrationDate
        {
            get { return registrationDate; }
            set { registrationDate = value; }
        }
        public DateTime EntryDate
        {
            get { return entryDate; }
            set { entryDate = value; }
        }
        public DateTime ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }
        public Enums.Area Area
        {
            get { return area; }
            set { area = value; }
        }
        public Enums.SubArea SubArea
        {
            get { return subArea; }
            set { subArea = value; }
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
        public Enums.Option Pool
        {
            get { return pool; }
            set { pool = value; }
        }
        public Enums.Option Jacuzzi
        {
            get { return jacuzzi; }
            set { jacuzzi = value; }
        }
        public Enums.Option Garden
        {
            get { return garden; }
            set { garden = value; }
        }
        public Enums.Option ChildrensAttractions
        {
            get { return childrensAttractions; }
            set { childrensAttractions = value; }
        }
        public bool Signed
        {
            get { return signed; }
            set { signed = value; }
        }

        public override string ToString()
        {
            return " GuestRequestKey: " + GuestRequestKey + ", privateName: " + privateName
            + ", FamilyName: " + FamilyName + ", MailAddress: " + MailAddress + ", Status: " + Status
            + ",  RegistrationDate: " + RegistrationDate + ", EntryDate: " + EntryDate + ", ReleaseDate: "
            + ReleaseDate + ",  Area: " + Area + ",   SubArea: " + SubArea + ",  Type: " + Type
            + ",   Adults: " + Adults + ", Children: " + Children + ",    Pool: " + Pool + ",  Jacuzzi: "
            + Jacuzzi + ", Garden: " + Garden + ", ChildrensAttractions: " + ChildrensAttractions;
        }
    }
}
