
namespace Inheritance
{
    //  class sealed ne support pas l'heritage
    internal sealed class Eagle : Animal
    {
        // public new int a { get; set; } // hiding filds
        public int c { get; set; } = 100001;


        public override int MyProperty 
        { 
            get
            {
                return c;
            }
            set => throw new NotImplementedException();
        }


        public sealed override void Move() // methode seald il interdera la redifinition dans les class fille
        {
            //base.Move();
            Console.WriteLine("the Eagle move"+base.a);
        }


        public Eagle()
        {
            Console.WriteLine("constructor eagle");
        }

        public void Fly()
        {
            Console.WriteLine("Eagle fly "+base.b);
        }

        public override void MoveTo()
        {
            throw new NotImplementedException();
        }
    }
}
