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
    
        public int firstDayOfMonth(int givenMonth, int givenYear){

            if(givenMonth < 3){
                givenYear = givenYear - 1;
                givenMonth = 10 + givenMonth;
            }else{
                givenMonth = givenMonth - 2;
            }

            int century = givenYear / 100;
            int year = givenYear % 100;

            int partOne = (int)((2.6 * givenMonth) - 0.2);
            int partTwo = (int)(year / 4);
            int partThree = (int)(century / 4);


            int dayOfWeek = (1 + partOne - (2 * century) + year + partTwo + partThree) % 7;

            
            



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
