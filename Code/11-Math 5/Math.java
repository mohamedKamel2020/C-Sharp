
// Write a program to compute the following (1 / 2) + (2 / 3) + (3 / 4) + (4 / 5)+......+(99 / 100)

public class Math {

    public static void main(String[] args) {
        double sum = 0;
        for (int i = 1; i <= 99; i++) {
            sum += (double) i / (i + 1);
        }
        System.out.println("Sum  = " + sum);
    }
}