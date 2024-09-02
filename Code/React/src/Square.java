
public class Square extends React {
    private double length1;

    public Square(double len) {
        super(len, len);
        length1 = len;
    }

    public void setLength1(double len) {
        length1 = len;
    }

    public double getLength1() {
        return length1;
    }

    public void area() {
        System.out.print("\nThe Area  : " + (length1 * length1) + "\n");
    }

    public void perimeter() {
        System.out.print("\nThe Perimeter : " + 4 * (length1) + "\n");
    }
}
