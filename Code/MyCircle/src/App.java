public class App {
    public static void main(String[] args) throws Exception {
        Point point = new Point(2, 3);
        MyCircle myCircle = new MyCircle(4, point);
        System.out.print(myCircle.toString());
    }
}
