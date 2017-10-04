using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_day2Loops
{
    class Program
    {
        static void Main(string[] args)
        {


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //} 



            //for (int counter = 50; counter <= 100; counter++)
            //{
            //    Console.WriteLine(counter);
            //}


            //string greeting = "My name is Goku";
            //string[] words = greeting.Split();

            //for(int i = 0; i < words.Length; i++ )
            //{
            //    Console.WriteLine(words[i]);
            //}


            //string[] days = { "Mondays", "Tuesday", "Wednesday" };
            //for (int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}

            //string fairyTale = "Once upon a time";
            //string[] storyWords = fairyTale.Split();
            //Array.Reverse(storyWords)



            //finish practice above

            //ForEach Loop
            //string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec", };

            //foreach(string abbreviations in months)
            //{
            //    Console.WriteLine(abbreviations);
            //}


            //string [] artists = { "Michael Jackson", "Nas", "Bob Marley", "Prince", "Andre 3000" };
            //foreach (string artist in artists)
            //{
            //    Console.WriteLine(artist);
            //}












            int[] numbers = { 3, 5, 7, 11, 15 };
            foreach (int luckyNumbers in numbers)
            {
                Console.WriteLine("Your Lucky Number is: " + (luckyNumbers));
            }







        }
    }
}
