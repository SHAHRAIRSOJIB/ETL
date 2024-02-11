using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExelTechApi.Service.Model
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PId { get; set; }
        public string? Name { get; set; }
        public bool? Epilepcy { get; set; }
        [ForeignKey("DId")]
        public int? DId {  get; set; } 
        public  ICollection<NCD_Details> NCDDetails { get; set; } = default!;
        public  ICollection<Allergies_Details> AllergiesDetails { get; set; } = default!;
    }
}
