// See https://aka.ms/new-console-template for more information

using VectorClass;

Vector a = new Vector(new double[] { 1, 2, 3 });
Vector b = new Vector(new double[] { 4, 5, 6 });
 
Vector c = a + b;

Console.WriteLine($"a = {a}");
Console.WriteLine($"b = {b}");
Console.WriteLine($"c = a + b = {a + b}");
Console.WriteLine($"|a| = {a.Length()}");
Console.WriteLine($"max(a) = {a.Max()}");
Console.WriteLine($"minIndex(a) = {a.MinIndex()}");
Console.WriteLine($"a+(b+c) = {a + (b + c)}");
Console.WriteLine($"a.b = {a * b}");
Console.WriteLine($"a == b = {a == b}");
Console.WriteLine($"a != b = {a != b}");

Vector d = Vector.Read();
Console.WriteLine($"d = {d}");
Console.WriteLine($"|d| = {d.Length()}");
Console.WriteLine($"max(d) = {d.Max()}");
Console.WriteLine($"minIndex(d) = {d.MinIndex()}");
Console.WriteLine($"d+0 = {d + new Vector(d.Size())}");
Console.WriteLine($"d * (b + c) = {d * (b + c)}");
Console.WriteLine($"d == a = {d == a}");
Console.WriteLine($"d != a = {d != a}");
