using System;

namespace funzioni_matematiche_calc
{
    public class operazioniMatematiche
    {
        public static double Numero()
        {
            Console.Write("inserisci un numero: ");
            double n = double.Parse(Console.ReadLine());
            return n;
        }
        
        public static double? Operazioni(double n1, double n2)
        {
            
            double? risultato = null;
            Console.WriteLine("1=somma, 2=differenza, 3=moltiplicazione, 4=divisione");
            Console.WriteLine("seleziona l'operazione ");
            string str = Console.ReadLine();
            switch (str)
            {
                case "1":
                case "somma":
                    risultato = n1 + n2;
                    break;
                case "2":
                case "differenza":
                    risultato = n1 - n2;
                    break;
                case "3":
                case "moltiplicazione":
                    risultato = n1 * n2;
                    break;
                case "4":
                case "divisione":
                    risultato = n1 / n2;
                    break;
                default:
                    Console.WriteLine("errore non hai scelto nessuna operazione!");
                    break;
            }
            return risultato;
        }
    }
}
