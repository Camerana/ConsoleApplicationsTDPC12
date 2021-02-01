using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12
{
    class Program
    {
        //20210131
        /*
         Scrivere un programma che:
            - chieda all'utente due numeri interi
            - faccia un ciclo for da 0 fino al primo numero e ad ogni iterazione stampi la somma tra
            l'indice del ciclo e il numero stesso
         */
        /*
         Scrivere un programma che:
            - Crei un array di stringhe di dimensione arbitraria
            - Popoli completamente l'array di stringhe qualsiasi
            - Tramite un ciclo stampi tutte le stringhe e le relative versioni al contrario (in reverse)
         */
        /*
         Scrivere un programma che:
            - Chieda all'utente un numero intero
            - Generi una stringa di lunghezza pari al numero comporta di caratteri casuali
         */
        /*
         Scrivere un programma che:
            - Dato un testo preso da file, lo codifichi tramite un algoritmo qualsiasi
            - Dato il testo cifrato, permetta anche di decifrarlo
         */
        /*
         Scrivere un programma che:
            - Chieda all'utente 5 stringhe
            - Crei un array con i caratteri iniziali di ciascuna delle 5 stringhe
            - Crei una lista con il resto delle 5 stringhe esclusi i caratteri iniziali
            - Tramite un ciclo for stampi il contenuto dell'array e della lista di modo che
            le stringhe vengano stampate correttamente come inserite dall'utente e nell'ordine corretto
         */

        //20210121
        /*
         Scrivere un programma che:
            - chieda all'utente una stringa
            - stampi su schermo la stringa al contrario
            - tramite un ciclo stampi i numeri da 0 fino alla lunghezza della stringa
            inserita dall'utente
         */
        /*
         Scrivere un programma che:
            - chieda all'utente 3 numeri
            - stampi su schermo i 3 numeri in ordine crescente
            - stampi su schermo solo i numeri pari tra i 3
         */
        /*
         Scrivere un programma che:
            - chieda all'utente il suo nome
            - tramite una funzione stampi su schermo il nome dell'utente anagrammato
         */
        /*
        !! SPOILER !!

         Console.WriteLine("Inserisci il tuo nome");
            string nome = Console.ReadLine();

            string anagramma = string.Empty;

            List<char> chars = nome.ToList();

            Random r = new Random();
            while (chars.Count > 0)
            {
                char estratto = chars[r.Next(0, chars.Count)];
                anagramma += estratto;
                chars.Remove(estratto);
            }
            Console.WriteLine(anagramma);
            Console.ReadKey();
         */

        /*
         Scrivere un programma che:
            - chieda all'utente 3 numeri (a,b,c)
            - calcoli altri 3 numeri (x,y,z), di modo che le moltiplicazioni a*x, b*y e c*z
            abbiano lo stesso risultato
         */
        /*
         !! SPOILER !!
            Console.WriteLine("Inserisci a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci c");
            int c = int.Parse(Console.ReadLine());

            int x = b * c;
            int y = a * c;
            int z = a * b;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.ReadKey();         
         */
        /*
         Scrivere un programma che:
            - chieda all'utente una stringa
            - stampi su schermo la stringa in minuscolo
            - stampi su schermo la stringa in maiuscolo
            - nel caso la stringa abbia un numero di caratteri dispari,
            stampi su schermo il carattere centrale
         */
        /*
         Scrivere un programma che:
            - chieda all'utente di scegliere un colore fra 3 opzioni
            - tramite una funzione setti il colore del testo della console
            a quello scelto dall'utente
         */





        //20210118
        /*
         Scrivere un programma che:
            - chieda all'utente una stringa
            - stampi su schermo la lunghezza della stringa
            - chieda all'utente una seconda stringa
            - stampi su schermo la somma della lunghezza della prima e della lunghezza
            della seconda
         */
        /*
         Scrivere un programma che:
            - dati 2 numeri:
                - tramite una funzione scriva la somma fra i tre numeri
                - tramite una seconda funzione scriva su schermo 
                prima il maggiore e poi il minore
        */
        /*
         Scrivere un programma che:
            - chieda all'utente il lato di un quadrato
            - tramite una funzione stampi su schermo l'area del quadrato
            - tramite una seconda funzione stampi su schermo il perimetro del quadrato
        */
        /*
         Scrivere un programma che:
            - tramite una funzione randomizzi due numeri
            - sommi i due numeri e stampi su schermo il risultato
        */
        /*
         Scrivere un programma che:
            - chieda all'utente nome e cognome
            - tramite una funzione scriva su schermo nome e cognome dell'utente
            - chieda all'utente un numero
            - generi un numero casuale
            - nel caso il numero dell'utente sia maggiore del numero casuale:
                - scriva su schermo "Hai vinto"
            - nel caso il numero dell'utente sia minore del numero casuale:
                - scriva su schermo "Hai perso"
        */
        /*
         Scrivere un programma che:
            - chieda all'utente una stringa
            - tramite una funzione stampi su schermo la stringa scritta in maiuscolo
            - tramite una seconda funzione stampi su schermo la stringa scritta in minuscolo
        */
        static void Main(string[] args)
        {
        }
    }
}
