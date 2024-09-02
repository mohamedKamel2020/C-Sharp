public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("Hello, World!");
        Player p1 = new Player(2000);
        p1.IncrementScore(2000);
        Player p2 = new Player(4000);
        p2.DecrementScore(1500);
        System.out.print("\n" + p1.toString() + "\n");
        System.out.print(p2.toString() + "\n");
        System.out.print(p1.equals(p2) + "\n");
        System.out.print(Player.getNoOfWinners() + "\n");
    }
}
