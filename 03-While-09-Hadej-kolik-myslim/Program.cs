using System;

namespace _03_While_09_Hadej_kolik_myslim
{
    class Program
    {
        static void Main(string[] args)
        {
            //vymysli si číslo
            Random rnd = new Random();
            int secret = rnd.Next(1, 101);
            int round = 1;

            // hranice smysluplných tipů
            int minGuess = 1;
            int maxGuess = 100;

            int guess;
            //DOKUD není uhodnuto
            do
            {

                //načti od hráče
                Console.Write($"{round}. kolo - Kolik tipuješ: ");
                
                string input = Console.ReadLine();
                
                //když je číslo Ok
                if (int.TryParse(input, out guess)) {
                    
                    //když je velké
                    if (guess > secret)
                    {
                        Console.WriteLine("To je moc!");
                        if (guess >= maxGuess)
                            Console.WriteLine("Přemýšlej, co píšeš!"); 
                        else
                            maxGuess = guess;
                    }
                        

                    //když je malé
                    else if (guess < secret)
                    {
                        Console.WriteLine("To je málo!");
                        if (guess <= minGuess)
                            Console.WriteLine("Přemýšlej, co píšeš!"); 
                        else
                            minGuess = guess;
                    }


                    //když číslo sedí
                    else
                    {
                        Console.WriteLine($"To je ono, myslel jsem si {secret}.");
                        //ukonči DOKUD a program
                    }

                    round++; //když bylo zadání OK, můžu zvýši počítadlo kola

                }

                //když napsal neplatný vstup
                else
                {
                    //upozorním
                    Console.WriteLine("Neplatné zadání, zkus to znovu.");
                }

            } while (secret != guess); // DOKUD není uhodnuto
        }
    }
}
