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
        public List<Student> Studenti { get; set; }
        
        
        public Predmet()
        {
            Studenti = new List<Student>();
        }

        public Predmet(int id, string naziv)
        {
            Id = id;
            Naziv = naziv;
            Studenti = new List<Student>();
        }

        public Predmet(int id, string naziv, List<Student> studenti)
        {
            Id = id;
            Naziv = naziv;
            Studenti = studenti;
        }

        public void Ispis()
        {
            Console.WriteLine($"Id:{Id}\nNaziv predmeta:{Naziv}");
            Console.WriteLine($"Studenti na predmetu:");
            foreach (var student in Studenti) {
                student.IspisBezPredmeta();
                Console.WriteLine();
            }
        }
        public override bool Equals(object obj)
        {
            if (obj != null && obj is Predmet)
            {
                Predmet query = (Predmet)obj;
                if (query.Id == Id || query.Naziv == Naziv)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
