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
        // print
        Console.WriteLine(a);
        Console.WriteLine($"{abc},     {b},     {c},     {d},     {f}");
        // math
        double pi = Math.PI;
        double bSqrt = Math.Sqrt(b);
        /*
         type casting
         - auto cast for number types from lower to higher (int -> double)
         - from higher to lower needs to be manual (double -> int)
        */
        double bInt = (int)b;
        Console.WriteLine(a + bInt); // 5.5 = 5 when down casting
        // operators arithmetic
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
    }
}