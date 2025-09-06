
using Mathematics;
using HR;


Complex Dobj = new Complex();
Complex c1 = new Complex(6, 9);
Complex c2 = new Complex(5, 7);

Complex c3 = c1 + c2; //+operator loading
Complex c4 = c1 - c2;

Console.WriteLine($"Before Swap C3={c3}, C4={c4}");
Complex.Swap(ref c1, ref c2);
Console.WriteLine($"Aftr Swap C3={c3}, C4={c4}");

object obj = new Employee(1, "Alice");  //Act of Polymorphism

Console.WriteLine(obj.ToString());
