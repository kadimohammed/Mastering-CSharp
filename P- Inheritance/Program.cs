
using Inheritance;



Eagle e = new Eagle();
e.MyProperty = 2;
Console.WriteLine(e.MyProperty);

/*
Eagle eagle1 = new Eagle();
Animal animal = eagle1; // up casting
animal.b = "animale 1";

Eagle eagle2 = (Eagle)animal; // down casting
eagle2.Fly();
*/


Animal eagle1 = new Eagle();
Animal animal = eagle1;
//Falcom falcom1 = (Falcom)animal; //exeception 
//Falcom falcom1 = animal as Falcom; // return null


// verification
if (animal is Falcon)
{
    Falcon falcom1 = (Falcon)animal;
    Console.WriteLine(falcom1.a);
    Console.WriteLine("is falcom");
}
else
{
    Console.WriteLine("is not falcom");
}