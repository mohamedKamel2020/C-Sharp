
// Write a program to compute the following (1 / 30) + (2 / 29) + (3 / 28) + (4 / 27)+......++ (27 / 4) + (28 / 3) + (29 / 2) + (30 / 1)

public class Math {

    public static void main(String[] args) {
        double sum = 0.0;
        int start = 1, end = 30;
        while (start <= 30) {
            sum += (start / end);
            start++;
            end--;
        }
        System.out.println("Sum = " + sum);
        // double num = (1 / 30) + (2 / 29) + (3 / 28) + (4 / 27) + (5 / 26) + (6 / 25)
        // + (7 / 24) + (8 / 23) + (9 / 22)
        // + (10 / 21) + (11 / 20) + (12 / 19) + (13 / 18) + (14 / 17) + (15 / 16) + (16
        // / 15) + (17 / 14)
        // + (18 / 13) + (19 / 12) + (20 / 11) + (21 / 10) + (22 / 9) + (23 / 8) + (24 /
        // 7) + (25 / 6) + (26 / 5)
        // + (27 / 4) + (28 / 3) + (29 / 2) + (30 / 1);
        // System.out.println(num);

    }
}