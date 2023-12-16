using StudentskaSluzba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(1,"Mh50/2018","Luka","Veniger","Sombor");
            student.Ispis();
            Console.WriteLine();
            Predmet predmet = new Predmet(1, "Mehanika Fluida");
            Predmet predmet1 = new Predmet(2, "Mehanika");


            predmet.Ispis();
            Console.WriteLine("---------------------------------");
            Nastavnik nastavnik1 = new Nastavnik(1,"Marko","Markovic","Dr.Operativnih sistema");
            Predmet operativniSistemi = new Predmet(3, "Operativni Sistemi");
            Predmet grafika = new Predmet(4, "Grafika");
            nastavnik1.Predmeti.Add(operativniSistemi);
            nastavnik1.Predmeti.Add(grafika);
            Console.WriteLine(nastavnik1);
            grafika.Nastavnici.Add(nastavnik1 );
            operativniSistemi.Nastavnici.Add(nastavnik1);
            IspitniRokovi januarski = new IspitniRokovi(1, "Januarski", Convert.ToDateTime("2024-01-09"), Convert.ToDateTime("2024-01-16"));
            IspitnePrijave grafikaJanuar = new IspitnePrijave();
            grafikaJanuar.Rok = januarski;
            grafikaJanuar.Predmet = grafika;
            grafikaJanuar.Student = student;


            //da je u pitanju prava studentska sluzba implementirao bih proveru kraja ispitnog roka, i forsirao bih nastavnika da upise bodove
            //pa bi onda student imao mogucnost da pristupi januarskoj prijavi ispita da proveri svoje rezultate pa iz tog razloga
            //ispisujem prijavu a ne rok
            grafikaJanuar.Teorija = 31;
            grafikaJanuar.Zadaci = 47;
            januarski.Prijave.Add(grafikaJanuar);
            grafikaJanuar.Predmeti.Add(januarski);
            Console.WriteLine(januarski);

            Console.ReadKey();
        
        }


    }
}
