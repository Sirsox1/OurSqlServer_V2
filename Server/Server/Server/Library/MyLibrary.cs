using System;
using System.Data.SqlClient;

namespace Server.Library
{
    class MyLibrary
    {

        public static string Decode(string myquery, string portname)
        {
            // Array che conterrà il risultato della query
            string[,] resultquery = new string[0, 0];
            string[] parts = new string[0];
            string txtErrorReport = "";

            // Questo parte è da modifica inserendo la stringa di query dal client
            //txtquery = "USE ISII SELECT * FROM Insegnanti";
            //myquery = txtquery;

            //Se la stringa contenente la query non è vuota, la divide in parti
            if (myquery != "")
            {
                //Serve per catturare il nome del database sul quale scateno la query
                parts = myquery.Split(' ');
            }
            else
            {
                txtErrorReport = "Query non trovata!";
            }

            try
            {
                // Se la stringa contenente la query non è vuota prosegue
                if (myquery != "")
                {

                    /* Stringa che mi permette di conettermi al server sul quale è possibile interagire con i DB. 
                    In altre parole è l'istanza di MySql sulla quale ho memorizzato i DB. */
                    string connectionString = "Server=C215-025\\MSSQL14.MSSQLSERVER;Database=" + parts[1] + ";" + "Trusted_Connection=True;MultipleActiveResultSets=true;";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {

                        // Per poter eseguire il comando Sql, passo la query e la stringa di connessione
                        SqlCommand command = new SqlCommand(myquery, connection);
                        // Apro la connessione
                        connection.Open();

                        // Ottengo il numero dei record affetti
                        SqlDataReader countreader = command.ExecuteReader();
                        int rowcount = 0;

                        if (countreader.HasRows)
                        {
                            while (countreader.Read())
                            {
                                rowcount++;
                            }
                        }
                        countreader.Close();


                        // Ottengo i valori della query eseguita, il risultato è memorizzato in un array 2D
                        SqlDataReader reader = command.ExecuteReader();
                        string[,] myresult = new string[rowcount, reader.FieldCount];
                        int cont = 0;
                        try
                        {
                            while (reader.Read())
                            {
                                for (int j = 0; j < myresult.GetLength(1); j++)
                                    myresult[cont, j] = reader.GetValue(j).ToString();

                                cont++;
                            }
                        }
                        finally
                        {
                            reader.Close();
                        }
                        resultquery = myresult;
                    }
                }


            }
            catch (Exception ex)
            {

                // Gestione delle eccezioni che si scatenano quando stacco il cavo con app running / cerco di accedere alla porta quando un'altra app la sta usando
                if (ex is System.IO.IOException)
                {
                    txtErrorReport = "Errore fatale, si è persa la connessione con la porta : " + portname;
                    return txtErrorReport;
                }
                else if (ex is UnauthorizedAccessException)
                {
                    txtErrorReport = "Errore, la porta : " + portname + " è usata da un'altra applicazione!";
                    return txtErrorReport;
                }
                else if (parts[1] != "ISII" && parts[1] != "TRAMELLO")
                {
                    txtErrorReport = "Errore sintassi, controllare il database scelto!";
                    return txtErrorReport;
                }
                else
                {
                    return ex.Message;
                }
            }

            string response = "";

            for (int i = 0; i < resultquery.GetLength(0); i++)
            {
                for (int j = 0; j < resultquery.GetLength(1); j++)
                {
                    response += resultquery[i, j];
                }
                response += "\r\t";
            }
            return response;
        }
    }
}
