using System;

namespace Cauculadora_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p0 = new Produto();
            p0.Codigo = 0;
            p0.Nome = "Havaianas";
            p0.Preco = 55f;

            p0.Cadastrar(p0);
        }
    }
}
