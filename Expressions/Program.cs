// null operator 
// nul coalescing operator


string str1 = "ff";
string str2 = null;
str2 = str1 ?? "karim";

Console.WriteLine(str2);


//-------------------------------


string str4 = null;
//  string str5 = str4.ToLower();  null reference exception
string str5 = str4?.ToLower(); //==// string str6 = str4 is null ? null : str4.ToLower();

Console.WriteLine(str5);



// switch ---------------------------------------------------------------------------------------------------


int val = 5;


switch (val)
{
    case 1:
        Console.WriteLine("salam");
        break;
    case 2:
        Console.WriteLine("bonjour");
        break;
    case 3:
        Console.WriteLine("hello");
        break;
    default:
        Console.WriteLine("");
        break;
}



switch (val)
{
    case 1:
    case 2:
    case 3:
        Console.WriteLine("bonjour");
        break;
    case 4:
    case 5:
    case 6:
        Console.WriteLine("hello");
        break;
    default:
        Console.WriteLine("");
        break;
}



object obje = "kadi";

switch (obje)
{
    case int t:
        Console.WriteLine("int " + t);
        break;
    case float t:
        Console.WriteLine("float " + t);
        break;
    case string t:
        Console.WriteLine("string "+t);
        break;
    default:
        Console.WriteLine("autre type");
        break;
}

int number = 10;

switch (number)
{
    case int n when (n > 0):
        Console.WriteLine(n + " Number is positive.");
        break;
    case int n when (n < 0):
        Console.WriteLine(n + " Number is negative.");
        break;
    default:
        Console.WriteLine(number + " Number is zero.");
        break;
}



string valuefin = val switch
{
    1 => "kadi",
    2 => "bazhar",
    3 => "yassin",
    _ => "autre"
};

Console.WriteLine(valuefin);


// goto ---------------------------------------------------------------------------------------------------


int cmpt1 = 0;
block:
{
    Console.WriteLine("bonjour");
    cmpt1++;
}
if(cmpt1<10)
{
    goto block;
}

