using System;
using System.Collections.Generic;
using System.Text;

namespace CursoPAV.EstruturaDeControle
{
    class EstruturaIfElse
    {
        public static void Executar()
        {
            double nota = 7.0;

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado");
                Console.WriteLine("Parabéns!");
            } else
            {
                Console.WriteLine("Recuperação");
            }

        }
    }
}
