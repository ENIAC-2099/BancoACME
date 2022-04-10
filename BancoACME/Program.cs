using System;

namespace BancoACME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario usuarioTeste = new Usuario("Bob", "Nelson");

            Console.WriteLine(usuarioTeste.InformarNome());
        }
    }
}
