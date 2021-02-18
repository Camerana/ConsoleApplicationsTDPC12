using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12
{
    public class Program
    {
        /*
         Scrivere un programma che:
         - abbia una classe Persona con properties:
            - Nome e Cognome di tipo stringa
            - AnimaleDomestico di tipo Animale con properties:
                - Nome e Razza di tipo stringa
         - crei un oggetto di tipo Persona che abbia al suo interno un
         oggetto di tipo Animale, entrambi pienamente valorizzati
         */
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.Nome = "Fred";
            p.Cognome = "Bongusto";
            p.AnimaleDomestico = new Animale();
            p.AnimaleDomestico.Nome = "Fuffi";
            p.AnimaleDomestico.Razza = "Cane";
        }
        /*
         Scrivere un programma che:
            - data una classe Persona con properties Nome e Cognome:
                - chieda all'utente Nome e Cognome di una Persona da creare
                - crei un oggetto di tipo Persona e lo valorizzi coi dati scelti
                dall'utente
                - stampi su schermo i valori dell'oggetto creato
         */
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Inserisci il cognome");
            string cognome = Console.ReadLine();

            Persona p = new Persona();
            p.Nome = nome;
            p.Cognome = cognome;

            Console.WriteLine("Nome: " + p.Nome);
            Console.WriteLine("Cognome: " + p.Cognome);
            Console.ReadKey();
        }
        */
        /*
         Scrivere un programma che:
            - data una classe Animale con properties Nome e Razza di tipo string:
                - istanzi 1000 oggetti di tipo Animale popolandone i valori
                nel costruttore e li salvi in una lista
                - stampi su schermo i dati dei 1000 oggetti

            - costruttore da usare:
             public Animale(string nome, string razza)
            {
                this.Nome = nome;
                this.Razza = razza;
            }
         */
        /*
        static void Main(string[] args)
        {
            List<Animale> lista = new List<Animale>();
            for (int i = 0; i < 1000; i++)
            {
                Animale a = new Animale("Nome" + i, "Razza" + i);
                lista.Add(a);
            }
            foreach (Animale a in lista)
            {
                Console.WriteLine(a.Nome + " è di razza: " + a.Razza);
            }
            Console.ReadKey();
        }
        */
        /*
            Creare una classe Animale con:
                - una property Nome
                - una property Razza
                - una funzione Muoviti
            Creare 2 oggetti di tipo Animale
            Attribuire tutti i valori ai due oggetti
            Stampare su schermo le properties dei due oggetti
            Chiamare la funzione Muoviti di entrambi gli oggetti
         */
        /*
        static void Main(string[] args)
        {
            Animale a1 = new Animale();
            a1.Nome = "Ciccio";
            a1.Razza = "Pesce rosso";

            Animale a2 = new Animale();
            a2.Nome = "Micio";
            a2.Razza = "Cane";

            Console.WriteLine(a1.Nome);
            Console.WriteLine(a1.Razza);

            Console.WriteLine(a2.Nome);
            Console.WriteLine(a2.Razza);

            a1.Muoviti();
            a2.Muoviti();

            Console.ReadKey();
        }
        */
    }
}