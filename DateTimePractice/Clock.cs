﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DateTimePractice
{
    public class Clock
    {
        public DateTime baseTime { get; set; }
        public DateTime militaryTime { get; set; }



        public int Method1(out int methodOneResult, int answer1A, int answer2A)
        {
            methodOneResult = answer1A + answer2A;
            Console.WriteLine(methodOneResult);
            return methodOneResult;
        }

        public int NextMethod(out int NextMethodResult, int answer3A)
        {
            NextMethodResult = answer3A + 1;
            Console.WriteLine(NextMethodResult);
            return NextMethodResult;
        }

        public int AgeMethod(out int AgeMethodResult, int answer4A)
        {
            AgeMethodResult = answer4A * 365;
            Console.WriteLine(AgeMethodResult);
            return AgeMethodResult;
        }

        public int RectangleMethod(out int RectangleMethodResult, int answer5A, int answer5B)
        {
            RectangleMethodResult = 2 * answer5A * answer5B;
            Console.WriteLine(RectangleMethodResult);
            return RectangleMethodResult;
        }

        public string MonthMethod(out string MonthMethodResult, int answer6A)
        {
            
            if (answer6A == 1)
            {
                MonthMethodResult = "January";
                Console.Write(MonthMethodResult);
                return MonthMethodResult;
            }
            else if (answer6A == 2)
            {
                MonthMethodResult = "February";
                Console.WriteLine(MonthMethodResult);
                return MonthMethodResult;
            }
            else if (answer6A == 3)
            {
                MonthMethodResult = "March";
                Console.WriteLine(MonthMethodResult);
                return MonthMethodResult;
            }
            else if (answer6A == 4)
            {
                MonthMethodResult = "April";
                Console.WriteLine(MonthMethodResult);
                return MonthMethodResult;
            }
            else if (answer6A == 5)
            {
                MonthMethodResult = "May";
                Console.WriteLine(MonthMethodResult);
                return MonthMethodResult;
            }
            else if (answer6A == 6)
            {
                MonthMethodResult = "June";
                Console.WriteLine(MonthMethodResult);
                return MonthMethodResult;
            }
            else if (answer6A == 7)
            {
                MonthMethodResult = "July";
                Console.WriteLine(MonthMethodResult);
                return MonthMethodResult;
            }
            else if (answer6A == 8)
            {
                MonthMethodResult = "August";
                Console.WriteLine(MonthMethodResult);
                return MonthMethodResult;
            }
            else if (answer6A == 9)
            {
                MonthMethodResult = "September";
                Console.WriteLine(MonthMethodResult);
                return MonthMethodResult;
            }
            else if (answer6A == 10)
            {
                MonthMethodResult = "October";
                Console.WriteLine(MonthMethodResult);
                return MonthMethodResult;
            }
            else if (answer6A == 11)
            {
                MonthMethodResult = "November";
                Console.WriteLine(MonthMethodResult);
                return MonthMethodResult;
            }
            else if (answer6A == 12)
            {
                MonthMethodResult = "December";
                Console.WriteLine(MonthMethodResult);
                return MonthMethodResult;
            }
            else
            {
                MonthMethodResult = "Nothing";
                return MonthMethodResult;
            }
            
        }

        //Loop through an array of user entered values and multiply each item in the array by the array's length
        //Return each result 
        public void ArrayMethod(int answer7A, int answer7B, int answer7C, int answer7D)
        {
            int[] aRay = { answer7A, answer7B, answer7C, answer7D };

            for (int i = 0; i < aRay.Length; i++)
            {
                int j = aRay[i] * aRay.Length;
                Console.WriteLine(j);
            }


        }


        //Write a C# Sharp program that takes four numbers as input to calculate and print the average
        public double AverageMethod(out double AverageMethodResult, List<int>list8A)
        {
                int answer8XA = list8A[0] + list8A[1] + list8A[2] + list8A[3];
                AverageMethodResult = answer8XA / list8A.Count;  //.Count is similar in use to .Length but for Lists
                Console.WriteLine(AverageMethodResult);
                return AverageMethodResult;           
        }


        //#9 Ask user for a word. Return the letter that occurs most in the word.
        //public void CountLettersMethod(string answer9A)
        //{
        //    Dictionary<char, int> dictionary9A = new Dictionary<char, int>(); //create empty dictionary object
        //    var value = 0;
        //    foreach (char letter in answer9A)
        //    {
        //        for (int i = 0; i < answer9A.Length; i++)
        //        {
        //            if (letter != answer9A[i])
        //            {
        //                value = 1;
        //            }
        //            else
        //            {
        //                value++;
                        
        //            }
        //        }
        //        dictionary9A.Add(letter, value); //breaks program because key has already been added to dictionary

        //    }
            
        //    Console.WriteLine(dictionary9A.Keys);
            
        //}


        //#10. Ask user for a word. Return every other letter in the word as a string.
        public string SkipLettersMethod(out string SkipLettersMethodResult, string answer10A)
        {
            string holder10A = ""; //make empty string outside of for loop and if statement so it can be used outside of them

            for (int i = 0; i < answer10A.Length; i++)
            {
                if (i == 0 || i % 2 == 0) //if current iteration is 0 index or i == even number add that index to string
                {
                    holder10A += Convert.ToString(answer10A[i]);
                }
            }
            SkipLettersMethodResult = holder10A;
            Console.WriteLine(SkipLettersMethodResult);
            return SkipLettersMethodResult;
        }



    }
}
