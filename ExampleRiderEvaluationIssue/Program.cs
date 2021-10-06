using System;
using System.Threading.Tasks;

namespace ExampleRiderEvaluationIssue
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");
            }
            catch (Exception e)
            {
                Action x = () =>
                {
                    Console.WriteLine(e);
                };
                x();
            }
        }
    }
}