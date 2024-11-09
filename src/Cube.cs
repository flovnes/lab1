namespace Lab1 {
    public class Cube : SquareF//, IComparable<Cube> 
    {
        private string col_;
        public string color{
            get {return col_;}
            set {col_ = value;}
        }
        public Cube(double a, string col) { side = a; color = col; }
        public Cube() : this(1, "blue") {}
        public Cube(Cube that) : this(that.side, that.color) {}
        public override string ToString() { return $"cube {{ side: {side}, color: {color}}}"; }
        public new double Area() { return 6 *side*side; }
        public new double Perimeter() { return 12 *side; }
        public double Volume() { return side*side*side; }
        // public int CompareTo(Cube other) => base.CompareTo(other);

        // public static bool operator >  (Cube some, Cube other) => some.CompareTo(other) > 0;
        // public static bool operator <  (Cube some, Cube other) => some.CompareTo(other) < 0;
        // public static bool operator >= (Cube some, Cube other) => some.CompareTo(other) >= 0;
        // public static bool operator <= (Cube some, Cube other) => some.CompareTo(other) <= 0;
        // public static bool operator == (Cube some, Cube other) => some.Equals(other);
        // public static bool operator != (Cube some, Cube other) => !(some == other);

        public static Cube operator +(Cube a, Cube b) => new(a.side + b.side, a.color);
        public static Cube operator -(Cube a, Cube b) => new (a.side-b.side<0 ?0 :a.side-b.side, a.color);
        public static Cube operator *(Cube a, double q) => new (a.side * (q<0 ?0 :q), a.color);
        public static Cube operator *(double q, Cube a) => a * q;
    }

    public class CubeF : Cube {
        public CubeF(double a, string col) { side = a; color = col; }
        public CubeF() : this(1, "blue") {}
        public CubeF(Cube that) : this(that.side, that.color) {}
        public override bool Equals(object some) => some is Cube cube && side == cube.side;
        public override int GetHashCode() => HashCode.Combine(side, color);
    }
}