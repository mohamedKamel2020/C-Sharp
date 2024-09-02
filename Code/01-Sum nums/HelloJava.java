import java.util.Scanner;

//1) Write a program to read n integers and compute the sum and average.
public class HelloJava {
    public static void main(String[] args) {
        int sum = 0;
        int n = 0;
        float avg = 0;

        Scanner s = new Scanner(System.in);

        System.out.println("Enter num or -1 to end ");
        int x = s.nextInt();
        while (x >= 0) {
            sum += x;
            n++;
            System.out.println("Enter another num or -1 to end ");
            x = s.nextInt();
        }
        System.out.println("Sum = " + sum);
        avg = sum / n;
        System.out.println("Avg = " + avg);
    }

}
