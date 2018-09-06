using System;

namespace Beginner
{
    public static class WageWithBonus
    {
        public static void Init()
        {
            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine());
            double totalvendas = double.Parse(Console.ReadLine());

            double total = salario + (totalvendas * 0.15f);
            Console.WriteLine("TOTAL = " + "R$ " + string.Format("{0:0.00}", total));
        }
    }
}