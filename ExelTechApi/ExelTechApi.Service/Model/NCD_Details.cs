using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExelTechApi.Service.Model
{
    public class NCD_Details
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("PatientId")]
        public int PatientId { get; set; }
        [ForeignKey("NCDId")]
        public int NCDId { get; set; }
        public virtual Patient? Patient { get; set; }
    }
}
