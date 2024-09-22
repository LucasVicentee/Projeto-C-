using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Vendedor
    {
        public double Comissao { get; set; }
        public Vendedor()
        {
            
        }
        public double CalcularComissao(double valorVenda)
        {
            Comissao = valorVenda * (2.0 / 100);
            return Comissao;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Comissão do Vendedor: {Comissao:C}");
        }
    }
}