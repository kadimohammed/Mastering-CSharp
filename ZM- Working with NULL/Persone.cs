using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZM__Working_with_NULL
{
    internal class Persone
    {
        public string Name { get; set; }
        public string Age  { get; set; }
        public string Major { get; set; }


        public Persone(string name, string age)
        {
            Name = name;
            Age = age;
            this.setMajor();
        }

        public Persone(string name, string age, string major)
        {
            Name = name;
            Age = age;
            this.setMajor(major);
        }

        // be3d lmarrat lcompiler my9derch idetecter lcode li ktabnah wach s7i7 hna kansta3mlo had tari9a
        [MemberNotNull(nameof(Major))] // hna kate3lem lcompiler blli had la methode mymkenh ikon fiha Major Null
        public void setMajor(string? major = default)
        {
            Major = major ?? "Undeclared";
        }
    }
}
