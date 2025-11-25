namespace gra_ubij_bestię
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ubij bestię";
            Random r = new Random();
            int whofirst = r.Next(0, 2);

            while (true)
            {
                Console.WriteLine("Witaj w grze \"Ubij bestię\".\nPodaj swoje statystyki i statystyki bestii.");
                Console.ReadKey();
                Console.Clear();

                Console.Write("Podaj swój atak: ");                                           // Wprowadzanie wartości ataku, obrony i punktów życia
                int attack_u = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj swoją obronę: ");
                int defense_u = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj swoje HP: ");
                int hp_u = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nPodaj statystyki bestii");
                Console.Write("Podaj atak bestii: ");
                int attack_m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj obronę bestii: ");
                int defense_m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj HP bestii: ");
                int hp_m = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("Statystyki gracza        Statystyki potwora");                                                   // Wyświetlanie ekranu z aktualnymi statystykami
                Console.WriteLine("-------------------      -------------------------------");
                Console.WriteLine($"HP:{hp_u} O:{defense_u} A:{attack_u}           HP:{hp_m} O:{defense_m} A:{attack_m}");

                int x = (attack_u - defense_m) * 10;                               // Blok do generowania wartości obrażeń na podstawie różnicy w punktach obrony i ataku
                if (attack_u < defense_m) x = 0;
                int y = (attack_m - defense_u) * 10;
                if (attack_m < defense_u) y = 0;

                if (whofirst == 1)                                                                              // Blok wykonywany, kiedy komputer wylosuje gracza jako rozpoczynającego
                {
                    while (true)
                    {
                        Console.WriteLine("\n\nNaciśnij dowolny przycik, aby rozpocząć atak");
                        Console.ReadKey();

                        hp_m = hp_m - x;

                        Console.Clear();
                        Console.WriteLine("Statystyki gracza        Statystyki potwora");
                        Console.WriteLine("-------------------      -------------------------------");
                        Console.WriteLine($"HP:{hp_u} O:{defense_u} A:{attack_u}           HP:{hp_m} O:{defense_m} A:{attack_m}");

                        Console.WriteLine("\n\nTeraz atakuje bestia");
                        Console.ReadKey();
                        
                        hp_u = hp_u - y;

                        Console.Clear();
                        Console.WriteLine("Statystyki gracza        Statystyki potwora");
                        Console.WriteLine("-------------------      -------------------------------");
                        Console.WriteLine($"HP:{hp_u} O:{defense_u} A:{attack_u}           HP:{hp_m} O:{defense_m} A:{attack_m}");

                        if ((hp_u <= 0 || hp_m <= 0)) break;

                    }
                    string wynik = (hp_u <= 0) ? "Bestia Cię pokonała" : "Pokonałeś bestię!";                   // ogłoszenie wyniku w przypadku spadku HP poniżej 0
                    Console.WriteLine("\n" + wynik);
                    Console.WriteLine("\nRozpocząć jeszcze raz?");
                    Console.ReadKey();
                    Console.Clear();
                }

                if (whofirst == 0)                                                                              // Blok wykonywany, kiedy komputer wylosuje bestię jako rozpoczynającą
                {

                    while (true)
                    {
                        Console.WriteLine("\n\nTeraz atakuje bestia");
                        Console.ReadKey();

                        hp_u = hp_u - y;

                        Console.Clear();
                        Console.WriteLine("Statystyki gracza        Statystyki potwora");
                        Console.WriteLine("-------------------      -------------------------------");
                        Console.WriteLine($"HP:{hp_u} O:{defense_u} A:{attack_u}           HP:{hp_m} O:{defense_m} A:{attack_m}");

                        Console.WriteLine("\n\nWciśnij dowolny przycik, aby rozpocząć atak");
                        Console.ReadKey();

                        hp_m = hp_m - x;

                        Console.Clear();
                        Console.WriteLine("Statystyki gracza        Statystyki potwora");
                        Console.WriteLine("-------------------      -------------------------------");
                        Console.WriteLine($"HP:{hp_u} O:{defense_u} A:{attack_u}           HP:{hp_m} O:{defense_m} A:{attack_m}");

                        if ((hp_u <= 0 || hp_m <= 0)) break;
                    }

                    string wynik = (hp_u <= 0) ? "Bestia Cię pokonała" : "Pokonałeś bestię!";                   // ogłoszenie wyniku w przypadku spadku HP poniżej 0
                    Console.WriteLine("\n" + wynik);
                    Console.WriteLine("\nRozpocząć jeszcze raz?");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
