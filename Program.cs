using ConsoleApplicationsTDPC12.ICanPrint;
using ConsoleApplicationsTDPC12.InputOutput;
using ConsoleApplicationsTDPC12.IPersona;
using ConsoleApplicationsTDPC12.Movimento;
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
         Scrivere un programma che:
            - abbia un array di numeri di dimensione e contenuto a piacere
            - abbia un array di stringhe
            - trasferisce il contenuto dell'array di numeri in quello di stringhe         
         */
        /*
         Scrivere un programma che:
            - chieda all'utente 4 numeri
            - stampi su schermo la media dei 4 numeri
            - stampi su schermo i numeri in ordine crescente
            - stampi su schermo il numero maggiore e il minore
         */
        /*
        Scrivere un programma che:
            - Abbia una classe Libro con:
                - double Costo
                - string Titolo
                - string Autore
            - Abbia una classe Libreria con una lista di Libro
            - Crei 5 oggetti di tipo Libro pienamente valorizzati
            - Tramite una funzione StampaLibri all'interno di Libreria:
                - Stampi su schermo i libri in 4 modi:
                    - ordinati per Costo
                    - ordinati per Titolo
                    - ordinati per Autore
                    - nel format ("Autore - Titolo, Costo")
        */
        /*
        Scrivere un programma che:
            - abbia una classe astratta Oggetto
            - abbia una classe Penna
            - abbia una classe Foglio
            - abbia una classe Matita
            - abbia una classe Zaino con all'interno una lista di Oggetto
            - crei un oggetto di tipo Zaino e all'interno della sua lista
            metta un oggetto di tipo Penna, un oggetto di tipo Foglio e un oggetto
            di tipo Matita
        */
        /*
        Scrivere un programma che:
            - abbia un'interfaccia ISubacqueo
            - abbia una classe astratta Entita con una proprietà Nome
            - abbia una classe Pesce : Entita, ISubacqueo
            - abbia una classe Mammifero : Entita, ISubacqueo
            - abbia una classe Sottomarino : Entita, ISubacqueo
            - crei un oggetto di ciascun tipo e li passi a una funzione
            PrintNome(ISubacqueo oggetto) che ne stampi la proprietà Nome
        */
        static void Main(string[] args)
        {

        }
        /*
         Scrivere un programma che:
            - Prenda in input dall'utente 3 stringhe
            - Crei una lista di stringhe e tramite questa ordini alfabeticamente
            le stringhe dell'utente e le stampi su schermo
         */
        /*
        static void Main(string[] args)
        {
            List<string> stringhe = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Inserisci una stringa");
                stringhe.Add(Console.ReadLine());
            }
            List<string> stringheOrdinate = stringhe.OrderBy(s => s).ToList();
            foreach (string stringa in stringheOrdinate)
                Console.WriteLine(stringa);
        }
        */
        /*
         Scrivere un programma che:
            - Prenda in input dall'utente 3 stringhe
            - Tramite una classe "static class Utilities"
            con al suo interno una funzione "public static void Print(List<string> stringhe)"
            stampi su schermo le tre stringhe in ordine alfabetico
         */
        /*
        static void Main(string[] args)
        {
            List<string> stringhe = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Inserisci una stringa");
                stringhe.Add(Console.ReadLine());
            }
            Utilities.Print(stringhe);
        }
        */
        /*
         Scrivere un programma che:
            - abbia un'interfaccia IPersona con:
                - void Saluta();
                - void Cammina();
            - abbia una classe Persona che implementa IPersona
            - abbia una classe Androide che implementa IPersona
            - tramite due oggetti uno di tipo Persona e uno di tipo Androide,
            chiami le relative implementazioni di Saluta() e Cammina()
         */
        /*
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.Cammina();
            p.Saluta();
            Androide a = new Androide();
            a.Cammina();
            a.Saluta();
        }
        */
        /*
         Scrivere un programma che:
            - abbia un'interfaccia IGetInput con:
                - void GetInput();
            - abbia un'interfaccia IPrintOutput con:
                - void PrintOutput();
            - abbia una classe InputHandler che implementa IGetInput
            - abbia una classe OutputHandler che implementa IPrintOutput
            - tramite due oggetti uno di tipo InputHandler e uno di tipo OutputHandler,
            chieda un input all'utente e poi lo stampi su schermo
         */
        /*
        static void Main(string[] args)
        {
            InputHandler i = new InputHandler();
            i.GetInput();
            OutputHandler o = new OutputHandler(i.Input);
            o.PrintOutput();
        }
        */
        /*
         Scrivere un programma che:
            - abbia un'interfaccia IMuoviti con:
                - void Muoviti();
            - abbia tre classi che implementano IMuoviti
            - abbia una funzione MuoviOggetto(IMuoviti oggetto) che al suo interno
            chiami la funzione Muoviti() di oggetto
            - crei tre oggetti uno per ciascuna classe e li passi a MuoviOggetto(IMuoviti oggetto)
         */
        /*
        static void Main(string[] args)
        {
            Aereo aereo = new Aereo();
            Nave nave = new Nave();
            Auto auto = new Auto();
            MuoviOggetto(aereo);
            MuoviOggetto(nave);
            MuoviOggetto(auto);
        }
        static void MuoviOggetto(IMuoviti oggetto)
        {
            oggetto.Muoviti();
        }
        */
        /*
         Scrivere un programma che:
            - abbia un'interfaccia ICanPrint con definito void Print()
            - abbia due classi, Classe1 e Classe2 che implementino ICanPrint
            e ne abbiano due implementazioni diverse
            - tramite due oggetti, uno di tipo Classe1 e uno di tipo Classe2,
            chiami le relative implementazioni di Print()
         */
        /*
        static void Main(string[] args)
        {
            ICanPrint.ICanPrint c1 = new Classe1();
            c1.Print();

            ICanPrint.ICanPrint c2 = new Classe2();
            c2.Print();
        }
        */
        /*
        static void Main(string[] args)
        {
            ISaNuotare papera = ClassFactory.GetPapera();
            ISaNuotare pesce = ClassFactory.GetPesce();

            papera.Nuota();
            pesce.Nuota();
        }
        */
    }
}