public class MyCircle {
    private int radius;
    private Point point;

    public MyCircle(int r, int x, int y) {
        radius = r;
        point = new Point(x, y);
    }

    public MyCircle(int r, Point p) {
        radius = r;
        point = p;
    }

    public void setRadius(int radius) {
        this.radius = radius;
    }

    public int getRadius() {
        return radius;
    }

    public void setPoint(int x, int y) {
        point.setXcoord(x);
        point.setYcoord(y);
    }

    public void setPoint(Point p1) {
        point = p1;
    }

    public Point gePoint() {
        return point;
    }

    public String toString() {
        return " Radius : " + radius + "  Point (" + point.getXcoord() + "," + point.getYcoord() + ")";
    }

}
