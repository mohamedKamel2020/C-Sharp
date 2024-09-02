
// For a float x, write a program to compute the following
//(𝑥^4)/2 + (𝑥^8)/5 + (x^16)/8⋯ …
import java.util.Scanner;

public class Math {
    public static void main(String[] args) {
        int n, power = 4, div = 2;
        float x, sum = 0;
        Scanner s = new Scanner(System.in);
        System.out.println("Please enter the value of X : ");
        x = s.nextFloat();
        System.out.println("Please enter the # of n : ");
        n = s.nextInt();
        for (int i = 1; i <= n; i++) {
            sum += (java.lang.Math.pow(x, power)) / div;
            power *= 2;
            div += 3;
        }
        System.out.println("The sum = " + sum);
    }

}