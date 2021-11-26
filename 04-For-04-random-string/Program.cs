using System;

namespace _04_For_04_random_string
{
    class Program
    {
        static void Main(string[] args)
        {
            //chci nahodny retezec dane delky
            int delka = 10;

            Random random = new Random();

            string nahodnyRetezec = "";

            for (int i = 0; i < delka; i++)
            {
                int kodZnaku = random.Next('a', 'z' + 1);
                char nahodnyZnak = (char)kodZnaku;

                nahodnyRetezec += nahodnyZnak;
            }

            Console.WriteLine(nahodnyRetezec);

        }
    }
}
