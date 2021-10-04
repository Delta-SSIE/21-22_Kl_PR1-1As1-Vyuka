using System;

namespace _02_Podm_02_Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jeDrahe = true; //nový datový typ - jen true / false

            if (jeDrahe)
            {
                Console.WriteLine("Tohle auto nechci!");
            }
            else
            {
                Console.WriteLine("je to popelnice, ale beru.");
            }
        }
    }
}
