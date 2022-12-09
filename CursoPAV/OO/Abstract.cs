using System;
using System.Collections.Generic;
using System.Text;

namespace CursoPAV.OO
{
    public abstract class Celular
    {
        public abstract string Assistente();

        public string Tocar()
        {
            return "trim trim trim....";
        }
    }

    public class Sansung : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Bixby!";
        }
    }

    public class Iphone : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Siri!";
        }
    }

    class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular>
            {
                new Iphone(),
                new Sansung()
            };

            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }

        }
    }
}
