using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApplicationsTDPC12.Rubrica
{
    public class Rubrica
    {
        public List<Contatto> Contatti = new List<Contatto>();

        public Rubrica()
        {
            if (File.Exists("Rubrica.txt"))
            {
                string[] contatti = File.ReadAllLines("Rubrica.txt");
                for (int i = 0; i < contatti.Length; i++)
                {
                    string[] splits = contatti[i].Split('|');
                    Contatto contatto = new Contatto();
                    contatto.Nome = splits[0];
                    contatto.Cognome = splits[1];
                    contatto.NumeroDiTelefono = splits[2];
                    this.Contatti.Add(contatto);
                }
            }
        }
        public void PrintContatti()
        {
            for (int i = 0; i < Contatti.Count; i++)
                Console.WriteLine(Contatti[i].Nome + " " + Contatti[i].Cognome + " " + Contatti[i].NumeroDiTelefono);
            Console.WriteLine();
        }
        public void InsertContatto()
        {
            Contatto contatto = new Contatto();
            Console.WriteLine("Inserisci il Nome");
            contatto.Nome = Console.ReadLine();
            Console.WriteLine("Inserisci il Cognome");
            contatto.Cognome = Console.ReadLine();
            Console.WriteLine("Inserisci il Numero di Telefono");
            contatto.NumeroDiTelefono = Console.ReadLine();
            SaveContatto(contatto);
            Console.WriteLine();
        }
        public void SaveContatto(Contatto contatto)
        {
            try
            {
                string text = File.ReadAllText("Rubrica.txt");

                string contattoString = contatto.Nome + "|" + contatto.Cognome + "|" + contatto.NumeroDiTelefono + "\n";
                if (!text.EndsWith("\n"))
                    contattoString = "\n" + contattoString;

                File.AppendAllText("Rubrica.txt", contattoString);
                this.Contatti.Add(contatto);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void PrintContattiForDelete()
        {
            Console.WriteLine("Scegli quale contatto cancellare");
            for (int i = 0; i < Contatti.Count; i++)
                Console.WriteLine(i + " = " + Contatti[i].Nome + " " + Contatti[i].Cognome + " " + Contatti[i].NumeroDiTelefono);
            string daCancellare = Console.ReadLine();
            try
            {
                int indiceDaRimuovere = int.Parse(daCancellare);
                Contatto contatto = this.Contatti[indiceDaRimuovere];
                this.Contatti.Remove(contatto);
                string[] contattiSuFile = File.ReadAllLines("Rubrica.txt");

                contattiSuFile[indiceDaRimuovere] = string.Empty;

                List<string> newContatti = new List<string>();
                for (int i = 0; i < contattiSuFile.Length; i++)
                    if (!string.IsNullOrEmpty(contattiSuFile[i]))
                        newContatti.Add(contattiSuFile[i]);

                //pericoloso !
                File.Delete("Rubrica.txt");
                File.AppendAllLines("Rubrica.txt", newContatti);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void PrintContattiForUpdate()
        {
            Console.WriteLine("Scegli quale contatto modificare");
            for (int i = 0; i < Contatti.Count; i++)
                Console.WriteLine(i + " = " + Contatti[i].Nome + " " + Contatti[i].Cognome + " " + Contatti[i].NumeroDiTelefono);
            string daModificare = Console.ReadLine();
            try
            {
                int indiceDaModificare = int.Parse(daModificare);
                Contatto contatto = this.Contatti[indiceDaModificare];

                Console.WriteLine("Inserisci il nuovo nome");
                contatto.Nome = Console.ReadLine();
                Console.WriteLine("Inserisci il nuovo cognome");
                contatto.Cognome = Console.ReadLine();
                Console.WriteLine("Inserisci il nuovo numero di telefono");
                contatto.NumeroDiTelefono = Console.ReadLine();

                string[] contattiSuFile = File.ReadAllLines("Rubrica.txt");

                contattiSuFile[indiceDaModificare] = contatto.Nome + "|" + contatto.Cognome + "|" + contatto.NumeroDiTelefono;

                //pericoloso !
                File.Delete("Rubrica.txt");
                File.AppendAllLines("Rubrica.txt", contattiSuFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}