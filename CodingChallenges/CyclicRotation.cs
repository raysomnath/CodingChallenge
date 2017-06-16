using System;
using System.Collections.Generic;

namespace CodingChallenges {

    public static class CyclicRotation {

        public static int []solution(int[] A, int k)
        {
            Stack<int> _Stack = new Stack<int>();
            Queue<int> _Queue = new Queue<int>();
            for (int i = 0; i < A.Length; i++)
            {
                _Stack.Push(A[i]);
                _Queue.Enqueue(A[i]);
            }

            for (int i = 0; i < k ; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (j == 0)
                        A[j] = _Stack.Pop();
                    else
                    {
                        A[j] = _Queue.Dequeue();
                        _Stack.Pop();
                    }
                    if (j + 1 == A.Length)
                    {
                        _Queue.Dequeue();
                        j++;
                    }
                }
                for (int l = 0; l < A.Length; l++)
                {
                    _Stack.Push(A[l]);
                    _Queue.Enqueue(A[l]);
                }
            }
            return A;
        }
    }
}