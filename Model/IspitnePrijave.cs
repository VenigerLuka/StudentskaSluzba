using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba.Model
{
    public class IspitnePrijave
    {
        public int StudentId { get; set; }
        public int PredmetId { get; set; }
        public int RokId { get; set; }
        public int Teorija { get; set; }
        public IspitnePrijave()
        {
            
        }

        public IspitnePrijave(int studentId, int predmetId, int rokId, int teorija)
        {
            StudentId = studentId;
            PredmetId = predmetId;
            RokId = rokId;
            Teorija = teorija;
        }
    }
}
