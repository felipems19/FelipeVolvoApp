using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace felipe_santos_volvoapp.Models.CustomAnnotations
{
    public class DateRangeValidator : ValidationAttribute
    {
        public DateRangeValidator()
        {
        }

        public override bool IsValid(object value)
        {
            var dataSelecionada = (int)value;
            var anoAtual = DateTime.Now.Year;

            if ((dataSelecionada == anoAtual) || (dataSelecionada == anoAtual-1))
            {
                return true;
            }
            return false;
        }
    }
}

