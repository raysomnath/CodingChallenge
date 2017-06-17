using System;
using System.Linq;


namespace CodingChallenges
{
    class PermMissingElem
    {
        public static int solution(int[] A)
        {
           
            if (A.Length != 0 && A.Length == 1)
                return A[0] == 1 ? 2 : 1;
            else if (A.Length != 0 && A.Length > 1)
            {
                Array.Sort(A);
                if (A[0] != 1)
                    return 1;
                else
                {
                    for (int i = 0; i < A.Length - 1; i++)
                    {
                        if (A[i + 1] - A[i] > 1)
                            return A[i] + 1;
                    }
               }
                return A.Length + 1;
            }
            return 1;
        }
    }
}
