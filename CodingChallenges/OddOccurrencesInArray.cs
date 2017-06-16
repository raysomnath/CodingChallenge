using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingChallenges
{
    static class OddOccurrencesInArray
    {
        public static int solution(int[] A)
        {
            int unMatchNumber = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                unMatchNumber = unMatchNumber ^ A[i];
            }
            return unMatchNumber;

        }
    }
}
