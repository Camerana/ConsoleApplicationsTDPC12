namespace ConsoleApplicationsTDPC12.Libreria
{
    public class Libro
    {
        public string Autore { get; set; }
        public string Titolo { get; set; }
        public Libro(string autore, string titolo)
        {
            this.Autore = autore;
            this.Titolo = titolo;
        }
    }
}