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

            //Chapter 08: Polymorphism
            Member[] clubMembers = new Member[5];

            clubMembers[0] = new NormalMember("Special Rate", "James", 1, 2010);
            clubMembers[1] = new NormalMember("Normal Rate", "Andy", 2, 2011);
            clubMembers[2] = new NormalMember("Normal Rate", "Bill", 3, 2011);
            clubMembers[3] = new VIPMember("Carol", 4, 2012);
            clubMembers[4] = new VIPMember("Evelyn", 5, 2012);

            foreach (Member m in clubMembers)
            {
                m.CalculateAnnualFee();
                Console.WriteLine(m.ToString());
            }

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

            public virtual void CalculateAnnualFee()
            {
                annualFee = 0;
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

            public override void CalculateAnnualFee()
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

            public override void CalculateAnnualFee()
            {
                annualFee = 1200;
            }
        }

    }
}
