public class App {
    public static void main(String[] args) throws Exception {
        Month m1 = new Month("January");
        Month m2 = new Month(1);
        System.out.print(m1.equals(m2));
    }
}
