namespace PNY.Batch19.Common
{
    #region Using
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    #endregion

    public class Person
    {
        public int CNIC { get; set; }
        public string Name { get; set; }
        public string PermanentAddress { get; set; }
        public string CurrentAddress { get; set; }
        public ContactNumber ContactNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }

        public Person() { }
        public Person(int cnic, string name, string pa, string ca, ContactNumber cn, DateTime dob, Country country, City city)
        {
            CNIC = cnic;
            Name = name;
            PermanentAddress = pa;
            CurrentAddress = ca;
            ContactNumber = cn;
            DateOfBirth = dob;
            Country = country;
            City = city;
        }
    }
}
