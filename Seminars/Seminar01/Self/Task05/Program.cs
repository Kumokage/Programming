Console.WriteLine("enter U");
string U = Console.ReadLine();
Console.WriteLine("enter R");
string R = Console.ReadLine();
Console.WriteLine();
var u = float.Parse(U);
var r = float.Parse(R);
Console.WriteLine($"I = {u/r}");
Console.WriteLine($"P = {(u*u)/r}");