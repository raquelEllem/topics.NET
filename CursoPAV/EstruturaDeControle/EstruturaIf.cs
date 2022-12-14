using System;
namespace CursoPAV.EstruturaDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            bomComportamento = entrada.ToLower() == "s";

            if (nota >= 9.0 && bomComportamento)
                Console.WriteLine("Quadro de honra!");

            if (nota >= 6.0 && bomComportamento) {
                Console.WriteLine("Parabéns!");
            }else{
                Console.WriteLine("Recuperação");
            }
       }
    }
}
