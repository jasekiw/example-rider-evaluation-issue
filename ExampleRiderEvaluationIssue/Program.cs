using System;
using System.Threading.Tasks;
using Sentry;

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
                SentrySdk.WithScope(scope =>
                {
                    SentrySdk.CaptureException(e);
                });
            }
        }
    }
}