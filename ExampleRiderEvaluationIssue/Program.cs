using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleRiderEvaluationIssue
{
    class Program
    {
        /**
         * Evaluate the following in the evaluation window at each place the comments say to place a breakpoint.
         * (new List<string>{"", ""}).Where(e => e != null).ToList()
         * Note: Remember to type it out and press enter as the autocomplete suggests so that it imports the List and .Where.
         */
        static async Task Main(string[] args)
        { /* Place a  breakpoint here, it will work as expected when evaluated */
            await IncorrectResultIssue();
            await NullReferenceExceptionIssue();
        }

        static async Task IncorrectResultIssue()
        { /* Place breakpoint here, it will give 0 results when there should be 2 */
            Console.WriteLine("Hello World!");
            var e = "hi";
            Action x = () =>
            {
                Console.WriteLine(e);
            };
            x();
        }
        
        static async Task NullReferenceExceptionIssue()
        {/* Place breakpoint here, it will throw a null reference exception */
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