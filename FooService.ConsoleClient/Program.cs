using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooService.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var fooClient = new Foo.FooServiceClient();
            try
            {
                fooClient.ServiceAction();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            var barClient = new Bar.BarServiceClient();
            try
            {
                barClient.ServiceAction();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            Console.WriteLine("Press ENTER to exit");
            Console.ReadLine();
        }
    }
}
