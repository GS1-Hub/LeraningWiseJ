namespace LeraningWiseJ.Models
{
    public class Finora
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public Finora(int id, string name, string description, decimal amount)
        {
            Id = id;
            Name = name;
            Description = description;
            Amount = amount;
        }
    }
}
