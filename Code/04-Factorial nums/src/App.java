import java.util.Scanner;

public class App {
    // Write a program to read an integer n and compute the factorial. Note that the
    // factorial of
    // n=n*(n-1)*(n-2)......1
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int n, fact = 1;
        boolean exit = false;
        while (!exit) {
            fact = 1;
            System.out.println("Please Enter n to  compute the factorial Or Enter -1 to Exit! ");
            n = s.nextInt();
            if (n == 0 || n == 1) {
                fact = 1;
                System.out.println("Fact = " + fact);
            } else if (n == -1) {
                exit = true;
            } else {
                for (int i = 1; i <= n; i++) {
                    fact = i * fact;
                }
                System.out.println("Fact = " + fact);
            }
        }

    }
}
