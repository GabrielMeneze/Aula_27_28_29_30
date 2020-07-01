using System;
using System.Collections.Generic;

namespace Cauculadora_09
{
    class Program
    {
        Produto p1 = new Produto();
           p1.Codigo = 1;
           p1.Nome = "Gabinete gamer";
           p1.Preco = 2029.99f;

           p1.Inserir(p1);
           p1.Remover("carro");

           List<Produto> lista = p1.Ler();

       
           foreach(Produto item in lista)
           {
               System.Console.WriteLine($"R${item.Preco} - {item.Nome}");
           }
    }
}