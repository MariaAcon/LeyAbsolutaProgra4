using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeyAbsolutaWeb.Models
{
    public class MaterialJudicial
    {
        [Key]
        public int id_MaterialJudicial { get; set; }
        [Required]
        [MaxLength(50)]

        [Display(Name = "Tipo Material")]
        public string Tipo_Material { get; set; }

        [Required]
        [Display(Name = "Encargado")]
        public string Encargado { get; set; }

        [Required]
        [MaxLength(50)]
        public int cantidad_Expediente { get; set; }

        
    

    }
    
}
