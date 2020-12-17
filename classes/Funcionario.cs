using System;

namespace Aulas_POO_SobrecargaDeMetodo.classes
{
    public class Funcionario
    {
        public string[] lista = {"Paulo", "Tsuka", "Priscila", "Fernanda"};
        
        public void Mostrar(){
            foreach (var item in lista)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(item);
                Console.ResetColor();
            }
        }


        public void Mostrar(int indice){
            Console.ForegroundColor = ConsoleColor.Blue;
            if (indice < lista.Length)
            {
                Console.WriteLine(lista[indice]);
            }
            Console.ResetColor();
        }


        public void Mostrar(string busca){
            foreach (var item in lista)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (item == busca)
                {
                    Console.WriteLine("Item encontrado : "+item);
                }else
                {
                    Console.WriteLine("Item não encontrado");
                }
                Console.ResetColor();
            }    
        }
    }
}