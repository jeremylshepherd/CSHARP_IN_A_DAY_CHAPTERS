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

            ClassA a = new ClassA();

            a.MyNumber = 5;
            a.InterfaceMethod();

            //For Every Exercise
            Console.Read();
        }

        //Interfaces
        interface IShape
        {
            int MyNumber
            {
                get;
                set;
            }

            void InterfaceMethod();
        }

        class ClassA : IShape
        {
            private int myNumber;
            public int MyNumber
            {
                get
                {
                    return myNumber;
                }
                set
                {
                    if (value < 0)
                        myNumber = 0;
                    else
                        myNumber = value;
                }
            }

            public void InterfaceMethod()
            {
                Console.WriteLine("The number is {0}.", MyNumber);
            }
        }

    }
}
