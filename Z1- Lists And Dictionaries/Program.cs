using Z1__Lists_And_Dictionaries;

// list ///////////////////////////////////////////////////////////////////////////////////////////////////

Player[] playersArray =
{
    new Player(1,"kadi"),
    new Player(2,"meed"),
    new Player(1,"yassin")
};

List<Player> list = new List<Player>();
//List<Player> list = new List<Player>(3);  // capaity initiale = 3 fach t3mer list b3 kayda3ef capacity twalli 6 ...
//List<Player> list = new List<Player>(playersArray); // te9der tfawet array bach t3amer list
list.Add(new Player(0, "abdou"));
list.AddRange(playersArray);
list.AddRange(list);


list.Insert(1,new Player(55, "ahmed"));

Console.WriteLine($"count est : {list.Count}");
Console.WriteLine($"Capacity est : {list.Capacity}");

foreach (Player p in list)
{
    Console.WriteLine("\n"+p);
}


//list.RemoveAt(0); // supprimer by index
//list.RemoveAll(u => u.Name.EndsWith("med")); // supprimer by index
list.Remove(playersArray[0]); // khas tkon meme reference ou redifinition hash code et equals methods

// list.Clear(); // vider la list

Console.WriteLine("\n");
foreach (Player p in list)
{
    Console.WriteLine("\n" + p);
}



// Dictionaries ///////////////////////////////////////////////////////////////////////////////////////////////////

Dictionary<int,Player> dict = new Dictionary<int,Player>();

dict.Add(0, new Player(0, "p0"));
dict.Add(1, new Player(0, "p1"));
dict.Add(2, new Player(0, "p2"));
dict.Add(3, new Player(0, "p3"));
dict.Add(4, new Player(0, "p4"));

dict.Remove(1);

foreach (var p in dict)
{
    Console.WriteLine("key: "+p.Key+" - value: "+p.Value);
}

// convert list to dictionary //////////////////////////////////////////////////////////////



Player[] playersArray1 =
{
    new Player(0,"kadi"),
    new Player(1,"kadi"),
    new Player(2,"meed"),
    new Player(10,"yassin")
};



var dictPlayer = playersArray1.ToDictionary(p => p.Id, p => p);

var dictPlayercount = playersArray1.GroupBy(p=>p.Name).ToDictionary(p => p.Key, p => p.Count());

Console.ReadKey();