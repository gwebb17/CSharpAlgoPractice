using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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



        //#11. Take two colors as strings. Return the result of the two colors combined.
        public void TwoColorsMethod(string answer11A, string answer11B)
        {
            string lower11A = answer11A.ToLower(); //make 1st answer lowercase for less error likelihood
            string shade11A = ""; //this will be set to 1st answers general shade inside below loop to give us a smaller pool of shades to mix

            string lower11B = answer11B.ToLower();
            string shade11B = "";

            
           
            //1st answer logic
            if (lower11A == "red" || lower11A == "maroon" || lower11A == "burgundy")
            {
                shade11A = "red"; //if answer 1 is like red then set shade = red
            }
            else if (lower11A == "yellow" || lower11A == "gold")
            {
                shade11A = "yellow"; //if answer 1 is like yellow set shade = yellow
            }
            else if (lower11A == "blue" || lower11A == "turquoise" || lower11A == "cyan")
            {
                shade11A = "blue";
            }
            else if (lower11A == "orange")
            {
                shade11A = "orange";
            }
            else if (lower11A == "purple" || lower11A == "violet" || lower11A == "lavendar")
            {
                shade11A = "purple";
            }
            else if (lower11A == "green")
            {
                shade11A = "green";
            }
            else if (lower11A == "white")
            {
                shade11A = "white";
            }
            else if (lower11A == "black" || lower11A == "grey" || lower11A == "gray")
            {
                shade11A = "black";
            }


            //2nd answer logic
            if (lower11B == "red" || lower11B == "maroon" || lower11B == "burgundy")
            {
                shade11B = "red"; //if answer 1 is like red then set shade = red
            }
            else if (lower11B == "yellow" || lower11B == "gold")
            {
                shade11B = "yellow"; //if answer 1 is like yellow set shade = yellow
            }
            else if (lower11B == "blue" || lower11B == "turquoise" || lower11B == "cyan")
            {
                shade11B = "blue";
            }
            else if (lower11B == "orange")
            {
                shade11B = "orange";
            }
            else if (lower11B == "purple" || lower11B == "violet" || lower11B == "lavendar")
            {
                shade11B = "purple";
            }
            else if (lower11B == "green")
            {
                shade11B = "green";
            }
            else if (lower11B == "white")
            {
                shade11B = "white";
            }
            else if (lower11B == "black" || lower11B == "grey" || lower11B == "gray")
            {
                shade11B = "black";
            }

            //COLOR vars (need to set these in order to search using .Contains())
            string red11 = "red";
            string blue11 = "blue";
            string green11 = "green";
            string yellow11 = "yellow";
            string orange11 = "orange";
            string purple11 = "purple";
            string white11 = "white";
            string black11 = "black";


            string combined11AB = shade11A + shade11B;  //have to combine them below the above logic or else value isn't updated
            string TwoColorsMethodResult = "";


            //Final logic to determine final shade
            if (combined11AB.Contains(red11) && combined11AB.Contains(yellow11)) //by using .Contains we avoid making double the logic to check
                                                                                 //the possible combinations of strings
            {
                TwoColorsMethodResult = orange11;
                Console.WriteLine(TwoColorsMethodResult);
            }
            else if (combined11AB.Contains(yellow11) && combined11AB.Contains(blue11))
            {
                TwoColorsMethodResult = green11;
                Console.WriteLine(TwoColorsMethodResult);
            }
            else if (combined11AB.Contains(blue11) && combined11AB.Contains(red11))
            {
                TwoColorsMethodResult = purple11;
                Console.WriteLine(TwoColorsMethodResult);
            }
            else if (combined11AB.Contains(red11) && combined11AB.Contains(orange11))
            {
                TwoColorsMethodResult = "red orange";
                Console.WriteLine(TwoColorsMethodResult);
            }
            else if (combined11AB.Contains(yellow11) && combined11AB.Contains(green11))
            {
                TwoColorsMethodResult = "yellow green";
                Console.WriteLine(TwoColorsMethodResult);
            }
            else if (combined11AB.Contains(blue11) && combined11AB.Contains(purple11))
            {
                TwoColorsMethodResult = "blue violet";
                Console.WriteLine(TwoColorsMethodResult);
            }
            else if (combined11AB.Contains(red11) && combined11AB.Contains(purple11))
            {
                TwoColorsMethodResult = "red violet";
                Console.WriteLine(TwoColorsMethodResult);
            }
            else if (combined11AB.Contains(yellow11) && combined11AB.Contains(orange11))
            {
                TwoColorsMethodResult = "yellow orange";
                Console.WriteLine(TwoColorsMethodResult);
            }
            else if (combined11AB.Contains(blue11) && combined11AB.Contains(green11))
            {
                TwoColorsMethodResult = "blue green";
                Console.WriteLine(TwoColorsMethodResult);
            }
            //FOR WHITE
            else if (combined11AB.Contains(white11))
            {
                string holderWhite = "light "; //our adjective to describe a lighter shade if white is involved
                if (shade11A.Contains(white11)) //need logic to determine which part of user string contains "white"
                {
                    holderWhite += shade11B; //since shade11A holds white in this case we can just add the other answer shade11B to result
                }
                else if (shade11B.Contains(white11))
                {
                    holderWhite += shade11A; 
                }
                TwoColorsMethodResult = holderWhite;
                Console.WriteLine(TwoColorsMethodResult);
            }
            //FOR BLACK
            else if (combined11AB.Contains(black11))
            {
                string holderBlack = "dark ";
                if (shade11A.Contains(black11))
                {
                    holderBlack += shade11B;
                }
                else if (shade11B.Contains(black11))
                {
                    holderBlack += shade11A;
                }
                TwoColorsMethodResult = holderBlack;
                Console.WriteLine(TwoColorsMethodResult);
            }
        }
        //END TWOCOLORSMETHOD --------------------------------------------------------------------------

        //#12. Unfinished

        //#13. Take an array of integers (pos or neg) and return the absolute value of the sum of them. (Absolute value meaning to remove
        //any negative sign in front of the integers).
        //**USING ELEMENTAT REQUIRES the using statement: Using System.Linq; in top
        public void AbsoluteSumMethod(int answer13A, int answer13B, int answer13C, int answer13D)
        {
            int[] holdingArray13 = new int[4]; //Must define amount of indices for array
            holdingArray13[0] = answer13A;
            holdingArray13[1] = answer13B;
            holdingArray13[2] = answer13C;
            holdingArray13[3] = answer13D;

            for (int i = 0; i < holdingArray13.Length; i++)
            {
                if (holdingArray13[i] < 0)
                {
                    holdingArray13[i] *= -1;
                }
                int AbsoluteSumMethodResult = holdingArray13[0] + holdingArray13[1] + holdingArray13[2] + holdingArray13[3];
                Console.WriteLine(AbsoluteSumMethodResult);
            }
        }

        //#14. Take a user input word and return the next letter in the alphabet for the final letter in the entered word.
        public void FinalLetterMethod(string answer14A)
        {
            string holding14A = ""; //can't use char for an empty placeholder, (Doesn't require conversion to char later either)
            string[] holding14B = new string[] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", //initialize array for alphabet
            "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
            string FinalLetterMethodResult = ""; //initialize empty string in order to adjust value in below loops 
            

            for (int i = 0; i < answer14A.Length; i++)
            {
                holding14A = Convert.ToString(answer14A[i]); //answer14A[i] is now equal to the final letter of user entered word.

                if (holding14B.Contains(holding14A))
                {
                    for (int j = 0; j < holding14B.Length - 1; j++) //2nd loop to iterate through alphabet array and keep track of where we are
                    {
                        if (holding14B[j] == holding14A) //if current letter in alphabet array loop == final letter in user entered word
                        {
                            FinalLetterMethodResult = holding14B.ElementAt(j + 1); //result var == array element (letter) at current iterator value + 1
                            //by using ElementAt we don't get the numeric value of j returned and instead get the ARRAY's value (letter)
                            //then just increment by 1 element giving us the NEXT element in array and not the next number value of j's iteration
                            break; //breaking here keeps us from continually increasing j's value when we hit the desired letter matching user input
                        }
 
                    }
                }
            }
            Console.WriteLine(FinalLetterMethodResult);
        }


    }
}
