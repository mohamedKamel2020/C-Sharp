import java.util.Scanner;

/**
 * factorsNum
 */
public class factorsNum {

    public static void main(String[] args) {
        int num = 0;
        Scanner s = new Scanner(System.in);
        System.out.println("Enetr Num ");
        num = s.nextInt();
        for (int i = 1; i <= num; i++) {
            if (num % i == 0) {
                System.out.print(i + ",");
            }
        }
    }
}