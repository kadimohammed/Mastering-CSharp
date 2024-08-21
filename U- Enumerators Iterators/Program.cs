

// == reference comparaison sauf string il compare la valeur
// == en peut surcharge loperateur

using U__Enumerators_Iterators;

object o1 = new object();
object o2 = new object();


Console.WriteLine(o1 == o2);

string s1 = "ahmed";
string s2 = "mohammed";


Console.WriteLine(s1 == s2);
Console.WriteLine(object.ReferenceEquals(s1,s2));



// Equals methode par defaut il compare les references
// redifinition pour comparer les valeur

Employee e1 = new Employee();
Employee e2 = new Employee();


Console.WriteLine(e1 == e2);
Console.WriteLine(e1.Equals(e2));




// Ienumrable - Ienumerator

FiveIntegger fi = new FiveIntegger();

foreach (var item in fi)
{
    Console.WriteLine(item);
}


// Icomparable


var temperatures = new List<Temperature>
{
    new Temperature { value = 30 },
    new Temperature { value = 20 },
    new Temperature { value = 25 }
};

temperatures.Sort();

foreach (var temp in temperatures)
{
    Console.WriteLine(temp.value);
}