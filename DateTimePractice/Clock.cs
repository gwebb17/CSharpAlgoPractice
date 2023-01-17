using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; //This is necessary to utilize the ElementAt method (used in #14). 

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
        public double AverageMethod(out double AverageMethodResult, List<int> list8A)
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


            for (int i = 0; i < answer14A.Length; i++) //Unecessary loop, instead set below variable by saying "if (answer14A.Length - 1 == i)
            {
                holding14A = Convert.ToString(answer14A[i]); //answer14A[i] is now equal to the final letter of user entered word.

                if (holding14B.Contains(holding14A))
                {
                    for (int j = 0; j < holding14B.Length - 1; j++) //2nd loop to iterate through alphabet array and keep track of where we are
                    {
                        if (holding14B[j] == holding14A) //if current letter in alphabet array loop == final letter in user entered word
                        {
                            FinalLetterMethodResult = holding14B.ElementAt(j + 1); //result var == array element (letter) at current iterator value + 1
                            Console.WriteLine(FinalLetterMethodResult);
                            //by using ElementAt we don't get the numeric value of j returned and instead get the ARRAY's value (letter)
                            //then just increment by 1 element giving us the NEXT element in array and not the next number value of j's iteration
                            //ElementAt method requires Using System.Linq 
                            break; //breaking here keeps us from continually increasing j's value when we hit the desired letter matching user input
                        }

                    }
                }
            }
            Console.WriteLine(FinalLetterMethodResult);
        }

        //#15. Take two strings, return the character(s) that are the same in both strings.
        //****Needs further revision, currently will return a duplicate char in the event that our test strings have more than one consecutive letter in common.***
        //Works for words that do not have consecutive letters that are the same however.
        public void HammingMethod(string answer15A, string answer15B)
        {
            List<char> holdingList15 = new List<char>(); //need a list of chars to fill with our resulting same chars later

            for (int i = 0; i < answer15A.Length; i++) //iterate through first answer
            {
                for (int j = 0; j < answer15B.Length; j++) //iterate through second answer
                {
                    if (answer15A[i].Equals(answer15B[j])) //if current iterator char on first answer == the current iterator char on second answer
                    {
                        holdingList15.Add(answer15A[i]); //then we add that char to our result list
                    }
                }

            }

            for (int h = 0; h < holdingList15.Count; h++) //third loop in order to print the chars that the two strings have in common
            {
                Console.WriteLine(holdingList15[h]);
            }
        }


        //#16. Create function that takes two numbers, and returns the multiples of the first number by increasing index value until the value matches 
        //the second number.
        public void ArrayMultipleMethod(int answer16A, int answer16B)
        {
            int result16 = 0;
            for (int i = 1; i < answer16B + 1; i++)
            {
                result16 = answer16A * i;
                Console.WriteLine(result16);
            }
        }

        //#17. Create function that returns "DUCK!" if the string "bomb" exists in the user input. If it does not exist return "Relax, no bomb."
        public void BombStringMethod(string answer17A)
        {
            string result17 = answer17A.ToLower();
            if (result17.Contains("bomb"))
            {
                Console.WriteLine("DUCK!");
            }
            else
            {
                Console.WriteLine("Relax, there is no bomb.");
            }
        }

        //#18. Create function that takes 3 arrays of ints and returns the largest number out of each array. Separate each int with a space.
        public void LargestIntArraysMethod(string answer18A, string answer18B, string answer18C)
        {
            string[] stringArray18A = answer18A.Split(' ').ToArray(); //create array of strings containing each number in answer18A
            int[] intArray18A = Array.ConvertAll(stringArray18A, Int32.Parse); //initialize int[] and fill it with each element in stringArray18A
            int result18A = intArray18A.Max();

            string[] stringArray18B = answer18B.Split(' ').ToArray();
            int[] intArray18B = Array.ConvertAll(stringArray18B, Int32.Parse);
            int result18B = intArray18B.Max();

            string[] stringArray18C = answer18C.Split(' ').ToArray();
            int[] intArray18C = Array.ConvertAll(stringArray18C, Int32.Parse);
            int result18C = intArray18C.Max();

            List<int> finalResult18A = new List<int>(); //final result will be list of each Max int from the 3 arrays.
            finalResult18A.Add(result18A); //add each highest value from the three arrays to our List of int's
            finalResult18A.Add(result18B);
            finalResult18A.Add(result18C);

            for (int i = 0; i < finalResult18A.Count; i++)
            {
                Console.WriteLine(finalResult18A.ElementAt(i)); //print all the elements of our list of highest values.
            }
        }

        //#19. Collatz Conjecture. If N is even perform N/2. Then if N is odd perform N * 3 + 1. Return the amount of steps is takes
        //for N to = 1.
        public void CollatzMethod(int answer19A)
        {
            int counter19 = 0;

            while (answer19A > 1)
            {
                if (answer19A % 2 == 0) //if N is even
                {
                    answer19A /= 2;
                    counter19++;
                    Console.WriteLine("Current value of N = {0}", answer19A);
                }
                else if (answer19A % 2 != 0) //if N is odd
                {
                    answer19A = answer19A * 3 + 1;
                    counter19++;
                    Console.WriteLine("Current value of N = {0}", answer19A);
                }
                else if (answer19A == 1)
                {
                    break;
                }
                Console.WriteLine("Current # of steps taken = {0}", counter19);
            }              
        }

        //#20. Given an array and an int input, return an array containing the two adjacent indices of array that = input.
        //public void TwoSumMethod(string nums, int target)
        //{
        //    string[] stringArray20A = nums.Split(' ').ToArray(); //create array containing each string int from nums
        //    int[] intArray20A = Array.ConvertAll(stringArray20A, Int32.Parse); //Convert stringArray20A into int Array

        //    Dictionary<int, int> result = new Dictionary<int, int>(); //initialize empty dictionary of ints
        //    int[] holdingArray20 = new int[2];

        //    //test values: nums = [0, 1, 2, 3, 4, 5]   target = 9;

        //    for (int i = 0; i < intArray20A.Length; i++)
        //    {
        //        if (result.ContainsKey(target-nums[i]))
        //        {
        //            result = 
        //        }
        //    }
        //}

        //#21. Keep track function. Return how many times a letter or number appears in an array.
        public void KeepTrackMethod(string answer21)
        {
            Dictionary<char, int> tracker = new Dictionary<char, int>(); 
            int counter = 1; //minimum value is 1 since each char in answer21 must appear at least once
            string resultKey = "";

            try
            {
                for (int i = 0; i < answer21.Length; i++)
                {
                    tracker.Add(answer21[i], counter); //add each char from answer21 as a key in our tracker dictionary
                    resultKey = Convert.ToString(answer21[i]);
                }
            } 
            catch( System.ArgumentException) //using because this is indicator of key already existing in dictionary. workaround for
            //KeyAlreadyAdded error being thrown. 
            {
                counter++;
                Console.WriteLine("The letter that occurs most is {0}, and it occurs {1} times.", resultKey, counter);
            }
        }

        //#22. Take a single string as an argument. Return an array containing the inidces of the capital letters of the string.
        public void IndexCapitalLettersMethod(string answer22)
        {
            char[] charArray22 = answer22.ToCharArray(); //First convert string to Char array so indices can be returned later
            //by making it a Char Array, we can use the Char.IsUpper() method to check if it's uppercase later
            
            int[] resultArray22 = new int[answer22.Length]; //Next initialize our result array which contains ints corresponding 
            //to indices of result22, we use the length of input string answer22 as array's length

            for (int i = 0; i < charArray22.Length; i++)
            {  
               bool finalResult22 = Char.IsUpper(charArray22.ElementAt(i)); //using a boolean to see if every element in the
                //char array is an uppercase with Char.IsUpper()

               if (finalResult22) //if a char is an uppercase
               {
                   resultArray22[i] = i; //add that char's index value to resultArray22 at [i]
                   Console.WriteLine(resultArray22.ElementAt(i)); //now print the elements of resultArray22
               }               
            }
        }

        //#23. Given a fraction as a string, return whether the fraction is greater than 1.0
        public void FractionMethod(string answer23)
        {
            string[] resultArray23 = answer23.Split('/').ToArray();
            

            for (int i = 0; i < resultArray23.Length - 1; i++)
            {
                int comparisonIndexA = Convert.ToInt32(resultArray23[i]);
                int comparisonIndexB = Convert.ToInt32(resultArray23[i + 1]);

                if (comparisonIndexA > comparisonIndexB)
                {
                    bool result23;
                    result23 = true;
                    Console.WriteLine(result23);
                }
                else if (comparisonIndexA <= comparisonIndexB)
                {
                    bool result23;
                    result23 = false;
                    Console.WriteLine(result23);
                }                
            }
        }

        //#24. Check if a number is a palindrome (the same when written in reverse).
        public void PalindromeMethod(string answer24)
        {
            List<char> stringList = new List<char>();
            List<char> stringListB = new List<char>();
            
            foreach (char C in answer24)
            {
                stringList.Add(C); //Add each char of answer24 to stringList
            }

            for (int i = stringList.Count - 1; i > 0; i--)
            {
                stringListB.Add(stringList[i]); //Going in descending order (this way the second list stringListB is reversed)               
            }
            stringListB.Add(stringList[0]); //Since the above descending iteration won't include the 0 index of stringList, we add it manually after

            string resultString = new string(stringList.ToArray()); //In order to use .Contains we need both lists to be strings or string Arrays
            string resultStringB = new string(stringListB.ToArray()); //So we convert them to strings using ToArray();


            if (resultString.Contains(resultStringB)) //Doesn't work when we tried "if resultString.Equals(resultStringB))"
            //And using multiple loops will be messy and can't overwrite values from outside the loops correctly in this case
            //We see if resultString.Contains resultStrinB in order to see if they are "equal" strings thereby defining if they are palindromes or not.
            {
                Console.WriteLine("This is a palindrome");
            }
            else
            {
                Console.WriteLine("This is not a palindrome");
            }
        }


        //#25. Maskify a string. Take a string as input and return a string that obscures all but the last 4 letters as # signs.
        public void MaskifyMethod(string answer25)
        {
            char[] resultString25 = new char[answer25.Length]; 

            if (answer25.Length > 4) //for results with more than 4 digits
            {
                answer25.CopyTo(0, resultString25, 0, answer25.Length); //copy everything from answer25 to resultString25

                for (int i = 0; i < resultString25.Length - 4; i++) //go through resultString25 except last 4 digits
                {
                    resultString25[i] = '#'; //turn every digit into a '#' (excluding last 4)
                }
            }
            else if (answer25.Length > 0 && answer25.Length <= 4) //for results with 1-4 digits
            {
                answer25.CopyTo(0, resultString25, 0, answer25.Length); //copy everything to resultString25
            }
            else if (answer25.Length == 0) //for empty results
            {
                Console.WriteLine(""); //write blank line
            }
        
            for (int i = 0; i < resultString25.Length; i++)
            {
                Console.WriteLine(resultString25.ElementAt(i)); //print all elements of finished resultString25
            }            
        }

        //#26. Create a function that takes any non-negative number as an argument and return it with its digits in descending order.
        public void DescendingOrderMethod(string answer26)
        {
            List<char> tempCharList = new List<char>();
            List<int> tempIntList = new List<int>();

            foreach (char C in answer26)
            {
                tempCharList.Add(C);
            }

            foreach (char D in tempCharList)
            {
                int value = (int)Char.GetNumericValue(D); //transpose the elements in char list to their numeric value equivalent (value)
                tempIntList.Add(value); //add value to tempIntList
            }

            int[] numbers = tempIntList.ToArray(); //transpose tempIntList into an int Array

            Array.Sort(numbers); //sort array items in ascending order
            Array.Reverse(numbers); //reverse the array to print descending

            for (int h = 0; h < numbers.Length; h++)
            {
                Console.WriteLine(numbers.ElementAt(h));
            }
                       
        }

        //#27. Write a function that returns the greatest common divisor of two numbers.
        public void GCDMethod(int answer27A, int answer27B)
        {
            List<int> intList27A = new List<int>(); //initalize two Lists to contain every divisor for each input answer
            List<int> intList27B = new List<int>();

            for (int i = 1; i < answer27A + 1; i++) // need to say answer27A + 1 because we need the loop to include answer27A as a divisor
            {                                       // don't need to start at 0 for i since anything divided by 0 is 0/unecessary

                if (answer27A % i == 0)//Iterates through each # including answer27A and finds all divisors 
                {
                    int greatestComDivA = i; //continually sets gCDA to divisors of answer27A stopping with highest
                    intList27A.Add(greatestComDivA); //add each divisor to first List
                }        
            }
            for (int j = 1; j < answer27B + 1; j++) //repeat above loop with second List
            {

                if (answer27B % j == 0)
                {
                    int greatestComDivB = j;
                    intList27B.Add(greatestComDivB);
                }
                
            }

            List<int> finalResult27 = new List<int>(); //initialize third list to now add values that both Lists have in common below

            for (int k = 0; k < intList27B.Count; k++)
            {
                
                if (intList27A.Contains(intList27B[k])) //if List 1 contains any values that List 2 does...
                {
                    finalResult27.Add(intList27B.ElementAt(k)); //add that value to List 3
                    
                }               
            }
            int[] result = finalResult27.ToArray(); //in order to Sort we need List 3 as an array
            Array.Sort(result);
            Console.WriteLine(result.Last()); //now we just need the last element of result Array which will be highest value both holding Lists have in common
        }
    }
}
