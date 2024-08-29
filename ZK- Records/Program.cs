using System.Drawing;
using System.Reflection;
using ZK__Records;

MyPoint p1 = new MyPoint(1,2);
MyPoint p2 = new MyPoint(1, 2);
MyPoint p3 = new MyPoint(); // es structs ont toujours un constructeur par défaut implicite, même si vous ne le définissez pas explicitement.

MyPoint p4 = new MyPoint
{
    X = 1,
    Y = 1,
    Z = 1,
};

//p4.Z = 4; // compile eror

Console.WriteLine(p1.Equals(p2)); // true il compare les valeur sans redifinir la mehod equals

// record ///////////////////////////////////////////////////////////////////////////////////////////

Console.WriteLine("\n\n");

PointRecord pr1 = new PointRecord(1,2);
PointRecord pr2 = new PointRecord(1,2);


Console.WriteLine(pr1);
Console.WriteLine(pr1.Equals(pr2));
Console.WriteLine(pr1 == pr2);

var (x, y) = pr1;

Console.WriteLine($"x={x}  y={y}");

// position record -> lecture seul sur les attributs  ///////////////////////////////////////////////////////////////////////////////////////////

Console.WriteLine("\n\n");

PointRec prec1 = new PointRec(2, 5)
{
    X = 1,
    Y = 5,
};
PointRec prec2 = new PointRec(2,5);

//prec2.X = 10; // compile record // position record emmutable par defaut ya3ni mat9derch tmodifier 3lih

Console.WriteLine(prec1);
Console.WriteLine(prec1.Equals(prec2));
Console.WriteLine(prec1 == prec2);

var (x1, y1) = prec1;

Console.WriteLine($"x={x1}  y={y1}");






// struct positionale record  //////////////////////////////////////////////////////////////

Console.WriteLine("\n\n");

PointStructRecord pstrec1 = new PointStructRecord(2, 5)
{
    X = 2,
    Y = 5,
};

pstrec1.X = 10; // struct record machi emmutable te9der tmodifier ila bghit iwllli emmutable zid readonly
PointStructRecord pstrec2 = new PointStructRecord(2, 5);


Console.WriteLine(pstrec1);
Console.WriteLine(pstrec1.Equals(pstrec2));
Console.WriteLine(pstrec1 == pstrec2);

var (x2, y2) = pstrec1;

Console.WriteLine($"x={x2}  y={y2}");


// machi recomander fach ikono 3endna bzf les parametre
PointStructRecord pstrec3 = new PointStructRecord(2, pstrec1.Y); 

// kaycopier kolchi ou katmodifier i li bghit wast {}
PointStructRecord pstrec4 = pstrec1 with { Y = 7 };
Console.WriteLine(pstrec4);
