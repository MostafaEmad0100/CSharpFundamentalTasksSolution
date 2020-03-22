using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentalTasksSolutions.Mathematical_Operators
{
    class Operators
    {

        #region 2.1.1
        public void Sum_TwoNumbers()
        {
            // Get First Number From thue user 
            Console.WriteLine("PLease Enter the First Number");
            double num1 = double.Parse(Console.ReadLine()); 

            //Get the Second Number From the User
            Console.WriteLine("PLease Enter the First Number");
            double num2 = double.Parse(Console.ReadLine());

            // Perform Sum Calculation 
            double sum = num1 + num2;

            //Print the Sum to the User
            Console.WriteLine("sum = {0}", sum);
        }
        #endregion
        #region 2.1.2
        public void CircleArea()
        {
            // Define the Pi = 3.14
            const double pi = 3.14;

            //Get the Radius From the User ;
            Console.WriteLine("Please Enter the Radius Of the Circle");
            double radius = double.Parse(Console.ReadLine());

            // Calculate the Area of the Circle 
            double Area = radius * radius * pi;

            //Print the Area to the User 
            Console.WriteLine("Area = {0}", Area);
           
        }
        #endregion
        #region 2.1.3 
        public void Rectangle_Area()
        {
            // Get The Width Form the User
            Console.WriteLine("Please Enter the Width");
            double width = double.Parse(Console.ReadLine());

            // Get The Hight Form the User
            Console.WriteLine("Please Enter the Width");
            double height = double.Parse(Console.ReadLine());

            //Calculate the Area
            double Area = width * height;

            // Print the Area to the User
            Console.WriteLine("Reactangle Area = {0}", Area);

        }

        #endregion
        #region 2.1.4
        public void Triangle_Area()
        {
            //Get the length of Triangle base 
            Console.WriteLine("Please Enter The Length of Triangle Base");
            double base_Length = double.Parse(Console.ReadLine());

            //Get The Height of Triangel 
            Console.WriteLine("Please Enter The Height of Triangle");
            double hight = double.Parse(Console.ReadLine());

            //Calculate The Area 
            double Area = 0.5 * base_Length * hight; 

            //Print the Area
            Console.WriteLine("Area = {0}", Area);
        }
        #endregion
        #region 2.1.5 
        public void Math_Operations()
        {
            //Get the First Number OF the User
            Console.WriteLine("Please Enter The First number");
            double num1 = double.Parse(Console.ReadLine());

            //Get the Second Number OF the User
            Console.WriteLine("Please Enter The Second number");
            double num2 = double.Parse(Console.ReadLine());

            // Perform Operation 
            // Sum
            double sum = num1 + num2;
            //Subtraction
            double sub = num1 - num2; 
            //Multiplication
            double mul = num1 * num2;
            //Division
            double div = num1 / num2;
            //Reminder
            double rem = num1 % num2;

            //Print the Result
            Console.WriteLine("Sum =  {0}", sum);
            Console.WriteLine("Sub =  {0}", sub);
            Console.WriteLine("Mul =  {0}", mul);
            Console.WriteLine("Div =  {0}", div);
            Console.WriteLine("Rem =  {0}", rem); 

        }
        #endregion
        #region 2.1.6
        public void Find_Reminder()
        {
            // Define Numbers 
            double a = 2;
            double b = 4;
            double c = 7;

            //Print the Reminder 
            Console.WriteLine("Reminder of 2", a % 2);
            Console.WriteLine("Reminder of 4", b % 2);
            Console.WriteLine("Reminder of 7", c % 2);


        }
        #endregion
        #region 2.1.7
        public void Multiplication_Table()
        {
             //Get Number From the User
             Console.WriteLine("Please Enter a number");
            
            //Print Result
             double num = double.Parse(Console.ReadLine());
             Console.WriteLine("{0} x {1} = {2}", num, 1,  num * 1);
             Console.WriteLine("{0} x {1} = {2}", num, 2,  num * 2);
             Console.WriteLine("{0} x {1} = {2}", num, 3,  num * 3);
             Console.WriteLine("{0} x {1} = {2}", num, 4,  num * 4);
             Console.WriteLine("{0} x {1} = {2}", num, 5,  num * 5);
             Console.WriteLine("{0} x {1} = {2}", num, 6,  num * 6);
             Console.WriteLine("{0} x {1} = {2}", num, 7,  num * 7);
             Console.WriteLine("{0} x {1} = {2}", num, 8,  num * 8);
             Console.WriteLine("{0} x {1} = {2}", num, 9,  num * 9);
             Console.WriteLine("{0} x {1} = {2}", num, 10, num * 10);
             Console.WriteLine("{0} x {1} = {2}", num, 11, num * 11);
             Console.WriteLine("{0} x {1} = {2}", num, 12, num * 12);
        }
        #endregion
        #region 2.1.8
        public void Average()
        { 

            //Get Five Numbers From THe Users
            Console.WriteLine("Please Enter the First Number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Second Number");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Third Number");
            double num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Fourth Number");
            double num4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Fifth Number");
            double num5 = double.Parse(Console.ReadLine());

            //Calculate Average 
            double average = (num1 + num2 + num3 + num4 + num5) / 5;
            Console.WriteLine("Avergae = {0} ", average);
        }
        #endregion 


    }
}
