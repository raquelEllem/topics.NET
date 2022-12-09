using System;
using System.Collections.Generic;
using System.Text;

namespace CursoPAV.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2008, "O Grande Truque");

            if (filmes.ContainsKey(2004))
            {
                Console.WriteLine("2004: " + filmes[2004]);
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004));
            }

            Console.WriteLine(filmes.ContainsValue("\nAmnésia"));

            Console.WriteLine($"\nRemoveu? {filmes.Remove(2004)}");

            filmes.TryGetValue(2016, out string filme2006);
            Console.WriteLine($"\nFilme {filme2006}");

            //percorrer dicionario

            foreach (var chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }

            foreach (var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }

            foreach (KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine($"\n {filme.Value} é de {filme.Key}");
            }

            foreach (var filme in filmes)
            {
                Console.WriteLine($"\n {filme.Value} é de {filme.Key}");
            }

      
        }

    }
}
