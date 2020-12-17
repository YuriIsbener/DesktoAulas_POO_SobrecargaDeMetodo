using System;
using Aulas_POO_SobrecargaDeMetodo.classes;

namespace Aulas_POO_SobrecargaDeMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario();
            fun.Mostrar();
            fun.Mostrar("Tsuka");
            fun.Mostrar(3);

            Console.WriteLine();
        }
    }
}
