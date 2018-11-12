using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Library {
    class MyLibrary {
        public static string[] Decodifica(string Query) //Andrea 20181109: Metodo di decodifica della query con split. Clausole where other da implementare successivamente
        {
            string Use, Select, From/*, Where, Other*/;

            Query = Query.ToLower();
            if (!(Query.Contains("use") && Query.Contains("select") && Query.Contains("from")))
                return null;

            int Clausola_S = Query.IndexOf("select");
            int Clausola_F = Query.IndexOf("from");

            Use = Query.Substring(3, Clausola_S - 3);
            Select = Query.Substring(Clausola_S + 6, (Clausola_F - (Clausola_S + 6)));
            From = Query.Substring(Clausola_F + 5);

            string[] Split_Query = { Use, Select, From };

            return Split_Query;
        }

        public static void SQL_Engine(string[] parameters) {
            //  metodo per restituzione dei record
        }
    }
}
