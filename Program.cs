namespace mju23h_dtp_genrep_FAS2
{
    class Art
    {
        public string art, familj, svenska;
        public Art(string art, string familj, string svenska)
        {
            this.art = art; this.familj = familj; this.svenska = svenska;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Art[] artlista = new Art[100];
            int sista = 0;
            artlista[sista] = new Art("Hepatica nobilis", "Ranunculaceae", "Blåsippa");
            sista++;
            artlista[sista] = new Art("Anemone nemorosa", "Ranunculaceae", "Vitsippa");
            sista++;
            artlista[sista] = new Art("Taraxacum ruderalia", "Asteraceae", "Maskros");
            sista++;
            artlista[sista] = new Art("Malus domestica", "Rosales", "Äppelträd");
            sista++;
            artlista[sista] = new Art("Pinus sylvestris", "Pinaceae", "Tall");

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