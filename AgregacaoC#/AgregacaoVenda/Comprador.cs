using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Comprador
    {
        public double Verba { get; set; }

        public Comprador()
        {

        }
        public Comprador(double verbaInicial)
        {
            Verba = verbaInicial;
        }

        public void Comprar(double valorDaCompra)
        {
            if (Verba >= valorDaCompra)
            {
                Verba -= valorDaCompra;
            }
            else{
                Console.WriteLine("Verba insuficiente.");
            }
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"A verba atual do comprador é igual a: {Verba:C}");
        }
    }
}