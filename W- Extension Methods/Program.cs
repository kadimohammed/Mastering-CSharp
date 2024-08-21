

// Créer un objet DateTime représentant la date et l'heure actuelles
using W__Extension_Methods;

DateTime now = DateTime.Now;
Console.WriteLine("DateTime Now: " + now);

// Créer un DateTime avec une date spécifique
DateTime specificDate = new DateTime(2024, 8, 21, 14, 30, 0);
Console.WriteLine("DateTime Spécifique: " + specificDate);

specificDate = specificDate.Add(new TimeSpan(2, 5, 3));
Console.WriteLine("DateTime Spécifique time Span: " + specificDate);

Console.WriteLine(specificDate.IsWeekEnd());
Console.WriteLine(DateTimeHelper.IsWeekEnd(specificDate));

// Créer un objet DateTimeOffset représentant la date et l'heure actuelles avec l'offset de l'heure locale
DateTimeOffset nowOffset = DateTimeOffset.Now;
Console.WriteLine("DateTimeOffset Now: " + nowOffset);

// Créer un objet DateTimeOffset représentant la date et l'heure actuelles avec l'offset de l'heure locale UTC
DateTimeOffset nowOffset1 = DateTimeOffset.UtcNow;
Console.WriteLine("DateTimeOffset Now: " + nowOffset1);





// methode chainee
Pizza p = new Pizza();
PizzaExtension.AddChecken(PizzaExtension.AddOlive(PizzaExtension.AddSauce(p,"algerien"), "zitone"), "mechwi");
Console.WriteLine(p);


// methode extension
Pizza p1 = new Pizza();
p1.AddSauce("algerien")
    .AddOlive("zitoun")
    .AddChecken("...");
Console.WriteLine(p1);