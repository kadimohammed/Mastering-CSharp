

namespace Inheritance
{
    internal abstract class Animal
    {
        public string nom = "meed";
        //public virtual int MyProperty { get; set; }
        public abstract int MyProperty { get; set; }
        public int a { get; set; } = 10;
        public string b { get; set; } = "kadi";

        // protected : acces just a linterieur des classs filles
        public virtual void Move()
        {
            Console.WriteLine("animal move");
        }

        public Animal()
        {
            Console.WriteLine("constructor Animal");
        }

        public abstract void MoveTo();

    }
}
