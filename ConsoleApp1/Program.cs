using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            int idade;
            double salario;
            string nome;

            idade = 19;
            salario = 1200;
            nome = "Maria Eduarda";

            //Comentários no Código
            /* Para cógigo inteiro, sem precisar ir de linha em linha
            if (idade > 18)
            {
                Console.WriteLine("Entra na festa");      
            }
            else
            {
                Console.WriteLine("Não entra na festa");
            }
            */


            string valorLido;

            Console.WriteLine("Informar seu nome");

            valorLido = Console.ReadLine();

            Console.WriteLine("Nome Lido:");
        }
    }
}
