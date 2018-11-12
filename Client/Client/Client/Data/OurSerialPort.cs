using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Client.Data {
    class OurSerialPort {

        public SerialPort srl = new SerialPort();
        public string PortName { get => PortName; set => PortName = value; }
        public int DataBits { get => DataBits; set => DataBits = value; }
        public string data;


        public OurSerialPort() {

            //srl.DataReceived += Srl_DataReceived;
            srl.PortName = "COM4";
            srl.BaudRate = 9600;
            srl.DataBits = 8;
            srl.Parity = Parity.Even;
            srl.StopBits = StopBits.One;
        }
        public OurSerialPort(string name, int data) { // Andrea 2018-11-12: Modifica solo del nome e della quantità di bit.

            //srl.DataReceived += Srl_DataReceived;
            srl.PortName = name;
            srl.DataBits = data;
            srl.BaudRate = 9600;
            srl.Parity = Parity.Even;
            srl.StopBits = StopBits.One;
        }

        //private void Srl_DataReceived(object sender, SerialDataReceivedEventArgs e) {
        //    data = srl.ReadExisting();
        //    srl.Close();
        //}

        public void Write(string Mex) { // Andrea 2018-11-12: Verifica che la porta sia aperta, nel caso la apre, e scrive nel buffer.
            if (!srl.IsOpen)
                srl.Open();

            srl.Write(Mex);
        }
        public string Read() { // Andrea 2018-11-12: Verifica se nel buffer c'è qualcosa e nel caso la legge poi chiude la connessione.

            if (srl.da > 0) {
                string buffer = srl.ReadExisting();
                srl.Close();
                return buffer;
            } else
                return null;
            
        }

    }
}
