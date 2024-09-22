using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        public Comprador Comp { get; set; }
        public Vendedor Vend { get; set; }
        public List<Produto> VetProduto { get; set; }
        public Venda(Comprador comp, Vendedor vend)
        {
            Comp = comp;
            Vend = vend;
        }

        public void RealizarVenda()
        {
            double valorVenda = 0;
            foreach (Produto p in VetProduto)
            {
                valorVenda += p.Preco;
            }

            Vend.CalcularComissao(valorVenda);
            Comp.Comprar(valorVenda);
        }

        public void MostrarAtributos()
        {
            foreach (Produto p in VetProduto)
            {
                Console.WriteLine($"Código do produto: {p.Codigo} \nNome do produto: {p.Nome} \nPreço do produto: {p.Preco:C} \n");
            }

            Comp.MostrarAtributos();
            Vend.MostrarAtributos();
        }
    }
}