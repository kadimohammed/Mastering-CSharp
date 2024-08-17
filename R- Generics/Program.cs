

using R__Generics;
using System.Collections;

/*
static void Display<T>(T value)
{
    Console.WriteLine(value);
}


Display(1);
Display<int>(1);
Display('a');
Display<string>("kadi");
*/



Any<int> array = new Any<int>();

array.Add(1);

Console.WriteLine(array);

array.Add(30);
array.Add(8);
array.Add(155);
array.Add(10);


Console.WriteLine(array);





ArrayList arrylist = new ArrayList();

arrylist.Add(1);
arrylist.Add("ahmed");
arrylist.Add('a');
arrylist.Add(1.255);
arrylist.Add(new {name = "kadi" , prenom = "mohammed"});// add anonymous object

Console.WriteLine("\n");
foreach (var item in arrylist)
{
    Console.WriteLine(item +" ");
}








