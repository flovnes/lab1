namespace Lab1 {
    public class GP : IEnumerable<double> {
        private double b;
        private double q;
        private double cur;

        public double start {
            get {return b;}
            set {b = value; cur = b;}
        }

        public double ratio {
            get {return q;}
            set {if (value != 0) q = value;}
        }

        public GP(double b, double q) {
            start = b;
            if (q != 0)
            ratio = q;
        }

        public override string ToString() { return $"{{ b = {start}, q = {ratio} }}"; }

        public double this[int index] {
            get {
                if (index < 0) { return 0; }
                return start * Math.Pow(ratio, index);
            }
        }

        public double Sum(int n) {
            if (n < 0) { return 0; }
            if (ratio == 1) return start*n;

            if (Math.Abs(ratio - 1) < 10e-12) 
                return start * (1 - Math.Pow(ratio, n)) / (1 - ratio);
            else 
                return start * (Math.Pow(ratio, n) - 1) / (ratio - 1);
        }

        public IEnumerator<double> GetEnumerator() {
            while (true) {
                double next = cur;
                cur *= ratio;
                yield return next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return GetEnumerator(); }
    }
}