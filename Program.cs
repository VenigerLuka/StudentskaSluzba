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

            Console.ReadKey();
        
        }


    }
}
