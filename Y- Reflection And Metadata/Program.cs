
using System.Reflection;
using Y__Reflection_And_Metadata;

/*
Type t1 = DateTime.Now.GetType(); // at runtime
Console.WriteLine(t1);
Type t2 = typeof(DateTime); // at compile time
Console.WriteLine(t2);

Console.WriteLine($"FullName: {t1.FullName}"); // Namespace.TypeName
Console.WriteLine($"Namespace: {t1.Namespace}"); // Namespace
Console.WriteLine($"Name: {t1.Name}"); // Type Name
Console.WriteLine($"BaseType: {t1.BaseType}"); // Base Type
Console.WriteLine($"IsPublic: {t1.IsPublic}");
*/



//////////////////////////////////////////////////////////////////////////////////////////

/*
DateTime dt = (DateTime)Activator.CreateInstance(typeof(DateTime));
Console.WriteLine(dt);



string typeName = Console.ReadLine();
Assembly assembly = Assembly.GetAssembly(typeof(Player));
string fullTypeName = $"{typeof(Player).Namespace}.{typeName}";

object playerInstance = Activator.CreateInstance(assembly.GetType(fullTypeName));

Player player = (Player)playerInstance;


*/

///////////////////////////////////////////////////////////////////////////////////////////
///

Console.WriteLine("\n 1-members");
MemberInfo[] members = typeof(BanqueAccount).GetMembers(BindingFlags.Public | BindingFlags.Instance);
foreach (MemberInfo member in members)
{
    Console.WriteLine(member);
}

Console.WriteLine("\n 2-filds");
FieldInfo[] filds = typeof(BanqueAccount).GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
foreach (FieldInfo fild in filds)
{
    Console.WriteLine(fild);
}

Console.WriteLine("\n 3-properties");
PropertyInfo[] properties = typeof(BanqueAccount).GetProperties();
foreach (PropertyInfo prop in properties)
{
    Console.WriteLine(prop);
    Console.WriteLine(prop.GetGetMethod());
}

Console.WriteLine("\n 4-events");
EventInfo[] events = typeof(BanqueAccount).GetEvents();
foreach (EventInfo even in events)
{
    Console.WriteLine(even);
}


Console.WriteLine("\n 5-constructor");
ConstructorInfo[] constructs = typeof(BanqueAccount).GetConstructors();
foreach (ConstructorInfo construct in constructs)
{
    Console.WriteLine(construct);
}


Console.WriteLine("\n 6-constructor");
MemberInfo[] constructs1 = typeof(BanqueAccount).GetMember(".ctor");
Console.WriteLine(constructs1[0]);
Console.WriteLine(constructs1[1]);



BanqueAccount account = new BanqueAccount("kadi",123456789, 100.0);
MethodInfo method = typeof(BanqueAccount).GetMethod("Deposit");
method.Invoke(account , new object[] {2000});

Console.WriteLine(account);


account.MyEvent += (obj, newBalance) =>
{
    Console.WriteLine(obj+" balance < 0.");
    Console.WriteLine($"new Balance = {newBalance}");
};

account.Withdraw(200);

////////////////////////////////////////////////////////////////////////////////////////////////


// Chemin vers le fichier DLL
var path = @"C:\Users\MO KADI\Desktop\.net course\Mastering-CSharp\Y- Reflection And Metadata\ClassLibrary1.dll";

// Charger l'assembly à partir du fichier
var assembly = Assembly.LoadFile(path);

// Obtenir tous les types définis dans l'assembly
var types = assembly.GetTypes();

// Parcourir les types et les afficher dans la console
foreach (var t in types)
{
    Console.WriteLine(t);
}

Console.ReadKey();