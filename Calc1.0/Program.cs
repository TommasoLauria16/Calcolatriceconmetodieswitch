using System;
using  funzioni_matematiche_calc;


namespace Calc1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = operazioniMatematiche.Numero();
            double n2 = operazioniMatematiche.Numero();
            double? risultato = operazioniMatematiche.Operazioni(n1, n2);
            Console.WriteLine($"{risultato}");
        }
    }
}
