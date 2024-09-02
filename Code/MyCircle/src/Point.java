
public class Point {

    private int xcoord;
    private int ycoord;
    private static int fquad = 0;
    private static int squad = 0;
    private static int tquad = 0;
    private static int foquad = 0;

    public Point() {
        xcoord = 0;
        ycoord = 0;
    }

    public Point(int x, int y) {
        xcoord = x;
        ycoord = y;
        if (xcoord > 0 && ycoord > 0) {
            fquad++;
        } else if (xcoord < 0 && ycoord < 0) {
            tquad++;
        } else if (xcoord > 0 && ycoord < 0) {
            foquad++;
        } else if (xcoord < 0 && ycoord > 0) {
            squad++;
        }
    }

    public void setXcoord(int x) {

        if (x > 0 && xcoord < 0 && ycoord > 0) {
            fquad++;
            squad--;
        } else if (x < 0 && xcoord > 0 && ycoord > 0) {
            fquad--;
            squad++;
        } else if (x > 0 && xcoord < 0 && ycoord < 0) {
            tquad--;
            foquad++;
        } else if (x < 0 && xcoord > 0 && ycoord < 0) {
            foquad--;
            tquad++;
        }

        xcoord = x;
    }

    public int getXcoord() {
        return xcoord;
    }

    public void setYcoord(int y) {
        if (y > 0 && xcoord < 0 && ycoord < 0) {
            tquad--;
            squad++;
        } else if (y < 0 && xcoord < 0 && ycoord > 0) {
            tquad++;
            squad--;
        } else if (y > 0 && xcoord > 0 && ycoord < 0) {
            fquad++;
            foquad--;
        } else if (y < 0 && xcoord > 0 && ycoord > 0) {
            fquad--;
            foquad++;
        }
        ycoord = y;
    }

    public int getYcoord() {
        return ycoord;
    }

    public static int getfquad() {
        return fquad;
    }

    public static int getSquad() {
        return squad;
    }

    public static int getTquad() {
        return tquad;
    }

    public static int getFoquad() {
        return foquad;
    }

    public void printQuadrant() {
        if (xcoord > 0 && ycoord > 0) {
            System.out.print("the first quardant. \n");
        } else if (xcoord < 0 && ycoord < 0) {
            System.out.print("the third quardent. \n");
        } else if (xcoord > 0 && ycoord < 0) {
            System.out.print("the fourth quardent. \n");
        } else if (xcoord < 0 && ycoord > 0) {
            System.out.print("the second quardent. \n");
        }
    }

    public double distance(Point p1) {
        double distance = Math
                .sqrt((p1.xcoord - xcoord) * (p1.xcoord - xcoord) + (p1.ycoord - ycoord) * (p1.ycoord - ycoord));
        return distance;
    }

}
