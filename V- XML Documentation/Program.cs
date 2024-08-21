


using V__XML_Documentation;

employee emp1 = new employee();
Console.WriteLine(emp1.Nom);

string password = emp1.GeneratePassword(10);


Console.WriteLine(password);


#warning Cette méthode doit être optimisée avant la mise en production.
Console.WriteLine("Doing something...");