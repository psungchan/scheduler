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
    }
}
