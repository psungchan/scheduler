import java.io.*;
import java.util.*;

public class Calendar {

    //set of class constants for the months, days, and namees of the days of the week since they won't change
    private static final String[] MONTHS = {"January","February","March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"};
    private static final int[] DAYS = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
    private static final String[] WEEKDAYS = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
    private int currentMonthNum;
    private int currentYear;
    private String currentDay;

    //constructor. Might be useful in main to get the month name with a scanner from the console to start off
    //by displaying the current month
    public Calendar(int currentMonthNum, int currentYear, String currentDay) {

        this.currentMonthNum = currentMonthNum;
        this.currentYear = currentYear;
        this.currentDay = currentDay;
    }

    //method to format things to the console
    public void displayPage() {

        System.out.println(MONTHS[this.currentMonthNum - 1]);
    }

    //method to calculate what day the first day of the month is
    public int calcDayStart() {

        return 0;
    }
}


































