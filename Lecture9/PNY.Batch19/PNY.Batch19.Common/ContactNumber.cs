namespace PNY.Batch19.Common
{
    public class ContactNumber
    {
        public int CountryCode { get; set; }
        public int AreaCode { get; set; }
        public int Number { get; set; }
        public ContactNumberType ContactNumberType { get; set; }

        public ContactNumber() { } 
        // ContactNumber cn = new ContactNumber();
        // cn.CountryCode = 92;
        public ContactNumber(int ac, int num):this(92, ac, num, ContactNumberType.Mobile) { }
        // ContactNumber cn = new ContactNumber(300,4833147);
        public ContactNumber(int cc, int ac, int num, ContactNumberType cnt)
        {
            CountryCode = cc;
            AreaCode = ac;
            Number = num;
            ContactNumberType = cnt;
        }

        // +92-300-4833147

        // cc = 92, ac = 300, number = 4833147
    }
}