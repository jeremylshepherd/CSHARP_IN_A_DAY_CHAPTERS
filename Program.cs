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

            //Chapter 08: Base/Derived Classes
            NormalMember norm01 = new NormalMember("Special Rate", "James", 1, 2010);
            VIPMember vip01 = new VIPMember("Andy", 2, 2011);

            norm01.CalculateAnnualFee();
            vip01.CalculateAnnualFee();

            Console.WriteLine(norm01.ToString());
            Console.WriteLine(vip01.ToString());

            //For Every Exercise
            Console.Read();
        }

        //Base Class
        class Member
        {
            protected int annualFee;
            private string name;
            private int memberID;
            private int memberSince;

            public Member()
            {
                Console.WriteLine("Parent constructor with no parameter(s)");
            }

            public Member(string pName, int pMemberID, int pMemberSince)
            {
                Console.WriteLine("Parent constructor with 3 parameters");

                name = pName;
                memberID = pMemberID;
                memberSince = pMemberSince;
            }

            public override string ToString()
            {
                return $"\nName: {name} \nMemberID: {memberID} \nMember Since: {memberSince} \nTotal Annual Fee: {annualFee:C}";
            }
        }

        //Child Class
        class NormalMember : Member
        {
            public NormalMember()
            {
                Console.WriteLine("Child constructor with no parameter");
            }

            public NormalMember(string remarks, string name, int memberID, int memberSince) : base(name, memberID, memberSince)
            {
                Console.WriteLine("Child constructor with 4 parameters");
                Console.WriteLine($"Remarks = {remarks}");
            }

            public void CalculateAnnualFee()
            {
                annualFee = 100 + 12 * 30;
            }
        }

        //Child Class
        class VIPMember : Member
        {
            public VIPMember(string name, int memberID, int memberSince) : base(name, memberID, memberSince)
            {
                Console.WriteLine("Child constructor with 3 parameters");
            }

            public void CalculateAnnualFee()
            {
                annualFee = 1200;
            }
        }

    }
}
