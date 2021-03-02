using ConsoleApplicationsTDPC12.Animali;
using ConsoleApplicationsTDPC12.Mobili;
using ConsoleApplicationsTDPC12.Visibilita;
using LibreriaEsterna;
using System;
using System.Collections.Generic;

namespace ConsoleApplicationsTDPC12
{
    class Program
    {
        /*
         * Termine: 20.30
         Scrivere un programma che:
            - Abbia le seguenti classi:
                - Mobile con proprietà a scelta
                - Sedia con proprietà a scelta e che eredita da Mobile
                - Armadio con proprietà a scelta e che eredita da Mobile
            - Chieda all'utente quale tipo di oggetto istanziare tra Sedia e Armadio
            - Crei un oggetto del tipo scelto, valorizzandolo
            - Stampare su schermo i dati dell'oggetto
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Quale oggetto vuoi creare ?");
            Console.WriteLine("1 = Sedia");
            Console.WriteLine("2 = Armadio");

            string scelta = Console.ReadLine();

            Mobile m = null;
            if (scelta == "1")
            {
                m = new Sedia();
                m.Materiale = "Legno";
                ((Sedia)m).Braccioli = true;
            }
            else if (scelta == "2")
            {
                m = new Armadio();
                m.Materiale = "Legno";
                ((Armadio)m).Capienza = 5;
            }
            if (m != null)
                m.Stampa();
        }
        /*
         Scrivere un programma che:
            - Abbia le seguenti classi:
                - Animale con proprietà a scelta
                - Cane con proprietà a scelta e che eredita da Animale
                - Ragno con proprietà a scelta e che eredita da Animale
            - Crei e valorizzi 2 oggetti di tipo Cane
            - Crei e valorizzi 2 oggetti di tipo Ragno
            - Stampi su schermo le proprietà degli oggetti
         */
        /*
        static void Main(string[] args)
        {
            List<Animale> animali = new List<Animale>();
            for (int i = 0; i < 2; i++)
            {
                Cane c = new Cane();
                c.Colore = "Nero";
                c.TipoPelo = "Lungo";
                animali.Add(c);

                Ragno r = new Ragno();
                r.Colore = "Marrone";
                r.IsVelenoso = true;
                animali.Add(r);
            }
            foreach (Animale a in animali)
            {
                a.Stampa();
            }
        }
        */
        /*
         Scrivere un programma che:
            - Abbia le seguenti classi:
                - Veicolo
                    - con property int Cilindrata
                - Auto
                    - con property int DiametroVolante
                - Moto
                    - con property int LunghezzaCavalletto
                - Treno
            - Crei e valorizzi 1 oggetto di tipo Moto
            - Crei e valorizzi 1 oggetto di tipo Auto
            - Crei e valorizzi 1 oggetto di tipo Treno
            - Stampi su schermo le loro proprietà         
         */
        /*
        static void Main(string[] args)
        {
            List<Veicolo> veicoli = new List<Veicolo>();
            Random r = new Random();

            Moto m = new Moto();
            m.Cilindrata = r.Next(1000, 2000);
            m.LunghezzaCavalletto = r.Next(35, 45);
            veicoli.Add(m);

            Auto a = new Auto();
            a.Cilindrata = r.Next(1000, 2000);
            a.DiametroVolante = r.Next(30, 40);
            veicoli.Add(a);

            Treno t = new Treno();
            t.Cilindrata = 50000;
            veicoli.Add(t);

            foreach (Veicolo v in veicoli)
                v.Stampa();

            Console.ReadKey();
        }
        */
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
