using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL__Samples
{
    class _4_Cancell_Task
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancellatiotokensource = new CancellationTokenSource();
            CancellationToken token = cancellatiotokensource.Token;
            Task task = new Task(() =>
              {
                  for (int i = 1; i < 10000; i++)
                  {
                      if (token.IsCancellationRequested)
                      {
                          Console.WriteLine(" Cancel () Called");
                          return;
                      }
                      Console.WriteLine($" Loop Value  : {i}" );
                  }
              },token);
            Console.WriteLine("Press any key to start task");
            Console.WriteLine("\n\n Press any key again to cancel the running task");
            Console.ReadKey();

            task.Start();
            Console.ReadKey();
            Console.WriteLine("Cancelling Task");
            cancellatiotokensource.Cancel();
            Console.WriteLine("Main method complete. Press any key to finish.");
            Console.ReadKey();

        }
    }
}
