using System;
using System.Collections.Generic;

namespace Cauculadora_09
{
    class Program
    {
         static void Main(string[] args)
        {
           
            Produto p1 = new Produto();
            p1.Codigo = 2;
            p1.Nome = "Havaianas";
            p1.Preco = 26f;

            p1.Cadastrar(p1);

            List<Produto> csv = p1.Ler();

            foreach (Produto item in csv)
            {
                Console.WriteLine($"R$ {item.Preco} - {item.Nome}");
            }
        }
    }
}