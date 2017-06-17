using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges
{
    class ParkingProblem
    {
        const int EntranceFree = 2;
        const int FirstHourCharge = 3;
        const int ChargeAfterFirstHour = 4;

        public static int solution(string E, string L)
        {
            var TotalCost = 2;

            if (string.IsNullOrEmpty(E) || string.IsNullOrEmpty(L) || E.IndexOf(':') == -1 || L.IndexOf(':') == -1)
                return 0;
            else
            {
                try
                {
                    TimeSpan EntryTime = new TimeSpan(Convert.ToInt32(E.Split(':')[0]), Convert.ToInt32(E.Split(':')[1]), 0);
                    TimeSpan ExitTime = new TimeSpan(Convert.ToInt32(L.Split(':')[0]), Convert.ToInt32(L.Split(':')[1]), 0);

                    var duration = ExitTime - EntryTime;

                    //For FirstHour 
                    TotalCost = EntranceFree + FirstHourCharge;

                    TimeSpan firstHour = new TimeSpan(1, 0, 0);

                    duration = duration - firstHour;

                    if (duration > TimeSpan.Zero)
                    {
                        if (duration.Hours > 0)
                            TotalCost = duration.Hours * ChargeAfterFirstHour;
                        if (duration.Minutes > 0)
                            TotalCost = TotalCost + ChargeAfterFirstHour;
                    }
                    return TotalCost;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
           
        }
    }
}
