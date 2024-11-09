namespace Lab1 {
    class Client {
        static void Main() {
            // ClientSquare();
            // ClientCube();
            ClientSquare_hash_addition();
            ClientSquareF_hash_addition();
            ClientCube_hash_addition();
            ClientCubeF_hash_addition();
        }

        static void ClientSquare_hash_addition() {
            Console.WriteLine("Square part:");
            HashSet<Square> squares = [];
            Square a_sqr = new(4);
            squares.Add(a_sqr);

            Square b_sqr = new(4);
            squares.Add(b_sqr);

            if (squares.Contains(a_sqr))
                Console.WriteLine($"Found A");
            if (squares.Contains(b_sqr))
                Console.WriteLine($"Found B");

            // if (squares.TryGetValue(a_sqr, out Square x))
            //     Console.WriteLine($"Found A: {x}");
            // else
            //     Console.WriteLine($"Found nothing for: {a_sqr}");

            // if (squares.TryGetValue(b_sqr, out Square y))
            //     Console.WriteLine($"Found B: {y}");
            // else
            //     Console.WriteLine($"Found nothing for: {b_sqr}");
        }

        static void ClientSquareF_hash_addition() {
            Console.WriteLine("\nSquareF part:");
            HashSet<SquareF> squares = [];
            SquareF a_sqr = new(4);
            squares.Add(a_sqr);

            SquareF b_sqr = new(4);
            squares.Add(b_sqr);

            if (squares.Contains(a_sqr))
                Console.WriteLine($"Found A");
            if (squares.Contains(b_sqr))
                Console.WriteLine($"Found B");

            // if (squares.TryGetValue(a_sqr, out SquareF x))
            //     Console.WriteLine($"Found A: {x}");
            // else
            //     Console.WriteLine($"Found nothing for: {a_sqr}");

            // if (squares.TryGetValue(b_sqr, out SquareF y))
            //     Console.WriteLine($"Found B: {y}");
            // else
            //     Console.WriteLine($"Found nothing for: {b_sqr}");
        }

        static void ClientCube_hash_addition() {
            Console.WriteLine("\nCube part:");
            HashSet<Cube> cubes = [];
            Cube a_cube = new(4, "a");
            Cube b_cube = new(4, "b");
            Cube c_cube = new(4, "c");
            Cube d_cube = new(4, "d");
            Cube f_cube = new(4, "f");

            cubes.Add(a_cube);
            cubes.Add(b_cube);
            cubes.Add(c_cube);
            cubes.Add(d_cube);
            cubes.Add(f_cube);

            Console.WriteLine($"Found: {cubes.Count}");
        }

        static void ClientCubeF_hash_addition() {
            Console.WriteLine("\nCubeF part:");
            HashSet<CubeF> cubes = [];
            CubeF a_cube = new(4, "a");
            CubeF b_cube = new(4, "b");
            CubeF c_cube = new(4, "c");
            CubeF d_cube = new(4, "d");
            CubeF f_cube = new(4, "f");

            cubes.Add(a_cube);
            cubes.Add(b_cube);
            cubes.Add(c_cube);
            cubes.Add(d_cube);
            cubes.Add(f_cube);

            Console.WriteLine($"Found: {cubes.Count}");
        }

        // static void ClientCube() {
        //     Console.WriteLine("\n\n -- 3 --");

        //     Cube cube1 = new ();
        //     Cube cube2 = new (4);

        //     Console.WriteLine($"Cube1 = {cube1}");
        //     Console.WriteLine($"Cube2 = {cube2}");

        //     cube1 *= 3; 
        //     Console.WriteLine($"Cube1 * 3 = {cube1}");

        //     Cube cube3 = cube1 + cube2;
        //     Console.WriteLine($"\nCube1 + Cube2 = Cube3\nCube3 = {cube3}");

        //     Console.WriteLine($"\nCube1 side = {cube1.side}");
        //     Console.WriteLine($"Cube2 side = {cube2.side}");
        //     Console.WriteLine($"Cube1 > Cube2  | {cube1 > cube2}");
        //     Console.WriteLine($"Cube1 <= Cube2 | {cube1 <= cube2}");
        // }

        // static void ClientSquare() {
        //     Console.WriteLine("\n\n -- 2 --");

        //     Square sqr1 = new (3);
        //     Square sqr2 = new (5);

        //     Console.WriteLine($"Square1 = {sqr1}");
        //     Console.WriteLine($"Square2 = {sqr2}");

        //     sqr1 = 2 * sqr1;
        //     Console.WriteLine($"Square1 * 2 = {sqr1}");

        //     Square sqr3 = sqr1 + sqr2;
        //     Console.WriteLine($"\nSquare1 + Square2 = Square3\nSquare3 = {sqr3}");

        //     Console.WriteLine($"\nSquare1 side = {sqr1.side}");
        //     Console.WriteLine($"Square2 side = {sqr2.side}");
        //     Console.WriteLine($"Square1 > Square2  | {sqr1 > sqr2}");
        //     Console.WriteLine($"Square1 <= Square2 | {sqr1 <= sqr2}");
        // }
    }
}