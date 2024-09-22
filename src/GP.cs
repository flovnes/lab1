namespace Lab1 {
    public class GP : IEnumerable<double> {
        private double b0;
        private double b;
        private double q;

        public double start {
            get {return b0;}
            set {b0 = value; b = b0;}
        }

        public double curr {
            get {return b;}
            set {b = value;}
        }

        public double ratio {
            get {return q;}
            set {if (value != 0) q = value;}
        }

        public GP(double b, double q) {
            start = b;
            ratio = q;
        }

        public double this[int index] {
            get {
                if (index < 0) { return 0; }
                return start * Math.Pow(ratio, index);
            }
        }

        public double Sum(int to) {
            if (to < 0) { return 0; }

            if (ratio < 1.01) 
                return start * (1 - Math.Pow(ratio, to)) / (1 - ratio);
            else 
                return start * (Math.Pow(ratio, to) - 1) / (ratio - 1);
        }

        public IEnumerator<double> GetEnumerator() {
            while (true) {
                double next = curr;
                curr *= ratio;
                yield return next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return GetEnumerator(); }
    }
}