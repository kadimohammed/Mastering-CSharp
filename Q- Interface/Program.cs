


using Q__Interface;
using Q__Interface.explicite_implimentation;

ISwimmable swimmable = new Duck();

swimmable.Swim();
// swimmable.Fly(); // eror


IPrinter p = new AllInOneDevice();
p.Print();
p.Display();
Console.WriteLine(p.prop);
p.prop = 6;


Console.WriteLine("\n");

IScanner p1 = new AllInOneDevice();
p1.Print();

Console.WriteLine("\n");

AllInOneDevice p2 = new AllInOneDevice();
p2.Print();
p2.Display(); // eror si AllInOneDevice ne redifini pas display methode
Console.WriteLine(p2.prop);
p2.prop = 6;
