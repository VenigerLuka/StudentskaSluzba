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
        public void Ispis()
        {
            Console.WriteLine($"Id: {Id}\nIndeks: {Indeks}\nIme: {Ime}\nPrezime:{Prezime}\nGrad:{Grad}");
            foreach(var predmet in Predmeti)
            {
                predmet.Ispis();
            }
        }
    }
}
