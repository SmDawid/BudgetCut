namespace MVCTemplate.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }
        public int Duration { get; set; }
        public decimal Price { get; set; }
        public string ImageFile { get; set; }
    }

}
