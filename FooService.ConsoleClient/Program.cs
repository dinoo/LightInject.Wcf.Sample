using System;

namespace FooService.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var fooClient = new Foo.FooServiceClient();
            try
            {
                var result = fooClient.ServiceAction();
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            var barClient = new Bar.BarServiceClient();
            try
            {
                var result = barClient.ServiceAction();
                Console.WriteLine(result);
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
