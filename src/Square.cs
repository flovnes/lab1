namespace Lab1 {
    public class Square : IComparable<Square> {
        private double side_;
        public double side {
            get {return side_;}
            set {if (value > 0) side_ = value; }
        }
        public Square() { side = 1; }
        public Square(double a) { side = a; }
        public Square(Square that) { this.side = that.side; }
        public override string ToString() { return $"Square with a side of {this.side}"; }
        public double Area() { return side*side; }
        public double Perimeter() { return 4 * side; }
        public int CompareTo(Square that) {
            if (this.side < that.side) return -1;
            if (this.side == that.side) return 0;
            return 1;
        }
        public static Square operator +(Square a, Square b) => new(a.side + b.side);
        public static Square operator -(Square a, Square b) => new(a.side - b.side);
        public static Square operator *(Square a, double q) => new(a.side * q);
    }
    public class Cube : Square {
        public Cube() { side = 1; }
        public Cube(double a) { side = a; }
        public new double Area() { return 6 *side*side; }
        public new double Perimeter() { return 12 *side; }
        public double Volume() { return side*side*side; }
    }
    class Client {
        static void Main() {
            int a = 4;
            Square some = new(a);

            Console.WriteLine(value: $"square1 side = {some.side}");

            Square other = new();

            Console.WriteLine($"square2 side = {other.side}");

            some.side *= 3;
            Square sum = some + other;

            Console.WriteLine(value: $"square3 area = {sum.Area()}");
            Console.WriteLine(value: $"square3 perimeter = {sum.Perimeter()}");

            Cube cube1 = new(some.side);

            Console.WriteLine(value: $"cube1 area = {cube1.Area()}");
        }
    }
}