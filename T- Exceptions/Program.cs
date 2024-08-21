


using T__Exceptions;

try
{
    Console.WriteLine("hello kadi");
}
catch(NullReferenceException ex) when (ex.Source == "Exception") // constraints =>  nom du projet
{
    Console.WriteLine(ex.Message);
}
catch(FormatException f) when (f.Message == "...")
{
    Console.WriteLine(f.Message);
}
catch (MyException ex)
{
    Console.WriteLine(ex.Message + " "+ex.Location);
}
catch (OverflowException ex) // swallow exception sans handling
{
    // inform the user
    // logging
    // Ducking (Rethrowing)
}
catch (Exception ex) // lordre et important bas vesr haute classes
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("finaly");
}