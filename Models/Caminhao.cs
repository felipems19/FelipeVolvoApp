using felipe_santos_volvoapp.Models.CustomAnnotations;
using felipe_santos_volvoapp.Models.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace felipe_santos_volvoapp.Models
{
    public enum modeloOpcoes
    {
        FH,
        FM
    }

    public class Caminhao
    {
        [Key]
        public int? Id { get; set; }
        
        [Required]
        [RegularExpression("FH|FM", ErrorMessage = "Apenas modelos FH e FM são permitidos")]
        public string Modelo { get; set; }
        
        [Required]
        [Display(Name = "Ano de fabricação")]
        [CurrentDateValidator(ErrorMessage = "O ano de fabricação deverá ser o atual")]
        public int AnoFabricacao { get; set; }
        
        [Required]
        [Display(Name = "Ano do modelo")]
        [DateRangeValidator(ErrorMessage = "O ano do modelo deverá ser o atual ou o anterior")]
        public int AnoModelo { get; set; }

    }
}
