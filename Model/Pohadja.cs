using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba.Model
{
    public class Pohadja
    {
        public int StudentId { get; set; }
        public int PredmetId { get; set; }
        public Pohadja()
        {
            
        }

        public Pohadja(int studentId, int predmetId)
        {
            StudentId = studentId;
            PredmetId = predmetId;
        }
    }
}
