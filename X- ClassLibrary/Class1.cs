using System.Reflection;

namespace X__ClassLibrary
{
    public class Class1
    {
        public static void Trace()
        {
            Console.WriteLine("Executing Assembly  : " + Assembly.GetExecutingAssembly());
            Console.WriteLine("Calling Assembly  :  " + Assembly.GetCallingAssembly());
            Console.WriteLine("Entry Assembly :  " + Assembly.GetEntryAssembly());
        }
    }
}
