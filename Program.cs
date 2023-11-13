﻿namespace mju23h_dtp_genrep_FAS2
{
    class Art
    {
        public string art, familj, svenska;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Art[] artlista = new Art[100];

            string[] art = new string[100];
            string[] familj = new string[100];
            string[] sv = new string[100];
            int sista = 0;
            art[sista] = "Hepatica nobilis";
            familj[sista] = "Ranunculaceae";
            sv[sista] = "Blåsippa";
            sista++;
            art[sista] = "Anemone nemorosa";
            familj[sista] = "Ranunculaceae";
            sv[sista] = "Vitsippa";
            sista++;
            art[sista] = "Taraxacum ruderalia";
            familj[sista] = "Asteraceae";
            sv[sista] = "Maskros";
            sista++;
            art[sista] = "Malus domestica";
            familj[sista] = "Rosales";
            sv[sista] = "Äppelträd";
            sista++;
            art[sista] = "Pinus sylvestris";
            familj[sista] = "Pinaceae";
            sv[sista] = "Tall";
            sista++;
            Console.WriteLine("Hej och välkommen till artdatabasen!");
            Console.WriteLine("Skriv 'hjälp' för hjälp, 'sluta' för att sluta!");
            while (true)
            {
                Console.Write("kommando: ");
                string userInput = Console.ReadLine();
                if (userInput == "sluta")
                {
                    break;
                }
                else if (userInput == "hjälp")
                {
                    Console.WriteLine("hjälp     - lista kommandona");
                    //FIXME: lägg till kommando för avsluta.
                    Console.WriteLine("lista     - lista alla arter");
                }
                else if (userInput == "lista")
                {
                    for (int i = 0; i < sista; i++)
                    {
                        Console.WriteLine($"{sv[i],-12}  {art[i],-24} fam.: {familj[i],-30}");
                    }
                }
                else if (userInput == "ny")
                {
                    Console.Write("artnamn: ");
                    string artnamn = Console.ReadLine();
                    Console.Write("familj:  ");
                    string familjenamn = Console.ReadLine();
                    Console.Write("svenska: ");
                    string svensktnamn = Console.ReadLine();
                    art[sista] = artnamn; familj[sista] = familjenamn; sv[sista] = svensktnamn;
                    sista++;
                    Console.WriteLine($"{artnamn} tillagd");
                }
                else
                {
                    Console.WriteLine($"Vaddå '{userInput}'?");
                }
            }
            Console.WriteLine("Hej då!");
        }
    }
}