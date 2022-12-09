using System;
using System.Collections.Generic;
using System.Text;

namespace CursoPAV.ClassesEMetodos
{
    public struct SPonto
    {
        public int X;
        public int Y;
    }

    public class CPonto
    {
        public int X;
        public int Y;
    }


    class StructVsClasse
    {
        public static void Executar()
        {
            SPonto sPonto1 = new SPonto { X = 1, Y = 3 };
            SPonto sCopiaPonto1 = sPonto1; // Atribuição por valor
            sPonto1.X = 3;


            Console.WriteLine("Struct - Ponto 1 X: {0}", sPonto1.X);
            Console.WriteLine("Struct - Cópia Ponto 1 X: {0}", sCopiaPonto1.X);

            CPonto cPonto2 = new CPonto { X = 2, Y = 4 };
            CPonto cCopiaPonto2 = cPonto2; // Atribuição por referência
            cPonto2.X = 5;


            Console.WriteLine("Classe - Ponto 2 X: {0}", cPonto2.X);
            Console.WriteLine("Classe - Cópia Ponto 2 X: {0}", cCopiaPonto2.X);


        }
    }
}
