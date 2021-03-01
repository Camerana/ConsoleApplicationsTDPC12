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
        static void Main(string[] args)
        {
            Moto m = new Moto();
            m.LunghezzaCavalletto = 10;
            m.Cilindrata = 1500;



            Auto a = new Auto();
            a.DiametroVolante = 30;
            a.Cilindrata = 2000;

        }
    }
}
