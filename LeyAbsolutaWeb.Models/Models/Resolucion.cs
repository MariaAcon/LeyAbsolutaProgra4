using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeyAbsolutaWeb.Models
{
    public class Resolucion
    {
        [Key]
        public int id_Resolucion { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Descripcion Resolucion")]
        public string Descripcion_Resolucion { get; set; }

        //Llave Foranea
        public int Id_Expediente_Imputado_Detalle { get; set; }
        [ForeignKey("Id_Expediente_Imputado_Detalle")]

        public ExpedienteImputadoDetalle ExpedienteImputadoDetalle { get; set; }

        public int Id_Expediente_Detalle { get; set; }
        [ForeignKey("Id_Expediente_Imputado")]

        public ExpedienteDetalle ExpedienteDetalle { get; set; }



    }
}
