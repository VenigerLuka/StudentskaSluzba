using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba.Model
{
    public class IspitniRokovi
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public DateTime Pocetak { get; set; }
        public DateTime Kraj { get; set; }
        public List<IspitnePrijave> Prijave { get; set; }
        public IspitniRokovi()
        {

        }

        public IspitniRokovi(int id, string naziv, DateTime pocetak, DateTime kraj)
        {
            Id = id;
            Naziv = naziv;
            Pocetak = pocetak;
            Kraj = kraj;
        }

        public IspitniRokovi(int id, string naziv, DateTime pocetak, DateTime kraj, List<IspitnePrijave> prijave)
        {
            Id = id;
            Naziv = naziv;
            Pocetak = pocetak;
            Kraj = kraj;
            Prijave = prijave;
        }

        public override string ToString()
        {
            return $"{Naziv} ispitni rok";
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is IspitniRokovi)
            {
                IspitniRokovi query = (IspitniRokovi)obj;
                if (Id == query.Id || Naziv == query.Naziv) return true;
            }
            return false;
        }
    }
}
