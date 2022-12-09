using System;
using System.Collections.Generic;
using System.Text;

namespace CursoPAV.ClassesEMetodos
{
    public class CarroOpcinal
    {
        private double desconto = 0.1;

        string nome;
        public string Nome
        {
            get
            {
                return "Opcional: " + nome;
            }
            set
            {
                nome = value;
            }
        }

        //Propriedade autoimplementada
        public double Preco { get; set; }

        //Somente leitura
        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco); //lambda

            //get
            //{
            //    return Preco - (desconto * Preco);
            //}
        }

        public CarroOpcinal()
        {

        }

        public CarroOpcinal(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

    }

    class Props
    {
        public static void Executar()
        {
            var op1 = new CarroOpcinal("Ar condicionado", 3499.9);
            Console.WriteLine(op1.PrecoComDesconto);

            //op1.PrecoComDesconto = 3000; //não pode, pois é somente leitura

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);


            var op2 = new CarroOpcinal();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2340.0;
                       
            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);








        }
    }
}
