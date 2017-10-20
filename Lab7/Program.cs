using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {

            // QuestionsOneThruSeven();

            #region Extra Credit

            for (int col = 0; col < 10; col++)
            {
                for (int row = 0; row < col; row++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int col = 10; col > 0; col--)
            {
                for (int row = 0; row < col; row++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int col = 0; col < 10; col++)
            {

                for (int spc = col; spc > 0; spc--)
                {
                    Console.Write(" ");
                }

                for (int row = 10 - col; row > 0; row--)
                {
                    Console.Write("*");
                }


                Console.WriteLine();
            }

            Console.WriteLine();

            for (int col = 10; col > 0; col--)
            {

                for (int spc = col-1; spc > 0; spc--)
                {
                    Console.Write(" ");
                }

                for (int row = 10 - col+1; row > 0; row--)
                {
                    Console.Write("*");
                }


                Console.WriteLine();
            }


            Console.ReadKey(true);

            #endregion 

        }

        static void QuestionsOneThruSeven()
        {

            int counter = 0; //Initial value & control variable

            while (counter < 10) // Loop-coninuation condition
            {
                Console.WriteLine("OBEY YOUR OVERLORDS!");

                counter++; // Increment
            }

            for (int c = 0; c < 10; c++)
            {
                Console.WriteLine("OBEY YOUR OVERLORDS!");

            }

            string input = "";

            do
            {

                Console.WriteLine("Do ya need another one?");

                input = Console.ReadLine().ToLower().Trim();

            } while (input == "give me another one, pal");

            for (int i = 1; i < 101; i++)
            {

                Console.WriteLine("The value {0} is {1}.", i, i % 2 == 0 ? "even" : "odd");
            }

            Console.ReadKey(true);

            int temp = 0;

            while (true)
            {
                try
                {
                    Console.Write("Please enter a temperature...   ");
                    temp = int.Parse(Console.ReadLine().ToLower().Trim());
                    break;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Enter a real number, you bum." +
                        "\n\nPress a key to try again.");
                    Console.ReadKey(true);
                    continue;
                }

                Console.WriteLine("\n");

                if (temp < 10)
                {
                    Console.WriteLine("Polar Bear");
                }
                else if (temp < 20)
                {
                    Console.WriteLine("Penguin");
                }
                else if (temp < 40)
                {
                    Console.WriteLine("Moose");
                }
                else if (temp < 50)
                {
                    Console.WriteLine("Reindeer");
                }
                else if (temp < 60)
                {
                    Console.WriteLine("Deer");
                }
                else if (temp < 70)
                {
                    Console.WriteLine("Turtle");
                }
                else if (temp < 80)
                {
                    Console.WriteLine("Lion");
                }
                else if (temp < 90)
                {
                    Console.WriteLine("Fish");
                }
                else
                {
                    Console.WriteLine("Bug");

                }
            }

            Console.ReadKey(true);

            int n = 10;
            while (n < 21)
            {
                Console.WriteLine(n);
                n++;
            }

            Console.ReadKey(true);

            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("********");
            }

            Console.ReadKey(true);
        }
    }
}
