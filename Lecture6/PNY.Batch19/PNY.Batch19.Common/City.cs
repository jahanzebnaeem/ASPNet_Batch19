namespace PNY.Batch19.Common
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CountryID { get; set; }
        public City() { }
        public City(string name, int cid)
        {
            Name = name;
            CountryID = cid;
        }
        public City(int id, string name, int cid)
        {
            ID = id;
            Name = name;
            CountryID = cid;
        }
    }
}