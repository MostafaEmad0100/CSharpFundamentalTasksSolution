using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentalTasksSolutions._2._5_Strings
{
   public class StringsTasks
   {
        #region 2.5.1
        public void SumOfArray()
        { 

            /*Ask the user to Enter a Series of Numbers Seperated by comma*/ 
            
            Console.WriteLine("Please Enter a series of numbers seperated By Comma");
            var input = Console.ReadLine();
            /*
             Split the Array of Strings By Comma 
             it will for an array of strings 
             */
            var arr = input.Split(',');
            
            // Create variable to hold the Sum of the Array
            double sum = 0; 
            for (int i = 0; i < arr.Length; i++)
            {
                 /*
                 parse each element in the array of string to double 
                */
                sum += double.Parse(arr[i]); 

            }
            Console.WriteLine("The Sum Of number");



                
        }
        #endregion
        #region 2.5.2
        public void Check_Number_in_Ascending_Order()
        { 

            /*Ask the user to Enter a Series of Numbers Seperated by comma*/
            Console.WriteLine("Please Enter a series of numbers seperated By Comma");
            var input = Console.ReadLine();
             /*
             Split the Array of Strings By Comma 
             it will for an array of strings 
              */
            var Strings_Array = input.Split(',');
            
             // Creare array of double to store the numeric Values  
             
             double[] double_Array = new double[Strings_Array.Length];
            
            // fill the array of double by parsing each element in string array
             
             for (int i = 0; i < double_Array.Length; i++)
             {
                double_Array[i] = double.Parse(Strings_Array[i]);
             } 

            //Check if numbers in Assending order 
            for (int i = 0; i < double_Array.Length-1; i++)
            {
                if (!(double_Array[i] < double_Array[i+1]))
                { 
                    Console.WriteLine("the numbers are not in ascending order"); 
                    // Note that we used return to terminate the function if the condition happened
                    return;
                } 

            } 

            
        }
        #endregion 
        #region 2.5.3  
        //Here we Send our String as a parameter to the function 
        public void Search_For_Hello_String(string input)
        {
            //Split the use input by the space to for array of strings 
           var arr = input.Split(' ');

            //Define boolean to check if the string found
            bool isFound = false;
            // Search for hello World in the Given String 
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]=="hello")
                {
                    //the word if found
                    isFound = true;
                }
            }   
            // Switch for the boolean
            switch (isFound)
            {
                case true:
                    Console.WriteLine("hell is Found");
                    break;
                case false:
                    Console.WriteLine("hello Is Not Found");
                    break;
            }

        }
        #endregion
        #region 2.5.4
        public void join_String()
        {
            // Ask the User to enter 3 Strings and join them in one String
            //Create an array to store the 3 strings 
            var words = new string[3]; 

            for (int i = 0; i < words.Length; i++)
            { 
                Console.WriteLine("Please Enter String {0}", i);
                words[i] = Console.ReadLine();
            }
            // Start join strings in one string 
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                sb.Append(words[i]);
                sb.Append(" ");
            }
            Console.WriteLine(sb);
        }

        #endregion 
        #region 2.5.5
        // send the string to the function 
        public void Count_Numbers_Of_VowelsLetters(string input)
        {
            //create array to store the Vowels Letters 
            var vowels = new char[] { 'a', 'o', 'e', 'i', 'u' };
            //Remove all spaces form the input String ans store it in input2
            var input2 = input.Replace(" ", "");
            //Deifne Conter for Vowels & COunter for Constant
            double Vowel_Counter = 0;
          
            for (int i = 0; i < vowels.Length; i++)
            {
                
                foreach (var letter in input2)
                {
                    if (vowels[i] == letter) {
                        Vowel_Counter++;
                    }
                }
            }
            Console.WriteLine("Number of Vowels = {0}", Vowel_Counter);
            Console.WriteLine("Number of constant = {0}", input2.Length - Vowel_Counter);
           
        }
        #endregion
        #region 2.5.6
        public void Check_Valid_Numbers()
        {
            Console.Write("Enter time: ");
            var input = Console.ReadLine();

            //Check if users Enter an empty String
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var components = input.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            } 

                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);
            //Check time is valid if  0<= hours <=23 and 0<= Mintues <=59 
                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
        }
        #endregion 




    }
}
