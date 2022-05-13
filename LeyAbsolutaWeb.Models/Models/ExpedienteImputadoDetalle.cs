using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeyAbsolutaWeb.Models
{
    public class ExpedienteImputadoDetalle
    {
        [Key]
        public int id_Expediente_Imputado_Detalle { get; set; }
        [Required]
        [MaxLength(50)]

        public int id_Resolucion { get; set; }
        [Required]
        [MaxLength(50)]

        [Display(Name = "Tipo Materia")]
        public string tipo_Materia { get; set; }
        [Required]

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [Required]

        //Llaves foranea
        public int Id_ExpedienteImputado { get; set; }
        [ForeignKey("IdExpedienteImputado")]
        public ExpedienteImputado ExpedienteImputado { get; set; }
    }
}
