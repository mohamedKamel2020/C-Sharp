//For a float x, write a program to compute the following

import java.util.Scanner;
import java.lang.*;

public class Math {
    public static void main(String[] args) {
        int n;
        float x, sum = 0;
        Scanner s = new Scanner(System.in);
        System.out.println("Please enter the value of X : ");
        x = s.nextFloat();
        System.out.println("Please enter the # of n : ");
        n = s.nextInt();
        for (int i = 1; i <= n; i++) {
            sum += (java.lang.Math.pow(x, i)) / i;
        }
        System.out.println("The sum = " + sum);
    }

}