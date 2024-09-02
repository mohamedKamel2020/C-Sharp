
public class React {
    private double length;
    private double width;

    public React() {
        length = 0.0;
        width = 0.0;
    }

    public React(double _length, double _width) {
        length = _length;
        width = _width;
    }

    // Setter && Getter
    public void setWidth(double wid) {
        width = wid;
    }

    public void setLength(double len) {
        length = len;
    }

    public double getWidth() {
        return width;
    }

    public double getLength() {
        return length;
    }

    // methods
    public void area() {
        System.out.print("\nArea : " + (width * length) + "\n");
    }

    public void perimeter() {
        System.out.print("\nPerimeter : " + 2 * (width + length) + "\n");
    }

}
