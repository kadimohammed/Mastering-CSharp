using O_Enums;
using System;



Console.WriteLine((int)MonthEnum.April);

// ex 1

MonthEnum1 month = MonthEnum1.May | MonthEnum1.March;

// Ajouter un mois
month |= MonthEnum1.January;

// Retirer un mois
month &= ~MonthEnum1.January;
Console.WriteLine(month.HasFlag(MonthEnum1.January));


if (month.HasFlag(MonthEnum1.May ))
{
    Console.WriteLine("oui");
}
else
{
    Console.WriteLine("non");
}



// ex 2

MonthEnum1 month1 = MonthEnum1.MyMonths;
if (month1.HasFlag(MonthEnum1.February))
{
    Console.WriteLine("oui");
}
else
{
    Console.WriteLine("non");
}


// ex 3


string mnt = "May";
Console.WriteLine(Enum.Parse(typeof(MonthEnum), mnt));

// methode plus mieux pour gerer lexeption
if(Enum.TryParse(mnt, out MonthEnum mn))
{
    Console.WriteLine(mn);
}
else
{
    Console.WriteLine("eror !!!");
}



// autre methode
if (Enum.IsDefined(typeof(MonthEnum), mnt))
{
    Console.WriteLine(mn);
}
else
{
    Console.WriteLine("eror !!!");
}


// bocle sur lenum
foreach (var m in Enum.GetNames(typeof(MonthEnum)))
{
    Console.WriteLine("{0} = {1}",(int)Enum.Parse(typeof(MonthEnum),m),m);
}


foreach (var m in Enum.GetValues(typeof(MonthEnum)))
{
    Console.WriteLine("{0} = {1}", m.ToString(),(int)m);
}

