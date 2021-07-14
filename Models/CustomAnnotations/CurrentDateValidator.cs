using System;
using System.ComponentModel.DataAnnotations;

namespace felipe_santos_volvoapp.Models.CustomAnnotations
{
    public class CurrentDateValidator : ValidationAttribute
    {
        public CurrentDateValidator()
        {
        }

        public override bool IsValid(object value)
        {
            var dataSelecionada = (int)value;
            var anoAtual = DateTime.Now.Year;

            if (dataSelecionada == anoAtual)
            {
                return true;
            }
            return false;
        }
    }
}