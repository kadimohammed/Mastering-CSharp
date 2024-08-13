using Microsoft.VisualBasic;
using OOP___Field___Constant;

// Casting / Type Conversion in C# ---------------------------------------------------------------------------------------------------

/*Class => alias */

// Int16 => short
// Int32 => int
// Int64 => long

// UInt16 => ushort
// UInt32 => uint
// UInt64 => ulong

// Single => float   => 32 bits
// Double => double  => 64 bits
// Decimal => decimal => 128 bits

// Byte => byte    => 8 bits   0 à 255
// SByte => sbyte  => 8 bits   -128 à 127

// Char => char
// Boolean => bool





long numb = 1000;
if (numb < int.MaxValue)
{
    int numero = (int)numb;  // explicit cast
}



// Boxing / UnBoxing /////////////////////////////////////////

int num1 = 4; // value type
Object oo = num1; //Boxing => value type --> reference type
int num2 = (int)oo; //unboxing => reference type --> value type


///////////////////////////////////////////////////////////////

// string numeroo = "1238888888888888888"; // over flow exception
// string numeroo = "123hf"; // format exception

//solution

string numeroo = "123";

int numerot2 = int.Parse(numeroo);

if (int.TryParse(numeroo, out int numparse))
{
    Console.WriteLine(numparse);
}
else
{
    Console.WriteLine("conversion impossible");
}


//convert type ///////////////////////////////////////////////////////////////

 // parse  plus performant que convert class

string stringValue = "12345";

decimal decimalValue = Convert.ToDecimal(stringValue);
float floatValue = Convert.ToSingle(stringValue);
double doubleValue = Convert.ToDouble(stringValue);
short shortValue = Convert.ToInt16(stringValue);
int intValue = Convert.ToInt32(stringValue);
long longValue = Convert.ToInt64(stringValue);
ushort ushortValue = Convert.ToUInt16(stringValue);
uint uintValue = Convert.ToUInt32(stringValue);
ulong ulongValue = Convert.ToUInt64(stringValue);

// bit covertor ///////////////////////////////////////////////////////////////



//int TO byte
/*
int number = 255;

byte[] i = BitConverter.GetBytes(number);

Console.WriteLine(i.Length);

foreach (byte b in i)
{
    Console.Write(Convert.ToString(b,2).PadLeft(8,'0')+" ");
}
*/


//string TO byte
string nom = "ahmed";
char[] letters = nom.ToCharArray();

foreach (char b in letters)
{
    int ascci = Convert.ToInt32(b);
    Console.WriteLine($"lettre :{b} , Ascii :{ascci} , binaire : {Convert.ToString(ascci,2).PadLeft(8, '0')}, hexadicimal :{ascci:x}");
}


//  hexadecimale to int / int to string

string numb1 = "6D";
int numb_int = int.Parse(numb1, System.Globalization.NumberStyles.HexNumber);
int numb_int2 = Convert.ToInt32(numb1, 16);

string cahr1 = Char.ConvertFromUtf32(numb_int);

Console.WriteLine(numb_int);
Console.WriteLine(numb_int2);
Console.WriteLine(cahr1);

int aaaa;
