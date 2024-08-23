// stack ou Queue -> makay7tafdoch bles objet fla memoire fach katrecuperh

// Stack / LIFO ///////////////////////////////////////////////////

// Créer une pile de type int
using Stack_and_Queue;

Stack<int> stack = new Stack<int>();

// Ajouter des éléments à la pile
stack.Push(1);
stack.Push(2);
stack.Push(3);

Console.WriteLine("Contenu de la pile:");
foreach (int item in stack)
{
    Console.WriteLine(item);
}

// Retirer l'élément au sommet de la pile
Console.WriteLine($"\nÉlément retiré: {stack.Pop()}");

// Regarder l'élément au sommet de la pile sans le retirer
Console.WriteLine($"Élément au sommet maintenant: {stack.Peek()}");

Console.WriteLine("\nContenu de la pile après Pop:");
foreach (int item in stack)
{
    Console.WriteLine(item);
}



if(stack.TryPeek(out int c))
{
    Console.WriteLine(c);
}
else
{
    Console.WriteLine("impossible il est vide !!!");
}


// Queue / FIFO ///////////////////////////////////////////////////

// Créer une file d'attente de type int
Queue<int> queue = new Queue<int>();

// Ajouter des éléments à la file d'attente
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);

Console.WriteLine("Contenu de la file d'attente:");
foreach (int item in queue)
{
    Console.WriteLine(item);
}

// Retirer l'élément en tête de la file d'attente
Console.WriteLine($"\nÉlément retiré: {queue.Dequeue()}");

// Regarder l'élément en tête de la file d'attente sans le retirer
Console.WriteLine($"Élément en tête maintenant: {queue.Peek()}");

Console.WriteLine("\nContenu de la file d'attente après Dequeue:");
foreach (int item in queue)
{
    Console.WriteLine(item);
}



// exercice "Stack" exemple

Stack<Command> commands = new Stack<Command>();

commands.Push(new Command("youtube.com"));
commands.Push(new Command("facebook.com"));
commands.Push(new Command("instagram.com"));
commands.Push(new Command("g9g.com"));

/*
foreach (var item in commands)
{
    Console.WriteLine(item);
}
*/

bool state = true;
Command d = null;
while (state)
{
    if (commands.Count > 0)
    {
        Console.WriteLine(commands.Peek());
    }
    else
    {
        Console.WriteLine("vide !!!");
    }
    
    string choix = Console.ReadLine();
    switch (choix)
    {
        case "back" :
            d = commands.Pop();           
            break;
        case "forward":
            commands.Push(d);
            break;
        case "exit":
            state = false;
            break;
        case "clear":
            commands.Clear();
            Console.WriteLine("la list bien vider");
            state = false;
            break;
        default:
            Console.WriteLine("invalid commande");
            break;
    }
}



// exercice "Queue" exemple

Queue<Coppy> coppies = new Queue<Coppy>();
coppies.Enqueue(new Coppy(5,"cv.pdf"));
coppies.Enqueue(new Coppy(2,"c#.docs"));
coppies.Enqueue(new Coppy(1,"rapport.exel"));
coppies.Enqueue(new Coppy(1,"cours.pdf"));


foreach (var item in coppies)
{
    item.Print();
}



