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
            Student student = new Student(1, "Mh50/2018", "Luka", "Veniger", "Sombor");
            //student.Ispis();
            
            Console.WriteLine();

            Predmet predmet = new Predmet(1, "Mehanika Fluida");
            Predmet predmet1 = new Predmet(2, "Mehanika");

            List<Predmet> predmeti = new List<Predmet>();
            predmeti.Add(predmet);
            predmeti.Add(predmet1);
            predmet.Studenti.Add(student);

            Console.WriteLine();

            Student student2 = new Student(2, "Mh51/2018", "Aleksa", "Tirnanic", "Beograd", predmeti);
            predmet.Studenti.Add(student2);
            //student2.Ispis();
            
            predmet.Ispis();


            Console.ReadKey();

        }


    }
}
