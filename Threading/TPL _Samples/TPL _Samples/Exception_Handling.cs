using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL__Samples
{
    class Exception_Handling
    {
        static void Main(string[] args)
        {
        
        Task t = Task.Factory.StartNew(() => {
          try
        {
          Console.WriteLine("Digging is in progress");
          throw new Exception("Tool is crashed");
        }
         catch (Exception ae)
        {
          Console.WriteLine("Stop the work and notify others :" + ae.Message);
        }
     
  });
          //  t.Wait();
            Console.ReadKey();
        }
    }
}
