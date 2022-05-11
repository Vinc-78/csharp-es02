using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)  //entry point
        {
            
            /* Esercizio: Realizzare un programma che chiede all'utente che tipo di operazione intende svolgere 
            ( 0-somma, 1-prodotto, 2-divisione, 3-sottrazione, 4-quadrato, 5-media )
            se tra 0 e 3 chiede due valori, per 4 un solo valore, e per media 10 valori
            usare un vettore per archiviare 
            opzionale implementare l'operazione di elevamento a potenza superiore al 2  */

            int operazione;

            Console.WriteLine("Scegli il tipo di operazione da fare ");
            Console.WriteLine("( 0-somma, 1-prodotto, 2-divisione, 3-sottrazione, 4-quadrato, 5-media, 6-trova-min-max )");

            Console.Write("Inserisci la scelta : ");
            if (!int.TryParse(Console.ReadLine(), out operazione))
            {
                Console.WriteLine("Errore non è un numero");
                Environment.Exit(1);
            }

            if (operazione <=3) {
                int a, b;

                Console.Write("Inserisci il primo numero : ");
                if (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Errore non è un numero");
                    Environment.Exit(1);
                }

                Console.Write("Inserisci il primo numero : ");
                if (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Errore non è un numero");
                    Environment.Exit(1);
                }
                if (operazione == 0)
                {

                    int somma = a + b;
                    Console.WriteLine("La somma è {0}", somma);

                }
                else if (operazione == 1)
                {
                    int prodotto = a * b;
                    Console.WriteLine("Il prodotto è {0}", prodotto);
                }
                else if (operazione == 2)
                {
                    float divisione = (float)a / (float)b;
                    Console.WriteLine("LA divisione è {0}", divisione);
                }
                else if (operazione == 3){
                    int sottrazione = a - b;
                    Console.WriteLine("La sottrazione è {0}", sottrazione);
                }


            }


            if (operazione == 4) {
                int numero;

                Console.Write("Inserisci il numero da fare al quadrato : ");
                if (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Errore non è un numero");
                    Environment.Exit(1);
                }
                
                int elevato = 2; // se si vuole il quadrato o quanto serve
                Console.WriteLine("Il quadrato è {0}", (long)Math.Pow(elevato, numero));


            }

            if (operazione == 5) {
                /*
                // prima versione

                float somma = 0;
                float media;
                Console.WriteLine("Inserisci dieci numeri per il calcolo della media : ");
                for (int i = 0; i < 10; i++) {
                    int num;
                    Console.Write("Inserisci il {0} numero  : ", (i+1));
                    if (!int.TryParse(Console.ReadLine(), out num))
                    {
                        Console.WriteLine("Errore non è un numero");
                        Environment.Exit(1);
                    }

                    somma += num; 

                }

                media =  somma / 10;
                Console.WriteLine("La media è {0}", media);
                */

                //versione che non prevede limiti di numeri scritti in riga
                Console.WriteLine("Inserisci l'elenco dei numeri di cui intendi calcolare la media, separati da spazi vuoti, ");
                Console.Write(" tutti sulla stessa riga: ");

                string sNumeri = Console.ReadLine();
                if (sNumeri == null)
                {
                    Console.WriteLine("Non hai fornito numeri!!");
                    Environment.Exit(0);
                }
                string[] svect = sNumeri.Split(' '); // split crea un vettore di stringhe divise dallo spazio
                double media = 0.0;
                int quanti = 0;
                foreach (string snum in svect)
                {
                    double num;
                    if (double.TryParse(snum, out num))
                    {
                        media += num;
                        quanti++;
                    }
                }
                media /= quanti;  
                Console.WriteLine("La media dei numeri forniti è: {0}", media);
            }


            if (operazione == 6) {
                Console.WriteLine("Inserisci l'elenco dei numeri di cui intendi trovare il min e max, ");
                Console.Write(" tutti sulla stessa riga: ");

                string sNumeri = Console.ReadLine();
                if (sNumeri == null)
                {
                    Console.WriteLine("Non hai fornito numeri!!");
                    Environment.Exit(0);
                }

                string[] vet = sNumeri.Split(' ');

                double min = 0.0;
                double max = 0.0;

                for (int i = 0; i < vet.Length; i++) {
                    double num;
                    double.TryParse(vet[i], out num);

                    if (num > max) {
                        max = num;

                    }
                
                }
                for (int i = 0; i < vet.Length; i++)
                {
                    double numStart;
                    double.TryParse(vet[0], out numStart);

                    min = numStart;

                    double num;
                    double.TryParse(vet[i], out num);

                    if (num < min)
                    {
                        min = num;

                    }

                }

                Console.WriteLine("Il minimo è {0}, il più grande è {1}", min, max);


            }

        }
       

    }
}

