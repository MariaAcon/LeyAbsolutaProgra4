using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeyAbsolutaWeb.Models
{
    public class Expediente
    {
        [Key]
        public int id_Expediente { get; set; }
        [Required]
        [MaxLength(50)]

        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }
        [Required]

        public int num_Expediente { get; set; }
        [Required]
        [MaxLength(50)]

        [Display(Name = "JuezEncargado")]
        public string juez_Encargado { get; set; }
        [Required]

        [Display(Name = "AbogadoDefensor")]
        public string Abogado_Defensor { get; set; }
        [Required]


        //Llaves foranea
        public int Id_Imputado { get; set; }
        [ForeignKey("ImputadoId")] 

        public Imputado Imputado { get; set; }

        public int Id_MaterialJudicial { get; set; }
        [ForeignKey("IdMaterialJudicial")]

        public MaterialJudicial MaterialJudicial { get; set; }
    }

  }
