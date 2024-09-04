

using System;
using ZP___Tuple_Type;

// reference tuple //////////////////////////////////////////////////////////

// hada kaykhezen fl heap
// hada kansta3mlo mlli kaykon 3endi les donner kbar bzf
Tuple<int,float> t = new Tuple<int, float>(5,2.2f);

// , un tuple en C# est immuable -- impossible de changer les valeur assigner
//t.Item1 = 1; // eror


string name;
double lat;
double lon;

Methodes.GetNameAndLocation(out name,out lat,out lon);

Console.WriteLine($"Name : {name}");
Console.WriteLine($"Latitude : {lat}");
Console.WriteLine($"Longitude : {lon}");

Tuple<string,double,double> tupl =  Methodes.GetNameAndLocationV2();

Console.WriteLine("\n"+tupl);

/*
Console.WriteLine($"Name : {tupl.Item1}");
Console.WriteLine($"Latitude : {tupl.Item2}");
Console.WriteLine($"Longitude : {tupl.Item3}");
*/



// equality /////////////////////////////////////////

var t1 = Tuple.Create(5, "kadi");
var t2 = Tuple.Create(5, "kadi");

Console.WriteLine(t1.Equals(t2)); // il compare les valeurs wakha reference type





// value tuple ////////////////////////////////////////////////////////

Console.WriteLine("\n");

// value tuple kaykhezen f stack machi fl heap performance tal3a
// redability ktar
// mantenability sahla
ValueTuple<int, string> vt = new ValueTuple<int, string>(5, "2.2f");


ValueTuple<string, double, double> ValueTupl = Methodes.GetNameAndLocationV3();
Console.WriteLine(ValueTupl);

(string, double, double) ValueTupl4 = Methodes.GetNameAndLocationV4();
Console.WriteLine(ValueTupl4);

(string, double, double) ValueTupl5 = Methodes.GetNameAndLocationV5();
Console.WriteLine(ValueTupl5);

// deconstruct
(string name, double lat, double lon) ValueTupl6 = Methodes.GetNameAndLocationV5();
Console.WriteLine($"{name} {lat} {lon}");


var ValueTupl7 = Methodes.GetNameAndLocationV7();
Console.WriteLine($"{ValueTupl7.name} {ValueTupl7.lat} {ValueTupl7.lon}");