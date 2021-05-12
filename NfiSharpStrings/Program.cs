using System;

namespace NfiSharpStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string text = "All Kind OF LeTTeRs";
                Console.WriteLine(text.ToLower());

                string meddelande = Console.ReadLine();



                if (meddelande.Length > 10)
                {
                    Console.WriteLine("Max 9 tecken");
                }

                if (meddelande.Contains("dum"))
                {
                    meddelande = meddelande.Replace("dum", "***");
                }


                Console.WriteLine($"Chatten: {meddelande}");
            }

            

            //string namn = "stefan *** hej hej";




            //if(namn.Equals())







            Console.WriteLine("Hello World!");
        }
    }
}
