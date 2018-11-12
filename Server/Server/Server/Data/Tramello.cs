using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurSqlServer.Data
{
    class Tramello
    {

        public List<Studenti> Studenti { get; set; }
        public List<Insegnanti> Insegnanti { get; set; }


        public Tramello()
        {
            this.Studenti = new List<Studenti>();
            this.Insegnanti = new List<Insegnanti>();
        }

        public Tramello(List<Studenti> stud, List<Insegnanti> ins)
        {
            Studenti = stud;
            Insegnanti = ins;
        }
    }
}
