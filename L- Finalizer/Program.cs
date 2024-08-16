using L__Finalizer;
using System.Numerics;



// appel de destructor lorsque la memoire est plein

Persone p;
for (int i = 0; i < 5; i++)
{
    p = new Persone();
}

//Console.WriteLine($"{20000000000:N0}"); // N0 kat9ssem kola 3 bwa7edhom

Console.WriteLine("avant clean");
Console.WriteLine($"total memory = {GC.GetTotalMemory(false)}");
GC.Collect();
GC.WaitForPendingFinalizers(); // st utilisée pour indiquer que le programme doit attendre que le Garbage Collector (GC) termine
Console.WriteLine($"total memory = {GC.GetTotalMemory(true):N0}");

Console.WriteLine("apres clean");


Console.ReadKey();