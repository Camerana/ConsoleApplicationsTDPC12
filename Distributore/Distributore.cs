using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12.Distributore
{
    public class Distributore
    {
        public List<Prodotto> Prodotti { get; set; } = new List<Prodotto>();

        public Distributore()
        {
            FillProdotti();
        }
        public void FillProdotti()
        {
            Prodotti = ProductGenerator.GetRandomProducts(5);
        }
        public void PrintProdotti()
        {
            for (int i = 0; i < this.Prodotti.Count; i++)
            {
                Console.WriteLine("Digita " + i + " per:");
                this.Prodotti[i].PrintProdotto();
                Console.WriteLine();
            }
        }
        public void BuyProdotto(int scelta, Cliente cliente)
        {
            if (scelta >= 0 && this.Prodotti.Count > scelta)
            {
                Prodotto p = this.Prodotti[scelta];
                if (p.Costo <= cliente.Soldi)
                {
                    Console.WriteLine("Acquisto riuscito");
                    cliente.Soldi = cliente.Soldi - p.Costo;
                    this.Prodotti.Remove(p);
                }
                else
                {
                    Console.WriteLine("Soldi non sufficienti");
                }
            }
        }
    }
}