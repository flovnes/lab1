namespace Lab1 {
    class Client {
        static void Main() {
            int a = 4;
            Square sqr1 = new(a);

            Console.WriteLine(value: $"square1 side = {sqr1.side}");

            Square sqr2 = new();

            Console.WriteLine($"square2 side = {sqr2.side}");

            sqr1.side *= 3;
            Square sqr3 = sqr1 + sqr2;

            Console.WriteLine(value: $"square3 area = {sqr3.Area()}");
            Console.WriteLine(value: $"square3 perimeter = {sqr3.Perimeter()}");

            Cube cube1 = new(sqr1.side);

            Console.WriteLine(value: $"cube1 area = {cube1.Area()}");

            Cube cube2 = new(2 * cube1);

            if (cube1 > sqr2) {
                Console.WriteLine($"{cube1} bigger than sqr2");
            } else {
                Console.WriteLine("cube2 bigger than cube1");
            }

            Cube cube3 = cube1 + cube2;

            Console.WriteLine(value: $"cube3 = {cube3.side}");
        }
    }
}