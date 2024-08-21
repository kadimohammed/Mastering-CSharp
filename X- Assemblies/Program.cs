using System.Reflection;
using X__Assemblies;
using X__ClassLibrary;


Type type = typeof(Persone);
Console.WriteLine(type);


Assembly assembly = type.Assembly;
Console.WriteLine(assembly);
Console.WriteLine(assembly.Location);


/////////////////////////////////////////////////////////////////////

AssemblyName assemblyname = assembly.GetName();
Console.WriteLine("assembly name = :"+assemblyname);
Console.WriteLine("name :" + assemblyname.Name);
Console.WriteLine("version = :" + assemblyname.Version);
Console.WriteLine("tocken = :" +  assemblyname.GetPublicKeyToken().Length);

Console.WriteLine(typeof(DateTime).Assembly.GetName().Name);

/////////////////////////////////////////////////////////////////////

Assembly asy = Assembly.GetExecutingAssembly();
Console.WriteLine(asy);

Class1.Trace();

/////////////////////////////////////////////////////////////////////

Stream stream = asy.GetManifestResourceStream(type, "contries.json");

Console.WriteLine("\n");







