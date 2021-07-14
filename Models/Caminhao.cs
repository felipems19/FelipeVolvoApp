using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace felipe_santos_volvoapp.Models
{
    public enum tiposModelo
    {
        FH,
        FM
    }
    public class Caminhao
    {
        [Key]
        public string Id { get; set; }
        
        [Required]
        public tiposModelo Modelo { get; set; }
        
        [Required]
        public DateTime AnoFabricacao { get; set; }
        
        [Required]
        public DateTime AnoModelo { get; set; }
    }
}
