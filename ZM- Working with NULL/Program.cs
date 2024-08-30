
// referencing / dereferencing ////////////////////////////////////////////////////////////////////

// string is reference type
using ZM__Working_with_NULL;

string str1 = default; // default is null <=> string str1 = null;
string str2 = "kadi";

// dereferencing
Console.WriteLine(str2.Length); // 5
//Console.WriteLine(str1.Length); // null ref exception


// value type
DateTime dt1 = default; // default is 0001/01/01
Console.WriteLine(dt1.Month);


// nullable value type /////////////////////////////////////////////////////////////////////////////
/*
Console.WriteLine("\n\n");

int num1 = 15;
int num2 = default; 
//var num3 = default(int);

Console.WriteLine(num1); // 15
Console.WriteLine(num2); // 0


// int null

Nullable<int> nullableInt = default; // null
if (nullableInt is null)
{
    Console.WriteLine("nullableInt is null");
}

int? nullableInt1 = default; // null
if (!nullableInt1.HasValue)
{
    Console.WriteLine("nullableInt1 is null");
}


Nullable<int> nullableInt2 = new Nullable<int>(); // null
Nullable<int> nullableInt3 = new (); // 0
int? nullableInt4 = default(int?); // 0
*/

// nullable reference type /////////////////////////////////////////////////////////////////////////////
/*
< Nullable > enable </ Nullable > // config de projet activiha bch te9der tekhdem biha f .net 6 lfo9 kayzidha automatique.
// diasable -> makay3tek walo
// warnings ->  kay3tek warning fach ikon 3endek chi code ye9der itsabeb f null ref exception
// enable -> kay3tek kolch
// annotations -> hna katstekhdem nullable ref type bs7 may3tekch lwarnings

Le mode `<Nullable>enable</Nullable>` dans un projet .NET permet d'activer les annotations 
de types de référence nullable, aidant à prévenir les erreurs liées à des références nulles 
en alertant lors de l'accès à des variables potentiellement nulles. L'avantage est une meilleure 
fiabilité du code, réduisant les risques de plantages dus à des exceptions de type `NullReferenceException`.

*/



string? name = null;
string disition = IsLongName(name) ? "Long" : "Short";
Console.WriteLine($"{name} is {disition}");


static bool IsLongName(string? name)
{
    if (name == null)
        return false;
    return name.Length > 10;
}

// <WarningsAsErrors>CS8600</WarningsAsErrors> ILA BGHIT TE3TABRE HAD TYPE AVERTISSEMENT COMME IROR ZID HAD LE CODE F PROJET CONFIG


static string? GetName()
{
    return null;
}

// la7wayej li kaychofhom lcompiler bach i3tek warning null

static string? GetNameV1()
{
    // fhad lfonction imposible ikon warning null reference exception 7it derna initialisation
    string name = "kadi"; 
    return name;
}
static string? GetNameV2()
{
    // fhad lfonction imposible ikon warning null reference exception 7it checking
    string? name = GetName();
    if(name == null) 
        return null;
    return name;
}

static bool MayBeNullSEnario()
{
    string? name = GetName();
    return name.Length > 10; // hna ye9der ikon null donc warning
}

// null annotation /////////////////////////////////////////////////////////////////////////////


string palayerfname = null!; // hna katgol lcompiler ana rani 3aref wach rani ndir bla madir warning

Player p1 = new Player(palayerfname);
// khas te7di rasek 9bel matzid ! ay treter ga3 les cas sinon ghadi ti7 f null reference exception
Console.WriteLine(p1.Name!.Length); // hna kangolo imposible ikon p1.Name null rani 3aref wach rani ndir



// Lcompiler maky9derch i3tek warning ila kan chi array fih reference type wella struct fih reference type
string[] names = new string[10];
Console.WriteLine(names[0]); // hna makanch warning 




Console.ReadKey();