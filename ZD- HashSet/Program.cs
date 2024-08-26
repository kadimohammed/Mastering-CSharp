using ZD__HashSet;

// HashSet ////////////////////////////////////////////////////
/*
Caractéristiques de HashSet<T>
Pas de doublons : Ne permet pas d'ajouter des éléments identiques.
Recherche rapide : Accès, ajout, et suppression efficaces (O(1) en moyenne).
Ordre non garanti : Les éléments ne sont pas stockés dans un ordre spécifique.
Opérations ensemblistes : Supporte des opérations comme union, intersection, et différence.

Quand utiliser HashSet<T>
Éviter les doublons : Idéal pour garantir l'unicité des éléments.
Performance rapide : Utilisez-le lorsque vous avez besoin d'opérations rapides de recherche et de manipulation.
*/


Client c1 = new Client("client1","tel1");
Client c2 = new Client("cleint2","tel2");
Client c3 = new Client("cleint3", "tel3");
Client c4 = new Client("cleint4", "tel4");
Client c5 = new Client("cleint5", "tel3"); // hna ghadi ykhdem b equals -> meme telephone donc maghadich izido flalist parceque deja kayn tel3


HashSet<Client> clients = new HashSet<Client>();

clients.Add(c1);
clients.Add(c2);
clients.Add(c3);
clients.Add(c4);

Client c6 = new Client("cleint6", "tel6");
HashSet<Client> clients1 = new HashSet<Client>();
clients1.Add(c6);

clients.UnionWith(clients1);
HashSet<Client> clients2  = clients.Union(clients1).ToHashSet();

foreach (Client client in clients)
{
    Console.WriteLine(client);
}


// SortedSet ////////////////////////////////////////////////////
/*
### Caractéristiques de `SortedSet<T>`
- **Tri automatique** : Les éléments sont toujours stockés dans un ordre trié.
- **Pas de doublons** : Ne permet pas d'ajouter des éléments identiques.
- **Recherche rapide** : Offre des performances efficaces pour les recherches, insertions, et suppressions.
- **Opérations ensemblistes** : Supporte des opérations comme union, intersection, et différence.

### Quand utiliser `SortedSet<T>`
- **Besoin d'un ordre trié** : Lorsque vous devez maintenir automatiquement l'ordre des éléments.
- **Éviter les doublons** : Idéal pour stocker des éléments uniques de manière triée.
- **Opérations sur des ensembles** : Parfait pour manipuler et comparer des ensembles de données.
*/

Console.WriteLine("\n\n");

SortedSet<Client> sortedSet = new SortedSet<Client>();

Client c7 = new Client("client7", "tel7");
Client c8 = new Client("cleint8", "tel8");
Client c9 = new Client("cleint9", "tel9");
Client c10 = new Client("cleint10", "tel10");

sortedSet.Add(c10);
sortedSet.Add(c9);
sortedSet.Add(c7);
sortedSet.Add(c8);

foreach (Client client in sortedSet)
{
    Console.WriteLine(client);
}


// SortedList ////////////////////////////////////////////////////
/*
### Caractéristiques de `SortedList<TKey, TValue>`
- **Tri automatique** : Les éléments sont triés par clé dès leur insertion.
- **Accès rapide** : Accès rapide aux éléments via l'index ou la clé.
- **Faible empreinte mémoire** : Utilise moins de mémoire que `SortedDictionary`.
- **Opérations coûteuses** : Les insertions et suppressions sont plus lentes que dans un `Dictionary`.

### Quand utiliser `SortedList<TKey, TValue>`
- **Nécessité de trier par clé** : Lorsque vous devez maintenir les éléments triés par clé.
- **Mémoire limitée** : Lorsque la gestion de la mémoire est critique et que les opérations d'ajout et de suppression sont peu fréquentes.
 */
Console.WriteLine("\n\nSortedList");
SortedList<string, string> sortedList = new SortedList<string, string>();

sortedList.Add("3", "Trois");
sortedList.Add("1", "Un");
sortedList["2"] = "Deux";  // Utilisation de l'indexeur
sortedList["a"] = "aaa";

foreach (KeyValuePair<string, string> kvp in sortedList)
{
    Console.WriteLine($"Clé: {kvp.Key}, Valeur: {kvp.Value}");
}

Console.WriteLine(sortedList["1"]);