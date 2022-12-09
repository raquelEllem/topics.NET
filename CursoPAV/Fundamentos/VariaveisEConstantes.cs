using System;

namespace CursoPAV.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 3.4;
            //PI = 3.1415; //- não pode ser modificado -- const

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é: " + area);

            //tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo: " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade: " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário: " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor valor int: " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População brasileira: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long: " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial: " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do computador: " + precoComputador);

            double valorMercadoApple = 1_000_000_000_000;
            Console.WriteLine("Valor de mercado da Apple: " + valorMercadoApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre estrelas: " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra: " + letra);

            string texto = "Seja bem vindo ao curso de C#!";
            Console.WriteLine(texto);

        }

    }
}
