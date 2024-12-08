using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZO__String_Builder
{
    internal class StringGenerator
    {
        public static string GenerateStringWithStringClass()
        {
            string Name = null; 
            Name += String.Concat(new char[] {'M','A','D','I','R'}); // new object
            Name = Name.Replace('M','K'); // new object
            Name = Name.Remove(Name.Length-1); // new object

            return Name;
        }


        public static string GenerateStringWithStringBuilderClass()
        {
            StringBuilder Sb = new StringBuilder(); // un seul object
            Sb = Sb.Append(new char[] { 'M', 'A', 'D', 'I', 'R' });
            Sb.Replace('M', 'K');
            Sb.Remove(Sb.Length - 1, 1);
            return Sb.ToString();
        }
    }
}
