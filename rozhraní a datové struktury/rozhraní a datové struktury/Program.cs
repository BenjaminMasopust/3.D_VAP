using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rozhraní_a_datové_struktury
{
    class Program
    {
        public static IBook BetterBook(IBook book1, IBook book2)
        {
            if (book1.GetValue() > book2.GetValue())
            {
                return book1;
            }
            else if (book2.GetValue() > book1.GetValue())
            {
                return book2;
            }
            else
            {
                return book1;
            }
        }

        static void Main(string[] args)
        {
            FantasyBook fantasyBook = new FantasyBook("Kniha1", "Autor1", 15);
            ScifiBook scifiBook = new ScifiBook("Kniha2", "Autor2", 20, 450);
            DetectiveBook detectiveBook = new DetectiveBook("Kniha3", "Autor3", 16, 4);

            List<IBook> books = new List<IBook>
            {
                fantasyBook,
                scifiBook,
                detectiveBook
            };

            IBook bestBook = books[0];
            foreach (var book in books)
            {
                bestBook = BetterBook(bestBook, book);
            }

            Console.WriteLine($"Nejlepší kniha je: {bestBook.GetType().Name}, Název: {((dynamic)bestBook).Název}");
        }
    }

    public interface IBook { double GetValue(); }

    public class FantasyBook : IBook
    {
        public string Název;
        public string Autor;
        public double Cena;

        public FantasyBook(string název, string autor, double cena)
        {
            Název = název;
            Autor = autor;
            Cena = cena;
        }
        public double GetValue()
        {
            return Cena;
        }
    }

    public class ScifiBook : IBook
    {
        public string Název;
        public string Autor;
        public double Cena;
        public int Počet_Stran;

        public ScifiBook(string název, string autor, double cena, int počet_stran)
        {
            Název = název;
            Autor = autor;
            Cena = cena;
            Počet_Stran = počet_stran;
        }
        public double GetValue()
        {
            return Cena + (Počet_Stran / 100) * 10;
        }
    }

    public class DetectiveBook : IBook
    {
        public string Název;
        public string Autor;
        public double Cena;
        public int Počet_Obětí;

        public DetectiveBook(string název, string autor, double cena, int počet_obětí)
        {
            Název = název;
            Autor = autor;
            Cena = cena;
            Počet_Obětí = počet_obětí;
        }
        public double GetValue()
        {
            return Cena + Počet_Obětí * 20;
        }
    }
}