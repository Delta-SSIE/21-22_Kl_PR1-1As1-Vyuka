using System;

namespace _04_For_16_Algebrogram
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int A = 1; A < 10; A++)
            //{
            //    for (int C = 1; C < 10; C++)
            //    {
            //        if (C == A)
            //            continue;

            //        if (A * C * (A * 10 + C) == C * 100 + C * 10 + C)
            //            Console.WriteLine($"{A}.{C}.{A}{C} = {C}{C}{C}");
            //    }
            //}

            //  KC +  I = OK
            //   +    +    +
            //   E +  E = KM
            //  ------------
            //  OL + KO = LI

            int pocet = 0;

            for (int K = 1; K < 10; K++)
            {
                for (int C = 1; C < 10; C++)
                {
                    if (C == K)
                        continue;
                    for (int I = 1; I < 10; I++)
                    {
                        if (I == K || I == C)
                            continue;
                        for (int O = 1; O < 10; O++)
                        {
                            if (O == K || O == C || O == I)
                                continue;
                            for (int E = 1; E < 10; E++)
                            {
                                if (E == K || E == C || E == I || E == O)
                                    continue;
                                for (int L = 1; L < 10; L++)
                                {
                                    if (L == K || L == C || L == I || L == O || L == E)
                                        continue;
                                    for (int M = 1; M < 10; M++)
                                    {
                                        if (M == K || M == C || M == I || M == O || M == E || M == L)
                                            continue;

                                        int KC = K * 10 + C;
                                        int OK = O * 10 + K;
                                        int KM = K * 10 + M;
                                        int OL = O * 10 + L;
                                        int KO = K * 10 + O;
                                        int LI = L * 10 + I;

                                        pocet++;

                                        if (
                                            KC + I == OK &&
                                            2 * E == KM &&
                                            OL + KO == LI &&
                                            KC + E == OL &&
                                            I + E == KO &&
                                            OK + KM == LI                                          
                                        )
                                        {
                                            Console.WriteLine($"{KC} +  {I} = {OK}");
                                            Console.WriteLine(" +    +    +");
                                            Console.WriteLine($" {E} +  {E} = {KM}");
                                            Console.WriteLine("------------");
                                            Console.WriteLine($"{OL} + {KO} = {LI}");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Vyzkoušeno {pocet} kobinací.");
        }
    }
}
