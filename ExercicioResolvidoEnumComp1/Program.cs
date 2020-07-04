using System;
using System.Globalization;
using ExercicioResolvidoEnumComp1.Entidades;
using ExercicioResolvidoEnumComp1.Entidades.Enums;


namespace ExercicioResolvidoEnumComp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o departamento: ");
            string deptoNome = Console.ReadLine();
            Console.WriteLine("Informe os dados do colaborador: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nível (Junior, NívelMedio, Senior): ");
            NivelDoColaborador nivel = Enum.Parse<NivelDoColaborador>(Console.ReadLine());
            Console.Write("Salário Base: ");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamento depto = new Departamento(deptoNome);
            Colaborador colaborador = new Colaborador(nome, nivel, salarioBase, depto);

            Console.Write("Informe quantos são os contratos para este colaborador: ");
            int quantContratos = int.Parse(Console.ReadLine());

            for (int i = 0; i <= quantContratos; i++)
            {
                Console.WriteLine($"Informe #{i} dados do contrato: ");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Informe a quantidade de horas: ");
                int horas = int.Parse(Console.ReadLine());

                ContratoHora contrato = new ContratoHora(data, valorPorHora, horas);

            }

        }

    }
}
