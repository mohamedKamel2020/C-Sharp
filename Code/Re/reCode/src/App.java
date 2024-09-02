import java.io.*;
import java.util.*;//scanner

//1) Write a program to read n integers and compute the sum and average.
public class App {
    public static void main(String[] args) {
        int n;
        int sum = 0;
        int x;
        int c = 0;
        Scanner s = new Scanner(System.in);
        while (true) {
            System.out.print("Enter num or -1 to exit : ");
            x = s.nextInt();
            if (x == -1) {
                break;
            }
            sum = sum + x;
            c++;
        }
        System.out.print("Sum = " + sum + "\n");
        System.out.print("Avg = " + (sum / c) + "\n");
    }
}