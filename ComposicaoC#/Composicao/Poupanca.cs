using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Composicao
{
    public class Poupanca
    {
        public double Saldo { get; set; }

        public double Depositar(double valor)
        {
            return valor += Saldo;
        }

        public void Sacar(double valor)
        {
            if (valor >= Saldo){
                Saldo -= valor;
            }
            else{
                Console.WriteLine("Saldo indisponível!");
            }
        }

        public void GerarRendimento()
        {
            Saldo += 50.00;
        }
    }
}