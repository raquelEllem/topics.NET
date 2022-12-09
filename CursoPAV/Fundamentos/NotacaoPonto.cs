using System;
using System.Collections.Generic;
using System.Text;

namespace CursoPAV.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " world!").Replace("world!", "mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine(saudacao.Length);

            string valorImportante = null;
            //Console.WriteLine(valorImportante.Length);
            Console.WriteLine(valorImportante?.Length);

            
        }

    }
}
