//#define WRITE_TO_FILE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//потоки ввода-вывода

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if WRITE_TO_FILE
            Console.WriteLine("Hello Files");
            string directory = Directory.GetCurrentDirectory();
            string filename = "File.txt";
            //StreamWriter sw = new StreamWriter(filename);
            //sw.WriteLine("Hello Files");
            //sw.Close();

            using (StreamWriter file = File.AppendText(filename))
            {
                file.WriteLine("Привет!");
            }
             
            string cmd=directory+"\\"+filename;
            System.Diagnostics.Process.Start("notepad", cmd);
#endif //WRITE_TO_FILE

            StreamReader sr = new StreamReader("File.txt");
            while(!sr.EndOfStream) 
            {
                string buffer = sr.ReadLine();
                Console.WriteLine(buffer);
            }
            sr.Close();
        }
    }
}
