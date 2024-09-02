public class App {
    public static void main(String[] args) throws Exception {
        Temperature temperature1 = new Temperature(34);
        System.out.print("\nCelsius : " + temperature1.getCelsius());
        System.out.print("\nKelvin  : " + temperature1.getKelvin());

    }
}
