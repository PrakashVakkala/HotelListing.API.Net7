namespace HotelListing.API.Data
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string shortname { get; set; }

        public virtual IList<Hotel> hotels { get; set;}
    }
}