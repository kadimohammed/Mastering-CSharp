


using Methods;

Joueur j = new Joueur();

float a;

j.CalculateStats(10, 15, out a);

Console.WriteLine(a);
// parametre out khaso darori tmodifia wast lmethode




// parametre ref khaso darori valeur 9bel matfawto lmethode
int level = 6;

j.UpgradeLevel(ref level);

j.ChangeNumero(j);

Console.WriteLine(j.numero);
Console.WriteLine(level);