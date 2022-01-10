using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRunner;

namespace Tests
{
    public class ExampleSequences
    {
        public static async IAsyncEnumerable<TestStepResult> ExampleSequence()
        {
            var client = new ExampleClient();
            var invoker = new ExampleClientInvoker();
            string guidStr = null;
            Guid guid = default(Guid);

            yield return invoker.Invoke("StepA", false, () =>
            {
                client.MethodA();
            });

            yield return await invoker.Invoke("StepB", true, async () =>
            {
                guidStr = await client.AsyncMethodB();
            });

            yield return await invoker.Invoke("StepC", true, async () =>
            {
                guid = await client.AsyncMethodC(guidStr);
            });

            yield return await invoker.Invoke("StepD", true, async () =>
            {
                await client.AsyncMethodD(guid);
            });
        }

    }
}
