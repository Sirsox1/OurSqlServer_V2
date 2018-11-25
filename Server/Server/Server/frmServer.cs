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
            prg1.Visible = false;
            btnStopServer.Enabled = false;
            btnStopServer.BackColor = System.Drawing.Color.Gray;
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
            prg1.Visible = true;

            string response = MyLibrary.Decode(myquery, srlPort.srl.PortName);

            prg1.Visible = false;
            txtQueryElaborata.Text = response;
            srlPort.Write(response);
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            btnStartServer.Enabled = true;
            btnStartServer.BackColor = System.Drawing.Color.Lime;
            btnStopServer.Enabled = false;
            btnStopServer.BackColor = System.Drawing.Color.Gray;
            // Invia al client un codice specifico (es. "####" ) per avvisarlo che il server è down

            srlPort.Write("####");
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            btnStartServer.Enabled = false;
            btnStartServer.BackColor = System.Drawing.Color.Gray;
            btnStopServer.Enabled = true;
            btnStopServer.BackColor = System.Drawing.Color.Red;

            // Invia al client un codice specifico (es. "@@@@" ) per avvisarlo che il server è running

            srlPort.Write("@@@@");
        }

        private void frmServer_FormClosing(object sender, FormClosingEventArgs e)
        {

            srlPort.srl.Close();
        }
    }
}
