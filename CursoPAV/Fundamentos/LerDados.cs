using System;
using System.Collections.Generic;
using System.Text;
//using System.Globalization;

namespace CursoPAV.Fundamentos
{
    class LerDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o seu salario? ");
            double salario = double.Parse(Console.ReadLine());
            //double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine($"{nome} {idade} R${salario}");


        }
    }
}
