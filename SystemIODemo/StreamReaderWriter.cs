using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SystemIODemo
{
    class StreamReaderWriter
    {
        public void WriterUsingStreamWriter()
        {
            string path = @"C:\Users\lenovo\Desktop\BridgeLabz\SystemIODemo\SystemIODemo\sample.txt";

            using (StreamWriter sr = File.AppendText(path))
                sr.Close();

            Console.WriteLine(File.ReadAllText(path));
        }
        public void ReaderUsingStreamer()
        {
            string path = @"C:\Users\lenovo\Desktop\BridgeLabz\SystemIODemo\SystemIODemo\sample.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";
                while ((s = sr.ReadLine()) is null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadLine();
        }
    }
}
