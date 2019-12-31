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

            //Chapter 08: Abstract Classes

            //MyAbstractClass abClass = new MyAbstractClass();  //Abstract Classes throw exception if instantiated, here for demonstration
            ClassA a = new ClassA();
            a.PrintMessage();
            a.PrintMessageAbstract();

            //For Every Exercise
            Console.Read();
        }

        //Abstract Classes

        abstract class MyAbstractClass
        {
            private string message = "Hello C#";
            public void PrintMessage()
            {
                Console.WriteLine(message);
            }

            public abstract void PrintMessageAbstract();
        }

        class ClassA : MyAbstractClass
        {
            public override void PrintMessageAbstract()
            {
                Console.WriteLine("C# is fun!");
            }
        }

    }
}
