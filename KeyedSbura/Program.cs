using ClassLibrary1;
using System.Text.RegularExpressions;
Console.WriteLine("Gestione Veicoli per una multinazionale grandissima potentissima wow!!");
VeicoliCollection Veicoli = new VeicoliCollection();
while (true)
{
    Console.WriteLine("-1 aggiungi veicolo");
    Console.WriteLine("-2 elimina veicolo per targa");
    Console.WriteLine("-3 visualizza veicoli");
    Console.WriteLine("-4 cerca veicolo per targa");
    Console.WriteLine("-6 terminazione del programma");
    Console.WriteLine("inserisci la tua scelta: ");
    if (!int.TryParse(Console.ReadLine(), out int scelta))
    {
        Console.WriteLine("la tua scelta è sbagliata , devi scegliere un n tra 1 e 6 ");
        continue;
    }
    switch (scelta)
    {
        case 1:
            // Aggiungi veicolo
            AggiungiVeicolo(Veicoli);
            break;
        case 2:
            // Elimina veicolo
            EliminaVeicolo(Veicoli);
            break;
        case 3:
            VisualizzaVeicoli(Veicoli);
            break;
        case 4:
            // Cerca veicolo
            CercaVeicolo(Veicoli);
            break;
        case 5:
            // Modifica veicolo
            break;
        case 6:
            return; // Terminazione del programma
        default:
            Console.WriteLine("Scelta non valida.");
            break;
    }
}
static void AggiungiVeicolo(VeicoliCollection Veicoli)
{
        Console.WriteLine("inserisci a se vuoi aggiungere un auto oppure c se vuoi aggiungere un camion");
   string  a = Console.ReadLine();
        if (a.ToLower() == "a")
        {
            Console.WriteLine("inserisci la targa ");
           string targa = Console.ReadLine();
        if (Veicoli.Contains(targa))
        {
            Console.WriteLine("ERRORE: Targa già presente in archivio!");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("inserisci la marca ");
          string marca = Console.ReadLine();
            Console.WriteLine("inserisci i Km Percorsi ");
        int km;
            while (!int.TryParse(Console.ReadLine(), out  km))
            {
                Console.WriteLine("errore  ");
            }
            Console.WriteLine("inserisci i litri di carburante consumato ");
        float c;
            while (!float.TryParse(Console.ReadLine(), out  c))
            {
                Console.WriteLine("la tua scelta è sbaglita ");
            }

        Console.WriteLine("inserisci i numeri posti ");
            int NumeroPosti;
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
            string targa = Console.ReadLine();
        if (Veicoli.Contains(targa))
        {
            Console.WriteLine("ERRORE: Targa già presente in archivio!");
            Console.ReadLine();
            return;
        }
        Console.WriteLine("inserisci la marca ");
            string marca = Console.ReadLine();
            Console.WriteLine("inserisci i Km Percorsi ");
        int km;
            while (!int.TryParse(Console.ReadLine(), out km))
            {
                Console.WriteLine("errore  ");
            }
            Console.WriteLine("inserisci i litri di carburante consumato ");
        float c;
            while (!float.TryParse(Console.ReadLine(), out  c))
            {
                Console.WriteLine("la tua scelta è sbaglita ");
            }

            Console.WriteLine("inserisci la capacita in tonnelate del  camion ");
        int Carico;
        while (!int.TryParse(Console.ReadLine(), out  Carico))
            {
                Console.WriteLine("errore ");
            }

            Veicolo Camion = new Camion(targa, marca, km, c, Carico);
            Veicoli.Add( Camion);
        }
   
}
static void EliminaVeicolo(VeicoliCollection Veicoli)
{   if (Veicoli.Count == 0)
    {
        Console.WriteLine("LA TUA LISTA DI VEICOLI è VUOTA;");
    }
    else
    {
        Console.WriteLine("inserisci la targa del veicolo da eliminare ");
        string input = Console.ReadLine();
        if (Veicoli.Remove(input))
        {
            Console.WriteLine("Veicolo eliminato con successo.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Veicolo non trovato.");
            Console.ResetColor();
        }
    }
}
static void VisualizzaVeicoli(VeicoliCollection Veicoli)
{
    if (Veicoli.Count == 0)
    {
        Console.WriteLine("Nessun veicolo presente.");
        return;
    }
    foreach (var veicolo in Veicoli)
    {
        Console.WriteLine(veicolo.GetDettagliCompleti());
    }
}
static void CercaVeicolo(VeicoliCollection Veicoli)
{
    if (Veicoli.Count == 0)
    {
        Console.WriteLine("lISTA VUOTA");
    }
    else
    {
        Console.WriteLine("Inserisci la targa del veicolo da cercare:");
        string targa = Console.ReadLine();
        var veicolo = Veicoli.FirstOrDefault(v => v.Targa.Equals(targa, StringComparison.OrdinalIgnoreCase));
        if (veicolo != null)
        {
            Console.WriteLine("Veicolo trovato:");
            Console.WriteLine(veicolo.GetDettagliCompleti());
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Veicolo non trovato.");
            Console.ResetColor();
        }
    }
}