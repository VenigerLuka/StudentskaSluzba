using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba.Model
{
    internal class Predaje
    {
        public int NastavnikId { get; set; }
        public int PredmetId { get; set; }
        public Predaje()
        {
            
        }

        public Predaje(int nastavnikId, int predmetId)
        {
            NastavnikId = nastavnikId;
            PredmetId = predmetId;
        }
    }
}
