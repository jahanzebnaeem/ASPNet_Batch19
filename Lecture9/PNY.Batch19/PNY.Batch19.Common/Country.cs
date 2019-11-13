namespace PNY.Batch19.Common
{
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Country() { }
        public Country(string name)
        {
            Name = name;
        }
        public Country(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}