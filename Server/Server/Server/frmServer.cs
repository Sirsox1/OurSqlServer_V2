using Server.Data;
using Server.Library;
using System;
using System.Windows.Forms;

namespace Server
{

    public partial class frmServer : Form
    {

        OurSerialPort srlPort = new OurSerialPort("COM100", 8);

        public frmServer()
        {
            InitializeComponent();
        }

        private void frmServer_Load(object sender, EventArgs e)
        {
            try
            {
                srlPort.srl.Open();
                srlPort.srl.DataReceived += Srl_DataReceived;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void Srl_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string myquery = srlPort.srl.ReadExisting();
            txtQuery.AppendText("" + myquery + "");

            string response = MyLibrary.Decode(myquery, srlPort.srl.PortName);

            txtQueryElaborata.Text= response;
            srlPort.Write(response);
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {

            // Invia al client un codice specifico (es. "####" ) per avvisarlo che il server è down

            srlPort.Write("####");
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {

            // Invia al client un codice specifico (es. "@@@@" ) per avvisarlo che il server è running

            srlPort.Write("@@@@");
        }

        private void frmServer_FormClosing(object sender, FormClosingEventArgs e)
        {

            srlPort.srl.Close();
        }

        private void txtQuery_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
