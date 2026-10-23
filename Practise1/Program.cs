using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello world!");
        // task 1 output:
        double n = 3.0;
        Console.WriteLine($"Delka strany je {n}");
        Console.WriteLine($"Obsah: {area(n)}, obvod: {circumference(n)}");
        // task 2 output:
        double r = 3.0;
        Console.WriteLine($"Polomer kruhu je {r}");
        Console.WriteLine($"Hodnota Pi je {Math.PI}");
        Console.WriteLine($"Obsah: {circleArea(r)}, obvod: {circleCircumference(r)}");
        // task 3 output:
        double a = 3.0;
        double b = 4.0;
        double c = 5.0;
        Console.WriteLine($"Delka strany trojuhelnika je {a}, {b} a {c}");
        Console.WriteLine($"Obsah: {triangleArea(a, b, c)}, obvod: {triagnleCircumference(a, b, c)}");

    }
    /** task 1: 
    * Ctverec je definovany delkou strany n
    * Spocitejte a vypiste jeho obvod a obsah
    **/
    static double area(double n)
    {
        return n * n;
    }

    static double circumference(double n)
    {
        return 4 * n;
    }
    /** task 2: 
    * Kruh je definovany polomerem r
    * spocitejte a vypiste obvod a obsah kruhu
    **/
    static double circleArea(double r)
    {
        return Math.PI * r * r;
    }
    static double circleCircumference(double r)
    {
        return 2 * Math.PI * r;
    }
    /** task 3: 
    * Trojuhelnik je definovany delkami stran a,b,c.
    * spocitejte a vypiste obvod a obsah trojuhelniku dle heronova vzorce https://cs.wikipedia.org/wiki/Heron%C5%AFv_vzorec 
    **/
    static double triangleArea(double a, double b, double c)
    {
        if (!isTriangle(a, b, c))
        {
            return -1;
        }
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }
    static double triagnleCircumference(double a, double b, double c)
    {
        if (!isTriangle(a, b, c))
        {
            return -1;
        }
        return a + b + c;
    }
    static bool isTriangle(double a, double b, double c)
    {
        if (((a + b) > c) && ((a + c) > b) && ((b + c) > a))
        {
            return true;
        }

        return false;
    }
    /** task 4: 
    
    **/
    /** task 5: 
    
    **/
}