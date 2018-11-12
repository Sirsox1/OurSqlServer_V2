using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Data;

namespace Client.View {
    public partial class frmMain : Form {

        List<string> schools = new List<string>();
        public frmMain() {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) {
          
            treeView1.BeginUpdate();
            treeView1.Nodes[0].Nodes.Add("ISII");
            treeView1.Nodes[0].Nodes.Add("Tramello");

            treeView1.Nodes[0].Nodes[0].Nodes.Add("Alunni");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Insegnanti");

            treeView1.Nodes[0].Nodes[1].Nodes.Add("Alunni");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Insegnanti");
            treeView1.EndUpdate();

            // Salvo dentro una lista i nomi di tutte le scuole, sono elementi di secondo livello nell'albero
            foreach (TreeNode tn in treeView1.Nodes[0].Nodes)
                schools.Add(tn.Text);

            OurSerialPort srlPort = new OurSerialPort("COM4",8);
        }


        private void btnSend_Click(object sender, EventArgs e) {
            btnSend.Enabled = false;
            tmr1.Start();

            //srlOurPort.Open();
            //srlOurPort.Write(txtQuery.Text);
        }

        private void tmr1_Tick(object sender, EventArgs e) //Andrea 20181109: Creazione timer che abilita ilbottone di ricezione se nel buffer di ricezione c'è qualcosa
        {
            
        }

        private void treeView1_NodeMouseClick_1(object sender, TreeNodeMouseClickEventArgs e) {
            if (rdbSQL.Checked) {
                // Se il nodo selezionato è una scuola si genera il comando USE + scuola_selezionata

                if (schools.Any(item => item == e.Node.Text))
                    txtQuery.Text = "USE " + e.Node.Text;

                else if (e.Node.Text != "Database") // Andrea 20181109: Realizzazione della query completa. 'use nDB select * from nTab'                     
                    txtQuery.Text = "USE " + e.Node.Parent.Text + "\r\nSELECT *\r\nFROM " + e.Node.Text; // Andrea 20181109: Sono mongolo e non riesco ad andare a capo

                else if (e.Node.Text == "Database")
                    txtQuery.Clear();
            }
        }
    }
}
