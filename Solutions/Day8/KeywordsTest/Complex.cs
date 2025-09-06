namespace Mathematics;

public class Complex
{

    public const double Ii = 3.14;
    public readonly int count;

    public double Real { get; set; }
    public double Imaginary { get; set; }

    public Complex() : this(0, 0) //constrctor chaining
    {

    }

    public Complex(double r, double i)
    {
        count++;
        Real = r;
        Imaginary = i;
    }

    public override string ToString()
    {
        return $"{Real} + {Imaginary}"; //placeholder for string interpolation
    }

    //Pass by value
    //Pass by address  (Pass by reference)

    public static void Swap(ref Complex c1, ref Complex c2) // its pass by ref
    {
        Complex temp = c1;
        c1 = c2;
        c2 = temp;

    }
    
     //Method overloading
     //Constructor overloading

    //Operator overloading
    public static Complex operator +(Complex a, Complex b)
    {
        return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
    }

    public static Complex operator -(Complex a, Complex b)
    {
        return new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
    }

}