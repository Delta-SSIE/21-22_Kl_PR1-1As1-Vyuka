using System;

namespace tmp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int AC, CCC;
            //for (int A = 1; A < 10; A++)
            //{
            //    for (int C = 1; C < 10; C++)
            //    {
            //        AC = A * 10 + C;
            //        CCC = C * 111;

            //        if (A * C * AC == CCC)
            //        {
            //            Console.WriteLine($"řešení je {A}.{C}.{AC} = {CCC}");
            //        }
            //    }
            //}


            //  KC +  I = OK
            //   +    +    +
            //   E +  E = KM
            //  ------------
            //  OL + KO = LI

            bool nalezeno = false;

            for (int K = 1; K < 10 &&; K++)
            {
                for (int C = 1; C < 10; C++)
                {
                    for (int I = 0; I < 10; I++)
                    {
                        for (int O = 1; O < 10; O++)
                        {
                            for (int E = 1; E < 10; E++)
                            {
                                for (int M = 0; M < 10; M++)
                                {
                                    for (int L = 1; L < 10; L++)
                                    {
                                        int KC = K * 10 + C;
                                        int OK = O * 10 + K;
                                        int KM = K * 10 + M;
                                        int OL = O * 10 + L;
                                        int KO = K * 10 + O;
                                        int LI = L * 10 + I;

                                        //  KC +  I = OK
                                        //   +    +    +
                                        //   E +  E = KM
                                        //  ------------
                                        //  OL + KO = LI

                                        if (
                                            KC + I == OK 
                                            && E + E == KM
                                            && OL + KO == LI
                                            && KC + E == OL
                                            && I + E == KO
                                            && OK + KM == LI
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
        }


    }
}
