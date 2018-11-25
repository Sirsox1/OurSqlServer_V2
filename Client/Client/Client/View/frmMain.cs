using Client.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Client.View
{
    public partial class frmMain : Form
    {

        List<string> schools = new List<string>();

        OurSerialPort srlPort = new OurSerialPort("COM101", 8);

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            prg1.Visible = false;
            btnSend.Enabled = false;
            btnStatus.BackColor = System.Drawing.Color.Red;
            btnStatus.Text = "STOPPED";


            CheckForIllegalCrossThreadCalls = false;

            try
            {
                srlPort.srl.Open();
                srlPort.srl.DataReceived += Srl_DataReceived;
            }
            catch (Exception ex)
            {
                if (ex is System.UnauthorizedAccessException)
                    txtReceived.Text = "Porta già in uso da un'altra applicazione";
                else if (ex is System.IO.IOException)
                    txtReceived.Text = "Connessione persa con la porta : " + srlPort.PortName;
                else
                    txtReceived.Text = "Errore!";
            }

            treeView1.BeginUpdate();
            treeView1.Nodes[0].Nodes.Add("ISII");
            treeView1.Nodes[0].Nodes.Add("Tramello");

            treeView1.Nodes[0].Nodes[0].Nodes.Add("Alunni");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Insegnanti");

            treeView1.Nodes[0].Nodes[1].Nodes.Add("Alunni");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Insegnanti");
            treeView1.EndUpdate();

            // Salvo dentro una lista i nomi di tutte le scuole, sono elementi di secondo livello nell'albero.
            foreach (TreeNode tn in treeView1.Nodes[0].Nodes)
                schools.Add(tn.Text);

        }

        private void Srl_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            prg1.Visible = false;

            string mex = srlPort.srl.ReadExisting();
            if ("####" == mex)
            {
                btnSend.Enabled = false ;
                btnStatus.BackColor = System.Drawing.Color.Red;
                btnStatus.Text = "STOPPED";
            }
            else if ("@@@@" == mex)
            {
                btnSend.Enabled = true;
                btnStatus.BackColor = System.Drawing.Color.Lime;
                btnStatus.Text = "RUNNING";
            }
            else
            {
                btnSend.Enabled = true;
                txtReceived.AppendText("" + mex + "");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            prg1.Visible = true;
            srlPort.Write(txtQuery.Text);
        }

        private void treeView1_NodeMouseClick_1(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (rdbSQL.Checked)
            {
                // Se il nodo selezionato è una scuola si genera il comando USE + scuola_selezionata.

                if (schools.Any(item => item == e.Node.Text))
                    txtQuery.Text = "USE " + e.Node.Text;

                // Andrea 2018-11-09: Realizzazione della query completa. 'use nDB select * from nTab'.
                else if (e.Node.Text != "Database") 
                    txtQuery.Text = "USE " + e.Node.Parent.Text + "\r\nSELECT *\r\nFROM " + e.Node.Text; 

                else if (e.Node.Text == "Database")
                    txtQuery.Clear();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            srlPort.srl.Close();
        }
    }
}
