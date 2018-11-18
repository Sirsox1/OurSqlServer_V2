﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Client.Data {
    class OurSerialPort {

        private SerialPort srl = new SerialPort();
        public string PortName { get => PortName; set => PortName = value; }
        public int DataBits { get => DataBits; set => DataBits = value; }

        public OurSerialPort() {

            srl.DataReceived += Srl_DataReceived;
            srl.PortName = "COM4";
            srl.BaudRate = 9600;
            srl.DataBits = 8;
            srl.Parity = Parity.Even;
            srl.StopBits = StopBits.One;
        }

        private void Srl_DataReceived(object sender, SerialDataReceivedEventArgs e) {

        }

        public void Write(string Mex) {

            srl.Write(Mex);
        }
        public string Read() {

            return srl.ReadExisting();
        }
    }
}