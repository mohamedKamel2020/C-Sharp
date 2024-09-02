
public class Clock {
    private int hours;
    private int min;
    private int seconds;

    // constructor
    public Clock() {
        hours = 0;
        min = 0;
        seconds = 0;
    }

    public Clock(int h, int m, int s) {
        hours = h;
        min = m;
        seconds = s;
    }

    // #region setter&&getter
    public void setHours(int h) {
        hours = h;
    }

    public int getHours() {
        return hours;
    }

    public void setMin(int m) {
        min = m;
    }

    public int getMin() {
        return min;
    }

    public void setSeconds(int s) {
        seconds = s;
    }

    public int getSeconds() {
        return seconds;
    }

    // #endregion
    //// #region Methods
    public void incSecond() {
        seconds++;
        if (seconds > 59) {
            seconds = 0;
            min++;
            if (min > 59) {
                min = 0;
                hours++;
            }
            incHours();
        }
    }

    public void incMinutes() {
        min++;
        if (min > 59) {
            min = 0;
            hours++;
        }
        incHours();
    }

    public void incHours() {
        hours++;
        if (hours > 23) {
            hours = 0;
            seconds = 0;
            min = 0;
        }
    }

    public Clock addClock(Clock c) {
        Clock result = new Clock();

        result.hours = hours + c.hours;
        if (result.hours > 23) {
            result.hours = result.hours - 24;
        }
        result.min = min + c.min;
        if (result.min > 59) {
            result.min = result.min - 60;
        }
        result.seconds = seconds + c.seconds;
        if (result.seconds > 59) {
            result.seconds = result.seconds - 60;
        }
        return result;
    }
}
