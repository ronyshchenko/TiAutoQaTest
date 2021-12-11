class TriangleTask
{
    public static double[] CalcDistance(double[] a, double[] b, double[] c)
    {
        return new double[] { Math.Sqrt(Math.Pow(b[0]-a[0],2) + Math.Pow(b[1]-a[1],2)),
            Math.Sqrt(Math.Pow(c[0]-b[0],2) + Math.Pow(c[1]-b[1],2)),
            Math.Sqrt(Math.Pow(a[0]-c[0],2) + Math.Pow(a[1]-c[1],2)),
            };
    }

    public static void printEvenNumbers(double perim)
    {
        for (int i = 0; i <= perim; i = i + 2) {
            Console.Write(i);
            if((i+2)<perim)
            Console.Write(", ");
            else Console.Write(".");
        }
    }

    static void Main(string[] args)
    {   
        // Value of fault
        double DELTA = 0.01;

        // Vertex coordinates
        double[] pointA = new double[2];
        double[] pointB = new double[2];
        double[] pointC = new double[2];

        Console.WriteLine("First Point.");
        Console.WriteLine("Input X: ");
        pointA[0] = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Input Y: ");
        pointA[1] = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Second Point.");
        Console.WriteLine("Input X: ");
        pointB[0] = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Input Y: ");
        pointB[1] = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Third Point.");
        Console.WriteLine("Input X: ");
        pointC[0] = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Input Y: ");
        pointC[1] = Convert.ToDouble(Console.ReadLine());


        //Calculating the lengths of the sides of the triangle
        double[] distances = CalcDistance(pointA, pointB, pointC);
        Console.WriteLine("The lengths of the sides of the triangle are: {0} units, {1} units, {2} units", distances[0], distances[1], distances[2]);

        // Determine whether a triangle is equilateral
        bool isEquilateral = (Math.Pow((distances[0] - distances[1]), 2) <= DELTA) && (Math.Pow((distances[2] - distances[1]), 2) <= DELTA) && (Math.Pow((distances[2] - distances[0]), 2) <= DELTA);
        if (isEquilateral) {
            Console.WriteLine("The triangle is equilateral");
        }

        else Console.WriteLine("The triangle is not equilateral");


        // Determine if a triangle is isosceles
        bool isIsosceles = (Math.Pow((distances[0] - distances[1]), 2) <= DELTA) || (Math.Pow((distances[1] - distances[2]), 2) <= DELTA) || (Math.Pow((distances[2] - distances[0]), 2) <= DELTA);
        if (isIsosceles)
        {
            Console.WriteLine("The triangle is isosceles");
        }
        else Console.WriteLine("The triangle is not isosceles");
        
        // Determine whether it is rectangular
        bool isRectangular = (Math.Pow(Math.Pow(distances[0], 2) + Math.Pow(distances[1], 2) - Math.Pow(distances[2], 2), 2) <= DELTA) ||
                             (Math.Pow(Math.Pow(distances[1], 2) + Math.Pow(distances[2], 2) - Math.Pow(distances[0], 2), 2) <= DELTA) ||
                             (Math.Pow(Math.Pow(distances[2], 2) + Math.Pow(distances[0], 2) - Math.Pow(distances[1], 2), 2) <= DELTA);
        if (isRectangular)
        {
            Console.WriteLine("The triangle is rectangular");
        }

        else Console.WriteLine("The triangle is not rectangular");

        // Calculating perimeter
        double perimeter = distances.Sum();
        Console.WriteLine("Perimeter is:{0}", perimeter);


        // Printing even numbers less than the perimeter
        Console.WriteLine("Even numbers is:");
        printEvenNumbers(perimeter);

        Console.ReadKey();
    }
}

