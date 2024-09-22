namespace Lab1 {
    public class Cube : Square {
        public Cube() { side = 1; }
        public Cube(double a) { if (a > 0) side = a; }
        public Cube(Cube that) { this.side = that.side; }
        public override string ToString() { return $"Cube with a side of {this.side}"; }
        public new double Area() { return 6 *side*side; }
        public new double Perimeter() { return 12 *side; }
        public double Volume() { return side*side*side; }
        public int CompareTo(Cube that) { return this.side.CompareTo(that.side); }

        public static bool operator >  (Cube some, Cube other) { return some.CompareTo(other) > 0; }
        public static bool operator <  (Cube some, Cube other) { return some.CompareTo(other) < 0; }
        public static bool operator >= (Cube some, Cube other) { return some.CompareTo(other) >= 0; }
        public static bool operator <= (Cube some, Cube other) { return some.CompareTo(other) <= 0; }

        public static Cube operator +(Cube a, Cube b) => new(a.side + b.side);
        public static Cube operator -(Cube a, Cube b) => new(a.side - b.side);
        public static Cube operator *(Cube a, double q) => new(a.side * q);
        public static Cube operator *(double q, Cube a) => new(a.side * q);
    }
}