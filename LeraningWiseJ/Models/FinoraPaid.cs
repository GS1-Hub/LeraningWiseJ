namespace LeraningWiseJ.Models
{
    public class FinoraPaid
    {
        public int Id { get; set; }
        public int FinId { get; set; }
        public Finora Fin { get; set; }
        public bool IsPaid { get; set; } 
    }
}