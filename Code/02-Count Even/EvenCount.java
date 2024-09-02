import java.util.Scanner;

public class EvenCount {

    public static void main(String[] args) {
        int countEven = 0;
        int num;
        Scanner s = new Scanner(System.in);
        System.out.println("Enter Num or -1 to end ");
        num = s.nextInt();
        while (true) {
            if (num % 2 == 0) {
                countEven++;
                System.out.println("Enter Num or -1 to end ");
                num = s.nextInt();
            } else if (num == -1) {
                break;
            } else {
                System.out.println("Enter Num or -1 to end ");
                num = s.nextInt();
            }
        }
        System.out.println("CountEven = " + countEven);
    }
}