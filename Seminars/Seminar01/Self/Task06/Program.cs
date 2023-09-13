Console.WriteLine("enter the first leg");
var a = Console.ReadLine();
var A = float.Parse(a);
Console.WriteLine("enter the second leg");
var b = Console.ReadLine();
var B = float.Parse(b);
Console.WriteLine(Math.Sqrt(A * A + B * B));