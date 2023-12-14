using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba.Model
{
    public class Predmet
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public Predmet()
        {
            
        }

        public Predmet(int id, string naziv)
        {
            Id = id;
            Naziv = naziv;
        }

        public void Ispis()
        {
            Console.WriteLine($"Id:{Id}\nNaziv predmeta:{Naziv}");
        }
    }
}
