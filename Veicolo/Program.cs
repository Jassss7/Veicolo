
using System.Threading.Channels;
using ClassLibrary1;
Console.WriteLine("-1 aggiungi veicolo");
Console.WriteLine("-2 visualizza veicoli");
Console.WriteLine("-3 esci dal programma");
List<Veicolo> Veicoli = new List<Veicolo>();
string a;
int scelta = 0;
do
{
    Console.WriteLine("inserisci una scelta ");
    while (!int.TryParse(Console.ReadLine(), out scelta) && scelta < 1 && scelta > 3)
    {
        Console.WriteLine("la tua scelta è sbaglita , devi scegliere un n tra 1 e 3 ");
    }

    switch (scelta)
    {
        case 1:
            Console.WriteLine("inserisci a se vuoi aggiungere un auto oppure c se vuoi aggiungere un camion");
            a = Console.ReadLine();
            if (a.ToLower() == "a")
            {
                Console.WriteLine("inserisci la targa ");
                string targa = Console.ReadLine();
                Console.WriteLine("inserisci la marca ");
                string marca = Console.ReadLine();
                Console.WriteLine("inserisci i Km Percorsi ");
                int Km = int.Parse(Console.ReadLine());
                Console.WriteLine("inserisci i litri di carburante consumato ");
                float c = float.Parse(Console.ReadLine());
                Console.WriteLine("inserisci i numeri posti ");
                int NumeroPosti = int.Parse(Console.ReadLine());
                Veicolo auto = new Auto(targa,marca,Km,c,NumeroPosti);
                Veicoli.Add(auto);
            }
            else if (a.ToLower() == "c")
            {
                Console.WriteLine("inserisci la targa ");
                string targa = Console.ReadLine();
                Console.WriteLine("inserisci la marca ");
                string marca = Console.ReadLine();
                Console.WriteLine("inserisci i Km Percorsi ");
                int Km = int.Parse(Console.ReadLine());
                Console.WriteLine("inserisci i litri di carburante consumato ");
                float c = float.Parse(Console.ReadLine());
                Console.WriteLine("inserisci i numeri posti ");
                int NumeroPosti = int.Parse(Console.ReadLine());
                Veicolo auto = new Auto(targa, marca, Km, c, NumeroPosti);
            }

    }
    
}
