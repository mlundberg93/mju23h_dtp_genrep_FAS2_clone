namespace mju23h_dtp_genrep_FAS2
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
            artlista[0] = new Art() { art = "Hepatica nobilis", familj = "Ranunculaceae", svenska = "Blåsippa" };
            artlista[1] = new Art() { art = "Anemone nemorosa", familj = "Ranunculaceae", svenska = "Vitsippa" };
            artlista[2] = new Art() { art = "Taraxacum ruderalia", familj = "Asteraceae", svenska = "Maskros" };
            artlista[3] = new Art() { art = "Malus domestica", familj = "Rosales", svenska = "Äppelträd" };
            artlista[4] = new Art() { art = "Pinus sylvestris", familj = "Pinaceae", svenska = "Tall" };
            artlista[sista].art = "Hepatica nobilis";
            artlista[sista].familj = "Ranunculaceae";
            artlista[sista].svenska = "Blåsippa";
            //sista++;
            artlista[sista].art = "Anemone nemorosa";
            artlista[sista].familj = "Ranunculaceae";
            artlista[sista].svenska = "Vitsippa";
            //sista++;
            artlista[sista].art = "Taraxacum ruderalia";
            artlista[sista].familj = "Asteraceae";
            artlista[sista].svenska = "Maskros";
            //sista++;
            artlista[sista].art = "Malus domestica";
            artlista[sista].familj = "Rosales";
            artlista[sista].svenska = "Äppelträd";
            //sista++;
            artlista[sista].art = "Pinus sylvestris";
            artlista[sista].familj = "Pinaceae";
            artlista[sista].svenska = "Tall";
            //sista++;
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