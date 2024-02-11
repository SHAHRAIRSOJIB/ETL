namespace ExelTechUI.Models
{
    public class PatientPerams
    {
        public int PId { get; set; }
        public string? Name { get; set; }
        public int? Disease { get; set; }
        public string? Epilepcy { get; set; }

        public ICollection<Ncd_Details>? NCDDetailsList { get; set; } 
        public ICollection<Allergy_Details>? AllergiesDetailsList { get; set; }
    }
}
