using System;
using System.Collections.Generic;
using System.Text;

namespace CursoPAV.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            //Preço desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - total * desconto;
            Console.WriteLine("O preço final é {0}", totalComDesconto);

            //IMC
            double peso = 50;
            double altura = 1.56;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC é {imc}");

            //Número par/ímpar
            int par = 22;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);

        }

    }
}

