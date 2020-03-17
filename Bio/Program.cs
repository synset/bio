using System;
using System.Collections.Generic;

namespace Bio
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //Testa ändringar
            // Huvudmeny för köp av biobiljetter
            //

            Console.WriteLine(
            "Biljettbokning\n" +
            "Huvudmeny\n" +
            "1.Köpa en biljett till ungdom eller pensionär, tryck 1\n" +
            "2.Köpa flera biljetter, tryck 2\n" +
            "3.Har du en åsikt om våran bio?, tryck 3\n" +
            "4.Upprepa 10 ggr, tryck 4");

            string menyVal = Console.ReadLine();

            switch (menyVal)
            {
                //case 0:

                //
                // Användaren uppger ålder
                // Under 20år, ungdomspris 80kr
                // Över 64år, pensionärspris 90kr
                // Alla andra, standardpris 120kr
                //

                case "1":
                    Console.WriteLine("Hur många år är du? : ");

                    string sAge = Console.ReadLine();//???lättare sätt att skriva detta
                    int iAge = Convert.ToInt32(sAge);

                    if (iAge < 20)
                        Console.WriteLine("Ungdomspris: 80 kr");
                    else if (iAge > 65)
                        Console.WriteLine("Pensionärspris: 90 kr");
                    else
                        Console.WriteLine("Standardpris: 120 kr");

                    break;

                //
                // Användaren uppger antalet biljetter
                // och ålder på varje besökande
                // Antalet biljetter och totala summan skrivs ut
                //

                case "2":
                    Console.WriteLine("Hur många biljetter vill du köpa? : ");

                    string sNumber = Console.ReadLine();            //???lättare sätt att skriva detta
                    int iNumber = Convert.ToInt32(sNumber);         //
                    int sum = 0;

                    for (int i = 1; i < iNumber + 1; i++)
                    {
                        Console.WriteLine("Hur många år är besökare " + i + " ?");

                        string sAge2 = Console.ReadLine();
                        int iAge2 = Convert.ToInt32(sAge2);

                        if (iAge2 < 20)
                            sum = sum + 80;
                        else if (iAge2 > 65)
                            sum = sum + 90;
                        else
                            sum = sum + 120;
                    }

                    Console.WriteLine(
                        "Antal personer: " + iNumber + " \n" +
                        "Totalt att betala: " + sum);

                    break;

                // 
                // Användaren matar in en mening
                // 3:e ordet i meningen skrivs ut
                // 

                case "3":
                    Console.WriteLine(
                        "Vad tycker du om våran bio? \n " +
                        "(Minimum 3 ord) : \n");

                    string opinion = Console.ReadLine();
                    string space = " ";
                    string[] words = opinion.Split(space, StringSplitOptions.RemoveEmptyEntries);

                    Console.WriteLine(words[2]);

                    break;

                // 
                // Användaren matar in en mening
                // Meningen skrivs ut 10 ggr på samma rad
                //

                case "4":
                    Console.WriteLine("Skriv en mening:");
                    var sentence = Console.ReadLine();

                    for (int i = 1; i < 11; i++)
                        Console.Write(i + ". " + sentence + " ");

                    break;

                //
                // default
                // vid felaktig input
                //

                default:
                    Console.WriteLine(
                        "Ogiltigt val\n" +
                        "Välj ett alternativ från huvudmenyn\n" +
                        "1.Köpa en biljett till ungdom eller pensionär, tryck 1\n" +
                        "2.Köpa flera biljetter, tryck 2\n" +
                        "3.Skriv en mening med minst 3 ord: ");
                    break;
            }


        }
    }
}
