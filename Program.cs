using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Type 's' to start the timer.");
                var user_input_start = Console.ReadLine().ToLower();
                var timer = new Timer();

                //start logic
                bool isTrueStart = (user_input_start == "s") ? true : false;
                while (true)
                {
                    if (isTrueStart == true)
                    {
                        timer.Start();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Type 's' to start the timer.");
                        user_input_start = Console.ReadLine().ToLower();
                        if (user_input_start != "s")
                        {
                            continue;
                        }
                        else
                        {
                            timer.Start();
                            break;
                        }
                    }
                }

                Console.WriteLine("Please type 'q' to stop timer");
                var user_input_stop = Console.ReadLine().ToLower();

                //stop logic
                bool isTrueStop = (user_input_stop == "q") ? true : false;
                while (true)
                {
                    if (isTrueStop == true)
                    {
                        timer.Stop();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Type 'q' to quit the timer.");
                        user_input_stop = Console.ReadLine().ToLower();
                        if (user_input_stop != "q")
                        {
                            continue;
                        }
                        else
                        {
                            timer.Stop();
                        }
                    }
                    break;
                }
                Console.WriteLine("Type 'ctrl c' to exit");
            }
            //Main 
        }
    }
}
