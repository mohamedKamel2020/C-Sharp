
public class Geometry {
    public static double getAreaCircle(double radius) {
        return Math.PI * (radius * radius);
    }

    public static double getAreaRect(double length, double width) {
        return (length * width);
    }

    public static double getAreaTriangle(double height, double base) {
        return 0.5 * (height * base);
    }

}
