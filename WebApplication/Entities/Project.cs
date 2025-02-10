namespace Backend.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int CustomerId { get; set; }  // Foreign Key till Customer
        public Customer Customer { get; set; } = null!; // Navigeringsproperty
    }
}
