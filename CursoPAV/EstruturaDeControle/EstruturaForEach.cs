using System;
using System.Collections.Generic;
using System.Text;

namespace CursoPAV.EstruturaDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "Opa!";

            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }
        }
    }
}
