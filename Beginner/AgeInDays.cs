using System;

namespace Beginner
{
    public static class AgeInDays
    {
        public static void Init()
        {
            int idadeEmDias = int.Parse(Console.ReadLine());
            int anos = idadeEmDias / 365;
            int meses = (idadeEmDias - (anos * 365)) / 30;
            int dias = (idadeEmDias - (anos * 365)) - (meses * 30);

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}