using System;
using System.Collections.Generic;
using System.Text;

namespace CursoPAV.ClassesEMetodos
{
    class Pessoa
    {
        //Atributos
        public string Nome;
        public int Idade;


        //Métodos
        //método retorna string e não recebe nada
        public string Apresentar()
        {
            return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos.");
        } 

        //método que não retorna nada
        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }

        public void Zerar()
        {
            Nome = "";
            Idade = 0;
        }
    }
}
