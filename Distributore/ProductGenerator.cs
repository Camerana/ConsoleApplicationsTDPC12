using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationsTDPC12.Distributore
{
    public static class ProductGenerator
    {
        public static List<Prodotto> GetRandomProducts(int maxProductNumber)
        {
            List<Prodotto> prodotti = new List<Prodotto>();
            Random r = new Random();
            for (int i = 0; i < maxProductNumber; i++)
            {
                //se il prodotto deve esistere
                if (r.Next(0, 2) == 1)
                {
                    //se il prodotto è uno snack
                    if (r.Next(0, 2) == 1)
                    {
                        Snack s = new Snack();
                        s.Tipo = "Snack";
                        s.Costo = r.Next(1, 3);
                        s.Peso = r.Next(100, 250);
                        prodotti.Add(s);
                    }
                    //se il prodotto è una bevanda
                    else
                    {
                        Bevanda b = new Bevanda();
                        b.Tipo = "Bevanda";
                        b.Costo = r.Next(1, 3);
                        b.Volume = r.Next(33, 50);
                        prodotti.Add(b);
                    }
                }
            }
            return prodotti;
        }
    }
}
