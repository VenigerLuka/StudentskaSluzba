using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba.Model
{
    public class Student
    {

        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Grad { get; set; }
        public List<Predmet> Predmeti { get; set; }

        public Student()
        {
            Predmeti = new List<Predmet>();
        }
        public Student(int id, string indeks, string ime, string prezime, string grad)
        {
            Id = id;
            Indeks = indeks;
            Ime = ime;
            Prezime = prezime;
            Grad = grad;
            Predmeti = new List<Predmet>();

        }

        public Student(int id, string indeks, string ime, string prezime, string grad, List<Predmet> predmeti) : this(id, indeks, ime, prezime, grad)
        {

            Predmeti = predmeti;
        }




        public void Ispis()
        {
            Console.WriteLine($"Id: {Id}\nIndeks: {Indeks}\nIme: {Ime}\nPrezime:{Prezime}\nGrad:{Grad}");
            foreach (var predmet in Predmeti)
            {
                predmet.Ispis();
            }
        }
        public void IspisBezPredmeta()
        {
            Console.WriteLine($"\tId: {Id}\n\tIndeks: {Indeks}\n\tIme: {Ime}\n\tPrezime:{Prezime}\n\tGrad:{Grad}");
        }

        public override string ToString()
        {
            return $"Id: {Id}\nIndeks: {Indeks}\nIme: {Ime}\nPrezime:{Prezime}\nGrad:{Grad}";
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Student)
            {
                Student query = (Student)obj;
                if (query.Id == Id || query.Indeks == Indeks)
                {
                    return true ;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
