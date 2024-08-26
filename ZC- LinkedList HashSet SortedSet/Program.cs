
using System.Collections.Generic;
using ZC__LinkedList_HashSet_SortedSet;

// Linked List ////////////////////////////////////////////////////////////////////////

/*
### Caractéristiques de `LinkedList`
-**Insertion rapide * * : Ajouter ou supprimer des éléments est rapide, surtout en début et fin de liste.
- **Pas d'accès direct** : L'accès aux éléments se fait en parcourant la liste, pas par index.
- **Mémoire non contiguë** : Les éléments ne sont pas stockés de manière continue en mémoire.
- **Doublement chaînée** : Chaque nœud pointe vers le suivant et le précédent (dans une `Doubly Linked List`).

### Quand utiliser `LinkedList`
- **Fréquentes insertions/suppressions** : Idéale lorsque vous modifiez souvent la liste.
- **Pas besoin d'accès rapide** : Utilisez-la si l'accès direct par index n'est pas crucial.
*/


Video v1 = new Video(1, "url1");
Video v2 = new Video(2, "url2");
Video v3 = new Video(3, "url3");
Video v4 = new Video(4, "url4");
Video v5 = new Video(5, "url5");
Video v6 = new Video(6, "url6");



LinkedList<Video> videos = new LinkedList<Video>();
videos.AddLast(v2);
videos.AddAfter(videos.First, v3);
var node = new LinkedListNode<Video>(v5);
videos.AddAfter(videos.First.Next, node);
videos.AddAfter(videos.First.Next.Next, v6);
videos.AddBefore(videos.Last, v4);
videos.AddFirst(v1);

LinkedListNode<Video> firstNode = videos.First;
Console.WriteLine(firstNode.Value);
Console.WriteLine("\n");

foreach (Video v in videos)
{
    Console.WriteLine(v);
}






