import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
        Scanner s = new Scanner(System.in);
        System.out.println(
                "\nGeometry Calculator\n1. Calculate the Area of a Circle\n2. Calculate the Area of a Rectangle\n3. Calculate the Area of a Triangle\n4. Quit");
        System.out.print("\nEnter your choice (1-4):");
        int choice;
        choice = s.nextInt();
        if (choice == 1) {
            System.out.print(Geometry.getAreaCircle(10));
        } else if (choice == 2) {
            System.out.print(Geometry.getAreaRect(10, 5));
        } else if (choice == 3) {
            System.out.print(Geometry.getAreaTriangle(4, 3));
        } else if (choice == 4) {
            System.out.print("Quit");
        } else {
            System.out.print("Error Choice ");
        }

    }
}
