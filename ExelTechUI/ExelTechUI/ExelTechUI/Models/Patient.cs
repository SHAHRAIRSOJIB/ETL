namespace ExelTechUI.Models
{
    public class Patient
    {
        public int PId { get; set; }
        public string? Name { get; set; }
        public bool? Epilepcy { get; set; }
        public int? DId { get; set; }
        public List<NcdDetails>? NCDDetails { get; set; }
        public List<AllergiesDetails>? AllergiesDetails { get; set; }
    }
    public class NcdDetails
    {
        public int Id { get; set; }
        public int? PatientId { get; set; }
        public int? NCDId { get; set; }
    }

    public class AllergiesDetails
    {
        public int Id { get; set; }
        public int? PatientId { get; set; }
        public int? Allergy_Id { get; set; }
    }
}
