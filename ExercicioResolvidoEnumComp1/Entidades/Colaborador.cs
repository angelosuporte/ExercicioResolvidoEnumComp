using System.Collections.Generic;
using ExercicioResolvidoEnumComp1.Entidades.Enums;

namespace ExercicioResolvidoEnumComp1.Entidades
{
    class Colaborador
    {
        public string Nome { get; set; }
        public NivelDoColaborador Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; } //<---Associação da classe Departamento à classe Colaborador
        public List<ContratoHora> Contratos { get; set; } = new List<ContratoHora>();

        public Colaborador()
        {
        }

        //No construtor abaixo não entra Contratos porque é uma associação para muitos do tipo List
        //Via de regra não se declara uma associção para muitos no construtor
        public Colaborador(string nome, NivelDoColaborador nivel, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddContrato(ContratoHora contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoveContrato(ContratoHora contrato)
        {
            Contratos.Remove(contrato);
        }

        public double Ganho(int ano, int mes)
        {
            double soma = SalarioBase;
            foreach (ContratoHora contrato in Contratos)
            {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    soma += contrato.ValorTotal();
                }
            }
            return soma;
        }

    }
}
