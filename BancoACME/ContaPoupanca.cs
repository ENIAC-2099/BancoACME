using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoACME
{
    internal class ContaPoupanca:Usuario
    {
        private float numeroID;
        private float saldoAtual;
        private String nome;

        public ContaPoupanca(float numeroID, float saldoAtual, string nome): base (primeiroNome, sobreNome)
        {
            this.numeroID = numeroID;
            this.saldoAtual = saldoAtual;
            this.nome = nome;
        }

        public float NumeroID 
        {
            get
            {
                return numeroID;
            }
        }
        public float SaldoAtual 
        {
            get 
            {
                return saldoAtual;
            }
        }
        public string Nome 
        {
            get
            {
                return nome;
            }        
        }
    }
}
