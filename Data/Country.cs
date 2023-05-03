namespace HotelListing.Data
{
    public class Country
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int ShortName { get; set; }

        public virtual IList<Hotel> Hotels { get; set; }
    }
}