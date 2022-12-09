using System;
using System.Collections.Generic;
using System.Text;

namespace CursoPAV.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
    class ColecoesList
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("Poster", 10),
                new Produto("Caneta", 3.5),
            };

            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);

            carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

                      
        }
    }
}
