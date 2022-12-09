using System;
using System.IO.Ports;
using System.Threading;

namespace SerialReadTest
{
    class SerialRead
    {
        public static void Mainnn()
        {
            Thread.Sleep(200);
            Console.WriteLine("Serial read init");
            SerialPort port = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One);
            //port.Handshake = Handshake.XOnXOff;
            port.Open();
            
            while (true)
            {
                port.Write("S");
                Console.WriteLine(port.ReadExisting());
                
            }

        }
    }
}