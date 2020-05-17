using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentalTasksSolutions.Dates
{
    public class DatesTasks
    { 

        // Assume start Date with this tasks 1 jan 2020 
        #region 2.6.1  
      
        public void Actcivities()
        { 


            #region  2.6.1 Find_Duaration_Activity1 


            //Enter the activites Start Date
            //String will be in MM/DD/YYYY formate
            Console.WriteLine("Please Enter the Start Date");
            var Start_Date = Console.ReadLine();
            //Enter Actvity1 Duaraion
            Console.WriteLine("Please Enter the Duration of Activity 1");
            var Activity1_Duartion = double.Parse(Console.ReadLine());
            DateTime Activity1_StartDate = DateTime.Parse(Start_Date);
            DateTime Activity1_End_Date = Activity1_StartDate.AddDays(Activity1_Duartion);
            Console.WriteLine("Activit1 End Date = {0}" , Activity1_End_Date.ToLongDateString());


            #endregion

            #region 2.6.2 Find_Duartion_Activity2 
            // From the Last we have 2 informations 
            // 1- we have the end date of Activity 1 
            // 2- we have start date of Activity 1 and Activity 2 will have the same start date

            var Activity2_End_Date = Activity1_End_Date.AddDays(10);
            var Activity2_Duartion = (Activity2_End_Date - Activity1_StartDate).TotalDays;
            Console.WriteLine("Activity2_Duartion = {0}", Activity2_Duartion);
            #endregion

            #region 2.6.3 Find EndDate_Activity3 
            //based on previous steps and task information we have the following informations 
            //Activity3 is finish to start with Activity 1, so Activtiy 3 Start Date 
            //will be the end date of the Activity 1 
            var Activity3_StartDate = Activity1_StartDate.AddDays(Activity1_Duartion);
            //Activity 3 Duartion is 45 Day 

            var Activity3_EndDate = Activity3_StartDate.AddDays(45); 
            Console.WriteLine("Activity3_EndDate = {0}", Activity3_EndDate.ToLongDateString());
            #endregion

            #region 2.6.4 Find EndDate_Activity4 
            //based on task information and previous steps 
            //task 4 is in Finish to start with Activty 2 so 
            //1-start Date of the Activtiy4 will be the End Date of Activity1 
            var Activity4_StartDate = Activity2_End_Date;
            //Activity4  Duartion = 20 Days 
            var Activity4_EndDate = Activity4_StartDate.AddDays(20);
            Console.WriteLine("Activity4_EndDate = {0}", Activity4_EndDate.ToLongDateString());


            #endregion

            #region 2.6.5  Find Start_and_End_Date_Activity 5
             // based on tasks info and previous steps 
            // Activity 5 is in start to start Relationship with Activity 4 so 
           // Activity 5 startDate will equal Activty 4 startDate   

            var Activity5_StartDate = Activity4_StartDate;
            //Activity 5 Duartion
            var Activity5_EndDate = Activity5_StartDate.AddDays(4);

            Console.WriteLine("Activity5_StartDate = {0}", Activity5_StartDate);
            Console.WriteLine("Activity5_EndDate = {0}", Activity5_EndDate);


            #endregion

            #region 2.6.6 Max_EndDate
            //Create an Array of DateTime to Find the Max End Date 
            DateTime[] dates = new DateTime[5] { Activity1_End_Date, Activity2_End_Date, Activity3_EndDate, Activity4_EndDate, Activity5_EndDate }; 
            //Get Max end Date
            var Project_duartion = (dates.Max()-Activity1_StartDate).TotalDays;
            Console.WriteLine("Project_duartion = {0} ", Project_duartion);
            #endregion

        }
        #endregion


    }
}
