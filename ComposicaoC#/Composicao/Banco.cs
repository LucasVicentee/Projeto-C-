using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Composicao
{
    public class Banco
    {
        public List<Poupanca> poups { get; set; }
        public List<ContaCorrente> contas { get; set; }

        public void IniciarBanco()
        {
            Banco b = new Banco();
        }

        public void AbrirConta()
        {
            ContaCorrente c = new ContaCorrente();
        }

        public void AbrirPoupanca()
        {
            Poupanca p = new Poupanca();
        }

        ~Banco()
        {

        }
    }
}