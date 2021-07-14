using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace felipe_santos_volvoapp.Models.DataTransferObjects
{
    public class CaminhaoDTO
    {
        public string Id { get; set; }
        public string Modelo { get; set; }
        public DateTime AnoFabricacao { get; set; }
        public DateTime AnoModelo { get; set; }
    }
}
