namespace MVCViewsIntro.Models
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
    }
}