using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba.Model
{
    public class IspitnePrijave
    {
        public int Id { get; set; }
        public int Teorija { get; set; }
        public int Zadaci { get; set; }
        public Student Student { get; set; }
        public IspitniRokovi Rok { get; set; }
        public Predmet Predmet { get; set; }
        //Lista koja sadrzi informacije o bodovima nakon zavrsetka ispitnog roka.
        public List<IspitniRokovi> Predmeti { get; set; }
        public IspitnePrijave()
        {
            Rok = new IspitniRokovi();
            this.Student = new Student();
            this.Predmet = new Predmet();
            Predmeti = new List<IspitniRokovi>();
        }

        public IspitnePrijave(int teorija, int zadaci, Student student, IspitniRokovi rok, Predmet predmet)
        {
            Teorija = teorija;
            Zadaci = zadaci;
            Student = student;
            Rok = rok;
            Predmet = predmet;
            Predmeti = new List<IspitniRokovi>();

        }

        public IspitnePrijave(int teorija, int zadaci, Student student, IspitniRokovi rok, Predmet predmet, List<IspitniRokovi> predmeti)
        {
            Teorija = teorija;
            Zadaci = zadaci;
            Student = student;
            Rok = rok;
            Predmet = predmet;
            Predmeti = predmeti;
        }


        public override string ToString()
        {
            return $"U {Rok} ispitnom roku {Student.Ime} {Student.Prezime} je ostvario sledece rezultate iz predmeta {Predmet}:\n\tTeorija: " +
                $"{Teorija}\n\t{Zadaci}";
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is IspitnePrijave)
            {
                IspitnePrijave query = (IspitnePrijave)obj;
                if (Id == query.Id) return true;
            }
            return false;
        }
    }
}
