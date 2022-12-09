using System;
using System.Collections.Generic;
using System.Text;

namespace CursoPAV.OO
{
    sealed class SemFilho
    {
        public double ValorDaFortuna()
        {
            return 7_402_088.25;
        }
    }

    //não é possível!
    //class SouFilho : SemFilho
    //{

    //}

    class Avo
    {
        public virtual bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class Pai : Avo
    {
        public sealed override bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class FilhoRebelde : Pai
    {
        //public override bool HonrarNomeFamilia()
        //{
        //    return false;
        //}
    }
    class Sealed
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());

        }
    }
}
