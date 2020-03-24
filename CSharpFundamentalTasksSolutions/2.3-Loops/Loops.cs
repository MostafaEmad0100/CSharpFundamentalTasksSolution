using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentalTasksSolutions.Loops
{
    class Loops
    {
        #region 2.3.1
        public void PrintNumbers() {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
        #endregion
        #region 2.3.2
        public void Print_Numbers_While() {
            int counter = 0;
            while (counter<=100)
            {
                Console.WriteLine(counter);
                counter++;
            }
        }
        #endregion
        #region 2.3.3
        public void Print_Sum_Of_Even_Numbers()
        {
            //Get Number From The User
            Console.WriteLine("Please Enter a Number");
            double num = double.Parse(Console.ReadLine());
            double sum = 0;

            //Check If Number Is Even 
            while (num % 2 == 0)
            {
                sum += num;
                Console.WriteLine("Please Reenter the Number");
                num = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("The Sum Of Even Numbers = {0} ", sum);
        }
        #endregion
        #region 2.3.4
        public void Sum_Of_Numbers() {
            //Define The Sum 
            double sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i%2==0)
                {
                    sum += i;
                }
            }

        }
        #endregion
        #region 2.3.5
        public void Sum_Numbers_DivisbleBy3()
        {
            //Define Sum 
            double sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    sum += i;
            }
            Console.WriteLine("Sum = {0} ", sum);
        }
        #endregion
        #region 2.3.6
        public void Number_Cube()
        { 
            // get Number From a User
            Console.WriteLine("Please Enter a Number");
            double num = double.Parse(Console.ReadLine());
            // Define a Variable to store the Cubic Value
            double cube = 1;
            for (int i = 0; i < 3; i++)
            {
                cube = cube * num;
            }
            Console.WriteLine("Cube = {0}", cube);
        }
        #endregion
        #region 2.3.7
        public void Even_Odd()
        {
            //Define varaible to store how many odds & evens 
            double even_Count = 0;
            double odd_Count = 0; 
           
            // Loop on each Number Between 1 t 100
            for (int i=1; i <=100;i++)
            {
                if (i % 2 == 0)
                {
                    even_Count++;
                }
                else {
                    odd_Count++;
                }
            }
            //Print How Many even Numbers 
            Console.WriteLine("there is {0} Even Numbers", even_Count); 

            //Print How Many odd Numbers
            Console.WriteLine("there is {0} Even Numbers", odd_Count);

        }
        #endregion
        #region 2.3.8
        public void Triangle_Angles()
        {
            int counter = 0;
            double sum;
            do
            {
                //Reset Sum Value to be 0 
                sum = 0;
                //Ask the User to enter the Angles Values
                Console.WriteLine("Please Enter the First Value");
                double angle1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter the First Value");
                double angle2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter the First Value");
                double angle3 = double.Parse(Console.ReadLine());

                // Calculate Sum
                sum = angle1 + angle2 + angle3;
              
                //Check Sum
                if (sum != 180)
                    counter++;

            } while (counter < 3 & sum != 180);

        }
        #endregion
    }
}
