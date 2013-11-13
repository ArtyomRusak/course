namespace Entities
{
    public class History
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
