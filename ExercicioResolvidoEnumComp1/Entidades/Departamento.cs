using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioResolvidoEnumComp1.Entidades
{
    class Departamento
    {
        public string Nome { get; set; }

        public Departamento()
        {
        }

        //contrutor para receber parâmetro de entrada
        public Departamento(string nome)
        {
            Nome = nome;
        }

    }
}
