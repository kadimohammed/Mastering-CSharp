using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Properties
{
    internal class Moteur
    {
        
        // propriété auto-implémentée
        public int MyProperty { get; set; }
        private string _type;

        /// <summary>
        /// pondant la compilation clr convert propertie comme des methode getter setter sur java
        /// </summary>
        /// 
        //property
        public string Type
        {
            get
            {
                Console.WriteLine("getter");
                return this._type;
            }
            private set
            {
                Console.WriteLine("setter");
                this._type = value;
            }
        }

        public string Type1
        {
            get =>   this._type;
            set => this.Type = value;
        }

        //property IsMercedese
        public bool IsMercedese
        {
            get
            {
                return this.Type == "Mercedese";
            }
        }

        // property avec autre ecriture
        public bool IsAudi => this.Type == "Audi";

        // property avec autre ecriture
        public int Size { get; set; } = 1000;


        public void setType(string type)
        {
            this.Type = type;
        }

        
    }
}
