
namespace Inheritance
{
    internal class Falcon : Animal
    {
        public new string nom = "kadi"; // hadi kanste3mlo new fach ikon chi attribut b7ala class mere mais machi daroti ghi bach n7aydo lwarning
        public int d { get; set; }
        public override int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Fly()
        {
            Console.WriteLine("Falcom fly");
        }

        public override void MoveTo()
        {
            throw new NotImplementedException();
        }
    }
}
