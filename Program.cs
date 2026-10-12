namespace filmtar
{
    internal class Film
    {
        public int Azonosito;
        public string Cim;
        public string Rendezo;
        public int Ev;
        public int Hossz;
        public bool Szines;

        public Film(string sor)
        {
            string[] adatok = sor.Split(';');
            Azonosito = int.Parse(adatok[0]);
            Cim = adatok[1];
            Rendezo = adatok[2];
            Ev = int.Parse(adatok[3]);
            Hossz = int.Parse(adatok[4]);
            Szines = adatok[5] == "1";

        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            List<Film> filmek = new List<Film>();

            string[] sorok = File.ReadAllLines("filmek.txt");
            foreach (string sor in sorok)
            {
             filmek.Add(new Film(sor));
            }

            Console.WriteLine($"Filmek száma: {filmek.Count}");

            foreach (Film f in filmek)
            {
                Console.WriteLine($"{f.Azonosito}. {f.Cim} ({f.Ev}) - {f.Rendezo}, {f.Hossz} perc");
            }

            int feketefeher = 0;
            foreach (Film f in filmek)
            {
                if (!f.Szines)
                {
                    feketefeher++;
                }
            }
            Console.WriteLine($"Fekete-fehér filmek száma: {feketefeher}");


            Film leghosszabb = filmek[0];
            foreach (Film f in filmek)
            {
                if (f.Hossz > leghosszabb.Hossz)
                {
                    leghosszabb = f;
                }
            }
            Console.WriteLine($"A leghosszabb film: {leghosszabb.Cim} ({leghosszabb.Hossz} perc)");


        }
    }
}
