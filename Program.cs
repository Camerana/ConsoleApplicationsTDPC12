using ConsoleApplicationsTDPC12.Distributore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12
{
    class Program
    {
        /*
         Creare un piccolo gioco di ruolo con queste caratteristiche:
            - Classe Personaggio
            - Classe Player che eredita da Personaggio
            - Classe Nemico che eredita da Personaggio
            - Simulazione di combattimento tra Player e Nemico
         */
        static void Main(string[] args)
        {

        }
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