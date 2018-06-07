using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _19_Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"D:\test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Hello");
            sw.Flush();

            fs.Position = 0;

            StreamReader sr = new StreamReader(fs);
            Console.WriteLine(sr.ReadLine());

            sr.Close();

            // --------------------------------------------------------------------

            MemoryStream ms = new MemoryStream();
            //NetworkStream ns = new NetworkStream(new Socket(SocketType.Stream, ProtocolType.Udp));
            //UnmanagedMemoryStream ums = new UnmanagedMemoryStream()

            StringReader strR = new StringReader("Hello");
            StringWriter strW = new StringWriter();
            BufferedStream bs = new BufferedStream(ms);
            BinaryReader br = new BinaryReader(ms);
            BinaryWriter bw = new BinaryWriter(ms);
        }
    }
}
