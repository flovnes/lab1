namespace Lab1 {
    public class Square : IComparable<Square> {
        private double side_;
        public double side {
            get {return side_;}
            set {if (value > 0) side_ = value; }
        }
        public Square() { side = 1; }
        public Square(double a) { if (a > 0) side = a; }
        public Square(Square that) { this.side = that.side; }
        public override string ToString() { return $"Square with a side of {this.side}"; }
        public double Area() { return side*side; }
        public double Perimeter() { return 4 * side; }
        public int CompareTo(Square that) { return side.CompareTo(that.side); }
        public static bool operator >  (Square some, Square other) {
            return some.CompareTo(other) > 0;
        }
        public static bool operator <  (Square some, Square other) {
            return some.CompareTo(other) < 0;
        }
        public static bool operator >=  (Square some, Square other) {
            return some.CompareTo(other) >= 0;
        }
        public static bool operator <=  (Square some, Square other) {
            return some.CompareTo(other) <= 0;
        }
        public static Square operator +(Square a, Square b) => new(a.side + b.side);
        public static Square operator -(Square a, Square b) => new(a.side - b.side);
        public static Square operator *(Square a, double q) => new(a.side * q);
        public static Square operator *(double q, Square a) => new(a.side * q);
    }
}

