using System.IO.Ports;

namespace Client.Data
{
    class OurSerialPort
    {
        public SerialPort srl = new SerialPort();
        public string PortName { get; set; }
        public int DataBits { get; set; }


        public OurSerialPort()
        {
            srl.PortName = "";
            srl.BaudRate = 9600;
            srl.DataBits = 8;
            srl.Parity = Parity.Even;
            srl.StopBits = StopBits.One;
        }
        public OurSerialPort(string name, int data)
        { 
            // Andrea 2018-11-12: Modifica solo del nome e della quantità di bit.

            srl.PortName = name;
            srl.DataBits = data;
            srl.BaudRate = 9600;
            srl.Parity = Parity.Even;
            srl.StopBits = StopBits.One;
        }

        public void Write(string Mex)
        { // Andrea 2018-11-12: Verifica che la porta sia aperta, nel caso la apre, e scrive nel buffer.
            if (!srl.IsOpen)
                srl.Open();

            Mex = Mex.Replace("\r\n", " "); // Andrea 2018-11-26: Pulizia della stringa
            srl.Write(Mex);
        }
    }
}
