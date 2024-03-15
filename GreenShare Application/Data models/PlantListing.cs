namespace GreenShare_Application.Data_models
{
    public class PlantListing
    {
        public int ID { get; set; }

        public PlantListing(int iD) => ID = iD;

        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public int OwnerID { get; set; }
        public DateTime DatePosted { get; set; }
        public List<string> Tags { get; set; }
        public int Quantity { get; set; }
        public string Condition { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }
        public bool Availability { get; set; }
    }
}
