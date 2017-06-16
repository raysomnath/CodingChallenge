using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenges
{
    static class BinaryGap
    {
        public static int solution(int N)
        {

            if (N == 0 || N == 1)
                return 0;

            string NumberInBinaryFormat = Convert.ToString(N, 2);
            List<int> BinaryGap = null;

            if (NumberInBinaryFormat.IndexOf('0') == -1)
                return 0;
            else
            {
                BinaryGap = new List<int>();

                while (NumberInBinaryFormat.Length > 1 && (NumberInBinaryFormat.IndexOf('0') > -1) && (NumberInBinaryFormat.IndexOf('1') > -1))
                {
                    if (NumberInBinaryFormat.IndexOf('0') > -1)
                    {
                        NumberInBinaryFormat = NumberInBinaryFormat.Substring(NumberInBinaryFormat.IndexOf('0'),
                                                                              NumberInBinaryFormat.Length - NumberInBinaryFormat.IndexOf('0'));

                        if (NumberInBinaryFormat.IndexOf('1') > -1)
                        {
                            var GapLength = NumberInBinaryFormat.IndexOf('1');

                            if (!BinaryGap.Contains(GapLength))
                            {
                                BinaryGap.Add(GapLength);
                            }
                            NumberInBinaryFormat = NumberInBinaryFormat.Substring(NumberInBinaryFormat.IndexOf('1'),
                                                                              NumberInBinaryFormat.Length - NumberInBinaryFormat.IndexOf('1'));
                        }
                        else
                            break;
                    }
                    else
                        break;
                }

                if (BinaryGap.Count > 0)
                    return BinaryGap.Max();
                else
                    return 0;
            }

        }
    }
}
