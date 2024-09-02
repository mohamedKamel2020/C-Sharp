public class App {
    public static void main(String[] args) throws Exception {
        Clock clock1 = new Clock(23, 59, 00);
        Clock clock2 = new Clock(2, 2, 30);

        Clock h = clock1.addClock(clock2);

        System.out.print("Hours : " + h.getHours() + "Min : " + h.getMin() + "Sec : " + h.getSeconds());

    }
}
