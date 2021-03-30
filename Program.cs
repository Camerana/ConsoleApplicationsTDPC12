using ConsoleApplicationsTDPC12.ICanPrint;
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
            - abbia un'interfaccia IPersona con:
                - void Saluta();
                - void Cammina();
            - abbia una classe Persona che implementa IPersona
            - abbia una classe Androide che implementa IPersona
            - tramite due oggetti uno di tipo Persona e uno di tipo Androide,
            chiami le relative implementazioni di Saluta() e Cammina()
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
         Scrivere un programma che:
            - abbia un'interfaccia IMuoviti con:
                - void Muoviti();
            - abbia tre classi che implementano IMuoviti
            - abbia una funzione MuoviOggetto(IMuoviti oggetto) che al suo interno
            chiami la funzione Muoviti() di oggetto
            - crei tre oggetti uno per ciascuna classe e li passi a MuoviOggetto(IMuoviti oggetto)
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