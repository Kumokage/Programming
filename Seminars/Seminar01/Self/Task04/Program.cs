Console.WriteLine("select console color number: \n1 - Red \n2 - Green \n3 - Blue \n4 - Black \n5 - White \n6 - Yellow \n7 - Purple");
string ColorOfConsole = Console.ReadLine();
Console.WriteLine("select text color number: \n1 - Red \n2 - Green \n3 - Blue \n4 - Black \n5 - White \n6 - Yellow \n7 - Purple");
string ColorOfText = Console.ReadLine();
Console.WriteLine("and print text :3");
string Text = Console.ReadLine();
if (ColorOfConsole == "1"){Console.BackgroundColor = ConsoleColor.Red;}
else if (ColorOfConsole == "2"){Console.BackgroundColor = ConsoleColor.Green;}
else if (ColorOfConsole == "3"){Console.BackgroundColor = ConsoleColor.Blue;}
else if (ColorOfConsole == "4"){Console.BackgroundColor = ConsoleColor.Black;}
else if (ColorOfConsole == "5"){Console.BackgroundColor = ConsoleColor.White;}
else if (ColorOfConsole == "6"){Console.BackgroundColor = ConsoleColor.Yellow;}
else if (ColorOfConsole == "7"){Console.BackgroundColor = ConsoleColor.Magenta;}
if (ColorOfText == "1"){Console.ForegroundColor = ConsoleColor.Red;}
else if (ColorOfText == "2"){Console.ForegroundColor = ConsoleColor.Green;}
else if (ColorOfText == "3"){Console.ForegroundColor = ConsoleColor.Blue;}
else if (ColorOfText == "4"){Console.ForegroundColor = ConsoleColor.Black;}
else if (ColorOfText == "5"){Console.ForegroundColor = ConsoleColor.White;}
else if (ColorOfText == "6"){Console.ForegroundColor = ConsoleColor.Yellow;}
else if (ColorOfText == "7"){Console.ForegroundColor = ConsoleColor.Magenta;}
Console.WriteLine(Text);