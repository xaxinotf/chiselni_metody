//Metod dilenna navpil

/*
using System.Text;
MethodDihotomia();


void MethodDihotomia()
{
    Console.WriteLine("Enter pls n,     epsilon 10^-n");
    var pow = int.TryParse(Console.ReadLine(), out var number) && number > 0 && number < 50 ? number : 3;
    
    
    Console.WriteLine($"x^4 - 2x^3 + x^2 - 2x + 1  = 0 interval[0.2;0.8], epsilon = 10^-{pow}");

    var e = Math.Pow(10, -pow);

    double a = 0.2;
    double b = 0.8;



    double c;
    var iteration = 0;
    do
    {
        c = (a + b) / 2;
        if (Func1(a) * Func1(b) < 0)
        {
            b = c;
        }
        else
        {
            a = c;
        }

        iteration++;
        Console.WriteLine($"Iteration: {iteration}, {b}, {a}");
    }
    while ( Math.Abs(b - a) >= e);

    Console.WriteLine("{0:0.00000000}", c);
}



double Func1(double x)
{


    return Math.Pow(x, 4) - 2 * Math.Pow(x, 3) + Math.Pow(x, 2) - 2 * x + 1;


}
*/


//metod sichnyh

/*
using System;

namespace MethodOfSecants
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.2;
            double b = 0.8;
            double epsilon = 1e-6;
            double x0 = a;
            double x1 = b;
            double x2 = 0;
            double f0 = F(x0);
            double f1 = F(x1);
            int iterationCount = 0;

            while (Math.Abs(x1 - x0) >= epsilon)
            {
                x2 = x1 - (f1 * (x1 - x0)) / (f1 - f0);
                x0 = x1;
                f0 = f1;
                x1 = x2;
                f1 = F(x1);
                iterationCount++;
                Console.WriteLine($"Iteration {iterationCount}: x2 = {x2}, f(x2) = {f1}");
            }

            Console.WriteLine($"\nThe root of the equation is: {x2}");
            Console.WriteLine("<===================================>");
            Console.WriteLine("<===================================>");
            Console.WriteLine("<===================================>");
            Console.WriteLine("Our Equation:");
            Console.WriteLine("x ^ 4 - 2x ^ 3 + x ^ 2 - 2x + 1 = 0 interval[0.2; 0.8], epsilon = 10 ^ -6");
            Console.ReadKey();
        }

        static double F(double x)
        {
            return x * x * x * x - 2 * x * x * x + x * x - 2 * x + 1;
        }
    }
}

*/

//10-20 iteraciy

/*
using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("x^4 - 2x^3 + x^2 - 2x + 1 = 0, interval [0.2, 0.8]");

        double a = 0.2;
        double b = 0.8;

        for (int iteration = 1; iteration <= 20; iteration++)
        {
            double c = (a + b) / 2;

            if (Func1(a) * Func1(b) < 0)
            {
                b = c;
            }
            else
            {
                a = c;
            }

            Console.WriteLine($"Iteration: {iteration}, a = {a}, b = {b}");
        }
        Console.WriteLine($"The root of the equation is: {((a + b) / 2):F8}");
        Console.WriteLine("tak yak vu prosulu zrobutu 10-20 iteraciy");
        Console.WriteLine("20 iteraciy");
    }

    public static double Func1(double x)
    {
        return Math.Pow(x, 4) - 2 * Math.Pow(x, 3) + Math.Pow(x, 2) - 2 * x + 1;
    }
}

*/



//10-20 iteraciy dlya metodu sichnyh


/*
using System;
namespace MethodOfSecants
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.2;
            double b = 0.8;
            double x0 = a;
            double x1 = b;
            double x2 = 0;
            double f0 = MathEquation(x0);
            double f1 = MathEquation(x1);

            for (int iterationCount = 1; iterationCount <= 20; iterationCount++)
            {
                x2 = x1 - (f1 * (x1 - x0)) / (f1 - f0);
                x0 = x1;
                f0 = f1;
                x1 = x2;
                f1 = MathEquation(x1);
                Console.WriteLine($"Iteration {iterationCount}: x2 = {x2}, f(x2) = {f1}");
            }
            Console.WriteLine($"\nThe root of the equation is: {x2}");
            Console.WriteLine("<===================================>");
            Console.WriteLine("<===================================>");
            Console.WriteLine("<===================================>");
            Console.WriteLine("Our Equation:");
            Console.WriteLine("x^4 - 2x^3 + x^2 - 2x + 1 = 0 interval[0.2; 0.8]");
            Console.WriteLine("tak yak vu prosulu zrobutu 10-20 iteraciy");
            Console.WriteLine("20 iteraciy");
            Console.ReadKey();
        }

        static double MathEquation(double x)
        {
            return Math.Pow(x, 4) - 2 * Math.Pow(x, 3) + Math.Pow(x, 2) - 2 * x + 1;
        }
    }
}


*/