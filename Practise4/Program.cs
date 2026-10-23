using System;
using System.Globalization;

class Program
{
    static void Main(String[] args)
    {
        PrintNumsWhile();
        PrintNumsFor();
        Console.WriteLine($"5! = {Factorial(5)}");
        Console.WriteLine($"5^3 = {Power(5, 3)}, 5^0 = {Power(5, 0)}, 5^1 = {Power(5, 1)}");
        PrintNumsModulo();
    }
    // task 1: 
    // s pomoci cyklu while vypiste na konzoli:
    // cisla 1,2,3,4,5,6,7,8,9
    // cisla 10,9,8,7,6,5,4,3,2,1
    // cisla 10,20,30,40,50,60,70,80,90,100
    // cisla 10,100,1000,10000,100000
    // cisla 256,128,64,32,16,8,4,2,1
    static void PrintNumsWhile()
    {
        int num = 1;
        while (num < 10)
        {
            Console.Write($"{num}");
            if (num != 9)
            {
                Console.Write(",");
            }
            num++;
        }
        Console.Write("\n");
        num = 10;
        while (num > 0)
        {
            Console.Write($"{num}");
            if (num != 1)
            {
                Console.Write(",");
            }
            num--;
        }
        Console.Write("\n");
        num = 10;
        while (num < 101)
        {
            Console.Write($"{num}");
            if (num != 100)
            {
                Console.Write(",");
            }
            num += 10;
        }
        Console.Write("\n");
        num = 10;
        int i = 5;
        while (i > 0)
        {
            Console.Write($"{num}");
            if (i != 1)
            {
                Console.Write(",");
            }
            num *= 10;
            i--;
        }
        Console.Write("\n");
        num = 256;
        i = 8;
        while (i > -1)
        {
            Console.Write($"{num}");
            if (i != 0)
            {
                Console.Write(",");
            }
            num /= 2;
            i--;
        }
        Console.Write("\n");
    }
    // task 2:
    // s pomoci cyklu forvypiste na konzoli:
    // cisla 1,2,3,4,5,6,7,8,9
    // cisla 10,9,8,7,6,5,4,3,2,1
    // cisla 10,20,30,40,50,60,70,80,90,100
    // cisla 10,100,1000,10000,100000
    // cisla 256,128,64,32,16,8,4,2,1
    static void PrintNumsFor()
    {
        for (int i = 1; i < 10; i++)
        {
            Console.Write($"{i}");
            if (i != 9)
            {
                Console.Write(",");
            }
        }
        Console.Write("\n");
        for (int i = 10; i > 0; i--)
        {
            Console.Write($"{i}");
            if (i != 1)
            {
                Console.Write(",");
            }
        }
        Console.Write("\n");
        for (int i = 10; i < 101; i += 10)
        {
            Console.Write($"{i}");
            if (i != 100)
            {
                Console.Write(",");
            }
        }
        Console.Write("\n");
        int num = 10;
        for (int i = 5; i > 0; i--)
        {
            Console.Write($"{num}");
            if (i != 1)
            {
                Console.Write(",");
            }
            num *= 10;
        }
        Console.Write("\n");
        num = 256;
        for (int i = 0; i <= 8; i++)
        {
            Console.Write($"{num}");
            if (i != 8)
            {
                Console.Write(",");
            }
            num /= 2;
        }
        Console.Write("\n");
    }
    // task 3:
    // Spocitejte faktorial cisla n
    // n!
    static double Factorial(double num)
    {
        if (num <= 1)
        {
            return 1;
        }
        return num * Factorial(num - 1);
    }
    // task 4:
    // mocnina cyklem
    static double Power(double num, int exponent)
    {
        double result = 1;
        if (exponent == 0)
        {
            return 1;
        }
        if (exponent == 1)
        {
            return num;
        }
        if (exponent < 0)
        {
            return -1;
        }
        for (int i = exponent; i > 0; i--)
        {
            result *= num;
        }
        return result;
    }
    // task 5:
    // S pomocí operátoru modulo vypiste cisla od 0 do 100 delitelna 5 nebo 3
    // 0, 3, 5, 6, 9, 10 .... 100
    static void PrintNumsModulo()
    {
        int num = 0;
        while (num <= 100)
        {
            if (num % 3 == 0 || num % 5 == 0)
            {
                Console.Write(num);
                if (num != 100)
                {
                    Console.Write(",");
                }
            }
            num++;
        }
        Console.Write("\n");
    }
}