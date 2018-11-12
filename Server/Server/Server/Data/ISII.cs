using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurSqlServer.Data
{
    class ISII
    {
        //private List<List<Persona>> Listaaa = new List<List<!>>();

        public List<Studenti> Studenti { get; set; }
        public List<Insegnanti> Insegnanti { get; set; }


        public ISII()
        {
            this.Studenti = new List<Studenti>();
            this.Insegnanti = new List<Insegnanti>();
        }

        public ISII(List<Studenti> stud, List<Insegnanti> ins)
        {
            Studenti = stud;
            Insegnanti = ins;
        }

    }

}
