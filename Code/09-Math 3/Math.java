
// For a float x, write a program to compute the n terms of the following series
//(𝑥^3)/3 - (𝑥^5)/5 + (x^7)/7- …
import java.util.Scanner;

public class Math {
    public static void main(String[] args) {
        int n, power = 3, div = 3;
        float x, sum = 0;
        Scanner s = new Scanner(System.in);
        System.out.println("Please enter the value of X : ");
        x = s.nextFloat();
        System.out.println("Please enter the # of n : ");
        n = s.nextInt();
        for (int i = 1; i <= n; i++) {
            sum += ((java.lang.Math.pow(-1, i + 1)) * (java.lang.Math.pow(x, power))) / div;
            power += 2;
            div += 2;
        }
        System.out.println("The sum = " + sum);
    }

}