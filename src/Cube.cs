namespace Lab1 {
    public class Cube : Square {
        public Cube(double a) { side = a; }
        public Cube() : this(1) {}
        public Cube(Cube that) : this(that.side) {}

        public override string ToString() { return $"cube {{ side: {side} }}"; }
        public new double Area() { return 6 *side*side; }
        public new double Perimeter() { return 12 *side; }
        public double Volume() { return side*side*side; }

        public int CompareTo(Cube that) { return side.CompareTo(that.side); }
        public static bool operator >  (Cube some, Cube other) { return some.CompareTo(other) > 0; }
        public static bool operator <  (Cube some, Cube other) { return some.CompareTo(other) < 0; }
        public static bool operator >= (Cube some, Cube other) { return some.CompareTo(other) >= 0; }
        public static bool operator <= (Cube some, Cube other) { return some.CompareTo(other) <= 0; }

        public static Cube operator +(Cube a, Cube b) => new(a.side + b.side);
        public static Cube operator -(Cube a, Cube b) => new (a.side-b.side<0 ?0 :a.side-b.side);
        public static Cube operator *(Cube a, double q) => new (a.side * (q<0 ?0 :q));
        public static Cube operator *(double q, Cube a) => a * q;
    }
}