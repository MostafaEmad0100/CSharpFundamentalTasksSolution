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

    }
}
