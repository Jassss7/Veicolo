using ClassLibrary1;

Console.WriteLine("Gestione Veicoli per una multinazionale grandissima potentissima wow!!");
Dictionary<string, Veicolo> Veicoli = new Dictionary<string, Veicolo>();
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
    Console.WriteLine("-2 elimina veicolo");
    Console.WriteLine("-3 visualizza veicoli");
    Console.WriteLine("-4 cerca veicolo");
    Console.WriteLine("-5 modifica veicolo");
    Console.WriteLine("-6 terminazione del programma");
    Console.WriteLine("inserisci la tua scelta: ");
    while (!int.TryParse(Console.ReadLine(), out scelta))
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
                Veicoli.Add(auto.Targa,auto);
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

                Console.WriteLine("inserisci la capacita in tonnelate del  camion ");
                while (!int.TryParse(Console.ReadLine(), out Carico))
                {
                    Console.WriteLine("errore ");
                }

                Veicolo Camion = new Camion(targa, marca, km, c, Carico);
                Veicoli.Add(Camion.Targa,Camion);
            }
            else
            {
                Console.WriteLine("ho detto a opppure c per la tipologia di veicolo da inserire!!!");
            }

            break;
        case 2:
            if (Veicoli.Count == 0)
            {
                Console.WriteLine("il tuo gestionario veicoli è vuoto");
            }
            else
            {
                Console.WriteLine("inserisci la targa del veicolo da eliminare ");
                string input = Console.ReadLine();
                
                if (Veicoli.ContainsKey(input))
                {
                    Veicoli.Remove(input);
                    Console.WriteLine($"Veicolo con targa:{input} è stato eliminato");
                }
                else
                {
                    Console.WriteLine("Veicolo non trovato");
                }
            }
            break;
        case 3:
            foreach (KeyValuePair<string, Veicolo> V in Veicoli)
            {
                Console.WriteLine(V.Value.GetDettagliCompleti());
            }
       
            break;
        case 4:
            if (Veicoli.Count == 0)
            {
                Console.WriteLine("il tuo gestionario veicoli è vuoto");
            }
            else
            {
                Console.WriteLine("inserisci la targa del veicolo da cercare ");
                string input = Console.ReadLine();

                if (Veicoli.ContainsKey(input))
                { 
                    Veicolo VeicoloTrovato = Veicoli[input];
                    Console.WriteLine($"Veicolo Trovato , ecco i dettagli : {VeicoloTrovato.GetDettagliCompleti()}");
                }
                else
                {
                    Console.WriteLine("Veicolo non trovato");
                }
            }
            break;
        case 5:
            if (Veicoli.Count == 0)
            {
                Console.WriteLine("il tuo gestionario veicoli è vuoto");
            }
            else
            {
                Console.WriteLine("inserisci la targa del veicolo da modificare ");
                string input = Console.ReadLine();

                if (Veicoli.ContainsKey(input))
                {
                    if (Veicoli[input] is Camion camion)
                    {
                        Console.WriteLine("inserisci la targa ");
                        camion.Targa = Console.ReadLine();
                        Console.WriteLine("inserisci la marca ");
                       camion.Marca = Console.ReadLine();
                        Console.WriteLine("inserisci i Km Percorsi ");
                        while (!int.TryParse(Console.ReadLine(), out km))
                        {
                            Console.WriteLine("errore  ");
                        }

                        camion.KmPercorsi = km;
                        Console.WriteLine("inserisci i litri di carburante consumato ");
                        while (!float.TryParse(Console.ReadLine(), out c))
                        {
                            Console.WriteLine("la tua scelta è sbaglita ");
                        }

                        Veicoli[input].LitriCarburanteConsumati = c;
                        Console.WriteLine("inserisci la capacita in tonnelate del  camion ");
                        while (!int.TryParse(Console.ReadLine(), out Carico))
                        {
                            Console.WriteLine("errore ");
                        }

                        camion.CapacitaCarico= Carico;
                    }
                   
                    else if (Veicoli[input] is Auto auto)
                    {
                        Console.WriteLine("inserisci la targa ");
                        auto.Targa = Console.ReadLine();
                        Console.WriteLine("inserisci la marca ");
                        auto.Marca = Console.ReadLine();
                        Console.WriteLine("inserisci i Km Percorsi ");
                        while (!int.TryParse(Console.ReadLine(), out km))
                        {
                            Console.WriteLine("errore  ");
                        }

                        auto.KmPercorsi = km;
                        Console.WriteLine("inserisci i litri di carburante consumato ");
                        while (!float.TryParse(Console.ReadLine(), out c))
                        {
                            Console.WriteLine("la tua scelta è sbaglita ");
                        }

                        Veicoli[input].LitriCarburanteConsumati = c;
                        Console.WriteLine("inserisci i numero dei posti disponibili ");
                        while (!int.TryParse(Console.ReadLine(), out NumeroPosti))
                        {
                            Console.WriteLine("errore ");
                        }

                        auto.NumeroPosti = NumeroPosti;
                    }
                }
             
                else
                {
                    Console.WriteLine("Veicolo non trovato");
                }
            }
            break;
        case 6:
            Console.WriteLine("terminazione del programma......");
            break;

        default:
                Console.WriteLine("errore,scelta non contemplata");
            break;
    }

} while (scelta != 6);

