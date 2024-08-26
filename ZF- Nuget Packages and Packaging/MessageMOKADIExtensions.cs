using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZF__Nuget_Packages_and_Packaging
{
    public static class MessageMOKADIExtensions
    {
        public static void PrintUpperCase(this String message)
        {
            // pendant debug il aficher les detaile erors et exception . realise non
            // pour afficher un message lors Debug (Dev) et pas release (Prod)
#if DEBUG
            Console.WriteLine("PrintUpperCase methode");
#endif
            Console.WriteLine(message.ToUpper());
        }

        // 2. Méthode d'extension pour afficher un message en minuscules
        public static void PrintLowerCase(this String message)
        {
            Console.WriteLine(message.ToLower());
        }

        // 3. Méthode d'extension pour afficher le nombre de caractères dans le message
        public static void PrintLength(this String message)
        {
            Console.WriteLine($"The length of the message is: {message.Length}");
        }
    }
}
