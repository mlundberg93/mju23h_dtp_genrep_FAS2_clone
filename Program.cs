namespace mju23h_dtp_genrep_FAS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                    string a = Console.ReadLine();
                    Console.Write("familj:  ");
                    string f = Console.ReadLine();
                    Console.Write("svenska: ");
                    string s = Console.ReadLine();
                    art[sista] = a; familj[sista] = f; sv[sista] = s;
                    sista++;
                    Console.WriteLine($"{a} tillagd");
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