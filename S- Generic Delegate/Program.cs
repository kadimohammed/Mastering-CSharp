using S__Generic_Delegate;

namespace genericDelegate;

public class Program
{
    public delegate bool Filter<in T>(T a); 
    // in -> parametre / out -> return
    public delegate U Filter2<in T, out U>(T a);

    static void Main(){

        // IEnumerable<int> values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 10, 16, 20 };
        //Calculer<int>(values, n => n > 0);

        Calcule<char> calcule = new Calcule<char>();

        IEnumerable<char> values = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k' };
        calcule.Calculer(values, n => n > 'c');
        Console.WriteLine("\n");
        calcule.Calculer1(values, n => n > 'c', i => Console.Write(i + " "));

    }


    static void Calculer<T>(IEnumerable<T> list, Filter<T> filter)
    {
        foreach (T i in list) 
        {
            if (filter(i))
            {
                Console.Write(i + " ");
            }
        }

    }

    static void Calculer1<T>(IEnumerable<T> list, Predicate<T> filter, Action<T> Printer)
    {
        foreach (T i in list)
        {
            if (filter(i))
            {
                Printer(i);
            }
        }

    }
}