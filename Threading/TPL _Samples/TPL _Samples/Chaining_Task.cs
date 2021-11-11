using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace TPL__Samples
{
    class Chaining_Task
    {
       static  string userid = null;

        static void Main(string[] args)
        {
            var loaduserDataTask = new Task(() =>
            {
                Console.WriteLine("User Data Loading");
                Thread.Sleep(2000);
                userid = "1234";
                Console.WriteLine(" User Data Loaded");

            });
            var LoaduserPermissonTask = loaduserDataTask.ContinueWith(t =>
            {
                Console.WriteLine( "Loading user Permission for the User : {0}",userid);
                Thread.Sleep(2000);
                Console.WriteLine("User Permission Loaded");
                return "Admin";
            });
            loaduserDataTask.Start();
           // LoaduserPermissonTask.Start(); // will through 
            LoaduserPermissonTask.Wait();
            Console.WriteLine( "User Application Loaded for the Permission  " +LoaduserPermissonTask.Result);
            loaduserDataTask.Dispose();
            LoaduserPermissonTask.Dispose();
            Console.ReadLine();
        }
    }
}
