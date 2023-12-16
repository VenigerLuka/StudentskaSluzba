using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba.Model
{
    public class Nastavnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime{ get; set; }
        public string Zvanje { get; set; }
        public List<Predmet> Predmeti { get; set; }
        public Nastavnik()
        {
            Predmeti = new List<Predmet>();
        }
        public Nastavnik(int id, string ime, string prezime, string zvanje)
        {
            Id = id;
            Ime = ime;
            Prezime = prezime;
            Zvanje = zvanje;
            Predmeti = new List<Predmet>();
        }

        public Nastavnik(int id, string ime, string prezime, string zvanje, List<Predmet> predmeti)
        {
            Id = id;
            Ime = ime;
            Prezime = prezime;
            Zvanje = zvanje;
            Predmeti = predmeti;
        }

        public override string ToString()
        {
            string predmeti = "";
            foreach (Predmet predmet in Predmeti)
            {
                predmeti += "\n\t" + predmet.ToString()  ;
            }

            return $"Ime:{Ime}\nPrezime: {Prezime}\nZvanje: {Zvanje}\nProfesor predaje predmete:{predmeti}";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
