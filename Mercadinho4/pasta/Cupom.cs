using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Cupom
    {
        static int Numero;
        public DateTime Emissao;
        public string Cliente;
        public List<ItemCupom> ItensCupom { get; set; } = new List<ItemCupom>();
        public int PCupom;

      


        public Cupom(DateTime emissao, string cliente, List<ItemCupom> itensCupom, int pCupom)
        {
            Emissao = emissao;
            Cliente = cliente;
            ItensCupom = itensCupom;
            PCupom = pCupom;
        }
        public Cupom(int numero, DateTime emissao, string cliente, List<ItemCupom> itensCupom)
        {

            Numero = numero; // numero cupom
            Emissao = DateTime.Now;
            Console.WriteLine(Emissao);
            Console.WriteLine("Digite seu CPF:");
            Cliente = Console.ReadLine();
            ItensCupom = itensCupom;
            PCupom = ObterProxCupom(Numero);

        }

        private int ObterProxCupom(in int numero)
        {
            PCupom = numero + 1;
            return PCupom;
        }

        public Cupom(int numero, DateTime emissao, string cliente, int pcupom)
        {
            Numero = numero;
            Emissao = emissao;
            Cliente = cliente.ToUpper();
            PCupom = pcupom;
        }

        public Cupom()
        {
        }

      
        public int CalcularValorTotal(ItemCupom itemCupom)
        {
            int x = itemCupom.CalcularValorItem();
            return x;
        }


      

        public class ItemCupom
        {
            public int Numero;
            public Produto item;
            public int quantidade;



            public ItemCupom(int numero, Produto item, int quantidade)
            {
                numero = Numero;
                this.item = item;
                item.Preco = item.Preco;
                this.quantidade = quantidade;
                }
            public int CalcularValorItem()
            {
                int x = this.quantidade * item.Preco;

                return x;
            }
        }
    }
}

