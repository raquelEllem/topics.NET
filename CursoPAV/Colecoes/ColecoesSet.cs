using System;
using System.Collections.Generic;
using System.Text;

namespace CursoPAV.Colecoes {

    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("Poster", 10),
                new Produto("Caneta", 3.5),
            };

            //carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);

            //carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                //sConsole.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

                      
        }
    }
}
