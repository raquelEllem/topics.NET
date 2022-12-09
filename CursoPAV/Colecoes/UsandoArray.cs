using System;
using System.Collections.Generic;
using System.Text;

namespace CursoPAV.Colecoes
{
    class UsandoArray
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Anna";
            alunos[1] = "Bia";
            alunos[2] = "Luis";
            alunos[3] = "Carlos";
            alunos[4] = "Luiza";
            


            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }



            double somatorio = 0;
            double[] notas = { 9.2, 4.5, 3, 8, 7 };
            
            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            //for (int i = 0; i < notas.Length; i++)
            //{
            //    somatorio += notas[i];
            //}

            double media = somatorio / notas.Length;
            Console.WriteLine(media);


            char[] letras = { 'a', 'R', 'c', 'f' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);

            


        }
    }
}
