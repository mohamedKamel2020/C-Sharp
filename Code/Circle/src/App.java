import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
        Scanner s = new Scanner(System.in);
        double radius;
        System.out.print("\nEnter radius : ");

        radius = s.nextDouble();
        Circle circle = new Circle(radius);

        System.out.print("\nThe Area : " + circle.getArea());
        System.out.print("\nThe Diameter : " + circle.getDiameter());
        System.out.print("\nThe Circumference : " + circle.getCircumference());

    }
}
