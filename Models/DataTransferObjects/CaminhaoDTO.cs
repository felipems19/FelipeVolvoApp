using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace felipe_santos_volvoapp.Models.DataTransferObjects
{
    public class CaminhaoDTO
    {
        public int? Id { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
    }
}
