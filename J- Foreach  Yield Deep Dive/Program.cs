


using System.Collections.Generic;

int[] numbers = { 10, 20, 30, 40, 50 };

// Utilisation de la boucle for
Console.WriteLine("Affichage avec for:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

// Utilisation de la boucle foreach
Console.WriteLine("\nAffichage avec foreach:");
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

// Utilisation de foreach avec une méthode lambda
Console.WriteLine("\nAffichage avec foreach ender te hood:");
ForEach(numbers, number => Console.WriteLine(number));



static void ForEach<T>(IEnumerable<T> collection, Action<T> action)
{
    if (collection == null) throw new ArgumentNullException(nameof(collection));
    if (action == null) throw new ArgumentNullException(nameof(action));

    using (IEnumerator<T> enumerator = collection.GetEnumerator())
    {
        while (enumerator.MoveNext())
        {
            T item = enumerator.Current;
            action(item);
        }
    }
}


Console.WriteLine("\nexmple 2");

IList<int> listnteger = getIntList2().ToList();
foreach (int number in listnteger)
{
    Console.WriteLine(number);
}

// yeild keyword ////////////////////////////////////////////////

static IEnumerable<int> getIntList()
{
    IList<int> list = new List<int>();
    for (int i = 0; i< 5; i++)
    {
        list.Add(i);
    }
    return list;
}

/*
 * L'kelma yield return hiya l'sir dial had l'code. Hadi katkhelli l'method t3ti l'values wa7da b wa7da, machi kolhom f daqqa wa7da.
 * Fach katappeli had l'method, ma katexecutach kamla f daqqa wa7da. Katbda kat3tik l'values wa7da b wa7da kol merra fach tatlabha.
 * Had l'technique kayssmiw "lazy evaluation" wla "deferred execution". Ya3ni l'execution dial l'code katssenna 7ta tji tstahl chi value.
 * Had l'approche naf3a bzaf ila kan 3endek bzzaf d data wla ila bghiti tkhdem 3la l'values b wa7da b wa7da bla ma tchargi kolchi f mémoire.
*/
static IEnumerable<int> getIntList1()
{
    for (int i = 0; i < 5; i++)
    {
        yield return i;
    }
}

static IEnumerable<int> getIntList2()
{
    yield return 0;
    yield return 1;
    yield return 2;
    yield return 3;
    yield break;
    yield return 4; 
}
