using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentalTasksSolutions._2._4__Array
{
   public class ArrayTasks
    { 

        #region 2.4.1 
        public void Reverse_Array()
        {
            Console.WriteLine("Please Enter the Length of the Array");
            int length = int.Parse(Console.ReadLine());
            //Validate User Input , Check the length is avalid number 
            if (length > 0)
            {
                //Create the Array
                double[] arr = new double[length];

                //Fill the array 
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("Please Enter index {0}", i);
                    arr[i] = double.Parse(Console.ReadLine());
                }

                double[] reverse = new double[length];
                //Counter to reverse the Array
                int j = 1;
                //Fill the reversed Array 
                for (int i = 0; i < reverse.Length; i++)
                {
                    reverse[i] = arr[length - j];
                    j++;
                }
                for (int i = 0; i < reverse.Length; i++)
                {
                    Console.WriteLine(reverse[i]);
                }
            }
            else {
                Console.WriteLine("Please Enter a Valid Number");
            }

        }
        #endregion
        #region 2.4.2
        // Send the Array to the Function
        public void Sum_Array(int [] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum = {0}", sum);
        }
        #endregion
        #region 2.4.3
        public void Duplication(double [] arr)
        {
          
            //Counter to Count the Duplicated Element
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length-1; j++)
                {
                    //Check For Duplicated Element
                    if (arr[i]==arr[j+1])
                    {
                        count++; 
                    }
                } 
            } 
            Console.WriteLine("Number of duplicated Element  = {0}", count);
        }
        #endregion 
        #region 2.4.4
        public void Unique_Element(double [] arr)
        {
            int count = 0;
            int unique = 0;
            double[] arr1 = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr1[i] = arr[i];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    //Check For Duplicated Element
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count == 1)
                    unique++; 
            }
            Console.WriteLine("Number of Unique Elements = {0}", unique);
        }

        #endregion
        #region 2.4.5 
        public void Max_Min(double[] arr)
        { 

            /* 
            order the array in descending order
            Note : you Can user arr.sort() to Sort the array but it will be
            Used later
            */
            for (int i = 1; (i <= arr.Length-1); i++)
            {
                for (int j = 0; (j < arr.Length-1); j++)
                {
                    if (arr[j+1]>arr[j])
                    {
                        double temp = arr[j];
                        arr[j] = arr[j+1] ;
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Min = {0}", arr[arr.Length-1]);
            Console.WriteLine("Max = {0} ", arr[0]);


        }
        #endregion
        #region 2.4.6 
        public void CountOdd_CountEven(double [] arr)
        {
            int count_even = 0;
            int count_odd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    count_even++;
                else 
                    count_odd++;
            } 
            Console.WriteLine("Number of Even Numbers ={0}", count_even);
            Console.WriteLine("Number of odd Numbers = {0}", count_odd);

        }
        #endregion
        #region 2.4.7 
        public void Remove_Element(double[] arr, int index) {
            /*
           arrays are fixed size collection so to remove an element it means 
           that you max its value equale zero 
         */
            if (index <= (arr.Length - 1) && index>=0)
            {
                arr[index] = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                } 

            }
            else {
                Console.WriteLine("Please Enter a vlid Index");
            } 

        }
        #endregion
        #region 2.4.8 
        public void Sum_2DArray()
        {
            int row1 = 2; int row2 = 2;
            int col1 = 3; int col2 = 3;
            double[,] arr1 = new double[row1, col1];
            double[,] arr2 = new double[row2, col2];
            arr1[0, 0] = 1;
            arr1[0, 1] = 2;
            arr1[0, 2] = 3;
            arr1[1, 0] = 1;
            arr1[1, 1] = 2;
            arr1[1, 2] = 3;
            arr2[0, 0] = 1;
            arr2[0, 1] = 2;
            arr2[0, 2] = 3;
            arr2[1, 0] = 1;
            arr2[1, 1] = 2;
            arr2[1, 2] = 3;
            if (row1 == row2 && col2 == col1)
            {

                double[,] sum = new double[row1, col2];
                // Perform the Addition
                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < col1; j++)
                    {
                        sum[i, j] = arr1[i, j] + arr2[i, j];
                    }
                }
                /*Print the New Array*/
                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < col1; j++)
                    {
                        Console.Write(sum[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else {
                Console.WriteLine("Can Not perform the operation");
            }


        }
        #endregion
        #region 2.4.9
        public void SmallestNumber_2DArray()
        {
            Console.WriteLine("PLease Enter the Number of rows");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("PLease Enter the Number of Columns");
            int col = int.Parse(Console.ReadLine());
            double[,] arr = new double[row, col];
            
            //Fill The array 
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("Please Enter the value of index ({0},{1})", i, j);
                    arr[i, j] = double.Parse(Console.ReadLine());
                }
            }
            double min = arr[0, 0];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (arr[i, j] < min) {
                        min = arr[i, j];
                    }
                }
            }
            Console.WriteLine("Min = {0}", min);
        }
        #endregion
        #region 2.4.10 
        public void Sum_Diagonal()
        {
            int row = 3;
            int col = 3;
            double[,] arr = new double[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("Please enter the value of index ({0} ,{1})", i, j);
                    arr[i, j] = double.Parse(Console.ReadLine());
                }
            }
            //find the Sum of Diagonal 
            double sum = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i==j)
                    {
                        sum+=arr[i,j];
                    }
                }
            }
            Console.WriteLine("Sum of Diagonal Element = {0} ", sum);

        }
        #endregion
    }
}
