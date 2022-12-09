using System;
using System.Collections.Generic;
using System.Text;

namespace CursoPAV.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa fulano = new Pessoa();
            fulano.Nome = "Raquel";
            fulano.Idade = 25;

            Console.WriteLine($"{fulano.Nome} tem {fulano.Idade} anos.");

            fulano.ApresentarNoConsole();
            fulano.Zerar();

            fulano.ApresentarNoConsole();

            var sicrano = new Pessoa();
            sicrano.Nome = "Giovanna";
            sicrano.Idade = 1;

            var apresentacaoDoSicrano = sicrano.Apresentar();
            Console.WriteLine(apresentacaoDoSicrano.Length);
            Console.WriteLine(apresentacaoDoSicrano);

        }
    }
}
