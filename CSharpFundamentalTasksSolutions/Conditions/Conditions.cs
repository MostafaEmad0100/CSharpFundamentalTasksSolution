using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentalTasksSolutions.Conditions
{
    class Conditions
    {
        #region 2.2.1
        public void CheckNUmberIsPositive()
        {
            //Get Number From a user 
            Console.WriteLine("PLease ENter a number");
            double num = double.Parse(Console.ReadLine());

            //Check IF number is Greater Than 0
            if (num > 0)
                Console.WriteLine("The Number Is Positve");
            else {
                Console.WriteLine("THe Number is Negative");
            }
        }
        #endregion
        #region 2.2.2
        public void Check_NUmbers_Equality()
        {
            //Get the First NUmber From the User
            Console.WriteLine("PLease Enter the First Number");
            double num1 = double.Parse(Console.ReadLine());

            //Get the Second Number From the User
            Console.WriteLine("PLease Enter the First Number");
            double num2 = double.Parse(Console.ReadLine());

            //Get Difference Between the two Numbers
            var diff = num1 - num2;

            //Switch on difference
            switch (diff)
            {
                case 0:
                    Console.WriteLine("The Two Numbers are Equal");
                    break;
                default:
                    Console.WriteLine("The Two Numers are not  equal");
                    break;
            }
        }
        #endregion
        #region 2.2.3
        public void check_Greater_Number()
        {
            //Get the First Number From the User 
            Console.WriteLine("Please Enter the First Numbers");
            double num1 = double.Parse(Console.ReadLine());

            //Get the Second Number From the User 
            Console.WriteLine("Please Enter the First Numbers");
            double num2 = double.Parse(Console.ReadLine());

            //Check If the First Number is Greater 
            if (num1 > num2)
                Console.WriteLine("the First Number Greater than the Second");
            else {
                if (num1 == num2)
                    Console.WriteLine("The  Two Numbers Rea Equal");
                else
                    Console.WriteLine("The Second Number is Greater than the First Number");
            }

        }
        #endregion
        #region 2.2.4
        public void Odd_Or_Even()
        {
            //Get the Number From the User 
            Console.WriteLine("Please Enter the Number");
            double num = double.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("The Number Is Even");
            else {
                Console.WriteLine("The Number is Odd");
            }
        }
        #endregion
        #region 2.2.5
        public void Check_User_Value()
        {
            //Get Number From the User 
            Console.WriteLine("Please Enter a number");
            double num = double.Parse(Console.ReadLine());
            //Switch on a number 
            switch (num)
            {
                case 10:
                    Console.WriteLine("You Entered the Real Number");
                    break;
                default:
                    Console.WriteLine("you Entered a Wrong Value");
                    break;
            }
        }
        #endregion
        #region 2.2.6
        public void Check_Triangle_Angles_Values()
        {
            //Get The First Angle value
            Console.WriteLine("Please Enter the Value Of the First Angle");
            double angle1 = double.Parse(Console.ReadLine());

            //Get The Second Angle value
            Console.WriteLine("Please Enter the Value Of the Second Angle");
            double angle2 = double.Parse(Console.ReadLine());

            //Get The Third Angle value
            Console.WriteLine("Please Enter the Value Of the Third Angle");
            double angle3 = double.Parse(Console.ReadLine());

            //Calcualte the total Angles Values
            double sum = angle1 + angle2 + angle3;

            //Switch on the sum 
            switch ( sum)
            {
                case 180:
                    Console.WriteLine("The Angles Form a Triangle");
                    break;
                default:
                    Console.WriteLine("the ANgles Does not form a Traingle");
                    break;
            }
        }
        #endregion
        #region 2.2.7
        public void Check_Student_Grade()
        {
            //Get the Student Grade 
            Console.WriteLine("Please Enter The Student Grade");
            double grade = double.Parse(Console.ReadLine());

            //Fail
            if (grade > 0 && grade < 50)
                Console.WriteLine("Fail");
            //Pass
            if (grade >= 50 && grade < 65)
                Console.WriteLine("Pass");
            //Good
            if (grade >= 65 && grade < 75)
                Console.WriteLine("Good");
            //V.Good
            if (grade >= 75 && grade < 85)
                Console.WriteLine("V.Good");
            //Excellent
            if (grade >= 85 && grade < 100)
                Console.WriteLine("Excellent");
        }
        #endregion
        #region 2.2.8 
        public void Student_Matching_Grade()
        {
            // Get the Value From the User 
            Console.WriteLine("Please Enter a Value");
            char Letter = char.Parse(Console.ReadLine());

            // Switch on a letter;
            switch (Letter)
            {
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                case 'P':
                    Console.WriteLine("Pass");
                    break;
                case 'G':
                    Console.WriteLine("Good");
                    break;
                case 'V':
                    Console.WriteLine("V.Good");
                    break;
                case 'E':
                    Console.WriteLine("Exellent");
                    break;
            }

        }
        #endregion
        #region 2.2.9
        public void Check_Month_Name()
        {
            // Get a Number From a User
            Console.WriteLine("Please Enter a Number");
            double num = double.Parse(Console.ReadLine());

            // Check If Number Is Between 1 & 12 
            if (num>=1 && num <= 12)
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Jan , 31 Days");
                        break;
                    case 2:
                        Console.WriteLine("Feb , 28 Days");
                        break;
                    case 3:
                        Console.WriteLine("Mar , 31 Days");
                        break;
                    case 4:
                        Console.WriteLine("April , 30 Days");
                        break;
                    case 5:
                        Console.WriteLine("May , 31 Days");
                        break;
                    case 6:
                        Console.WriteLine("Jun , 30 Days");
                        break;
                    case 7:
                        Console.WriteLine("Jul , 31 Days");
                        break;
                    case 8:
                        Console.WriteLine("Aug , 31 Days");
                        break;
                    case 9:
                        Console.WriteLine("Sep , 30 Days");
                        break;
                    case 10:
                        Console.WriteLine("Act , 31 Days");
                        break;
                    case 11:
                        Console.WriteLine("Nov , 30 Days");
                        break;
                    case 12:
                        Console.WriteLine("Dec , 31 Days");
                        break;
                }
            }
            else
            {
                Console.WriteLine("You Entered inValid Number");
            }

        }

        #endregion
        #region 2.2.10
        public void Equation_Roots() {
            // ax2 + bx + c= 0;

            double d, x1, x2;
            Console.Write("\n\n");
            Console.Write("Calculate root of Quadratic Equation :\n");
            Console.Write("----------------------------------------");
            Console.Write("\n\n");

            //Get equation paramter;
            Console.Write("Input the value of a : ");
           double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the value of b : ");
           double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the value of c : ");
           double c = Convert.ToDouble(Console.ReadLine());
            //Calculate d 
            d = b * b - 4 * a * c;
            if (d == 0)
            {
                Console.Write("Both roots are equal.\n");
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.Write("First  Root Root1= {0}\n", x1);
                Console.Write("Second Root Root2= {0}\n", x2);
            }
            else if (d > 0)
            {
                Console.Write("Both roots are real and diff-2\n");

                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.Write("First  Root Root1= {0}\n", x1);
                Console.Write("Second Root root2= {0}\n", x2);
            }
            else
                Console.Write("Root are imeainary;\nNo Solution. \n\n");
        }
    }
        #endregion


     
}
