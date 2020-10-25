using System;
using System.IO;

namespace SystemIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            FileExists();
            ReadLines();
            StreamReaderWriter srw = new StreamReaderWriter();
            srw.WriterUsingStreamWriter();
            srw.ReaderUsingStreamer();
            BinarySerialization binarySerialization=new BinarySerialization();
            binarySerialization.Serialization();
            binarySerialization.DeSerialization();

        }
        public static void FileExists()
        {
            string path = @"C:\Users\lenovo\Desktop\BridgeLabz\SystemIODemo\SystemIODemo\sample.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }

        }
        public static void ReadLines()
        {
            string path = @"C:\Users\lenovo\Desktop\BridgeLabz\SystemIODemo\SystemIODemo\sample.txt"; ;

            string[] lines;
            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
        }

    }
    
}
