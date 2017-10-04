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












            //int[] numbers = { 3, 5, 7, 11, 15 };
            //foreach (int luckyNumbers in numbers)
            //{
            //    Console.WriteLine("Your Lucky Number is: " + (luckyNumbers));
            //}



            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.WriteLine("do you want to play again? (yes/no)");
            //string playAgain = Console.ReadLine();
            //while(playAgain == "yes")
            //{
            //    Console.WriteLine("its a rematch!");
            //    Console.WriteLine("do you want to play again? (yes/no)");
            //    playAgain = Console.ReadLine();
            //}



            //Console.WriteLine("Would you like to check in patient for appoinment? (yes/no)");
            //string checkIn = Console.ReadLine();
            //while(checkIn == "yes")
            //{
            //    Console.WriteLine("PATIENT CHECK IN SYSTEM");

            //    Console.WriteLine("what is your full name?");
            //    Console.ReadLine().ToLower();
            //    Console.WriteLine("what is your social?");
            //    int userId = int.Parse(Console.ReadLine().ToLower());
            //    Console.WriteLine("what time is your appointment?");
            //    Console.ReadLine().ToLower();

            //    Console.WriteLine("would you like to check in for appointment?");
            //    checkIn = Console.ReadLine().ToLower();

            //}




            //string playAgain;
            //do
            //{

            //    Console.WriteLine("Great game!");
            //    Console.WriteLine("Do you want to play again? (yes/no)");
            //    playAgain = Console.ReadLine();
            //}
            //while (playAgain == "yes");

            //Console.WriteLine("Thanks for playing the game");



            //string addClass;
            //do
            //{
            //    Console.WriteLine("What class would you like to add to your GPA calculation?");
            //    Console.ReadLine();
            //    Console.WriteLine("What is the letter grade of class?");
            //    Console.ReadLine();
            //    Console.WriteLine("Do you have another class you would like to add to calculation?");
            //    addClass = Console.ReadLine().ToLower();
            //}

            //while (addClass == "yes");
            //Console.WriteLine("Thank you for your grades.");

            ////To print just odd numbers. whenver an even number is hit, the "continue command will continue past it
            //for (int i = 0; i <= 20; i++) 
            //{
            //    if(i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);

            //}

            //Console.WriteLine("The loop has finished.");


            ////Use break to break a loop once it no longer meets the condition
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 14 == 0)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);

            //}

            //Console.WriteLine("The loop has finished.");


            //nested loops

            //for(int i = 1; i<=2; i++)
            //{
            //    for (int j = 1; j <= 4; j++)
            //    {
            //        Console.Write(j); //Write for columns
            //    }
            //    Console.WriteLine(); //next row
            //}



            //int n = int.Parse(Console.ReadLine());
            //for (int row = 1; row <= n; row++)
            //{
            //    for (int col = 1; col <= row; col++)
            //    {
            //        Console.Write(col + " ");
            //    }
            //    Console.WriteLine();
            //}























        }
    }
}
