using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeyAbsolutaWeb.Models
{
    public class ExpedienteDetalle
    {
        [Key]
        public int id_ExpedienteDetalle { get; set; }
        [Required]
        [MaxLength(50)]

        [Display(Name = "Fecha Inicio: ")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:MM-dd-yyyy HH:mm}")]
        public DateTime Fecha_Inicio { get; set; }

        [Display(Name = "Fecha Final: ")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:MM-dd-yyyy HH:mm}")]
        public DateTime Fecha_Final { get; set; }
    
        //Llaves foranea
        public int Id_Expediente { get; set; }
        [ForeignKey("IdExpediente")]

        public Expediente Expediente { get; set; }

    
    }
}
