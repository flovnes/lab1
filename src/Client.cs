namespace Lab1 {
    class Client {
        static void Main() {
            ClientGP();
            ClientSquare();
        }

        static void ClientGP() {
            System.Console.WriteLine("-- 1 --");

            GP gp1 = new GP(2, 3);
            Console.WriteLine($"GP_1 {gp1}");

            Console.WriteLine("\n5 terms:");
            for (int i = 0; i < 5; i++) {
                Console.Write($"{gp1[i]} ");
            }

            Console.WriteLine($"\nSum(5) of GP_1 = {gp1.Sum(5)}");

            GP gp2 = new(1, 2);
            Console.WriteLine($"\nGP_2 {gp2}");

            Console.WriteLine("6 terms (enum):");

            foreach (double term in gp2.Take(6))
                { Console.Write($"{term} "); }

            gp2.start = 5;
            gp2.ratio = 0.5;
            Console.WriteLine($"\n\nGP_2* {gp2}");

            Console.WriteLine("5 terms:");
            for (int i = 0; i < 5; i++) {
                Console.Write($"{gp2[i]} ");
            }
        }

        static void ClientSquare() {
            System.Console.WriteLine("\n\n -- 2 --");

            Square sqr1 = new (3);
            Square sqr2 = new (5);

            Console.WriteLine($"Square1 = {sqr1}");
            Console.WriteLine($"Square2 = {sqr2}");

            sqr1 = 2 * sqr1;
            Console.WriteLine($"Square1 * 2 = {sqr1}");

            Square sqr3 = sqr1 + sqr2;
            Console.WriteLine($"\nSquare1 + Square2 = Square3\nSquare3 = {sqr3}");

            Console.WriteLine($"\nSquare1 side = {sqr1.side}");
            Console.WriteLine($"Square2 side = {sqr2.side}");
            Console.WriteLine($"Square1 > Square2  | {sqr1 > sqr2}");
            Console.WriteLine($"Square1 <= Square2 | {sqr1 <= sqr2}");

            Cube cube1 = new ();
            Cube cube2 = new (4);

            Console.WriteLine($"\n\nCube1 = {cube1}");
            Console.WriteLine($"Cube2 = {cube2}");

            cube1 *= 3; 
            Console.WriteLine($"Cube1 * 3 = {cube1}");

            Cube cube3 = cube1 + cube2;
            Console.WriteLine($"\nCube1 + Cube2 = Cube3\nCube3 = {cube3}");


            Console.WriteLine($"\nCube1 side = {cube1.side}");
            Console.WriteLine($"Cube2 side = {cube2.side}");
            Console.WriteLine($"Cube1 > Cube2  | {cube1 > cube2}");
            Console.WriteLine($"Cube1 <= Cube2 | {cube1 <= cube2}");
        }
    }
}