// See https://aka.ms/new-console-template for more information


/*int count = 0;
object locker = new object();

void PrintHello(object amount)
{
    int amountVal = (int)amount;

    for (int i = 0; i < amountVal; i++)
    {
      //  Console.WriteLine(DateTime.Now);
     //   Console.WriteLine($"state = {Thread.CurrentThread.ThreadState} , id = {Thread.CurrentThread.ManagedThreadId}");
     lock (locker)
     {
         count++;
     }

     Console.WriteLine(count);
     Thread.Sleep(1);
    }
}

Thread t = new Thread(PrintHello);
Console.WriteLine($"state = {t.ThreadState} , id = {t.ManagedThreadId}");
t.Start(500);
Thread t2 = new Thread(PrintHello);
t2.Start(500);

t.Join();
t2.Join();
Console.WriteLine($"state = {t.ThreadState} , id = {t.ManagedThreadId}");
Console.WriteLine("Thread terminated");

*/

CancellationTokenSource cts = new CancellationTokenSource();

async Task PrintNumbers(object amount)
{

    try
    {
        // Console.WriteLine(DateTime.Now);

        int amountVal = (int)amount;

        for (int i = 0; i < amountVal; i++)
        {
            //Console.WriteLine(i);
            Console.WriteLine($"Thread id = {Thread.CurrentThread.ManagedThreadId} , {DateTime.Now}");
            await Task.Delay(10000, cts.Token);

        }
    }
    catch (OperationCanceledException)
    {
        Console.WriteLine("Task Canceled");
    }
}

void CancelAction(object? obj)
{
    cts.Cancel();
}
//Console.WriteLine(DateTime.Now);
Timer timer = new Timer(CancelAction, null, 2000, Timeout.Infinite);

int amount = 6;

Task task = Task.Run(() => PrintNumbers(1));

task.Wait();

//Console.ReadLine();