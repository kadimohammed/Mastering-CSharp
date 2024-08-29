// dima les using globale homa lwala kaykono
// global using System.Text; // daba fay blasa fl projet te9der tekhdem bla matimporter had namespace

using kadi = System.Type;
using T2 = System;
using static  System.Math;


// namespace ABC{ } // eror // mamno3 that ay 7aja 9bel lcode
// te9der t7at function sans acces modifier 9bel wella menba3d le code
static void afficher()
{
    Console.WriteLine("eee");
}


kadi type = typeof(int);
T2.Type type1 = typeof(float);

Console.WriteLine(type);
Console.WriteLine(type1);

// static using methode

Console.WriteLine(System.Math.Cos(45));
Console.WriteLine(Cos(45));// appel direct

//using implicit // enable fl config nta3 le projet
Console.WriteLine(DateTime.Now); 

afficher();
Console.WriteLine("Top level");




// ftop level te9der t7at name space ba3d lcode
namespace ABC
{
    class c1
    {


    }
}


namespace efg
{

}