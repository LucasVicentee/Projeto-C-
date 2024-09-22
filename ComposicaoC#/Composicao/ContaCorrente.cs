using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Composicao
{
    public class ContaCorrente
    {
        private double Saldo { get; set; }
        private double ChequeEspecial { get; set; }

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

        public void GerarExtrato()
        {
            Console.WriteLine($"Extrato: {Saldo:C} \nCheque especial: {ChequeEspecial:C}");
        }
    }
}