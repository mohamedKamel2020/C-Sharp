
public class Month {
    private int monthNumber;
    private String monthName;

    public Month() {
        monthNumber = 1;
        monthName = "January";
    }

    public Month(int m) {
        if (m >= 1 && m <= 12) {
            monthNumber = m;
        } else {
            monthNumber = 1;
        }
        if (monthNumber == 1) {
            monthName = "January";
        } else if (monthNumber == 2) {
            monthName = "February";
        } else if (monthNumber == 3) {
            monthName = "March";
        } else if (monthNumber == 4) {
            monthName = "April";
        } else if (monthNumber == 5) {
            monthName = "May";
        } else if (monthNumber == 6) {
            monthName = "june";
        } else if (monthNumber == 7) {
            monthName = "july";
        } else if (monthNumber == 8) {
            monthName = "August";
        } else if (monthNumber == 9) {
            monthName = "September";
        } else if (monthNumber == 10) {
            monthName = "October";
        } else if (monthNumber == 11) {
            monthName = "November";
        } else if (monthNumber == 12) {
            monthName = "December";
        } else {
            monthName = "January";
        }
    }

    public Month(String name) {
        if (name == "January") {
            monthNumber = 1;
        } else if (name == "February") {
            monthNumber = 2;
        } else if (name == "March") {
            monthNumber = 3;
        } else if (name == "April") {
            monthNumber = 4;
        } else if (name == "May") {
            monthNumber = 5;
        } else if (name == "june") {
            monthNumber = 6;
        } else if (name == "july") {
            monthNumber = 7;
        } else if (name == "August") {
            monthNumber = 8;
        } else if (name == "September") {
            monthNumber = 9;
        } else if (name == "October") {
            monthNumber = 10;
        } else if (name == "November") {
            monthNumber = 11;
        } else if (name == "December") {
            monthNumber = 12;
        } else {
            monthNumber = 1;
        }
    }

    public void setMonth(int num) {
        monthNumber = num;
    }

    public int getMonthNumber() {
        return monthNumber;
    }

    public String getMonthName() {
        return monthName;
    }

    public String toString() {
        return "Month : " + monthName;
    }

    public boolean equals(Month m) {
        return (m.monthNumber == monthNumber);
    }

}
