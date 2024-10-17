namespace Hospital_Management.Models
{
    public class Accounts
    {
        public int Id { get; set; } 

        public Patient? Patient { get; set; }

        public float AmountPaid { get; set; }
        
        public string? PaymentMethod { get; set; }

        
    }
}
