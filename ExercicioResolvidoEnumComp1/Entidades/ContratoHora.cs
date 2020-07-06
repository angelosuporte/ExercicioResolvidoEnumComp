using System;

namespace ExercicioResolvidoEnumComp1.Entidades
{
    class ContratoHora
    {
        public DateTime Data { get; set; }
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public ContratoHora()
        {
        }

        public ContratoHora(DateTime data, double valorPorHora, int horas)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }

        public double ValorTotal()
        {
            return Horas * ValorPorHora;
        }

    }
}
