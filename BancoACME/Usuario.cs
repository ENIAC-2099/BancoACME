using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoACME
{
    internal class Usuario
    {
        public string primeiroNome;
        public string sobreNome;
        public Usuario(string primeiroNome, string sobreNome)
        {
            this.primeiroNome = primeiroNome;
            this.sobreNome = sobreNome;
        }

        public string PrimeiroNome
        {
            get 
            {
                return primeiroNome;
            }
        }
        public string SobreNome 
        {
            get 
            {
                return sobreNome;
            }
        }

        public string InformarNome()
        {
            return $"{PrimeiroNome} {SobreNome}";
        }
    }
}
