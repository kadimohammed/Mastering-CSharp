using _9_Delegate;

MyClass.Somme((bb, jj) => bb + jj);




void DisplayNumber(IList<int> numbers)
{
    foreach (var n in numbers)
    {
        Console.WriteLine(n + " ");
    }
}



// exemple 2 /////////////////////////////////////////////////////////////////////

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 11, 12, 15, 20 };

// Crée une instance de la classe FilterNumbers
FilterNumbers filterNumbers = new FilterNumbers();


Console.WriteLine("Nombres pairs :");
// Utilisation d'une expression lambda pour filtrer les nombres pairs
IList<int> newist = filterNumbers.FiltrerNumbers(numbers, (n) =>
{
    return n % 2 == 0; // Déclaration d'un délégué lambda pour vérifier si un nombre est pair
});
DisplayNumber(newist); 


FilterNumbers.FilterCriteria IsOdd = (n) => n % 2 != 0; // Délégué lambda nommé pour vérifier si un nombre est impair

Console.WriteLine("Nombres impairs :");
// Utilisation du délégué nommé IsOdd pour filtrer les nombres impairs
IList<int> newist1 = filterNumbers.FiltrerNumbers(numbers, IsOdd);
DisplayNumber(newist1); 


Console.WriteLine("Nombres supérieurs à 10 :");
// Utilisation d'une méthode pour filtrer les nombres supérieurs à 10
IList<int> newist2 = filterNumbers.FiltrerNumbers(numbers, filterNumbers.IsGreaterThanTen);
DisplayNumber(newist2); 



Console.WriteLine("Nombres supérieurs à 15 :");
// Utilisation d'un délégué anonyme pour filtrer les nombres supérieurs à 15
IList<int> newist3 = filterNumbers.FiltrerNumbers(numbers, delegate (int n) { return n > 15; });
DisplayNumber(newist3);


// exmple 3 Délégué Multicast ////////////////////////////////////////////////


MessagePublisher mp = new MessagePublisher(); 

MessagePublisher.SendMessage a = mp.PublishMessageSMS; 
a += mp.PublishMessageEmail; // subscribe
a += mp.PublishMessageWhatsap;

a("hello");

a -= mp.PublishMessageWhatsap; // insubscribe

a("salam");