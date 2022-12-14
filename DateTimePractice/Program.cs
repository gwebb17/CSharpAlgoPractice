using System;
using System.Collections.Generic;

namespace DateTimePractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Clock clockenspiel = new Clock();

            

            //#1
            Console.WriteLine("Enter number 1");
            int answer1A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int answer2A = Convert.ToInt32(Console.ReadLine());
            clockenspiel.Method1(out int methodOneResult, answer1A, answer2A);

            //#2
            Console.WriteLine("Enter an amount of minutes");
            int answer1B = Convert.ToInt32(Console.ReadLine());
            int result1B = answer1B *= 60;
            Console.WriteLine("The amount in seconds is: " + result1B + ".");

            //#3
            Console.WriteLine("Enter a number to increment");
            int answer3A = Convert.ToInt32(Console.ReadLine());
            clockenspiel.NextMethod(out int NextMethodResult, answer3A);

            //#4
            Console.WriteLine("Enter your age: ");
            int answer4A = Convert.ToInt32(Console.ReadLine());
            clockenspiel.AgeMethod(out int AgeMethodResult, answer4A);


            //#5
            Console.WriteLine("Enter length of rectangle ");
            int answer5A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width of rectangle ");
            int answer5B = Convert.ToInt32(Console.ReadLine());
            clockenspiel.RectangleMethod(out int RectangleMethodResult, answer5A, answer5B);

            //#6
            Console.WriteLine("Enter # between 1-12");
            int answer6A = Convert.ToInt32(Console.ReadLine());
            clockenspiel.MonthMethod(out string MonthMethodResult, answer6A);

            //#7
            //Loop through an array of user entered values and multiply each item in the array by the array's length
            //Return each result 
            Console.WriteLine("\nEnter array #1");
            int answer7A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter array #2");
            int answer7B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter array #3");
            int answer7C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter array #4");
            int answer7D = Convert.ToInt32(Console.ReadLine());
            clockenspiel.ArrayMethod(answer7A, answer7B, answer7C, answer7D);

            //#8
            //Write a C# Sharp program that takes user inputs, turns them into a List, and finds the average of the List 
            Console.WriteLine("Find average #1");
            int answer8A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Find average #2");
            int answer8B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Find average #3");
            int answer8C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Find average #4");
            int answer8D = Convert.ToInt32(Console.ReadLine());
            List<int> list8A = new List<int>(){answer8A, answer8B, answer8C, answer8D};   //Have to instantiate first since its a list
            clockenspiel.AverageMethod(out double AverageMethodResult, list8A);


            //#9 Ask user for a word. Return the letter that occurs most in the word.
            //Console.WriteLine("Enter a word");
            //string answer9A = Console.ReadLine();
            //clockenspiel.CountLettersMethod(answer9A);


            //#10. Ask user for a word. Return every other letter in the word as a string.
            Console.WriteLine("Enter a word");
            string answer10A = Console.ReadLine();
            clockenspiel.SkipLettersMethod(out string SkipLettersMethodResult, answer10A);


            //#11. Take two colors as strings. Return the color that combining them results in.
            Console.WriteLine("Enter color #1");
            string answer11A = Console.ReadLine();
            Console.WriteLine("Enter color #2");
            string answer11B = Console.ReadLine();
            clockenspiel.TwoColorsMethod(answer11A, answer11B);


            //#12. Shoes are either L or R. A  pair is a L and R adjacent to each other. There can be multiple pairs next to each if adjacent (LLRR or RRLL//LLLRRR RRR LLL).
            //Workers can grab any amount of pairs but they have to be adjacent. Return the amount of workers required for the String S. 
            //public string myFunction(string S)
            //{
            //    List<string> holdingList = new List<string>();

            //    for (int i = 0; i < S.Length; i++)
            //    {
            //        if (S[i] + S[i + 1] == 'LR' || S[i] + S[i + 1] == 'RL')
            //        {
            //            holdingList.Add("pair"); 
            //        }
            //        else if (S[i] + S[i + 1] == 'LL')
            //        {
            //            holdingList.Add("ll");
            //        }
            //        else if (S[i] + S[i + 1] == 'RR')
            //        {
            //            holdingList.Add("rr");
            //        }
            //        i++;
            //    }

            //    int result = 0;

            //    for (int j = 0; j < holdingList.Count; j++)
            //    {
            //        if (holdingList[j].Contains("pair"))
            //        {
            //            result++;
            //        }
            //    }
            //}

            //#13. Take an array of integers (pos or neg) and return the absolute value of the sum of them. (Absolute value meaning to remove
            //any negative sign in front of the integers).
            //For more practice try to make the input dynamic potentially using a List<> instead of Array.
            Console.WriteLine("Enter an array of integers to get absolute sum. #1");
            int answer13A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an array of integers to get absolute sum. #2");
            int answer13B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an array of integers to get absolute sum. #3");
            int answer13C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an array of integers to get absolute sum. #4");
            int answer13D = Convert.ToInt32(Console.ReadLine());

            clockenspiel.AbsoluteSumMethod(answer13A, answer13B, answer13C, answer13D);


            //#14. Take a user input word and return the next letter in the alphabet for the final letter in the entered word.
            Console.WriteLine("Enter a word (final letter algorithm)");
            string answer14A = Console.ReadLine();

            clockenspiel.FinalLetterMethod(answer14A);

            //#15. Take two strings as input, return the character(s) that are the same in both strings.
            Console.WriteLine("Differences in strings challenge, enter string #1");
            string answer15A = Console.ReadLine();
            Console.WriteLine("Differences in strings challenge, enter string #2");
            string answer15B = Console.ReadLine();

            clockenspiel.HammingMethod(answer15A, answer15B);

            //#16. Create function that takes two numbers, and returns the multiples of the first number by increasing index value
            //until the value matches the second number.
            Console.WriteLine("Enter number to be multiplied:");
            int answer16A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number that will be amount of times previous number is multiplied.");
            int answer16B = Convert.ToInt32(Console.ReadLine());

            clockenspiel.ArrayMultipleMethod(answer16A, answer16B);

            //#17. Create function that returns "DUCK!" if the string "bomb" exists in the user input. If it does not exist return "Relax, no bomb."
            Console.WriteLine("Enter string with or without the word 'bomb''");
            string answer17A = Console.ReadLine();

            clockenspiel.BombStringMethod(answer17A);

            //#18. Create function that takes 3 groups of int arrays of any size and returns the largest number out of each array.
            Console.WriteLine("Enter array of int's #1");
            string answer18A = Console.ReadLine();
            Console.WriteLine("Enter array of int's #2");
            string answer18B = Console.ReadLine();
            Console.WriteLine("Enter array of int's #3");
            string answer18C = Console.ReadLine();

            clockenspiel.LargestIntArraysMethod(answer18A, answer18B, answer18C);

            //#19. Collatz Conjecture. If N is even perform N/2. Then if N is odd perform N * 3 + 1. Return the amount of steps is takes
            //for N to = 1.
            Console.WriteLine("Collatz Conjecture. Enter a number.");
            int answer19A = Convert.ToInt32(Console.ReadLine());

            clockenspiel.CollatzMethod(answer19A);




            Console.ReadLine();
        }
    }
}
