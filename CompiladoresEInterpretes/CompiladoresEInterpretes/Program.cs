using CompiladoresEInterpretes.Domain;
using CompiladoresEInterpretes.DTO;
using System;

namespace CompiladoresEInterpretes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ingrese SI para iniciar proceso");
            string conditional = Console.ReadLine();

            while (conditional.ToUpper() == "SI")
            {

                Console.WriteLine("Ingrese su nombre: ");
                string name = Console.ReadLine();
                if (!new Validator().IsStringValid(name))
                {
                    Console.WriteLine("Nombre invalido.");
                }

                ResultDTO resul = new Process().Calculator(name);

                Console.WriteLine($"Su nombre mas nuestro apellido default al revés es: {resul.NameBackwards}");
                Console.WriteLine($"********************************************************************************");
                Console.WriteLine($"El porcentage nuestro para su nombre es: {resul.PercentName}");
                Console.WriteLine($"********************************************************************************");

                Console.WriteLine("Ingrese SI para iniciar proceso");
                conditional = Console.ReadLine();
            }
            Console.WriteLine($"CHAO");
            Console.WriteLine($"********************************************************************************");
        }

    }
}
