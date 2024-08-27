using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using ZG__Threading;


Thread.CurrentThread.Name = "Master Thread";

Console.WriteLine($"Current Process Id : {Process.GetCurrentProcess().Id}");
Console.WriteLine($"Thread Id : {Thread.CurrentThread.ManagedThreadId}");
Console.WriteLine($"Thread Name : {Thread.CurrentThread.Name}");
Console.WriteLine($"Is Background : {Thread.CurrentThread.IsBackground}");
Console.WriteLine($"Thread Processor Id : {Thread.GetCurrentProcessorId()}");// lprocessor li khddam fih thread

/*
Foreground Thread(Thread principal) : Un thread de premier plan continue de s'exécuter même si 
l'application principale se termine. L'application ne se termine pas tant que tous les threads 
de premier plan ne sont pas terminés. Par défaut, les threads créés sont des threads de premier plan.

Background Thread (Thread en arrière-plan) : Un thread en arrière-plan s'arrête automatiquement 
dès que l'application principale se termine, même s'il n'a pas fini son travail. Il est utile 
pour des tâches qui ne nécessitent pas de bloquer la fin de l'application.
*/

int[] ints = new int[1000];

for (int i = 0; i < ints.Length; i++)
{
    ints[i] = i;
}

CalculeSum cs = new CalculeSum();
cs.Tab = ints;

Thread t1 = new Thread(() =>
{
    cs.ClaculeSum(0, 500);
});
t1.Name = "Thread1";

Thread t2 = new Thread(new ThreadStart(() =>
{
    cs.ClaculeSum(500, 1000);
}));
t2.Name = "Thread2";

Console.WriteLine($"state thread 1 :{t1.ThreadState}");

t1.Start();
t2.Start();

t1.Join();
t2.Join();


Console.WriteLine(cs.Somme);




// exercice 2 //////////////////////////////////////////////////////////////////


Compte compte1 = new Compte();

/*compte1.Debit(40);
compte1.Debit(30);*/


Thread th1 = new Thread(() => compte1.Debit(40));
Thread th2 = new Thread(() => compte1.Debit(30));

th1.Start();
th2.Start();

th1.Join();
th2.Join();

Console.WriteLine($"Solde = {compte1.Solde}");


// exercice 3 //////////////////////////////////////////////////////////////////

Console.WriteLine("\n\n");


// Exemple de Deadlock
/*
   Thread A verrouille compte1 et essaie de verrouiller compte2.
   Thread B verrouille compte2 et essaie de verrouiller compte1.
*/


Compte comp1 = new Compte();
Compte comp2 = new Compte();

Transfere tr1 = new Transfere(comp1, comp2, 10);
Transfere tr2 = new Transfere(comp2, comp1, 10);

Thread TransferThread1 = new Thread(() => tr1.Envoyer());
Thread TransferThread2 = new Thread(() => tr2.Envoyer());

TransferThread1.Start();
TransferThread2.Start();

TransferThread1.Join();
TransferThread2.Join();


Console.WriteLine(comp1);
Console.WriteLine(comp2);



// ThreadPool //////////////////////////////////////////////////////////////////
/*
Réutilisation des Threads : Le ThreadPool gère un pool de threads réutilisables. 
Au lieu de créer et détruire des threads à chaque fois qu'une tâche doit être exécutée, 
les threads sont réutilisés. Cela réduit la surcharge liée à la création et à la destruction des threads.

Économie de Temps : Créer et détruire des threads peut être coûteux en termes de temps et 
de ressources. Le ThreadPool réduit ce coût en maintenant un ensemble de threads prêts à l'emploi.
*/


// ThreadPool ne peut pas donner un nom
// ThreadPool toujour background
/*
ThreadPool.QueueUserWorkItem((obj) => {
    Console.WriteLine("ThreadPool" + obj);
    Console.WriteLine($"Thread Name : {Thread.CurrentThread.Name}");
    Console.WriteLine($"Thread Is Pool : {Thread.CurrentThread.IsThreadPoolThread}");
    Console.WriteLine($"Is Background : {Thread.CurrentThread.IsBackground}");
},"101102");


Console.WriteLine("\n\n");
*/



// Task //////////////////////////////////////////////////////////////////
Task myTask = Task.Run(() =>
{
    Console.WriteLine("Task is running.");
    Console.WriteLine($"Thread Name : {Thread.CurrentThread.Name}");
    Console.WriteLine($"Thread Is Pool : {Thread.CurrentThread.IsThreadPoolThread}");
    Console.WriteLine($"Is Background : {Thread.CurrentThread.IsBackground}");
    Task.Delay(2000).Wait();
    Console.WriteLine("Task completed.");
});

// Attendre que la tâche se termine avant de quitter l'application
//myTask.Wait();
await myTask;

Console.ReadKey();