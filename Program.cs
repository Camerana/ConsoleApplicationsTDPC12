using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        /*
         Scrivere un programma che:
            - Abbia le seguenti classi:
                - Veicolo
                    - con property int Cilindrata
                - Auto
                    - con property int DiametroVolante
                - Moto
                    - con property int LunghezzaCavalletto
            - Crei e valorizzi 10 oggetti di tipo Moto
            - Crei e valorizzi 10 oggetti di tipo Auto
            - Stampi su schermo le loro proprietà         
         */
        /*
        static void Main(string[] args)
        {
            List<Veicolo> veicoli = new List<Veicolo>();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                Moto m = new Moto();
                m.Cilindrata = r.Next(1000, 2000);
                m.LunghezzaCavalletto = r.Next(35, 45);
                veicoli.Add(m);

                Auto a = new Auto();
                a.Cilindrata = r.Next(1000, 2000);
                a.DiametroVolante = r.Next(30, 40);
                veicoli.Add(a);
            }
            foreach (Veicolo v in veicoli)
            {
                if (v.GetType() == typeof(Moto))
                {
                    Console.WriteLine("Cilindrata: " + v.Cilindrata + ", Cavalletto: " + ((Moto)v).LunghezzaCavalletto);
                }
                else if (v.GetType() == typeof(Auto))
                {
                    Console.WriteLine("Cilindrata: " + v.Cilindrata + ", Volante: " + ((Auto)v).DiametroVolante);
                }
            }
            Console.ReadKey();
        }
        */
    }
}
