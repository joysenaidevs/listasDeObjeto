using System;
using System.Collections.Generic;
using listasDeObjeto.classe;

namespace listasDeObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            Produto cafe = new Produto(2, "Café pequeno", 3.5f);

            produtos.Add(new Produto(1, "Pão na chapa", 2.5f));
            produtos.Add(cafe);
            produtos.Add(new Produto(3, "coxinha", 5.5f));
            produtos.Add(new Produto(4, "risole", 5.5f));
            produtos.Add(new Produto(5, "batata", 5.5f));

            //remove da lista
            produtos.RemoveAll(x => x.Name == "coxinha");

            Console.WriteLine(produtos[0].Codigo);
            
            //mostrando os produtos com foreach
            foreach (Produto item in produtos)
            {
                Console.WriteLine($"Item Codigo {item.Codigo}, Nome {item.Name}, Preco {item.Preco}");
            }
        }
    }
}
