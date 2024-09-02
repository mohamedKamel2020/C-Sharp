import java.util.Scanner;

public class Maximum {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int n, max;
        System.out.println("Enter # of Numbers ");
        n = s.nextInt();

        int arrNum[] = new int[n];
        for (int i = 0; i < n; i++) {
            System.out.print("Enter Num [" + (i + 1) + "] = ");
            arrNum[i] = s.nextInt();
        }
        max = arrNum[0];
        for (int i = 0; i < n; i++) {
            if (max < arrNum[i]) {
                max = arrNum[i];
            }
        }
        System.out.println("Max = " + max);
    }
}