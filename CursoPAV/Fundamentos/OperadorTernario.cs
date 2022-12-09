using System;
using System.Collections.Generic;
using System.Text;

namespace CursoPAV.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 5.0;
            bool bomComportamento = true;
            //string resultado = nota >= 6.0 ? "Aprovado" : "Reprovado";
            string resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
