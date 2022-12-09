using System;
using System.Collections.Generic;
using System.Text;

namespace CursoPAV.ClassesEMetodos
{
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };
    

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }

    class ExemploEnum
    {
        public static void Executar()
        {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Procurando Nemo";
            filmeParaFamilia.GeneroDoFilme = Genero.Animacao;

            Console.WriteLine("{0} é {1}", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);

        }
    }
}
