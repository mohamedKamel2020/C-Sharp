import java.util.Scanner;

public class Calcu {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int x, y;
        System.out.println("Enter the first num 'X' ");
        x = s.nextInt();
        System.out.println("Enter the second num 'Y' ");
        y = s.nextInt();

        if (x < y) {
            for (int i = x; i < y; i++) {
                if (i == x)
                    continue;
                System.out.print(i + " , ");
            }
        } else if (y < x) {
            for (int i = y; i < x; i++) {
                if (i == y)
                    continue;
                System.out.print(i + " , ");
            }
        } else if (x == y) {
            System.out.println("X==Y 'not found' ");
        }
    }
}
