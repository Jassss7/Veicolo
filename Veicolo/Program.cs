
using ClassLibrary1;

Console.WriteLine("Gestione Veicoli per una multinazionale grandissima potentissima wow!!");
List<Veicolo> Veicoli = new List<Veicolo>();
string marca;
string targa;
int km;
float c;
int NumeroPosti;
string a;
int scelta = 0;
int Carico;
do
{
    Console.WriteLine("-1 aggiungi veicolo");
    Console.WriteLine("-2 visualizza veicoli");
    Console.WriteLine("-3 esci dal programma");
    Console.WriteLine("inserisci una scelta ");
    while (!int.TryParse(Console.ReadLine(), out scelta))
    {
        Console.WriteLine("la tua scelta è sbaglita , devi scegliere un n tra 1 e 3 ");
    }

    switch (scelta)
    {
        case 1:
            Console.WriteLine("inserisci a se vuoi aggiungere un auto oppure c se vuoi aggiungere un camion");
            a =Console.ReadLine();
            if (a.ToLower() == "a")
            {
                Console.WriteLine("inserisci la targa ");
                targa = Console.ReadLine();
                Console.WriteLine("inserisci la marca ");
                marca = Console.ReadLine();
                Console.WriteLine("inserisci i Km Percorsi ");
                while (!int.TryParse(Console.ReadLine(), out km))
                {
                    Console.WriteLine("errore  ");
                }
                Console.WriteLine("inserisci i litri di carburante consumato ");
                while (!float.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("la tua scelta è sbaglita ");
                }

                Console.WriteLine("inserisci i numeri posti ");
                while (!int.TryParse(Console.ReadLine(), out NumeroPosti))
                {
                    Console.WriteLine("errore  ");
                }

                Veicolo auto = new Auto(targa, marca, km, c, NumeroPosti);
                Veicoli.Add(auto);
            }
            else if (a.ToLower() == "c")
            {
                Console.WriteLine("inserisci la targa ");
                targa = Console.ReadLine();
                Console.WriteLine("inserisci la marca ");
                marca = Console.ReadLine();
                Console.WriteLine("inserisci i Km Percorsi ");
                while (!int.TryParse(Console.ReadLine(), out km))
                {
                    Console.WriteLine("errore  ");
                }
                Console.WriteLine("inserisci i litri di carburante consumato ");
                while (!float.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("la tua scelta è sbaglita ");
                }

                Console.WriteLine("inserisci i numeri posti ");
                while (!int.TryParse(Console.ReadLine(), out Carico))
                {
                    Console.WriteLine("errore ");
                }

                Veicolo Camion = new Camion(targa, marca, km, c, Carico);
                Veicoli.Add(Camion);
            }

            break;
        case 2:
            if (Veicoli.Count == 0)
            {
                Console.WriteLine("il tuo gestionario veicoli è vuoto");
            }
            else
            {
                foreach (var V in Veicoli)
                {
                    Console.WriteLine(V.GetDettagliCompleti());
                }

            }
            break;
        case 3:
            Console.WriteLine("terminazione del programma.....");
            break;
        default:

            Console.WriteLine("errore,scelta non contemplata");
            break;
    }

} while (scelta != 3);
