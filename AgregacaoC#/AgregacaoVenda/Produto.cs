using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        private static int CodigoInicialProduto;
        private string nome;
        private double preco;
        private int codigo;
        public Vendedor Vendedor { get; set; }

        static Produto()
        {
            CodigoInicialProduto = 500;
        }
        public Produto(int codigo, string nome, double preco)
        {   
            Codigo = CodigoInicialProduto++;
            Nome = nome;
            Preco = preco;
        }


        public string Nome
        {
            get { return nome; }
            set { 
                if (Nome != ""){
                    nome = value;
                }
                else{
                    Console.WriteLine("O nome do produto não pode ser nulo!");
                }
                }
        }
        public double Preco
        {
            get { return preco; }
            set { 
                if (Preco != null){
                    preco = value; 
                }
                else{
                    Console.WriteLine("O peço do produto não pode ser nulo!");
                }
                }
        }
        public int Codigo
        {
            get { return codigo; }
            set { 
                if (Codigo != null){
                    codigo = value; 
                }
                else{
                    Console.WriteLine("Valor do código não pode ser nulo!");
                }
                }
        }
        
        public void MostrarAtributos()
        {
            Console.WriteLine($"Código do produto: {Codigo} \nNome do produto: {Nome} \nPreço do produto: {Preco:C} \n");
        }
    }
}