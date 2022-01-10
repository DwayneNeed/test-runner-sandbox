using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class ExampleClient
    {
        public void MethodA()
        {
            Console.WriteLine("MethodA()");
            throw new InvalidOperationException("Something went wrong!");
        }

        public async Task<string> AsyncMethodB()
        {
            Console.WriteLine("StepB()");
            await Task.Yield();

            return $"{Guid.NewGuid()}";

        }

        public async Task<Guid> AsyncMethodC(string guidStr)
        {
            Console.WriteLine($"StepC({guidStr})");
            await Task.Yield();

            return Guid.Parse(guidStr);
        }

        public async Task AsyncMethodD(Guid x)
        {
            Console.WriteLine($"StepD({x})");
            await Task.Yield();

            throw new InvalidOperationException("Something went wrong!");
        }
    }
}
