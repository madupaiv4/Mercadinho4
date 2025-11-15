using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando produtos
            Produto produto1 = new Produto("001", "Produto A", "UN", 10, 50);
            Produto produto2 = new Produto("002", "Produto B", "KG", 20, 30);

            // Criando itens do cupom
            var item1 = new Cupom.ItemCupom(1, produto1, 2); // 2 unidades do Produto A
            var item2 = new Cupom.ItemCupom(2, produto2, 3); // 3 unidades do Produto B

            // Adicionando itens ao cupom
            var itensCupom = new List<Cupom.ItemCupom> { item1, item2 };

            // Criando um cupom
            var cupom = new Cupom(1, DateTime.Now, "Cliente 1", itensCupom);

            // Exibindo informações do cupom
            Console.WriteLine($"Número do Cupom: {cupom.PCupom}");
            Console.WriteLine($"Data de Emissão: {cupom.Emissao}");
            Console.WriteLine($"Cliente: {cupom.Cliente}");
            Console.WriteLine("Itens do Cupom:");

            foreach (var item in cupom.ItensCupom)
            {
                Console.WriteLine($"- Produto: {item.item.Descricao}, Quantidade: {item.quantidade}, Valor Total: {item.CalcularValorItem()}");
            }

            Console.ReadKey();
        }
    }
}

