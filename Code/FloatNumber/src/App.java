public class App {
    public static void main(String[] args) throws Exception {
        FloatNumber floatNumber1 = new FloatNumber(123.445f);
        System.out.print("\n" + floatNumber1.value);
        System.out.print("\n" + floatNumber1.ndp);

        FloatNumber floatNumber2 = new FloatNumber(243.552f);
        System.out.print("\n" + floatNumber2.value);
        System.out.print("\n" + floatNumber2.ndp);
        // FloatNumber floatNumber3 = floatNumber1.AddFloat(floatNumber2);
        // System.out.print("\n---value " + floatNumber3.value);
        // System.out.print("---ndp " + floatNumber3.ndp);

    }

}
