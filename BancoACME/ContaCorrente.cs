using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoACME
{
    class ContaCorrente
    {
        private float numeroID;
        private float saldoAtual;
        private String nome;

        public ContaCorrente(float numeroID, float saldoAtual, string nome)
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
