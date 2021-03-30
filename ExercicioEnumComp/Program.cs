using System;
using System.Globalization;
using ExercicioEnumComp.Entities;
using ExercicioEnumComp.Entities.Enums;


namespace ExercicioEnumComp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter order data: ");
            DateTime data = DateTime.Now;
            Console.WriteLine("Status: ");
            PedidoStatus pedStatus = Enum.Parse <PedidoStatus> (Console.ReadLine());

            Cliente cliente = new Cliente(nome, email, dataNascimento);
        






        }
    }
}
