using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Produto
    {
        public static Random random = new Random();
        public static string Codigo;
        public string Descricao;
        public string Unidade;
        public int Preco;
        public float SaldoEstoque;

        public Produto(string codigo, string descricao, string unidade, int preco, float saldoEstoque)
        {
            Codigo = codigo;
            Descricao = descricao;
            Unidade = unidade;
            Preco = preco;
            SaldoEstoque = saldoEstoque;
        }

        public Produto()
        {
            Console.WriteLine("aaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Codigo = GenerateCodigo(8);
            Descricao = $"Produto {random.Next(1, 10000)}";
            Unidade = PickUnidade();
            SaldoEstoque = (float)Math.Round(random.NextDouble() * 1000.0, 2); // estoque entre 0 e 1000
            Preco = random.Next(1, 10000); // preço entre 0.00 e 500.00
        }

        private static string GenerateCodigo(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var sb = new StringBuilder(length);
            for (int i = 0; i < length; i++)
                sb.Append(chars[random.Next(chars.Length)]);
            return sb.ToString();
        }

        private static string PickUnidade()
        {
            string[] unidades = { "un", "kg", "l", "cx", "m", "pc" };
            return unidades[random.Next(unidades.Length)];
        }
    }
}
