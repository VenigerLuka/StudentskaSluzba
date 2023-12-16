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
        public List<Nastavnik> Nastavnici { get; set; }
        public Predmet()
        {
            Nastavnici = new List<Nastavnik>();
        }

        public Predmet(int id, string naziv)
        {
            Id = id;
            Naziv = naziv;
            Nastavnici = new List<Nastavnik>();
        }

        public Predmet(int id, string naziv, List<Nastavnik> nastavnici)
        {
            Id = id;
            Naziv = naziv;
            Nastavnici = nastavnici;
        }

        public void Ispis()
        {
            string predaju = "";
            foreach (var nastavnik in Nastavnici)
            {
                predaju +="\n\t" + nastavnik.Ime + " " + nastavnik.Prezime;
            }
            Console.WriteLine($"Id:{Id}\nNaziv predmeta:{Naziv}\n Predavaci:{predaju}");
        }
        
        public override string ToString()
        {
            return $"{Naziv}";
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Predmet)
            {
                Predmet query = (Predmet)obj;
                if (Id == query.Id || Naziv == query.Naziv) return true;
            }
            return false;
        }
    }
}
