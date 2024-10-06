namespace Financia.Models
{
    public class Account
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsActive { get; set; }
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }
        // apaguei a migração pq tava quebrando tudo xddd
    }
}
