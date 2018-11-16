using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OurSqlServer.Data;
using System.IO;
using System.Data.SqlClient;
using System.Collections;

namespace Server {
    public partial class frmServer : Form {

        // Array che conterrà il risultato della query
        string[,] resultquery = new string[0, 0];
        // Stringa che conterrà la query
        string myquery = "";

        string[] parts = new string[0];

        public frmServer() {
            InitializeComponent();
        }

        private void frmServer_Load(object sender, EventArgs e) {


            tmrTimer.Start();

            // Questo parte è da modifica inserendo la stringa di query dal client
            txtQuery.Text = "USE rwe SELECT Nome FROM Insegnanti";
            myquery = txtQuery.Text;

            //Se la stringa contenente la query non è vuota, la divide in parti
            if (txtQuery.Text != "") {
                //Serve per catturare il nome del database sul quale scateno la query
                parts = myquery.Split(' ');
            } else {
                MessageBox.Show("Error 9, query not found!");
            }

        }

        private void txtQuery_TextChanged(object sender, EventArgs e) {

        }

        private void tmrTimer_Tick(object sender, EventArgs e) {


        }

        private void button1_Click(object sender, EventArgs e) {

            try {
                // Se la stringa contenente la query non è vuota prosegue
                if (myquery != "") {

                    /* Stringa che mi permette di conettermi al server sul quale è possibile interagire con i DB. 
                    In altre parole è l'istanza di MySql sulla quale ho memorizzato i DB. */
                    string connectionString = "Server=DESKTOP-BOGNLK2\\FLORINMOCANU;Database=" + parts[1] + ";" + "Trusted_Connection=True;MultipleActiveResultSets=true;";

                    using (SqlConnection connection = new SqlConnection(connectionString)) {

                        // Per poter eseguire il comando Sql, passo la query e la stringa di connessione
                        SqlCommand command = new SqlCommand(myquery, connection);
                        //command.Parameters.AddWithValue("@tPatSName", "Your-Parm-Value");
                        // Apro la connessione
                        connection.Open();

                        // Ottengo il numero dei record affetti
                        SqlDataReader countreader = command.ExecuteReader();
                        int rowcount = 0;

                        if (countreader.HasRows) {
                            while (countreader.Read()) {
                                rowcount++;
                            }
                        }
                        countreader.Close();


                        // Ottengo i valori della query eseguita, il risultato è memorizzato in un array 2D
                        SqlDataReader reader = command.ExecuteReader();
                        string[,] myresult = new string[rowcount, reader.FieldCount];
                        int cont = 0;
                        try {
                            while (reader.Read()) {

                                for (int j = 0; j < myresult.GetLength(1); j++) {

                                    myresult[cont, j] = reader.GetValue(j).ToString();
                                }

                                cont++;

                            }
                        } finally {
                            reader.Close();
                        }
                        resultquery = myresult;


                    }
                } else
                    MessageBox.Show("Errore fatale, query non trovata!");
            } catch {
                if (parts[1] != "ISII" && parts[1] != "TRAMELLO")
                    MessageBox.Show("Errore sintassi, controllare il database scelto!");
                else
                    MessageBox.Show("Errore sintassi SQL, controllare la query!");
            } finally {

            }

        }

        private void button2_Click(object sender, EventArgs e) {


            // In mancanza di RS232 questo button mi serviva per vedere se fungeva il tutto
            for (int i = 0; i < resultquery.GetLength(0); i++) {

                for (int j = 0; j < resultquery.GetLength(1); j++) {

                    txtQueryElaborata.Text += resultquery[i, j].ToString();
                }

                txtQueryElaborata.Text += "\r\n";
            }
        }


    }
}
