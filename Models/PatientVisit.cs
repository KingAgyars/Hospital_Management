namespace Hospital_Management.Models
{
    public class PatientVisit
    {
        public int Id { get; set; }
        public int PatientId { get; set; }

        public Patient? Patient { get; set; }

        public CardType CardType { get; set; }

        public string? InsuranceCardNo { get; set; }

        public BloodGroup BloodGroup { get; set; }

        public int Age { get; set; }

        public float Temperature { get; set; }

        public float Height { get; set; }

        public float Weight { get; set; }




    }

    public enum CardType
    {
        NHIS,
        Others
    }

    public enum BloodGroup
    {
        APlus,
        AMinus,
        BPlus,
        BMinus,
        ABPlus,
        ABMinus,
        OPlus,
        OMinus
    }

    public class PatientVisitCommand
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public CardType CardType { get; set; }

        public string? InsuranceCardNo { get; set; }

        public int Age { get; set; }

        

    }

}
