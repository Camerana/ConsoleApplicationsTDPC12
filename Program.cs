using ConsoleApplicationsTDPC12.Distributore;
using ConsoleApplicationsTDPC12.GDR;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplicationsTDPC12.Rubrica;

namespace ConsoleApplicationsTDPC12
{
    class Program
    {
        /*
         Creare un programma che simuli una rubrica:
            - Permettere all'utente di inserire nuovi nomi con relativi dati
            - Permettere all'utente di leggere i nomi già esistesti e i relativi dati
            - Spunti:
                - scrittura/lettura dei dati su file (classe File in System.IO)
                - delete/update dei dati esistenti
         */
        static void Main(string[] args)
        {
            Rubrica.Rubrica rubrica = new Rubrica.Rubrica();
            while (true)
            {
                Console.WriteLine("Scegli l'operazione da svolgere:");
                Console.WriteLine("1 = Inserisci nuovo contatto");
                Console.WriteLine("2 = Leggi contatti esistenti");
                Console.WriteLine("3 = Cancella un contatto esistente");
                Console.WriteLine("4 = Modifica un contatto esistente");
                string input = Console.ReadLine();
                if (input == "1")
                    rubrica.InsertContatto();
                else if (input == "2")
                    rubrica.PrintContatti();
                else if (input == "3")
                    rubrica.PrintContattiForDelete();
                else if (input == "4")
                    rubrica.PrintContattiForUpdate();
            }
        }
        /*
         Creare un piccolo gioco di ruolo con queste caratteristiche:
            - Classe Personaggio (abstract)
            - Classe Player che eredita da Personaggio
            - Classe Nemico che eredita da Personaggio
            - Simulazione di combattimento tra Player e Nemico
         */
        /*
        static void Main(string[] args)
        {
            Random random = new Random();
            Player player = new Player(random);
            Nemico nemico = new Nemico(random);

            bool playerHasEscaped = false;
            while ((player.HP > 0 && nemico.HP > 0) && !playerHasEscaped)
            {
                Console.WriteLine("Player has: " + player.HP);
                Console.WriteLine("Nemico has: " + nemico.HP);

                Console.WriteLine("Press 1 to attack");
                Console.WriteLine("Press 2 to run");
                string input = Console.ReadLine();

                if (input == "1")
                    player.Attack(nemico);
                else if (input == "2")
                    playerHasEscaped = player.Run();

                if (!playerHasEscaped)
                {
                    if (nemico.HP > 0)
                        nemico.Attack(player);
                    else
                        player.Gold += nemico.GoldReward;
                }
            }
            if (player.HP > 0)
            {
                Console.WriteLine("You won");
                if (!playerHasEscaped)
                    Console.WriteLine("You obtained: " + nemico.GoldReward);
            }
            else
            {
                Console.WriteLine("YOU DIED");
            }
        }
        */
        /*
         Tramite l'uso di classi simulare un distributore automatico:
            - classe Distributore
            - classe Prodotto da cui ereditano:
                - classe Bevanda
                - classe Snack
            - classe Cliente per gestire i soldi del cliente
            - funzionalità richieste:
                - offrire una scelta di prodotti al cliente con costi differenti
                - rispondere positivamente o negativamente a seconda
                dei soldi disponibili
         */
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Distributore automatico");
            Cliente cliente = new Cliente();
            Distributore.Distributore distributore = new Distributore.Distributore();

            string input = string.Empty;
            while (input != "q")
            {
                Console.WriteLine("Che prodotto vuoi comprare ?");
                Console.WriteLine("Digita q per uscire");
                Console.WriteLine();
                distributore.PrintProdotti();
                int scelta = -1;
                try
                {
                    input = Console.ReadLine();
                    if (input != "q")
                        scelta = int.Parse(input);
                }
                catch
                {
                    Console.WriteLine("E' stato inserito un codice errato");
                }
                distributore.BuyProdotto(scelta, cliente);
            }
            Console.WriteLine("Arrivederci");
            Console.ReadKey();
        }
        */
    }
}