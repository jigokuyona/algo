using System.Formats.Asn1;

namespace algo1;

class Program
{
    static void Main(string[] args)
    {
        // types
        int a = 5;
        int z = 3;
        double b = 5.5;
        String abc = "random string";
        char c = 'a';
        decimal d = 5.5m;
        float f = 5.5f;
        bool idk = true;
        // print
        Console.WriteLine(a);
        Console.WriteLine($"{abc},     {b},     {c},     {d},     {f}");
        // math
        double pi = Math.PI;
        double bSqrt = Math.Sqrt(b);
        /*
         * type casting
         * - auto cast for number types from lower to higher (int -> double)
         * - from higher to lower needs to be manual (double -> int)
         */
        double bInt = (int)b;
        Console.WriteLine(a + bInt); // 5.5 = 5 when down casting
        // operators arithmetic, when doing division with multiple number below the line (x / (y * y)) there need to be () 
        int aPlusZ = a + z;
        int aMinusZ = a - z;
        int aTimesZ = a * z;
        int aDivideZ = a / z;
        int aIncrement = a++;
        int aDecrement = a--;
        int aModuloZ = a % z;
        Console.WriteLine($"{aPlusZ}, {aMinusZ}, {aTimesZ}, {aDivideZ}, {aIncrement}, {aDecrement}, {aModuloZ}");
        // operators assignment
        z += 20;
        Console.WriteLine(z);
        z -= a;
        Console.WriteLine(z);
        z /= 3;
        Console.WriteLine(z);
        z *= z;
        Console.WriteLine(z);
        z %= 13; // modulo
        Console.WriteLine(z);
        z &= 3; // AND
        Console.WriteLine(z);
        z |= 3; // OR
        Console.WriteLine(z);
        z ^= z; // XOR
        Console.WriteLine(z);
        z >>= 3; // right shift binary
        Console.WriteLine(z);
        z = a >>> 3; // unsigned right shift binary
        Console.WriteLine(z);
        z <<= 3; // left shift binary
        Console.WriteLine(z);
        // logical operators - && = AND, || = OR - i am not writing that its obvious
        /*
         * switch case
         * switch (x)
         * {
         * case 0:
         *  ...
         *  break;
         * case 1:
         *  ...
         * default:
         *  ...
         *  break;
         * }
         */
        // if, else if, else - normal
        /*
         * loops
         * for, for each, while, do-while - normal
         * break, continue, return - normal
         * goto - rare but used for jumping to exact line
        */
        // tasks from first file (before loops)
        // task 1
        double n = 3.0;
        Console.WriteLine(squareArea(n));
        Console.WriteLine(squareCircumference(n));
        // task 2
        double r = 3.0;
        Console.WriteLine(circleArea(r));
        Console.WriteLine(circleCircumference(r));
        // task 3
        double a1 = 3.0, a2 = 3.0, a3 = 3.0, b1 = 3.0, b2 = 5.0, b3 = 4.0, c1 = 3.0, c2 = 9.0, c3 = 5.0;
        Console.WriteLine(triangleCircumference(a1, b1, c1));
        Console.WriteLine(triangleCircumference(a2, b2, c2));
        Console.WriteLine(triangleCircumference(a3, b3, c3));
        Console.WriteLine(triangleArea(a1, b1, c1));
        Console.WriteLine(triangleArea(a2, b2, c2));
        Console.WriteLine(triangleArea(a3, b3, c3));
        // task 4
        double height = 1.78;
        double weight = 85;
        Console.WriteLine(bmi(height, weight));
        // task 5
        int timeYears = 20;
        double annualInterestRate = 2;
        double interest = 1000000;
        Console.WriteLine(simpleInterest(interest, annualInterestRate, timeYears));
        Console.WriteLine(monthlyInterestPayment(interest, annualInterestRate, timeYears));
        
    }
    // task 1 - square area, circumference
    public static double squareArea(double n)
    {
        return n * n;
    }

    public static double squareCircumference(double n)
    {
        return 4 * n;
    }
    // task 2 - circle area, circumference 
    public static double circleArea(double r)
    {
        return Math.PI * r * r;
    }

    public static double circleCircumference(double r)
    {
        return 2 * Math.PI * r;
    }
    // task 3 - triangle area, circumference
    public static bool isTriangle(double a, double b, double c)
    {
        if (((a + b) > c) && ((a + c) > b) && ((b + c) > a)) return true;
        return false;
    }
    public static double triangleArea(double a,  double b, double c)
    {
        if (isTriangle(a, b, c) == false) return -1;
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    public static double triangleCircumference(double a,  double b, double c)
    {
        if (isTriangle(a, b, c) == false) return -1;
        return a + b + c;
    }
    // task 4 - BMI
    public static double bmi(double height, double weight)
    {
        return weight / (height * height);
    }
    // task 5 - interest amount calculation
    public static double simpleInterest(double principalAmount, double annualInterestRate, double timeYears)
    {
        annualInterestRate /= 100;
        return principalAmount * timeYears * annualInterestRate;
    }

    public static String monthlyInterestPayment(double principalAmount, double annualInterestRate, double timeYears)
    {
        return "mrdam ekonomiku";
    }
}