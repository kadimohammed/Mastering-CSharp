

// bas niveax 
using System.Runtime.CompilerServices;

Thread t1 = new Thread(obj =>
{
    Display("Thread");
});

t1.Start();
t1.Join();


// haut niveax 
await Task.Run(() =>
{
    Display("Task");
});




// Task generique qui return un Type
Task<DateTime> task1 = Task.Run(() =>
{
    return DateTime.Now;
});

Console.WriteLine(task1.Result); // had tari9a katbloki thread
Console.WriteLine(task1.GetAwaiter().GetResult()); 




/*
 Préserve le pool de threads : Empêche les tâches longues de bloquer les threads du pool, 
permettant à d'autres tâches de courte durée de s'exécuter efficacement.

Optimisation des performances : Utilise un thread dédié pour les tâches intensives, 
améliorant ainsi la réactivité et les performances de l'application.

Évite les blocages : Garantit que les tâches longues n'affectent pas la disponibilité des 
threads pour d'autres opérations asynchrones.
*/
var task2 = Task.Factory.StartNew(() =>
{
    Thread.Sleep(3000);
    Display("Task long temps");
},TaskCreationOptions.LongRunning);

task2.Wait();

// thread /task - exception ///////////////////////////////////////////////////////////////////////////////////////////////////////
// thread mat9derch thandle exception ta3 thread child fthread parent ftask te9der
/*
try
{
    Thread threadex = new Thread(ThrowException);
    threadex.Start();
    threadex.Join();
}
catch
{
    Console.WriteLine("exception throwed !!");
}
*/
/*
try
{
    await Task.Run(ThrowException);
}
catch
{
    Console.WriteLine("exception throwed !!");
}
*/



// task continuation ///////////////////////////////////////////////////////////////////////////////////////////
/*
Task<int> taskc1 = Task.Run(getInt);
//Console.WriteLine(taskc1.Result); // block thread (hadi kankhadmoha fles operation li makakhdoch wa9t bzf)

TaskAwaiter<int> awaiter = taskc1.GetAwaiter();
awaiter.OnCompleted(() =>
{
    Console.WriteLine(awaiter.GetResult()); // hadi 7etta hiya katbloki bs7 hna dernaha 7etta kemel task
    Console.WriteLine("task se termine");
});

// tari9a msahla
taskc1.ContinueWith( (t) => 
{
    Console.WriteLine(t.Result);
    Console.WriteLine("task se termine");
});


Console.WriteLine("Fin Task");
*/

// task Delay ///////////////////////////////////////////////////////////////////////////////////////////

Console.WriteLine("\n\n");

ThreadSleep();
TaskDelay();









static void ThreadSleep()
{
    Thread.Sleep(3000);
    Console.WriteLine("fin thread sleep");
}

static void TaskDelay()
{
    Task.Delay(3000).GetAwaiter().OnCompleted(() =>
    {
        Console.WriteLine("fin Task Delay");
    });
}

static int getInt()
{
    Thread.Sleep(3000);
    return 1234;
}

static void ThrowException()
{
    throw new Exception("exception");
}


static void Display(string message)
{
    Console.WriteLine($"thread id: {Thread.CurrentThread.ManagedThreadId} / Is Pool: {Thread.CurrentThread.IsThreadPoolThread} / Is Background: {Thread.CurrentThread.IsBackground}");
    Console.WriteLine(message);
}


Console.ReadKey();