using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace ReceiveAndSave
{
    class Program
    {
        private const int FRAME_SIZE = 36;

        static void Main(string[] args)
        {
            using (var port = new SerialPort())
            using (var fs = File.Create("data.bin"))
            {
                while (true)
                {
                    var buffer = new byte[FRAME_SIZE];
                    for (var offset = 0; offset < FRAME_SIZE; )
                    {
                        var nRead = port.Read(buffer, offset, FRAME_SIZE - offset);
                        offset += nRead;
                    }
                    fs.Write(buffer, 0, FRAME_SIZE);
                }
            }
        }
    }
}
