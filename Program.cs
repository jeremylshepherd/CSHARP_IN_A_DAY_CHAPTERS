using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSHARP_IN_ONE_DAY_CHAPTERS
{
    class Program
    {
        static void Main(string[] args)
        {

            //Chapter 11
            string readPath = "/Users/jeremyshepherd/Projects/ASPdotNET/CSHARP_IN_ONE_DAY_CHAPTERS/CSHARP_IN_ONE_DAY_CHAPTERS/myReadFile.txt",
                writePath = "/Users/jeremyshepherd/Projects/ASPdotNET/CSHARP_IN_ONE_DAY_CHAPTERS/CSHARP_IN_ONE_DAY_CHAPTERS/myWriteFile.txt";
            if (File.Exists(readPath))
            {
                using (StreamReader sr = new StreamReader(readPath))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }

                    sr.Close();
                }
            }
            else
                Console.WriteLine("File does not exist");

            using (StreamWriter sw = new StreamWriter(writePath, true))
            {
                sw.WriteLine("Writing First Line");
                sw.WriteLine("Writing Second Line");
                sw.WriteLine("Writing Final Line");
                sw.Close();
            }

            if (File.Exists(writePath))
            {
                using (StreamReader sr = new StreamReader(writePath))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }

                    sr.Close();
                }
            }

            //For Every Exercise
            Console.Read();
        }
        
    }
}
