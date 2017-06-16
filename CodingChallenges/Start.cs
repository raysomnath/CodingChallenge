using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    class Start
    {
        static void Main(string[] args)
        {
            CheckArrayEquilibiriumProblem();
        }

        private static void CheckArrayEquilibiriumProblem()
        {
            int[] A = { -1, 3, -4, 5, 1, -6, 2, 1 };

            Console.WriteLine(DateTime.Now.ToString());
            var x = System.DateTime.Now;
            var retVal = ArrayEqulibrium.solution(A);
            Console.WriteLine(retVal);
            Console.WriteLine((DateTime.Now - x).ToString());

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine(DateTime.Now.ToString());
             x = System.DateTime.Now;
             retVal = BinaryGap.solution(529);

            Console.WriteLine("Binary gap for 529 is " + retVal);
            Console.WriteLine("Binary gap for 20 is " + BinaryGap.solution(20));
            Console.WriteLine("Binary gap for 15 is " + BinaryGap.solution(15));
            Console.WriteLine("Binary gap for " + Int32.MaxValue + "is " + BinaryGap.solution(Int32.MaxValue));

            Console.WriteLine((DateTime.Now - x).ToString());

            Console.Read();
        }
    }
}
