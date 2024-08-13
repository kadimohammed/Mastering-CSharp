
using _6_Constructor;

MyDate d1 = new MyDate(1,1,2000);


// object initializer avec constructeur par defaut => khas constructeur pardefaut et laccess les attribut (pubic-avec properties)
MyDate d2 = new MyDate
{
    Day = 2,
    Month = 2,
    Year = 1999,
};

// object initializer avec constructeur dinitialisation => khas constructeur pardefaut et laccess les attribut (pubic-avec properties)
MyDate d3 = new MyDate(2,2,1)
{
    Year = 1999,
};



Console.WriteLine(d1.GetDate());
Console.WriteLine(d2.GetDate());
