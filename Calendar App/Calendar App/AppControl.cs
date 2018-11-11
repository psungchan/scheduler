using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar_App
{
    class AppControl
    {

        private string currentMonth;
        private string currentDay;
        private int currentYear;

        private string[] MONTHS = {"January","February","March", "April", "May", "June","July", "August", "September", "October", "November","December"};
        private int[] DAYS = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        private string[] WEEKDAYS = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};

        public AppControl(string currentMonth, string currentDay, int currentYear) {

            this.currentDay = currentDay;
            this.currentYear = currentYear;
            this.currentMonth = currentMonth;
        }
    
        ///*
        public int dayToDisplay(int month, int year){
            int firstDay = firstDayOfMonth(month, year);

            int tempDay = 1;
            int tempDayOfWeek = 1;
            bool firstDisplay = false;
            int toDisplay;

            while (tempDay < DAYS[month]){
                if (tempDayOfWeek == firstDay){ //Checks if current day of week is first day of month
                    firstDisplay = true;
                    firstDay = 0; //Prevents retrigger
                }

                if (firstDisplay == true) { //If days of month have started
                    toDisplay = tempDay; //Use this for display
                    tempDay++; //Increment day
                }

                if (tempDayOfWeek == 7){ //Resets day of week
                    tempDayOfWeek = 1;
                }
                else{
                    tempDayOfWeek++;
                }
            }


        }
        //*/


        public int firstDayOfMonth(int givenMonth, int givenYear){

            if(givenMonth < 3){ //Modification to Jan, Feb for function
                givenYear = givenYear - 1;
                givenMonth = 10 + givenMonth;
            }else{ //Shifts months for functino
                givenMonth = givenMonth - 2;
            }

            int century = givenYear / 100; //Gets first two numbers in year
            int year = givenYear % 100; //Gets last two numbers in year
            int partOne = (int)((2.6 * givenMonth) - 0.2); 
            int partTwo = (int)(year / 4);
            int partThree = (int)(century / 4);


            int dayOfWeek = (1 + partOne - (2 * century) + year + partTwo + partThree) % 7; //Function that determines day of the week 

            /*
             * floor is integer floor function
             * k is day 
             * m is month where jan/feb are treated as of previous year
             * c is century (1987:19)
             * Y is year (1987:87) jan/feb treated as prev year
             * w is weekday (0 for sun ... 6 for sat)
             */

            return dayOfWeek+1;
        }
    
    }

}
