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
		 * Termine: 19.30
		 Scrivere un programma che:
			- Data una funzione per stampare una stringa passata come parametro in ingresso,
			chiami la suddetta funzione un numero n di volte scelto dall'utente
		 */
		static void Main(string[] args)
		{
			for (int i = 0; i < 10; i++)
			{
				Eseguimi(i);
			}
			Console.ReadKey();
		}

		static void Eseguimi(int i)
		{
			Console.WriteLine("Ciao " + i);
		}
	}
}