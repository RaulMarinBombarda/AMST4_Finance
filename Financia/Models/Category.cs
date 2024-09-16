namespace Financia.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Nome { get; set; }
        public DateTime  CreatAt{ get; set; }
        public bool IsActive { get; set; }

    }
}
