import java.util.*;

public class calander {

	/* This is the first program for 100 days of code [Thursday, Nov 8]
	 * This is the first part - a warmup for a scheduling app
	 * This is a simple implementation of a basic calander (Excluding leap years)
	 * This will be a brute force, based from today, disaplays a month*/
	public static final int SETDAYOFWEEK = 0;
	public static final int SETDATE = 0;
	public static final int SETMONTH = 0;
	public static final int SETYEAR = 2017;
	public static final String[] daysOfWeek = {"Sun", "Mon", "Tue", "Wen", "Thu", "Fri", "Sat"};
	public static final String[] monthsInYear = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};
	public static final int[] daysInMonth = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};



	public static void main(String[] args) {
		//Scanner s = new Scanner(System.in);
		drawMonth(8, 11, 2018);
	}

	/*
	 * Takes in the month and year input
	 * Determines number of days offset from Thu Nov 8, 2018
	 *
	 */


	/*

	//Assume year > 2017
	public int dayOfMonth(int targetYear, int targetMonth, int targetDay, int targetMonthInYear) {

		int seperation = targetDay - 1;
		int testYear = targetYear;
		int testMonth = targetMonth;
		int testDay = 1;

		while(testYear > SETYEAR) {
			while(testMonth > SETMONTH+1) {

				while(targetDay > 1) {
					//Add number of days to total seperation until reaches month total
					seperation--;
				}
				testMonth--;
			}
			testYear--;
		}


		return 0;
	}

	*/

	public static int dayOfWeek(int targetYear, int targetMonth) {

		int testYear = SETYEAR;
		int testMonth = SETMONTH+1;
		int seperation = 0;

		while(testMonth < targetMonth) {
			seperation = seperation + daysInMonth[testMonth];
			testMonth++;
			while(testYear < targetYear) {
				seperation = seperation + 365*(targetYear - testYear);
			}
		}

		return (seperation%7);

	}

	public static void drawMonth(int targetDay, int targetMonth, int targetYear) {
		int testDay = 1; //The Day to be printed in the box
		int targetDays = daysInMonth[targetMonth-1]; //Total days in target month
		int targetDayOfWeek = dayOfWeek(targetYear, targetMonth); //Day of week of first day in target Month

		while(testDay < targetDays) { //While day being printed < number of days in month
			for (int days = 0; days < 7; days++) { //Iterated through a week
				if(days+1 < targetDayOfWeek) { //If
					System.out.print("[ ]");
					testDay++;
				}else {
					System.out.print("["+testDay+"]  ");
					testDay++;
				}
			}
			System.out.println();
		}
	}




}
