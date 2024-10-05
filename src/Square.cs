namespace Lab1 {
    public class Square : IComparable<Square> {
        private double side_;
        public double side {
            get {return side_;}
            set { side_ = value<0 ?0 :value; }
        }
        public Square(double a) { side = a; }
        public Square() : this(1) {}
        public Square(Square that) : this(that.side) {}
        public override string ToString() { return $"square {{side: {side}}}"; }
        public double Area() { return side*side; }
        public double Perimeter() { return side*4; }
        public int CompareTo(Square that) { return side.CompareTo(that.side); }
        public override bool Equals(object some) => some is Square square && side == square.side;
        public override int GetHashCode() => side.GetHashCode();
        public static bool operator >  (Square some, Square other) => some.CompareTo(other) > 0; 
        public static bool operator <  (Square some, Square other) => some.CompareTo(other) < 0; 
        public static bool operator >= (Square some, Square other) => some.CompareTo(other) >= 0; 
        public static bool operator <= (Square some, Square other) => some.CompareTo(other) <= 0;
        public static bool operator == (Square some, Square other) => some.Equals(other);
        public static bool operator != (Square some, Square other) => !(some == other);

        public static Square operator +(Square a, Square b) => new(a.side + b.side);
        public static Square operator -(Square a, Square b) => new (a.side-b.side<0 ?0 :a.side-b.side);
        public static Square operator *(Square a, double q) => new (a.side * (q<0 ?0 :q));
        public static Square operator *(double q, Square a) => a * q;
    }
}