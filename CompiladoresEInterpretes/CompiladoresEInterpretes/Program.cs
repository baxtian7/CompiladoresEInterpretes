using CompiladoresEInterpretes.Domain;
using System;

namespace CompiladoresEInterpretes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre: ");
            string name = Console.ReadLine();
            if(! new Validator().IsStringValid(name))
            {
                Console.WriteLine("Nombre invalido.");
            }
        }
    }
}
