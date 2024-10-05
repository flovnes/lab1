namespace Lab1 {
    public class Cube : Square, IComparable<Cube> {
        public Cube(double a) { side = a; }
        public Cube() : this(1) {}
        public Cube(Cube that) : this(that.side) {}

        public override string ToString() { return $"cube {{ side: {side} }}"; }
        public new double Area() { return 6 *side*side; }
        public new double Perimeter() { return 12 *side; }
        public double Volume() { return side*side*side; }

        public override bool Equals(object some) => some is Cube cube && side == cube.side;
        public override int GetHashCode() => base.GetHashCode();
        public int CompareTo(Cube other) => base.CompareTo(other);

        public static bool operator >  (Cube some, Cube other) => some.CompareTo(other) > 0;
        public static bool operator <  (Cube some, Cube other) => some.CompareTo(other) < 0;
        public static bool operator >= (Cube some, Cube other) => some.CompareTo(other) >= 0;
        public static bool operator <= (Cube some, Cube other) => some.CompareTo(other) <= 0;
        public static bool operator == (Cube some, Cube other) => some.Equals(other);
        public static bool operator != (Cube some, Cube other) => !(some == other);

        public static Cube operator +(Cube a, Cube b) => new(a.side + b.side);
        public static Cube operator -(Cube a, Cube b) => new (a.side-b.side<0 ?0 :a.side-b.side);
        public static Cube operator *(Cube a, double q) => new (a.side * (q<0 ?0 :q));
        public static Cube operator *(double q, Cube a) => a * q;
    }
}