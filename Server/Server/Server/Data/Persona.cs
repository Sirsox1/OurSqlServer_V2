using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurSqlServer.Data
{
    abstract class Persona
    {

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string NTelefono { get; set; }

        protected Persona(string n, string c, string nT)
        {
            Nome = n;
            Cognome = c;
            NTelefono = nT;
        }
        protected Persona()
        {
            Nome = "";
            Cognome = "";
            NTelefono = "0000000000";
        }
    }
}
