using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeyAbsolutaWeb.Models
{
    public class ExpedienteImputado
    {
        [Key]
        public int id_Expediente_Imputado { get; set; }
        [Required]
        [MaxLength(50)]

        [Display(Name = "Fecha: ")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:MM-dd-yyyy HH:mm}")]
        public DateTime FechaExpedienteImputado { get; set; }

        [Display(Name = "NombreImputado")]
        public string NombreImputado { get; set; }
        [Required]


        //Llaves foranea
        public int Id_MaterialJudicial { get; set; }
        [ForeignKey("IdExpediente")]
        public MaterialJudicial MaterialJudicial { get; set; }

        public int Id_Imputado { get; set; }
        [ForeignKey("IdImputado")]
        public Imputado Imputado { get; set; }
    }
}
