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

            Console.Write("Status: ");
            PedidoStatus pedStatus = Enum.Parse<PedidoStatus>(Console.ReadLine());
            Cliente cliente = new Cliente(nome, email, dataNascimento);
            Pedido pedido = new Pedido(data, pedStatus, cliente);

            Console.Write("How many items to this order?  ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"$Enter #{i} item data: ");
                Console.Write("Product name: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Product price: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantidade = int.Parse(Console.ReadLine());

                Produto produto = new Produto(nomeProduto, preco);
                ItemPedido itemPedido = new ItemPedido(quantidade, preco, produto);
                
                pedido.AddItem(itemPedido);

            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(pedido);
            
        }
    }
}
