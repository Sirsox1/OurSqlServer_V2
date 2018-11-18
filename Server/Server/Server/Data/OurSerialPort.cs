using System.IO.Ports;

namespace Server.Data
{
    class OurSerialPort
    {

        public SerialPort srl = new SerialPort();
        public string PortName { get => PortName; set => PortName = value; }
        public int DataBits { get => DataBits; set => DataBits = value; }


        public OurSerialPort()
        {
            srl.PortName = "COM100";
            srl.BaudRate = 9600;
            srl.DataBits = 8;
            srl.Parity = Parity.Even;
            srl.StopBits = StopBits.One;
        }
        public OurSerialPort(string name, int data)
        { // Andrea 2018-11-12: Modifica solo del nome e della quantità di bit.

            srl.PortName = name;
            //srl.DataBits = data;
            //srl.BaudRate = 9600;
            //srl.Parity = Parity.Even;
            //srl.StopBits = StopBits.One;
        }

        public void Write(string Mex)
        { // Andrea 2018-11-12: Verifica che la porta sia aperta, nel caso la apre, e scrive nel buffer.
            if (!srl.IsOpen)
                srl.Open();

            srl.Write(Mex);
        }
    }
}
